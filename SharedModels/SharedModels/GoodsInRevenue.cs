using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels
{
    public class GoodsInRevenue
    {
        public int Id { get; set; }
        public int GoodCount { get; set; }
        public string GoodName { get; set; }
        public int RevenueId { get; set; }
    }
}
