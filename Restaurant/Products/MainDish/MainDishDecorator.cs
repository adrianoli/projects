using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Products.MainDish
{
    public abstract class MainDishDecorator : IMainDish
    {
        protected string _name;
        protected decimal _price;

        public abstract string Name();
        public abstract decimal Price();
        public abstract int ID();

        public override string ToString()
        {
            CultureInfo cultureInfo = new CultureInfo(Properties.Resources.CultureInfo_Message);
            return string.Format("{0} - {1}", Name(), Price().ToString("C", cultureInfo));
        }
    }
}
