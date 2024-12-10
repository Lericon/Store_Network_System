using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels
{
    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string BankAccount { get; set; }
        public string TIN { get; set; }
        public int BankId { get; set; }
        public int CityId { get; set; }
        public int StreetId { get; set; }
    }
}
