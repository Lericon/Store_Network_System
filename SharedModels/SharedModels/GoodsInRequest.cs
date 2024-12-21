using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels
{
    public class GoodsInRequest
    {
        public int Id { get; set; }
        public int CountGoods { get; set; }
        public int RequestId { get; set; }
        public string GoodName { get; set; }
    }
}
