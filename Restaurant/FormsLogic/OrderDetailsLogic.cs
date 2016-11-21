using Restaurant.DataBase;
using Restaurant.FormsLogic.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.FormsLogic
{
    public class OrderDetailsLogic
    {
        ConnectDB _conDB;

        public OrderDetailsLogic()
        {
            _conDB = new ConnectDB();
        }

        public string GetOrderDetails(OrderObject orderObject)
        {
            AddressObject address = _conDB.GetAddress(orderObject.ID);
            List<OrderProductObject> products = _conDB.GetProducts(orderObject.ID);

            return OrderLogic.CreateOrderDetails(orderObject, address, products);
            
        }
    }
}
