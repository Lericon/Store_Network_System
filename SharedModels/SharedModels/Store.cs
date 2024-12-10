using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels
{
    public class Store
    {
        public int Id { get; set; }
        public string StoreName { get; set; }
        public int CityId { get; set; }
        public int StreetId { get; set; }
    }
}
