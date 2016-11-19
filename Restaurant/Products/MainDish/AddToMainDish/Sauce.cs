using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Products.MainDish.AddToMainDish
{
    public class Sauce :MainDishDecorator
    {
        private IMainDish _mainDish;

        public Sauce(IMainDish mainDish)
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
