using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Products.Pizza
{
    public abstract class PizzaDecorator : IPizza
    {
        public abstract string Name();
        public abstract decimal Price();
        public abstract int ID();
    }
}
