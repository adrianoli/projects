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
    }
}
