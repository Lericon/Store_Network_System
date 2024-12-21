using Npgsql;
using SharedModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodsInStore
{
    public class GoodsInStoreService
    {
        private readonly string _connectionString;
        private User _currentUser;
        private Form? mainForm;

        public GoodsInStoreService(string connectionString, User currentUser, Form? mainForm)
        {
            _connectionString = connectionString;
            _currentUser = currentUser;
            if (mainForm != null)
            {
                this.mainForm = mainForm;
            }
        }

        public List<SharedModels.GoodsInStore> GetGoodsInStoreAsync()
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var query = @"
                            SELECT gs.id, gs.count_goods, s.store_name, g.name
                            FROM goods_in_store gs
                            LEFT JOIN store s ON s.id = gs.store_id
                            LEFT JOIN good g ON g.id = good_id
                            ORDER BY gs.id;";
                List<SharedModels.GoodsInStore> goodsinstore = new List<SharedModels.GoodsInStore>();
                using (var command = new NpgsqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            goodsinstore.Add(new SharedModels.GoodsInStore
                            {
                                Id = reader.GetInt32(0),
                                CountGoods = reader.GetInt32(1),
                                StoreName = reader.GetString(2),
                                GoodName = reader.GetString(3)
                            });
                        }
                    }
                }
                return goodsinstore;
            }
        }
    }
}
