using Restaurant.DataBase;
using Restaurant.Forms;
using Restaurant.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class RestaurantForm : Form
    {
        private object obj = new Object();

        public RestaurantForm()
        {
            InitializeComponent();
        }

        private void uiBtnEnter_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.Show();

            Task task = new Task(() =>
                {
                    lock (obj)
                    {
                        uiPictureBox.Image = Resources.OpenDoor;
                    }

                    Task.Delay(1000).ContinueWith(x =>
                        {
                            lock (obj)
                            {
                                uiPictureBox.Image = Resources.CloseDoor;
                            }
                        });  
                });

            task.Start();
        }

        private void uiBtnGoAway_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CreateDatabase_Click(object sender, EventArgs e)
        {
            PrepareDatabaseForm db = new PrepareDatabaseForm();
            db.ShowDialog();
        }
    }
}
