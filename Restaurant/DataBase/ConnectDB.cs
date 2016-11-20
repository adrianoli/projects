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
    }
}
