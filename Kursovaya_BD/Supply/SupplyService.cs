using Npgsql;
using SharedModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supply
{
    public class SupplyService
    {
        private readonly string _connectionString;
        private User _currentUser;
        private Form? mainForm;

        public SupplyService(string connectionString, User currentUser, Form? mainForm)
        {
            _connectionString = connectionString;
            _currentUser = currentUser;
            if (mainForm != null)
            {
                this.mainForm = mainForm;
            }
        }

        public List<SharedModels.Supply> GetSuppliesAsync()
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var query = @"
                    SELECT s.id, s.supply_date, CONCAT(last_name, ' ', first_name, ' ', surname) as name
                    FROM supply s
                    LEFT JOIN supplier sp ON s.supplier_id = sp.id
                    ORDER BY s.id;";
                List<SharedModels.Supply> supplies = new List<SharedModels.Supply>();
                using (var command = new NpgsqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            supplies.Add(new SharedModels.Supply
                            {
                                Id = reader.GetInt32(0),
                                Date = reader.GetDateTime(1),
                                SupplierName = reader.GetString(2)
                            });
                        }
                    }
                }
                return supplies;
            }
        }
    }
}
