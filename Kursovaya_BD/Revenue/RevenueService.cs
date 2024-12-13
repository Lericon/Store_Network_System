using Npgsql;
using SharedModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revenue
{
    public class RevenueService
    {
        private readonly string _connectionString;
        private User _currentUser;
        private Form? mainForm;

        public RevenueService(string connectionString, User currentUser, Form? mainForm)
        {
            _connectionString = connectionString;
            _currentUser = currentUser;
            if (mainForm != null)
            {
                this.mainForm = mainForm;
            }
        }

        public List<SharedModels.Revenue> GetRevenuesAsync()
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var query = @"
                    SELECT r.id, r.revenue_date, CONCAT(s.last_name, ' ', s.first_name, ' ', s.surname), revenue_count
                    FROM revenue r
                    LEFT JOIN seller s ON r.seller_id = s.id
                    ORDER BY r.id;";
                List<SharedModels.Revenue> revenues = new List<SharedModels.Revenue>();
                using (var command = new NpgsqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            revenues.Add(new SharedModels.Revenue
                            {
                                Id = reader.GetInt32(0),
                                Date = reader.GetDateTime(1),
                                SellerName = reader.GetString(2),
                                RevenueCount = reader.GetInt32(3)
                            });
                        }
                    }
                }
                return revenues;
            }
        }
    }
}
