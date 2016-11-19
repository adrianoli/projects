using Restaurant.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Products.Pizza
{
    public class PizzaFactory
    {
        public static IPizza CreatePizza(FoodInformation foodInformation)
        {
            IPizza pizza = null;

            switch (foodInformation.Name.ToUpper())
            {
                case "MARGHERITTA":
                    pizza = new Margheritta(foodInformation.ID, foodInformation.Name, foodInformation.Price);
                    break;
                case "VEGETARIANA":
                    pizza = new Vegetariana(foodInformation.ID, foodInformation.Name, foodInformation.Price);
                    break;
                case "VENECIA":
                    pizza = new Venecia(foodInformation.ID, foodInformation.Name, foodInformation.Price);
                    break;
                case "TOSCA":
                    pizza = new Tosca(foodInformation.ID, foodInformation.Name, foodInformation.Price);
                    break;
            }

            return pizza;
        }
    }
}
