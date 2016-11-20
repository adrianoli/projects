using Restaurant.DataBase;
using Restaurant.Products.MainDish;
using Restaurant.Products.MainDish.AddToMainDish;
using Restaurant.Products.Pizza;
using Restaurant.Products.Pizza.AddToPizza;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.FormsLogic
{
    public class ToppingsLogic
    {
        private ConnectDB _connectDB;

        public ToppingsLogic()
        {
            _connectDB = new ConnectDB();
        }

        public List<FoodInformation> GetPizzaToppingsObjects()
        {
            return _connectDB.GetRecordsBySql("select * from AddToPizza where IsArchival = 0");
        }

        public List<FoodInformation> GetMainDishToppingsObjects()
        {
            return _connectDB.GetRecordsBySql("select * from AddToMainDish where IsArchival = 0");
        }

        public IPizza CustomPizza(IPizza pizza, List<FoodInformation> objects)
        {
            foreach(FoodInformation food in objects)
            {
                pizza = AddToPizzaFactory.CreateAddToPizza(pizza, food);
            }

            return pizza;
        }

        public IMainDish CustomMainDish(IMainDish mainDish, List<FoodInformation> objects)
        {
            foreach (FoodInformation food in objects)
            {
                mainDish = AddToMainDishFactory.CreateAddToMainDish(mainDish, food);
            }

            return mainDish;
        }

    }
}
