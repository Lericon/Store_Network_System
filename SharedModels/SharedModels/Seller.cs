using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels
{
    public class Seller
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public bool Gender { get; set; }
        public int Age { get; set; }
        public string WorkExp { get; set; }
        public int StoreId { get; set; }
        public int DepartmentId { get; set; }
        public int QualificationId { get; set; }
    }
}
