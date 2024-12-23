﻿using System;
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
        public string Gender { get; set; }
        public int Age { get; set; }
        public string WorkExp { get; set; }
        public string? StoreId { get; set; }
        public string? DepartmentId { get; set; }
        public string? QualificationId { get; set; }
    }
}
