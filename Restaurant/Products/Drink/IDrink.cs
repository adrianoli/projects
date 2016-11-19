using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Products.Drink
{
    public interface IDrink
    {
        int ID();
        string Name();
        decimal Price();
    }
}
