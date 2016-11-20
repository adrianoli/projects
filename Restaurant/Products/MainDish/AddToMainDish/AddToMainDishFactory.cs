using Restaurant.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Products.MainDish.AddToMainDish
{
    public class AddToMainDishFactory
    {
        public static IMainDish CreateAddToMainDish(IMainDish mainDish, FoodInformation foodInformation)
        {
            switch (foodInformation.Name.ToUpper())
            {
                case "BAR SAŁATKOWY":
                    mainDish = new Salad(mainDish, foodInformation.Name, foodInformation.Price);
                    break;
                case "ZESTAW SOSÓW":
                    mainDish = new Sauce(mainDish, foodInformation.Name, foodInformation.Price);
                    break;
            }

            return mainDish;
        }
    }
}
