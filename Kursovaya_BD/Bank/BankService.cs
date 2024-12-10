using Npgsql;
using SharedModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class BankService
    {
        private readonly string _connectionString;
        private User _currentUser;
        private Form? mainForm;

        public BankService(string connectionString, User currentUser, Form? mainForm)
        {
            _connectionString = connectionString;
            _currentUser = currentUser;
            if (mainForm != null)
            {
                this.mainForm = mainForm;
            }
        }

        public List<SharedModels.Bank> GetBanksAsync()
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var query = "SELECT * FROM bank;";
                List<SharedModels.Bank> banks = new List<SharedModels.Bank>();
                using (var command = new NpgsqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            banks.Add(new SharedModels.Bank
                            {
                                Id = reader.GetInt32(0),
                                BankName = reader.GetString(1)
                            });
                        }
                    }
                }
                return banks;
            }
        }
    }
}
