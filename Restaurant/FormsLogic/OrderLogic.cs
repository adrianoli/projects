using Restaurant.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.FormsLogic
{
    public class OrderLogic
    {
        private ConnectDB _connectDB;

        public OrderLogic()
        {
            _connectDB = new ConnectDB();
        }

        public List<FoodInformation> GetPizzaObjects()
        {
            return _connectDB.GetRecordsBySql("select * from Pizza where IsArchival = 0");
        }

        public List<FoodInformation> GetMainDishObjects()
        {
            return _connectDB.GetRecordsBySql("select * from MainDish where IsArchival = 0");
        }

        public List<FoodInformation> GetSoupObjects()
        {
            return _connectDB.GetRecordsBySql("select * from Soup where IsArchival = 0");
        }

        public List<FoodInformation> GetDrinkObjects()
        {
            return _connectDB.GetRecordsBySql("select * from Drink where IsArchival = 0");
        }
    }
}
