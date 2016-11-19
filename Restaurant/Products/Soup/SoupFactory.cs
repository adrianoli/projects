using Restaurant.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Products.Soup
{
    public class SoupFactory
    {
        public static ISoup CreateSoup(FoodInformation foodInformation)
        {
            ISoup soup = null;

            switch (foodInformation.Name.ToUpper())
            {
                case "POMIDOROWA":
                    soup = new TomatoSoup(foodInformation.ID, foodInformation.Name, foodInformation.Price);
                    break;
                case "ROSÓŁ":
                    soup = new ChickenSoup(foodInformation.ID, foodInformation.Name, foodInformation.Price);
                    break;
            }

            return soup;
        }
    }
}
