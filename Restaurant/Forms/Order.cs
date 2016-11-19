using Restaurant.DataBase;
using Restaurant.FormsLogic;
using Restaurant.Products.Drink;
using Restaurant.Products.MainDish;
using Restaurant.Products.Pizza;
using Restaurant.Products.Soup;
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
    public partial class Order : Form
    {
        private List<FoodInformation> _pizzaObjects;
        private List<FoodInformation> _mainDishObjects;
        private List<FoodInformation> _soupObjects;
        private List<FoodInformation> _drinkObjects;
        private decimal _orderCost = 0.0m;
        private CultureInfo _cultureInfo;

        private const int SubstractWidth = 10;
        

        private OrderLogic _orderLogic;

        public Order()
        {
            InitializeComponent();
            _orderLogic = new OrderLogic();
            _cultureInfo = new CultureInfo("pl-PL");
            Init();

        }

        private void Init()
        {
            _pizzaObjects = _orderLogic.GetPizzaObjects();
            _mainDishObjects = _orderLogic.GetMainDishObjects();
            _soupObjects = _orderLogic.GetSoupObjects();
            _drinkObjects = _orderLogic.GetDrinkObjects();

            AddMenu();
        }

        private void AddMenu()
        {
            foreach(FoodInformation food in _pizzaObjects)
            {
                Button button = new Button();
                button.MouseClick += new MouseEventHandler(PizzaClickEvent);
                button.Text = string.Format("{0} {1}", food.Name, food.Price.ToString("C", _cultureInfo));
                button.Tag = food;
                button.Width = uiFlpFood.Width - SubstractWidth;

                uiFlpFood.Controls.Add(button);
            }

            foreach (FoodInformation food in _mainDishObjects)
            {
                Button button = new Button();
                button.MouseClick += new MouseEventHandler(MainDishClickEvent);
                button.Text = string.Format("{0} {1}", food.Name, food.Price.ToString("C", _cultureInfo));
                button.Tag = food;
                button.Width = uiFlpFood.Width - SubstractWidth;

                uiFlpFood.Controls.Add(button);
            }

            foreach (FoodInformation food in _soupObjects)
            {
                Button button = new Button();
                button.MouseClick += new MouseEventHandler(SoupClickEvent);
                button.Text = string.Format("{0} {1}", food.Name, food.Price.ToString("C", _cultureInfo));
                button.Tag = food;
                button.Width = uiFlpFood.Width - SubstractWidth;

                uiFlpFood.Controls.Add(button);
            }

            foreach (FoodInformation food in _drinkObjects)
            {
                Button button = new Button();
                button.MouseClick += new MouseEventHandler(DrinkClickEvent);
                button.Text = string.Format("{0} {1}", food.Name, food.Price.ToString("C", _cultureInfo));
                button.Tag = food;
                button.Width = uiFlpFood.Width - SubstractWidth;

                uiFlpFood.Controls.Add(button);
            }
        }

        private void uiFlpFood_SizeChanged(object sender, EventArgs e)
        {
            foreach(Control control in uiFlpFood.Controls)
            {
                Button button = control as Button;
                button.Width = uiFlpFood.Width - SubstractWidth;
            }
        }

        private void PizzaClickEvent(object sender, EventArgs e)
        {
            Button button = sender as Button;
            IPizza pizza = PizzaFactory.CreatePizza(button.Tag as FoodInformation);
            ToppingsForDinner toppings = new ToppingsForDinner(pizza);
            
            if(toppings.ShowDialog() == DialogResult.OK)
            {

            }

        }

        private void MainDishClickEvent(object sender, EventArgs e)
        {
            Button button = sender as Button;
            IMainDish mainDish = MainDishFactory.CreateMainDish(button.Tag as FoodInformation);
            ToppingsForDinner toppings = new ToppingsForDinner(mainDish);

            if (toppings.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void SoupClickEvent(object sender, EventArgs e)
        {
            Button button = sender as Button;
            ISoup soup = SoupFactory.CreateSoup(button.Tag as FoodInformation);
            uiClbShopingCard.Items.Add(soup);
            _orderCost += soup.Price();
            uiTxtOrderCost.Text = _orderCost.ToString("C", _cultureInfo);
        }

        private void DrinkClickEvent(object sender, EventArgs e)
        {
            Button button = sender as Button;
            IDrink drink = DrinkFactory.CreateDrink(button.Tag as FoodInformation);
            uiClbShopingCard.Items.Add(drink);
            _orderCost += drink.Price();
            uiTxtOrderCost.Text = _orderCost.ToString("C", _cultureInfo);
        }

        private void uiBtnDelete_Click(object sender, EventArgs e)
        {
            for(int i = uiClbShopingCard.CheckedItems.Count - 1; i >= 0; i--)
            {
                if(uiClbShopingCard.CheckedItems[i] is IPizza)
                {

                }
                else if(uiClbShopingCard.CheckedItems[i] is IDrink)
                {
                    IDrink drink = uiClbShopingCard.CheckedItems[i] as IDrink;
                    _orderCost -= drink.Price(); 
                    uiClbShopingCard.Items.RemoveAt(uiClbShopingCard.Items.IndexOf(uiClbShopingCard.CheckedItems[i]));
                }
                else if(uiClbShopingCard.CheckedItems[i] is ISoup)
                {
                    ISoup soup = uiClbShopingCard.CheckedItems[i] as ISoup;
                    _orderCost -= soup.Price();
                    uiClbShopingCard.Items.RemoveAt(uiClbShopingCard.Items.IndexOf(uiClbShopingCard.CheckedItems[i]));
                }
                else if(uiClbShopingCard.CheckedItems[i] is IMainDish)
                {

                }
            }

            uiTxtOrderCost.Text = _orderCost.ToString("C", _cultureInfo);
        }
    }
}
