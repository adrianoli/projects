using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Products.Pizza.AddToPizza
{
    public class DoubleCheese : PizzaDecorator
    {
        private IPizza _pizza;

        public DoubleCheese(IPizza pizza)
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

        public override int ID()
        {
            throw new NotImplementedException();
        }
    }
}
