using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.FormsLogic.Objects
{
    public class OrderObject
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public int ProductCount { get; set; }
        public decimal Price { get; set; }
        public DateTime OrderDate { get; set; }
        public string AttentionToOrder { get; set; }
    }
}
