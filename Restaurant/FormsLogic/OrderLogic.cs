using Restaurant.DataBase;
using Restaurant.Forms;
using Restaurant.FormsLogic.Objects;
using Restaurant.Properties;
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

        // Pobieranie z bazy wszystkich niearchiwalnych obiektów pizza
        public List<FoodInformation> GetPizzaObjects()
        {
            return _connectDB.GetRecordsBySql("select * from Pizza where IsArchival = 0");
        }

        // Pobieranie z bazy wszystkich niearchiwalnych obiektów dań głównych
        public List<FoodInformation> GetMainDishObjects()
        {
            return _connectDB.GetRecordsBySql("select * from MainDish where IsArchival = 0");
        }

        // Pobieranie z bazy wszystkich niearchiwalnych obiektów zupa
        public List<FoodInformation> GetSoupObjects()
        {
            return _connectDB.GetRecordsBySql("select * from Soup where IsArchival = 0");
        }

        // Pobieranie z bazy wszystkich niearchiwalnych obiektów napój
        public List<FoodInformation> GetDrinkObjects()
        {
            return _connectDB.GetRecordsBySql("select * from Drink where IsArchival = 0");
        }

        // Walidacja występująca przy próbie wysłania zamówienia
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

        // Walidacja poprawności adresu email dla Historii zamówień wyjątek słowo ADMIN, które pozwala wyświetlić historię wszystkich zamówień w aplikacji
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
                message = Resources.WrongFormatEmail_Message;
                return false;
            }
            catch (FormatException)
            {
                message = Resources.WrongFormatEmail_Message;
                return false;
            }
        }

        // Funkcja do tworzenia adresu odpala formularz do wypełnienia danych adresowych
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

        // Funkcja odpowiedzialna za utworzenie zamówienia i wysłanie maila. Zapisuje wszystkie dane na temat zamówienia, produktów i adresu do bazy a następnie wysyła maila z zamówieniem.
        public void CreateOrder(OrderObject orderObject, AddressObject addressObject, List<OrderProductObject> products)
        {
            string date = orderObject.OrderDate;

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

            string subject = string.Format(Resources.OrderNumber_Message, orderFk);
            string body = OrderLogic.CreateOrderDetails(orderObject, addressObject, products);

            SendMail(subject, body, orderObject.Email);
        }

        // Funkcja przygotowuje treść szczegółów zamówienia wykorzystywana przy budowaniu treści maila i szczegółów zamówienia w historii zamówień
        public static string CreateOrderDetails(OrderObject order, AddressObject address, List<OrderProductObject> products)
        {
            StringBuilder orderDatails = new StringBuilder();
            orderDatails.AppendLine(string.Format(Resources.OrderNumber2_Message, order.ID, Environment.NewLine));

            foreach(OrderProductObject product in products)
            {
                orderDatails.AppendLine(string.Format("{0}",product.Name));
            }

            CultureInfo info = new CultureInfo(Resources.CultureInfo_Message);
            orderDatails.AppendLine(string.Format(Resources.OrderCost_Message, order.Price.ToString("C", info), Environment.NewLine));

            if(string.IsNullOrWhiteSpace(order.AttentionToOrder))
            {
                orderDatails.AppendLine(string.Format(Resources.OrderAttentionEmpty_Message, Environment.NewLine));
            }
            else
            {
                orderDatails.AppendLine(string.Format(Resources.OrderAttention_Message ,order.AttentionToOrder, Environment.NewLine));
            }

            orderDatails.AppendLine(Resources.OrderSend_Message);

            if(string.IsNullOrWhiteSpace(address.FlatNumber))
            {
                orderDatails.AppendLine(string.Format("{0} {1}",address.Street, address.HouseNumber));
            }
            else
            {
                orderDatails.AppendLine(string.Format(Resources.OrderStreetDetail_Message, address.Street, address.HouseNumber, address.FlatNumber));
            }

            orderDatails.AppendLine(string.Format("{0}", address.City));
            orderDatails.AppendLine(string.Format(Resources.PhoneNumber_Message, address.PhoneNumber));

            return orderDatails.ToString();
        }

        public void ShowHistory(string email)
        {
            List<OrderObject> orders = _connectDB.GetOrders(email);
            OrderHistoryForm orderHistory = new OrderHistoryForm(orders);
            orderHistory.Show();
        }

        // Walidacja adresu E-mail
        private bool EmailValidation(ref string message, string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);
                return true;
            }
            catch(ArgumentException)
            {
                message = Resources.WrongFormatEmail_Message;
                return false;
            }
            catch(FormatException)
            {
                message = Resources.WrongFormatEmail_Message;
                return false;
            }
        }

        private bool ProductValidation(ref string message, int productCount)
        {
            if(productCount == 0)
            {
                message = Resources.EmptyShoppingCard_Message;
                return false;
            }

            return true;
        }

        // Funkcja wysyłająca maila. Pobiera dane dotyczące serwera smtp z App.Config by działała funkjconalność należy wypełnić w App.Config poprawnie dane.
        private void SendMail(string subject, string message, string emailTo)
        {
            try
            {
                string emailFrom = ConfigurationManager.AppSettings["userName"];
                string password = ConfigurationManager.AppSettings["password"];
                string host = ConfigurationManager.AppSettings["host"];
                string port = ConfigurationManager.AppSettings["port"];

                MailMessage mail = new MailMessage();
                SmtpClient smtpServer = new SmtpClient(host);
                mail.From = new MailAddress(emailFrom);
                mail.To.Add(emailTo);
                mail.Subject = subject;
                mail.Body = message;
                smtpServer.Port = int.Parse(port);
                smtpServer.Credentials = new System.Net.NetworkCredential(emailFrom, password);
                smtpServer.EnableSsl = true;
                smtpServer.Send(mail);

                MessageBox.Show(Resources.OrderSendToMail_Message, Resources.Information, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(string.Format(Resources.ErrorSendMail_Message, Environment.NewLine, ex.Message), 
                    Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
