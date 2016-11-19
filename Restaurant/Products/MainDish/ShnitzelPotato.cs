using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Products.MainDish
{
    public class ShnitzelPotato : IMainDish
    {
        private int _id;
        private string _name;
        private decimal _price;

        public ShnitzelPotato(int id, string name, decimal price)
        {
            _id = id;
            _name = name;
            _price = price;
        }

        public int ID()
        {
            return _id;
        }

        public string Name()
        {
            return _name;
        }

        public decimal Price()
        {
            return _price;
        }
    }
}
