using Restaurant.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Products.Pizza.AddToPizza
{
    public class AddToPizzaFactory
    {
        public static IPizza CreateAddToPizza(IPizza pizza, FoodInformation foodInformation)
        {
            switch (foodInformation.Name.ToUpper())
            {
                case "PODWÓJNY SER":
                    pizza = new DoubleCheese(pizza, foodInformation.Name, foodInformation.Price);
                    break;
                case "SALAMI":
                    pizza = new Salami(pizza, foodInformation.Name, foodInformation.Price);
                    break;
                case "SZYNKA":
                    pizza = new Ham(pizza, foodInformation.Name, foodInformation.Price);
                    break;
                case "PIECZARKI":
                    pizza = new Mushroom(pizza, foodInformation.Name, foodInformation.Price);
                    break;
            }

            return pizza;
        }
    }
}
