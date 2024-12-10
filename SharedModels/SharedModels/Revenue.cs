using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels
{
    public class Revenue
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int SellerId { get; set; }
        public int RevenueCount { get; set; }
    }
}
