using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kursovaya_BD.Models.Interfaces;
using Npgsql;
using System.Security.Cryptography;
using SharedModels;

namespace Kursovaya_BD.Presenters
{
    public class LoginPresenter
    {
        private readonly ILogin _view;
        string _connection = "Host = localhost;Username = postgres;Password = 17668;Port = 5432;Database = store_network;";


        public LoginPresenter(ILogin view)
        {
            _view = view ?? throw new ArgumentNullException(nameof(view));
            _view.LoginAttempt += this.LoginAttempt;
        }

        public void LoginAttempt(object sender, EventArgs e)
        {
            List<string> loginPassword = _view.GetLoginPassword();
            try
            {
                if (loginPassword[0] == "")
                {
                    throw new ArgumentNullException("Заполните 'Имя пользователя'!");
                }
                if (loginPassword[1] == "")
                {
                    throw new ArgumentNullException("Заполните 'Пароль'!");
                }
                if (loginPassword[1].Length > 50)
                {
                    throw new ArgumentException("Пароль не может быть длинее 50 символов!");
                }

                string checkQuery = "SELECT count(*) FROM users";
                using (var connection = new NpgsqlConnection(_connection))
                {
                    connection.Open();
                    using (var checkCmd = new NpgsqlCommand(checkQuery, connection))
                    {
                        long userCnt = (long)checkCmd.ExecuteScalar();
                        if (userCnt == 0)
                        {
                            if (_view.FirstUserForm("Зарегистрированных пользователей не обнаружено. Желаете пройти регистрацию как администратор?") == true)
                            {
                                _view.Registration();
                            }
                            else
                            {
                                throw new OperationCanceledException("Регистрация отменена пользователем");
                            }
                        }
                        else
                        {
                            string query = "SELECT id, username, password_hash, user_role, isadmin FROM users WHERE username = @Username";
                            using (var cmd = new NpgsqlCommand(query, connection))
                            {
                                cmd.Parameters.AddWithValue("Username", loginPassword[0]);
                                using (var reader = cmd.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        var user = new User
                                        {
                                            Id = reader.GetInt32(0),
                                            Username = reader.GetString(1),
                                            PasswordHash = reader.GetString(2),
                                            Role = reader.GetString(3),
                                            IsAdmin = reader.GetBoolean(4)
                                        };
                                        if (VerifyPassword(loginPassword[1], user.PasswordHash))
                                        {
                                            _view.Message($"Попытка авторизации успешна! Роль: {user.Role}");
                                            _view.Login(user);
                                        }
                                        else
                                        {
                                            throw new UnauthorizedAccessException("Неправильный пароль! Доступ запрещён!");
                                        }
                                    }
                                    else
                                    {
                                        throw new UnauthorizedAccessException("Данное имя пользователя не зарегистрировано!");
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (OperationCanceledException ex)
            {
                _view.Message(ex.Message);
            }
            catch (UnauthorizedAccessException ex)
            {
                _view.Message("Ошибка! " + ex.Message);
            }
            catch (ArgumentNullException ex)
            {
                _view.Message("Ошибка! " + ex.Message);
            }
            catch (ArgumentException ex)
            {
                _view.Message("Ошибка! " + ex.Message);
            }
            catch (Exception ex)
            {
                _view.Message("Непредвиденная ошибка! \n" + ex.Message);
            }
        }
        public static bool VerifyPassword(string unknownPassword, string knownPasswordHash)
        {
            string unknownPasswordHash = User.HashPassword(unknownPassword);
            if (unknownPasswordHash != knownPasswordHash)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
