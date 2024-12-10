using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kursovaya_BD.Models.Interfaces;
using Npgsql;
using SharedModels;

namespace Kursovaya_BD.Presenters
{
    public class RegistrationPresenter
    {
        private readonly IRegistr _view;
        string _connection = "Host = localhost;Username = postgres;Password = 17668;Port = 5432;Database = store_network;";


        public RegistrationPresenter(IRegistr view)
        {
            _view = view ?? throw new ArgumentNullException(nameof(view));
            _view.RegistrationAttempt += this.RegistrationAttempt;
        }

        public void RegistrationAttempt(object sender, EventArgs e)
        {
            List<string> loginPassword = _view.GetLoginPassword();
            try
            {
                if (loginPassword[0] == "")
                {
                    throw new ArgumentNullException("Поле 'Имя пользователя' пустое!");
                }
                if (loginPassword[1] == "")
                {
                    throw new ArgumentNullException("Поле 'Пароль' пустое!");
                }
                if (loginPassword[1].Length > 50)
                {
                    throw new ArgumentException("Пароль не может быть длиннее 50 символов!");
                }
                if (loginPassword[2] != loginPassword[1])
                {
                    throw new ArgumentException("Введённые пароли не совпадают!");
                }

                using (var connection = new NpgsqlConnection(_connection))
                {
                    connection.Open();
                    User newUser = new User
                    {
                        Username = loginPassword[0],
                        PasswordHash = loginPassword[1],
                        Role = "Администратор",
                        IsAdmin = true
                    };
                    string hashedPass = User.HashPassword(newUser.PasswordHash);
                    string query = "INSERT INTO users (username,password_hash,user_role,isadmin) VALUES (@Username, @PasswordHash, @Role, @IsAdmin)";
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("Username", newUser.Username);
                        command.Parameters.AddWithValue("PasswordHash", hashedPass);
                        command.Parameters.AddWithValue("Role", newUser.Role);
                        command.Parameters.AddWithValue("IsAdmin", newUser.IsAdmin);
                        command.ExecuteNonQuery();
                    }
                    _view.Message("Первичный пользователь успешно зарегистрирован, как администратор!");
                    _view.Close();
                }
            }
            catch (Exception ex)
            {
                _view.Message("Непредвиденная ошибка! \n" + ex.Message);
            }
        }
    }
}
