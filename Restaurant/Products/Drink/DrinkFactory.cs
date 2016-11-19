using Restaurant.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Products.Drink
{
    public class DrinkFactory
    {
        public static IDrink CreateDrink(FoodInformation foodInformation)
        {
            IDrink drink = null;

            switch (foodInformation.Name.ToUpper())
            {
                case "COFFEE":
                    drink = new Coffee(foodInformation.ID, foodInformation.Name, foodInformation.Price);
                    break;
                case "TEA":
                    drink = new Tea(foodInformation.ID, foodInformation.Name, foodInformation.Price);
                    break;
                case "COLA":
                    drink = new Cola(foodInformation.ID, foodInformation.Name, foodInformation.Price);
                    break;
            }

            return drink;
        }
    }
}
