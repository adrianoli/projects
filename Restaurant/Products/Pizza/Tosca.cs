using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Products.Pizza
{
    public class Tosca : IPizza
    {
        private int _id;
        private string _name;
        private decimal _price;

        //public Tosca()

        public string Name()
        {
            throw new NotImplementedException();
        }

        public decimal Price()
        {
            throw new NotImplementedException();
        }
    }
}
