using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant.DataBase
{
    public partial class PrepareDatabaseForm : Form
    {
        public PrepareDatabaseForm()
        {
            InitializeComponent();
        }

        private void uiBtnCreateDatabase_Click(object sender, EventArgs e)
        {
            CreateDatabase();
        }

        private void CreateDatabase()
        {
            try
            {
                SQLiteConnection.CreateFile("RestaurantDB.sqlite");

                MessageBox.Show("Baza danych została utworzona");
            }
            catch (SQLiteException sqlExeption)
            {
                MessageBox.Show(sqlExeption.Message);
            }
        }

        private void ConnectDbTest_Click(object sender, EventArgs e)
        {
            ConnectDB connectDB = new ConnectDB();
            connectDB.OpenConnection();
            connectDB.CloseConnection();

            MessageBox.Show("Połączenie z bazą danych zostało nawiązane");
        }

        private void uiBtnCreateTable_Click(object sender, EventArgs e)
        {
            ConnectDB conDB = new ConnectDB();
            conDB.ExecuteSql("create table Pizza (ID INTEGER PRIMARY KEY AUTOINCREMENT, Name varchar(50), Price decimal)");
            conDB.ExecuteSql("create table AddToPizza (ID INTEGER PRIMARY KEY AUTOINCREMENT, Name varchar(50), Price decimal)");
            conDB.ExecuteSql("create table MainDish (ID INTEGER PRIMARY KEY AUTOINCREMENT, Name varchar(50), Price decimal)");
            conDB.ExecuteSql("create table AddToMainDish (ID INTEGER PRIMARY KEY AUTOINCREMENT, Name varchar(50), Price decimal)");
            conDB.ExecuteSql("create table Soup (ID INTEGER PRIMARY KEY AUTOINCREMENT, Name varchar(50), Price decimal)");
            conDB.ExecuteSql("create table Drink (ID INTEGER PRIMARY KEY AUTOINCREMENT, Name varchar(50), Price decimal)");
            
            MessageBox.Show("Tabele zostały utworzone");
        }

        private void uiBtnDeleteTable_Click(object sender, EventArgs e)
        {
            ConnectDB conDB = new ConnectDB();

            try
            {
                conDB.OpenConnection();
                string sql = "select * from Pizza";
                SQLiteCommand command = new SQLiteCommand(sql, conDB.SqliteConnection);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = int.Parse(reader["ID"].ToString());
                    string name = reader["Name"].ToString();
                    decimal price = (decimal)reader["Price"];
                }
                
            }
            finally
            {
                conDB.CloseConnection();
            }
        }

        private void uiBtnAddData_Click(object sender, EventArgs e)
        {
            ConnectDB conDB = new ConnectDB();
            conDB.ExecuteSql("insert into Pizza (Name, Price) values ('Margheritta', 20.0)");
            conDB.ExecuteSql("insert into Pizza (Name, Price) values ('Vegetariana', 22.0)");
            conDB.ExecuteSql("insert into Pizza (Name, Price) values ('Tosca', 25.0)");
            conDB.ExecuteSql("insert into Pizza (Name, Price) values ('Venecia', 25.0)");
            conDB.ExecuteSql("insert into AddToPizza (Name, Price) values ('Podwójny ser', 2.0)");
            conDB.ExecuteSql("insert into AddToPizza (Name, Price) values ('Salami', 2.0)");
            conDB.ExecuteSql("insert into AddToPizza (Name, Price) values ('Szynka', 2.0)");
            conDB.ExecuteSql("insert into AddToPizza (Name, Price) values ('Pieczarki', 2.0)");
            conDB.ExecuteSql("insert into MainDish (Name, Price) values ('Schabowy z frytkami', 30.0)");
            conDB.ExecuteSql("insert into MainDish (Name, Price) values ('Schabowy z ryżem', 30.0)");
            conDB.ExecuteSql("insert into MainDish (Name, Price) values ('Schabowy z ziemniakami', 30.0)");
            conDB.ExecuteSql("insert into MainDish (Name, Price) values ('Ryba z frytkami', 28.0)");
            conDB.ExecuteSql("insert into MainDish (Name, Price) values ('Placek po węgiersku', 27.0)");
            conDB.ExecuteSql("insert into AddToMainDish (Name, Price) values ('Bar sałatkowy', 5.0)");
            conDB.ExecuteSql("insert into AddToMainDish (Name, Price) values ('Zestaw sosów', 6.0)");
            conDB.ExecuteSql("insert into Soup (Name, Price) values ('Pomidorowa', 12.0)");
            conDB.ExecuteSql("insert into Soup (Name, Price) values ('Rosół', 10.0)");
            conDB.ExecuteSql("insert into Drink (Name, Price) values ('Kawa', 5.0)");
            conDB.ExecuteSql("insert into Drink (Name, Price) values ('Herbata', 5.0)");
            conDB.ExecuteSql("insert into Drink (Name, Price) values ('Cola', 5.0)");

            MessageBox.Show("Dane zostały dodane");
        }
    }
}
