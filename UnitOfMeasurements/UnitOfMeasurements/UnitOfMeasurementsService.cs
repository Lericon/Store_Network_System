using Npgsql;
using SharedModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfMeasurements
{
    public class UnitOfMeasurementsService
    {
        private readonly string _connectionString;
        private User _currentUser;
        private Form? mainForm;

        public UnitOfMeasurementsService(string connectionString, User currentUser, Form? mainForm)
        {
            _connectionString = connectionString;
            _currentUser = currentUser;
            if (mainForm != null)
            {
                this.mainForm = mainForm;
            }
        }

        public List<Unit> GetUnitsAsync()
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var query = "SELECT * FROM unit_of_measurements;";
                List<Unit> units = new List<Unit>();
                using (var command = new NpgsqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            units.Add(new Unit
                            {
                                Id = reader.GetInt32(0),
                                UnitName = reader.GetString(1)
                            });
                        }
                    }
                }
                return units;
            }
        }
    }
}
