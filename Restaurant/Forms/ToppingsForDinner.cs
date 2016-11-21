using Restaurant.DataBase;
using Restaurant.FormsLogic;
using Restaurant.Products.MainDish;
using Restaurant.Products.Pizza;
using Restaurant.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant.Forms
{
    public partial class ToppingsForDinner : Form
    {
        private IPizza _pizza;
        private IMainDish _mainDish;
        private ToppingsLogic _toppingsLogic;
        private List<FoodInformation> _addToPizzaObjects;
        private List<FoodInformation> _addToMainDishObjects;
        private CultureInfo _cultureInfo;
        private decimal _actualPrice = 0.0m;

        private const short MaximumAddElement = 8;

        public ToppingsForDinner()
        {
            InitializeComponent();
            _toppingsLogic = new ToppingsLogic();
            _cultureInfo = new CultureInfo(Resources.CultureInfo_Message);
        }

        public ToppingsForDinner(IPizza pizza) 
            : this()
        {
            _pizza = pizza;
            uiLblDinnerName.Text = pizza.Name();
            _actualPrice = pizza.Price();
            uiTxtPrice.Text = _actualPrice.ToString("C", _cultureInfo);
            _addToPizzaObjects = _toppingsLogic.GetPizzaToppingsObjects();
            AddMenu();
        }

        public ToppingsForDinner(IMainDish mainDish)
            : this()
        {
            _mainDish = mainDish;
            uiLblDinnerName.Text = mainDish.Name();
            _actualPrice = mainDish.Price();
            uiTxtPrice.Text = _actualPrice.ToString("C", _cultureInfo);
            _addToMainDishObjects = _toppingsLogic.GetMainDishToppingsObjects();
            AddMenu();
        }

        public IPizza Pizza
        {
            get { return _pizza; }
        }

        public IMainDish MainDish
        {
            get { return _mainDish; }
        }

        //Funkcja dodaje dodatki do kontrolki i subskrybuje zdarzenia. W Tagu jest przechowywany obiekt dodatków z bazy
        private void AddMenu()
        {
                foreach (FoodInformation food in _addToMainDishObjects ?? _addToPizzaObjects)
                {
                    Label label = new Label();
                    label.AutoSize = true;
                    label.MouseClick += new MouseEventHandler(AddElementClickEvent);
                    label.MouseHover += new EventHandler(AddColorElementClickEvent);
                    label.MouseLeave += new EventHandler(AddLeaveElementClickEvent);
                    label.Text = string.Format("+ {0} {1}", food.Name, food.Price.ToString("C", _cultureInfo));
                    label.Tag = food;

                    uiFlpAddToppings.Controls.Add(label);
               }
        }

        // Funkcja odpalana przy kliknięciu w dodatek. Tworzy dynamicznie nowy label umieszczany na innym panelu i blokuje dodawanie wybranego dodatku.
        private void AddElementClickEvent(object sender, EventArgs e)
        {
            if(uiFlpToppingsChoosen.Controls.Count >= MaximumAddElement)
            {
                MessageBox.Show(Resources.NotAddMoreToppings, Resources.Attention, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Label lbl = (Label)sender;
            lbl.Enabled = false;

            Label label = new Label();
            label.AutoSize = true;

            label.MouseClick += new MouseEventHandler(RemovePizzaElementClickEvent);
            label.MouseHover += new EventHandler(RemoveColorPizzaElementClickEvent);
            label.MouseLeave += new EventHandler(RemoveLeavePizzaElementClickEvent);

            FoodInformation food = (FoodInformation)lbl.Tag;
            _actualPrice += food.Price;
            uiTxtPrice.Text = _actualPrice.ToString("C", _cultureInfo);
            label.Text = string.Format("x {0} {1}", food.Name, food.Price.ToString("C", _cultureInfo));

            label.Tag = food;
            uiFlpToppingsChoosen.Controls.Add(label);

        }

        // Zmiana koloru po najechaniu myszką na label
        private void AddColorElementClickEvent(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;

            if(!lbl.Enabled)
            {
                return;
            }

            lbl.ForeColor = Color.Blue;
        }

        // Powrót do domyślnego koloru gdy kursor myszki zniknie z labela.
        private void AddLeaveElementClickEvent(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;

            if (!lbl.Enabled)
            {
                return;
            }

            lbl.ForeColor = Color.Black;
        }

        // Zdarzenie odpowiedzialne za usuwanie dodatków, których jednak nie chcemy zamówić. Gdy usuniemy dodatek z panelu wyboru znów staje się on aktywny.
        private void RemovePizzaElementClickEvent(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            if(!lbl.IsDisposed)
            {
                FoodInformation foodInformation = (FoodInformation)lbl.Tag;
                _actualPrice -= foodInformation.Price;
                uiTxtPrice.Text = _actualPrice.ToString("C", _cultureInfo);

                lbl.Dispose();

                foreach (Control control in uiFlpAddToppings.Controls)
                {
                    Label label = (Label)control;
                    FoodInformation food2 = (FoodInformation)label.Tag;
                    if (food2.ID == foodInformation.ID)
                    {
                        label.Enabled = true;
                        label.ForeColor = Color.Black;
                    }
                }
            }
        }

        private void RemoveColorPizzaElementClickEvent(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            lbl.ForeColor = Color.Red;
        }

        private void RemoveLeavePizzaElementClickEvent(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            lbl.ForeColor = Color.Black;
        }

        private void ToppingsForDinner_SizeChanged(object sender, EventArgs e)
        {
            uiLblDinnerName.Left = (uiPnlDinnerName.Width - uiLblDinnerName.Width) / 2;
            uiLblDinnerName.Top = (uiPnlDinnerName.Height - uiLblDinnerName.Height) / 2;
        }

        // Wykorzystanie wzorca projektowego Dekorator do dekorowania Pizzy lub Dań głównych dodatkami.
        private void uiBtnAccept_Click(object sender, EventArgs e)
        {
            List<FoodInformation> foodInformations = new List<FoodInformation>();

            foreach(Control control in uiFlpToppingsChoosen.Controls)
            {
                Label lbl = (Label)control;
                foodInformations.Add((FoodInformation)lbl.Tag);
            }

            if(_pizza != null)
            {
                _pizza = _toppingsLogic.CustomPizza(_pizza, foodInformations);
            }
            else if (_mainDish != null)
            {
                _mainDish = _toppingsLogic.CustomMainDish(_mainDish, foodInformations);
            }

            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
