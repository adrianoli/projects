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
            conDB.ExecuteSql("create table Pizza (ID INTEGER PRIMARY KEY AUTOINCREMENT, Name varchar(50), Price decimal, IsArchival int)");
            conDB.ExecuteSql("create table AddToPizza (ID INTEGER PRIMARY KEY AUTOINCREMENT, Name varchar(50), Price decimal, IsArchival int)");
            conDB.ExecuteSql("create table MainDish (ID INTEGER PRIMARY KEY AUTOINCREMENT, Name varchar(50), Price decimal, IsArchival int)");
            conDB.ExecuteSql("create table AddToMainDish (ID INTEGER PRIMARY KEY AUTOINCREMENT, Name varchar(50), Price decimal, IsArchival int)");
            conDB.ExecuteSql("create table Soup (ID INTEGER PRIMARY KEY AUTOINCREMENT, Name varchar(50), Price decimal, IsArchival int)");
            conDB.ExecuteSql("create table Drink (ID INTEGER PRIMARY KEY AUTOINCREMENT, Name varchar(50), Price decimal, IsArchival int)");
            
            MessageBox.Show("Tabele zostały utworzone");
        }

        private void uiBtnDeleteTable_Click(object sender, EventArgs e)
        {
        }

        private void uiBtnAddData_Click(object sender, EventArgs e)
        {
            ConnectDB conDB = new ConnectDB();
            conDB.ExecuteSql("insert into Pizza (Name, Price, IsArchival) values ('Margheritta', 20.0, 0)");
            conDB.ExecuteSql("insert into Pizza (Name, Price, IsArchival) values ('Vegetariana', 22.0, 0)");
            conDB.ExecuteSql("insert into Pizza (Name, Price, IsArchival) values ('Tosca', 25.0, 0)");
            conDB.ExecuteSql("insert into Pizza (Name, Price, IsArchival) values ('Venecia', 25.0, 0)");
            conDB.ExecuteSql("insert into AddToPizza (Name, Price, IsArchival) values ('Podwójny ser', 2.0, 0)");
            conDB.ExecuteSql("insert into AddToPizza (Name, Price, IsArchival) values ('Salami', 2.0, 0)");
            conDB.ExecuteSql("insert into AddToPizza (Name, Price, IsArchival) values ('Szynka', 2.0, 0)");
            conDB.ExecuteSql("insert into AddToPizza (Name, Price, IsArchival) values ('Pieczarki', 2.0, 0)");
            conDB.ExecuteSql("insert into MainDish (Name, Price, IsArchival) values ('Schabowy z frytkami', 30.0, 0)");
            conDB.ExecuteSql("insert into MainDish (Name, Price, IsArchival) values ('Schabowy z ryżem', 30.0, 0)");
            conDB.ExecuteSql("insert into MainDish (Name, Price, IsArchival) values ('Schabowy z ziemniakami', 30.0, 0)");
            conDB.ExecuteSql("insert into MainDish (Name, Price, IsArchival) values ('Ryba z frytkami', 28.0, 0)");
            conDB.ExecuteSql("insert into MainDish (Name, Price, IsArchival) values ('Placek po węgiersku', 27.0, 0)");
            conDB.ExecuteSql("insert into AddToMainDish (Name, Price, IsArchival) values ('Bar sałatkowy', 5.0, 0)");
            conDB.ExecuteSql("insert into AddToMainDish (Name, Price, IsArchival) values ('Zestaw sosów', 6.0, 0)");
            conDB.ExecuteSql("insert into Soup (Name, Price, IsArchival) values ('Pomidorowa', 12.0, 0)");
            conDB.ExecuteSql("insert into Soup (Name, Price, IsArchival) values ('Rosół', 10.0, 0)");
            conDB.ExecuteSql("insert into Drink (Name, Price, IsArchival) values ('Kawa', 5.0, 0)");
            conDB.ExecuteSql("insert into Drink (Name, Price, IsArchival) values ('Herbata', 5.0, 0)");
            conDB.ExecuteSql("insert into Drink (Name, Price, IsArchival) values ('Cola', 5.0, 0)");

            MessageBox.Show("Dane zostały dodane");
        }
    }
}
