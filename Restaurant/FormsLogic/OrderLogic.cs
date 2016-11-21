using Restaurant.DataBase;
using Restaurant.Forms;
using Restaurant.FormsLogic.Objects;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            orderObject.ID = (int)orderFk;

            sql = string.Format("insert into Address (Street, HouseNumber, FlatNumber, City, PhoneNumber, OrderFK) values ('{0}', '{1}', '{2}', '{3}', {4}, {5})",
                addressObject.Street, addressObject.HouseNumber, addressObject.FlatNumber, addressObject.City, addressObject.PhoneNumber, orderFk);

            _connectDB.ExecuteSql(sql);

            foreach(OrderProductObject product in products)
            {
                sql = string.Format("insert into Product (Name, OrderFK) values ('{0}', {1})", product.Name, orderFk);
                _connectDB.ExecuteSql(sql);
            }

            string subject = string.Format("Zamówienie o numerze: {0}", orderFk);
            string body = OrderLogic.CreateOrderDetails(orderObject, addressObject, products);

            SendMail(subject, body, orderObject.Email);
        }

        public static string CreateOrderDetails(OrderObject order, AddressObject address, List<OrderProductObject> products)
        {
            StringBuilder orderDatails = new StringBuilder();
            orderDatails.AppendLine(string.Format("Zamówienie o numerze: {0}{1}", order.ID, Environment.NewLine));

            foreach(OrderProductObject product in products)
            {
                orderDatails.AppendLine(string.Format("{0}",product.Name));
            }

            CultureInfo info = new CultureInfo("pl-PL");
            orderDatails.AppendLine(string.Format("{1}Łączny koszt zamówienia: {0}{1}", order.Price.ToString("C", info), Environment.NewLine));

            if(string.IsNullOrWhiteSpace(order.AttentionToOrder))
            {
                orderDatails.AppendLine(string.Format("Uwagi do zamówienia: Brak{0}", Environment.NewLine));
            }
            else
            {
                orderDatails.AppendLine(string.Format("Uwagi do zamówienia: {0}{1}",order.AttentionToOrder, Environment.NewLine));
            }

            orderDatails.AppendLine("Zamówienie zostało wysłane na adres:");

            if(string.IsNullOrWhiteSpace(address.FlatNumber))
            {
                orderDatails.AppendLine(string.Format("{0} {1}",address.Street, address.HouseNumber));
            }
            else
            {
                orderDatails.AppendLine(string.Format("{0} {1} mieszkanie:{2}",address.Street, address.HouseNumber, address.FlatNumber));
            }

            orderDatails.AppendLine(string.Format("{0}", address.City));
            orderDatails.AppendLine(string.Format("Numer telefonu komórkowego: {0}", address.PhoneNumber));

            return orderDatails.ToString();
        }

        public void ShowHistory(string email)
        {
            List<OrderObject> orders = _connectDB.GetOrders(email);
            OrderHistoryForm orderHistory = new OrderHistoryForm(orders);
            orderHistory.Show();
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

        private void SendMail(string subject, string message, string emailTo)
        {
            try
            {
                string emailFrom = ConfigurationManager.AppSettings["userName"];
                string password = ConfigurationManager.AppSettings["password"];
                string host = ConfigurationManager.AppSettings["host"];
                string port = ConfigurationManager.AppSettings["port"];

                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient(host);
                mail.From = new MailAddress(emailFrom);
                mail.To.Add(emailTo);
                mail.Subject = subject;
                mail.Body = message;

                SmtpServer.Port = int.Parse(port);
                SmtpServer.Credentials = new System.Net.NetworkCredential(emailFrom, password);
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);

                MessageBox.Show("Zamówienie zostało wysłane na E-mail", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
