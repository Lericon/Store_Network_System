using Npgsql;
using SharedModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Street
{
    public class StreetService
    {
        private readonly string _connectionString;
        private User _currentUser;
        private Form? mainForm;

        public StreetService(string connectionString, User currentUser, Form? mainForm)
        {
            _connectionString = connectionString;
            _currentUser = currentUser;
            if (mainForm != null)
            {
                this.mainForm = mainForm;
            }
        }

        public List<SharedModels.Street> GetStreetsAsync()
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var query = "SELECT * FROM street;";
                List<SharedModels.Street> streets = new List<SharedModels.Street>();
                using (var command = new NpgsqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            streets.Add(new SharedModels.Street
                            {
                                Id = reader.GetInt32(0),
                                StreetName = reader.GetString(1)
                            });
                        }
                    }
                }
                return streets;
            }
        }
    }
}
