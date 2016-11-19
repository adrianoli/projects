using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Products.Soup
{
    public interface ISoup
    {
        int ID();
        string Name();
        decimal Price();
    }
}
