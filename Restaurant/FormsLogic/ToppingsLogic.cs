using Restaurant.DataBase;
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
    }
}
