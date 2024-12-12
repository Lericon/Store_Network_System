using Npgsql;
using SharedModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seller
{
    public class SellerService
    {
        private readonly string _connectionString;
        private User _currentUser;
        private Form? mainForm;

        public SellerService(string connectionString, User currentUser, Form? mainForm)
        {
            _connectionString = connectionString;
            _currentUser = currentUser;
            if (mainForm != null)
            {
                this.mainForm = mainForm;
            }
        }

        public List<SharedModels.Seller> GetSellersAsync()
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var query = @"
                    SELECT s.id, s.last_name, s.first_name, s.surname, s.gender,
                    s.age, s.work_exp, st.store_name, d.department_name, q.qualification_name
                    FROM seller s
                    LEFT JOIN store st ON st.id = store_id
                    LEFT JOIN department d ON d.id = s.department_id
                    LEFT JOIN qualification q ON q.id = s.qualification_id
                    ORDER BY s.id;";
                List<SharedModels.Seller> sellers = new List<SharedModels.Seller>();
                using (var command = new NpgsqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            bool SellerGender = reader.GetBoolean(4);
                            string GenderString;
                            if (SellerGender)
                            {
                                GenderString = "Женский";
                            }
                            else
                            {
                                GenderString = "Мужской";
                            }
                            sellers.Add(new SharedModels.Seller
                            {
                                Id = reader.GetInt32(0),
                                LastName = reader.GetString(1),
                                FirstName = reader.GetString(2),
                                Surname = reader.GetString(3),
                                Gender = GenderString,
                                Age = reader.GetInt32(5),
                                WorkExp = reader.GetString(6),
                                StoreId = reader.IsDBNull(7) ? null : reader.GetString(7),
                                DepartmentId = reader.IsDBNull(8) ? null : reader.GetString(8),
                                QualificationId = reader.IsDBNull(9) ? null : reader.GetString(9)
                            });
                        }
                    }
                }
                return sellers;
            }
        }
    }
}
