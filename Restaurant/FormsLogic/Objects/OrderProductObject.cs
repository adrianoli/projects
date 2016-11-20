using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.FormsLogic.Objects
{
    public class OrderProductObject
    {
        public OrderProductObject(string name)
        {
            Name = name;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public int OrderFK { get; set; }
    }
}
