using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Products.MainDish
{
    public interface IMainDish
    {
        int ID();
        string Name();
        decimal Price();
    }
}
