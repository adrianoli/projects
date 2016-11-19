using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Products.MainDish.AddToMainDish
{
    public class Salad : MainDishDecorator
    {
        private IMainDish _mainDish;

        public Salad(IMainDish mainDish)
        {
            _mainDish = mainDish;
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
