using Npgsql;
using SharedModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodsInRevenue
{
    public class GoodsInRevenueService
    {
        private readonly string _connectionString;
        private User _currentUser;
        private Form? mainForm;

        public GoodsInRevenueService(string connectionString, User currentUser, Form? mainForm)
        {
            _connectionString = connectionString;
            _currentUser = currentUser;
            if (mainForm != null)
            {
                this.mainForm = mainForm;
            }
        }

        public List<SharedModels.GoodsInRevenue> GetGoodsInRevenueAsync()
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var query = @"
                            SELECT gr.id, gr.good_count, g.name, gr.revenue_id
                            FROM goods_in_revenue gr
                            LEFT JOIN good g ON g.id = gr.good_id
                            ORDER BY gr.id;";
                List<SharedModels.GoodsInRevenue> goodsinrevenue = new List<SharedModels.GoodsInRevenue>();
                using (var command = new NpgsqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            goodsinrevenue.Add(new SharedModels.GoodsInRevenue
                            {
                                Id = reader.GetInt32(0),
                                GoodCount = reader.GetInt32(1),
                                GoodName = reader.GetString(2),
                                RevenueId = reader.GetInt32(3)
                            });
                        }
                    }
                }
                return goodsinrevenue;
            }
        }
    }
}
