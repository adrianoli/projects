using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Products.MainDish.AddToMainDish
{
    public class Salad : MainDishDecorator
    {
        private IMainDish _mainDish;

        public Salad(IMainDish mainDish, string name, decimal price)
        {
            _mainDish = mainDish;
            _name = name;
            _price = price;
        }

        public override string Name()
        {
            return string.Format("{0}, {1}", _mainDish.Name(), _name);
        }

        public override decimal Price()
        {
            return _mainDish.Price() + _price;
        }

        public override int ID()
        {
            return _mainDish.ID();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
