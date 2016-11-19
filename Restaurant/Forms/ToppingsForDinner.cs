using Restaurant.DataBase;
using Restaurant.FormsLogic;
using Restaurant.Products.MainDish;
using Restaurant.Products.Pizza;
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

        public ToppingsForDinner()
        {
            InitializeComponent();
            _toppingsLogic = new ToppingsLogic();
            _cultureInfo = new CultureInfo("pl-PL");
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

        private void AddElementClickEvent(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;

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

        private void AddColorElementClickEvent(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            lbl.ForeColor = Color.Blue;
        }

        private void AddLeaveElementClickEvent(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            lbl.ForeColor = Color.Black;
        }

        private void RemovePizzaElementClickEvent(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            if(!lbl.IsDisposed)
            {
                FoodInformation foodInformation = (FoodInformation)lbl.Tag;
                _actualPrice -= foodInformation.Price;
                uiTxtPrice.Text = _actualPrice.ToString("C", _cultureInfo);

                lbl.Dispose();
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
    }
}
