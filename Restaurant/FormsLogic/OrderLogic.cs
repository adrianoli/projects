using Restaurant.DataBase;
using Restaurant.Forms;
using Restaurant.FormsLogic.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
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

        public bool Validate(out string message, string email, int productCount)
        {
            bool isValid = true;
            message = string.Empty;

            if (!ProductValidation(ref message, productCount))
            {
                return false;
            }

            if(!EmailValidation(ref message, email))
            {
                return false;
            }

            return isValid;
        }

        public bool EmailValidationToHistory(ref string message, string email)
        {
            if (email.ToUpper().Trim() == "ADMIN")
            {
                return true;
            }

            try
            {
                MailAddress m = new MailAddress(email);
                return true;
            }
            catch (ArgumentException)
            {
                message = "Nieprawidłowy format adresu email";
                return false;
            }
            catch (FormatException)
            {
                message = "Nieprawidłowy format adresu email";
                return false;
            }
        }

        public AddressObject CreateAddress()
        {
            AddressObject addressObject = null;

            using(AddressForm addressForm = new AddressForm())
            {
                if(addressForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    addressObject = addressForm.AddressObj;
                }
            }

            return addressObject;
        }

        public void CreateOrder(OrderObject orderObject, AddressObject addressObject, List<OrderProductObject> products)
        {
            string date = string.Format("{0} {1}", orderObject.OrderDate.ToShortDateString(), orderObject.OrderDate.ToShortTimeString());

            string sql = string.Format("insert into Orders (Email, Price, ProductCount, OrderDate, Attention) values ('{0}', '{1}', {2}, '{3}', '{4}')",
                orderObject.Email, orderObject.Price, orderObject.ProductCount, date, orderObject.AttentionToOrder);

            long orderFk = _connectDB.InsertOrderToDatabase(sql);

            sql = string.Format("insert into Address (Street, HouseNumber, FlatNumber, City, PhoneNumber, OrderFK) values ('{0}', '{1}', '{2}', '{3}', {4}, {5})",
                addressObject.Street, addressObject.HouseNumber, addressObject.FlatNumber, addressObject.City, addressObject.PhoneNumber, orderFk);

            _connectDB.ExecuteSql(sql);

            foreach(OrderProductObject product in products)
            {
                sql = string.Format("insert into Product (Name, OrderFK) values ('{0}', {1})", product.Name, orderFk);
                _connectDB.ExecuteSql(sql);
            }
        }

        private bool EmailValidation(ref string message, string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);
                return true;
            }
            catch(ArgumentException)
            {
                message = "Nieprawidłowy format adresu email";
                return false;
            }
            catch(FormatException)
            {
                message = "Nieprawidłowy format adresu email";
                return false;
            }
        }

        private bool ProductValidation(ref string message, int productCount)
        {
            if(productCount == 0)
            {
                message = "Nie można złożyc zamówienia koszyk jest pusty.";
                return false;
            }

            return true;
        }

    }
}
