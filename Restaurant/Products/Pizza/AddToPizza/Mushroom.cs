using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Products.Pizza.AddToPizza
{
    public class Mushroom : PizzaDecorator
    {
        private IPizza _pizza;

        private string _name;
        private decimal _price;

        public Mushroom(IPizza pizza, string name, decimal price)
        {
            _pizza = pizza;
            _name = name;
            _price = price;
        }

        public override string Name()
        {
            return string.Format("{0}, {1}", _pizza.Name(), _name);
        }

        public override decimal Price()
        {
            return _pizza.Price() + _price;
        }

        public override int ID()
        {
            return _pizza.ID();
        }

        public override string ToString()
        {
            CultureInfo cultureInfo = new CultureInfo("pl-PL");
            return string.Format("{0} - {1}", Name(), Price().ToString("C", cultureInfo));
        }
    }
}
