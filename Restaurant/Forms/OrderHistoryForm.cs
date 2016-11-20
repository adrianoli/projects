using Restaurant.FormsLogic.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant.Forms
{
    public partial class OrderHistoryForm : Form
    {
        public OrderHistoryForm(List<OrderObject> orders)
        {
            InitializeComponent();
            uiDgvOrderHistory.DataSource = orders;
        }

        private void uiBtnLook_Click(object sender, EventArgs e)
        {

        }

        private void uiBtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
