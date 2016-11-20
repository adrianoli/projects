using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Products.Pizza
{
    public interface IPizza
    {
        int ID();
        string Name();
        decimal Price();
    }
}
