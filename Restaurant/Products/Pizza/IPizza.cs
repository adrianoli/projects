using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Products.Pizza
{
    public interface IPizza
    {
        string Name();
        decimal Price();
    }
}
