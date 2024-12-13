using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels
{
    public class Good
    {
        public int Id { get; set; }
        public string? GoodName { get; set; }
        public int RemainingStock { get; set; }
        public int PurchasePrice { get; set; }
        public int Price { get; set; }
        public string? UnitName { get; set; }
    }
}
