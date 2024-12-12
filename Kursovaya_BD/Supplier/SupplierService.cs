using Npgsql;
using SharedModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seller
{
    public class SupplierService
    {
        private readonly string _connectionString;
        private User _currentUser;
        private Form? mainForm;

        public SupplierService(string connectionString, User currentUser, Form? mainForm)
        {
            _connectionString = connectionString;
            _currentUser = currentUser;
            if (mainForm != null)
            {
                this.mainForm = mainForm;
            }
        }

        public List<SharedModels.Supplier> GetSuppliersAsync()
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var query = @"
                    SELECT s.id, s.last_name, s.first_name, s.surname, s.phone_number,
                    s.bank_account, s.tin, b.bank_name, c.city_name, st.street_name
                    FROM supplier s
                    LEFT JOIN bank b ON b.id = s.bank_id
                    LEFT JOIN city c ON c.id = s.city_id
                    LEFT JOIN street st ON st.id = s.street_id
                    ORDER BY s.id;";
                List<SharedModels.Supplier> suppliers = new List<SharedModels.Supplier>();
                using (var command = new NpgsqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            suppliers.Add(new SharedModels.Supplier
                            {
                                Id = reader.GetInt32(0),
                                LastName = reader.GetString(1),
                                FirstName = reader.GetString(2),
                                Surname = reader.GetString(3),
                                PhoneNumber = reader.GetString(4),
                                BankAccount = reader.GetString(5),
                                TIN = reader.GetString(6),
                                BankName = reader.IsDBNull(7) ? null : reader.GetString(7),
                                CityName = reader.IsDBNull(8) ? null : reader.GetString(8),
                                StreetName = reader.IsDBNull(9) ? null : reader.GetString(9)
                            });
                        }
                    }
                }
                return suppliers;
            }
        }
    }
}
