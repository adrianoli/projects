using Restaurant.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Products.MainDish
{
    public class MainDishFactory
    {
        public static IMainDish CreateMainDish(FoodInformation foodInformation)
        {
            IMainDish mainDish = null;

            switch (foodInformation.Name.ToUpper())
            {
                case "SCHABOWY Z FRYTKAMI":
                    mainDish = new ShnitzelFries(foodInformation.ID, foodInformation.Name, foodInformation.Price);
                    break;
                case "SCHABOWY Z ZIEMNIAKAMI":
                    mainDish = new ShnitzelPotato(foodInformation.ID, foodInformation.Name, foodInformation.Price);
                    break;
                case "SCHABOWY Z RYŻEM":
                    mainDish = new ShnitzelRice(foodInformation.ID, foodInformation.Name, foodInformation.Price);
                    break;
                case "RYBA Z FRYTKAMI":
                    mainDish = new FishFries(foodInformation.ID, foodInformation.Name, foodInformation.Price);
                    break;
                case "PLACEK PO WĘGIERSKU":
                    mainDish = new HungarianCake(foodInformation.ID, foodInformation.Name, foodInformation.Price);
                    break;
            }

            return mainDish;
        }
    }
}
