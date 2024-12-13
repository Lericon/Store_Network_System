using Npgsql;
using SharedModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Good
{
    public class GoodService
    {
        private readonly string _connectionString;
        private User _currentUser;
        private Form? mainForm;

        public GoodService(string connectionString, User currentUser, Form? mainForm)
        {
            _connectionString = connectionString;
            _currentUser = currentUser;
            if (mainForm != null)
            {
                this.mainForm = mainForm;
            }
        }

        public List<SharedModels.Good> GetGoodsAsync()
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var query = @"
                    SELECT g.id, g.name, g.remaining_stock, g.purchase_price, g.price, u.unit_name
                    FROM good g
                    LEFT JOIN unit_of_measurements u ON g.unit_id = u.id
                    ORDER BY g.id;";
                List<SharedModels.Good> goods = new List<SharedModels.Good>();
                using (var command = new NpgsqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            goods.Add(new SharedModels.Good
                            {
                                Id = reader.GetInt32(0),
                                GoodName = reader.GetString(1),
                                RemainingStock = reader.GetInt32(2),
                                PurchasePrice = reader.GetInt32(3),
                                Price = reader.GetInt32(4),
                                UnitName = reader.GetString(5)
                            });
                        }
                    }
                }
                return goods;
            }
        }
    }
}
