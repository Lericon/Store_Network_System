using Npgsql;
using SharedModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfMeasurements
{
    public class CityService
    {
        private readonly string _connectionString;
        private User _currentUser;
        private Form? mainForm;

        public CityService(string connectionString, User currentUser, Form? mainForm)
        {
            _connectionString = connectionString;
            _currentUser = currentUser;
            if (mainForm != null)
            {
                this.mainForm = mainForm;
            }
        }

        public List<SharedModels.City> GetCitiesAsync()
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var query = "SELECT * FROM city;";
                List<SharedModels.City> units = new List<SharedModels.City>();
                using (var command = new NpgsqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            units.Add(new SharedModels.City
                            {
                                Id = reader.GetInt32(0),
                                CityName = reader.GetString(1)
                            });
                        }
                    }
                }
                return units;
            }
        }
    }
}
