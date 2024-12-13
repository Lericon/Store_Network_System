using Npgsql;
using SharedModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supply
{
    public class RequestService
    {
        private readonly string _connectionString;
        private User _currentUser;
        private Form? mainForm;

        public RequestService(string connectionString, User currentUser, Form? mainForm)
        {
            _connectionString = connectionString;
            _currentUser = currentUser;
            if (mainForm != null)
            {
                this.mainForm = mainForm;
            }
        }

        public List<SharedModels.Request> GetRequestsAsync()
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var query = @"
                    SELECT r.id, r.request_date, s.store_name 
                    FROM request r 
                    LEFT JOIN store s ON s.id = r.store_id 
                    ORDER BY r.id;";
                List<SharedModels.Request> requests = new List<SharedModels.Request>();
                using (var command = new NpgsqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            requests.Add(new SharedModels.Request
                            {
                                Id = reader.GetInt32(0),
                                Date = reader.GetDateTime(1),
                                StoreName = reader.GetString(2)
                            });
                        }
                    }
                }
                return requests;
            }
        }
    }
}
