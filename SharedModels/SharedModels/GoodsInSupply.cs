using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels
{
    public class GoodsInSupply
    {
        public int Id { get; set; }
        public int CountGood { get; set; }
        public string GoodName { get; set; }
        public int SupplyId { get; set; }
    }
}
