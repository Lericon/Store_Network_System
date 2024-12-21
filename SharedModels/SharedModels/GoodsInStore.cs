using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels
{
    public class GoodsInStore
    {
        public int Id { get; set; }
        public int CountGoods { get; set; }
        public string? StoreName { get; set; }
        public string? GoodName { get; set; }
    }
}
