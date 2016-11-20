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

        private string _name;
        private decimal _price;

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
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            CultureInfo cultureInfo = new CultureInfo("pl-PL");
            return string.Format("{0} - {1}", Name(), Price().ToString("C", cultureInfo));
        }
    }
}
