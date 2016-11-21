using Restaurant.FormsLogic.Objects;
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

namespace Restaurant.Forms
{
    public partial class AddressForm : Form
    {
        public AddressObject AddressObj {get; private set;}

        public AddressForm()
        {
            InitializeComponent();
        }

        private void uiBtnAccept_Click(object sender, EventArgs e)
        {
            if(!Validate())
            {
                return;
            }

            AddressObj = CreateAddressObject();

            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void uiBtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        // Walidacja wymaganych pól adresu
        private bool Validate()
        {
            if(string.IsNullOrWhiteSpace(uiTxtStreet.Text) || string.IsNullOrWhiteSpace(uiTxtHouseNumber.Text) ||
                string.IsNullOrWhiteSpace(uiTxtCity.Text))
            {
                MessageBox.Show(Resources.NotSetRequiredField, Resources.Attention, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private AddressObject CreateAddressObject()
        {
            AddressObject address = new AddressObject();
            address.Street = uiTxtStreet.Text;
            address.HouseNumber = uiTxtHouseNumber.Text;
            address.FlatNumber = uiTxtFlatNumber.Text;
            address.City = uiTxtCity.Text;
            address.PhoneNumber = int.Parse(uiNudPhoneNumber.Value.ToString());

            return address;
        }
    }
}
