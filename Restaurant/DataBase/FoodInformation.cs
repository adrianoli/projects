using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.DataBase
{
    public class FoodInformation
    {
        public int ID { get; private set; }
        public string Name { get; private set; }
        public decimal Price { get; private set; }

        public FoodInformation(int id, string name, decimal price)
        {
            ID = id;
            Name = name;
            Price = price;
        }

    }
}
