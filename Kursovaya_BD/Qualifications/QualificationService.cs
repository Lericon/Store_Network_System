using Npgsql;
using SharedModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualification
{
    public class QualificationService
    {
        private readonly string _connectionString;
        private User _currentUser;
        private Form? mainForm;

        public QualificationService(string connectionString, User currentUser, Form? mainForm)
        {
            _connectionString = connectionString;
            _currentUser = currentUser;
            if (mainForm != null)
            {
                this.mainForm = mainForm;
            }
        }

        public List<SharedModels.Qualification> GetQualificationsAsync()
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var query = @"SELECT * FROM qualification;";
                List<SharedModels.Qualification> qualifications = new List<SharedModels.Qualification>();
                using (var command = new NpgsqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            qualifications.Add(new SharedModels.Qualification
                            {
                                Id = reader.GetInt32(0),
                                QualificationName = reader.GetString(1)
                            });
                        }
                    }
                }
                return qualifications;
            }
        }
    }
}
