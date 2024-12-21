using Npgsql;
using SharedModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodsInRequest
{
    public class GoodsInRequestService
    {
        private readonly string _connectionString;
        private User _currentUser;
        private Form? mainForm;

        public GoodsInRequestService(string connectionString, User currentUser, Form? mainForm)
        {
            _connectionString = connectionString;
            _currentUser = currentUser;
            if (mainForm != null)
            {
                this.mainForm = mainForm;
            }
        }

        public List<SharedModels.GoodsInRequest> GetGoodsInRequestAsync()
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var query = @"
                            SELECT gr.id, gr.count_goods, gr.request_id, g.name
                            FROM goods_in_request gr
                            LEFT JOIN good g ON g.id = gr.good_id
                            ORDER BY gr.id;";
                List<SharedModels.GoodsInRequest> goodsinrequest = new List<SharedModels.GoodsInRequest>();
                using (var command = new NpgsqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            goodsinrequest.Add(new SharedModels.GoodsInRequest
                            {
                                Id = reader.GetInt32(0),
                                CountGoods = reader.GetInt32(1),
                                RequestId = reader.GetInt32(2),
                                GoodName = reader.GetString(3)
                            });
                        }
                    }
                }
                return goodsinrequest;
            }
        }
    }
}
