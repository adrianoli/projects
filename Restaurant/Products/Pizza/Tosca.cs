using System;
using System.Collections.Generic;
using System.Globalization;
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

        public Tosca(int id, string name, decimal price)
        {
            _id = id;
            _name = name;
            _price = price;
        }

        public string Name()
        {
            return _name;
        }

        public decimal Price()
        {
            return _price;
        }

        public int ID()
        {
            return _id;
        }

        public override string ToString()
        {
            CultureInfo cultureInfo = new CultureInfo("pl-PL");
            return string.Format("{0} - {1}", _name, _price.ToString("C", cultureInfo));
        }
    }
}
