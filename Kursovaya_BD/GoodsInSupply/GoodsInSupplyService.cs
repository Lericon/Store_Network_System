using Npgsql;
using SharedModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualification
{
    public class GoodsInSupplyService
    {
        private readonly string _connectionString;
        private User _currentUser;
        private Form? mainForm;

        public GoodsInSupplyService(string connectionString, User currentUser, Form? mainForm)
        {
            _connectionString = connectionString;
            _currentUser = currentUser;
            if (mainForm != null)
            {
                this.mainForm = mainForm;
            }
        }

        public List<SharedModels.GoodsInSupply> GetGoodsInSupplyAsync()
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var query = @"
                            SELECT gs.id, gs.count_good, g.name, gs.supply_id
                            FROM goods_in_supply gs
                            LEFT JOIN good g ON g.id = gs.good_id
                            ORDER BY gs.id;";
                List<SharedModels.GoodsInSupply> goodsinsupply = new List<SharedModels.GoodsInSupply>();
                using (var command = new NpgsqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            goodsinsupply.Add(new SharedModels.GoodsInSupply
                            {
                                Id = reader.GetInt32(0),
                                CountGood = reader.GetInt32(1),
                                GoodName = reader.GetString(2),
                                SupplyId = reader.GetInt32(3)
                            });
                        }
                    }
                }
                return goodsinsupply;
            }
        }
    }
}
