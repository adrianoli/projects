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

            if(uiDgvOrderHistory.Rows.Count == 0)
            {
                uiBtnLook.Enabled = false;
            }
        }

        private void uiBtnLook_Click(object sender, EventArgs e)
        {
            OrderObject order = uiDgvOrderHistory.CurrentRow.DataBoundItem as OrderObject;

            if(order != null)
            {
                using(OrderDetails orderDetails = new OrderDetails(order))
                {
                    orderDetails.ShowDialog();
                }
            }
        }

        private void uiBtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
