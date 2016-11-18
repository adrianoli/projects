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
    public partial class ToppingsForDinner : Form
    {
        public ToppingsForDinner()
        {
            InitializeComponent();
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            Label lbl = new Label();
            lbl.Text = string.Format("X {0}", label1.Text);
            uiFlpToppingsChoosen.Controls.Add(lbl);
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Blue;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
        }

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {
            Label lbl = new Label();
            lbl.Text = string.Format("X {0}", label2.Text);
            lbl.MouseClick += new MouseEventHandler(DeleteControl);
            uiFlpToppingsChoosen.Controls.Add(lbl);
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Blue;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black;
        }

        private void DeleteControl(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            lbl.Dispose();
        }
    }
}
