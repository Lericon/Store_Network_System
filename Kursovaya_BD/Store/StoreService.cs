using Npgsql;
using SharedModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class StoreService
    {
        private readonly string _connectionString;
        private User _currentUser;
        private Form? mainForm;

        public StoreService(string connectionString, User currentUser, Form? mainForm)
        {
            _connectionString = connectionString;
            _currentUser = currentUser;
            if (mainForm != null)
            {
                this.mainForm = mainForm;
            }
        }

        public List<SharedModels.Store> GetStoresAsync()
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var query = "SELECT * FROM store;";
                List<SharedModels.Store> stores = new List<SharedModels.Store>();
                using (var command = new NpgsqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            stores.Add(new SharedModels.Store
                            {
                                Id = reader.GetInt32(0),
                                StoreName = reader.GetString(1),
                                CityId = reader.GetInt32(2),
                                StreetId = reader.GetInt32(3)
                            });
                        }
                    }
                }
                return stores;
            }
        }
    }
}
