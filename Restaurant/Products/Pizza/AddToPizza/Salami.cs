using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Products.Pizza.AddToPizza
{
    public class Salami : PizzaDecorator
    {
        private IPizza _pizza;

        public Salami(IPizza pizza)
        {
            _pizza = pizza;
        }

        public override string Name()
        {
            throw new NotImplementedException();
        }

        public override decimal Price()
        {
            throw new NotImplementedException();
        }
    }
}
