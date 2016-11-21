using Restaurant.FormsLogic.Objects;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant.DataBase
{
    public class ConnectDB
    {
        private SQLiteConnection sqliteConnection;

        public ConnectDB()
        {
            sqliteConnection = new SQLiteConnection("Data Source=RestaurantDB.sqlite;Version=3;");
        }

        public SQLiteConnection SqliteConnection
        {
            get { return sqliteConnection; }
            private set { sqliteConnection = value; } 
        }

        public void OpenConnection()
        {
            try
            {
                sqliteConnection.Open();
            }
            catch(SQLiteException sqlEx)
            {
                MessageBox.Show(sqlEx.Message);
            }
        }

        public void CloseConnection()
        {
            try
            {
                sqliteConnection.Close();
            }
            catch(SQLiteException sqlEx)
            {
                MessageBox.Show(sqlEx.Message);
            }
        }

        public void ExecuteSql(string sql)
        {
            try
            {
                OpenConnection();
                SQLiteCommand command = new SQLiteCommand(sql, SqliteConnection);
                command.ExecuteNonQuery();
            }
            finally
            {
                CloseConnection();
            }
        }

        public List<FoodInformation> GetRecordsBySql(string sql)
        {
            List<FoodInformation> foods = new List<FoodInformation>();

            try
            {
                OpenConnection();
                SQLiteCommand command = new SQLiteCommand(sql, SqliteConnection);
                SQLiteDataReader reader = command.ExecuteReader();
                int id;
                string name;
                decimal price;

                while (reader.Read())
                {
                    id = int.Parse(reader["ID"].ToString());
                    name = reader["Name"].ToString();
                    price = decimal.Parse(reader["Price"].ToString());

                    foods.Add(new FoodInformation(id, name, price));
                }
            }
            catch(SQLiteException sqlEx)
            {
                MessageBox.Show(sqlEx.Message);
            }
            finally
            {
                CloseConnection();
            }

            return foods;
        }

        public long InsertOrderToDatabase(string sql)
        {
            long value = 0;

            try
            {
                OpenConnection();
                SQLiteCommand command = new SQLiteCommand(sql, SqliteConnection);
                command.ExecuteNonQuery();
                
                string select = @"select last_insert_rowid()";
                command = new SQLiteCommand(select, SqliteConnection);
                value = (long)command.ExecuteScalar();
            }
            finally
            {
                CloseConnection();
            }

            return value;
        }

        public List<OrderObject> GetOrders(string email)
        {
            List<OrderObject> orders = new List<OrderObject>();
            string sql = string.Empty;

            if(email.ToUpper().Trim() == "ADMIN")
            {
                sql = "select * from orders order by ID desc";
            }
            else
            {
                sql = string.Format("select * from orders where Email = '{0}' order by ID desc", email);
            }

            try
            {
                OpenConnection();
                SQLiteCommand command = new SQLiteCommand(sql, SqliteConnection);
                SQLiteDataReader reader = command.ExecuteReader();
                
                int id;
                string emailFromBase;
                decimal price;
                int productCount;
                string orderDate;
                string attention;
                

                OrderObject orderObject;

                while (reader.Read())
                {
                    id = int.Parse(reader["ID"].ToString());
                    emailFromBase = reader["Email"].ToString();
                    price = decimal.Parse(reader["Price"].ToString());
                    productCount = int.Parse(reader["ProductCount"].ToString());
                    orderDate = reader["OrderDate"].ToString();
                    attention = reader["Attention"].ToString();

                    orderObject = new OrderObject();
                    orderObject.ID = id;
                    orderObject.Email = emailFromBase;
                    orderObject.Price = price;
                    orderObject.ProductCount = productCount;
                    orderObject.OrderDate = DateTime.ParseExact(orderDate, "yyyy-MM-dd HH:mm",
                                       System.Globalization.CultureInfo.InvariantCulture);
                    orderObject.AttentionToOrder = attention;
                    orders.Add(orderObject);
                }
            }
            catch (SQLiteException sqlEx)
            {
                MessageBox.Show(sqlEx.Message);
            }
            finally
            {
                CloseConnection();
            }

            return orders;
        }

        public AddressObject GetAddress(long orderId)
        {
            AddressObject address = null;

            string sql = string.Format("select * from Address where OrderFK = {0}", orderId);

            try
            {
                OpenConnection();
                SQLiteCommand command = new SQLiteCommand(sql, SqliteConnection);
                SQLiteDataReader reader = command.ExecuteReader();

                int id;
                string street;
                string houseNumber;
                string flatNumber;
                string city;
                int phoneNumber;

                while (reader.Read())
                {
                    id = int.Parse(reader["ID"].ToString());
                    street = reader["Street"].ToString();
                    houseNumber = reader["HouseNumber"].ToString();
                    flatNumber = reader["FlatNumber"].ToString();
                    city = reader["City"].ToString();
                    phoneNumber = int.Parse(reader["PhoneNumber"].ToString());

                    address = new AddressObject();
                    address.ID = id;
                    address.Street = street;
                    address.HouseNumber = houseNumber;
                    address.FlatNumber = flatNumber;
                    address.City = city;
                    address.PhoneNumber = phoneNumber;
                }
            }
            catch (SQLiteException sqlEx)
            {
                MessageBox.Show(sqlEx.Message);
            }
            finally
            {
                CloseConnection();
            }

            return address;
        }

        public List<OrderProductObject> GetProducts(long orderId)
        {
            List<OrderProductObject> products = new List<OrderProductObject>();

            string sql = string.Format("select * from Product where OrderFK = {0}", orderId);

            try
            {
                OpenConnection();
                SQLiteCommand command = new SQLiteCommand(sql, SqliteConnection);
                SQLiteDataReader reader = command.ExecuteReader();

                int id;
                string name;

                OrderProductObject product;

                while (reader.Read())
                {
                    id = int.Parse(reader["ID"].ToString());
                    name = reader["Name"].ToString();


                    product = new OrderProductObject(name);
                    product.ID = id;
                    products.Add(product);
                }
            }
            catch (SQLiteException sqlEx)
            {
                MessageBox.Show(sqlEx.Message);
            }
            finally
            {
                CloseConnection();
            }

            return products;
        }
    }
}
