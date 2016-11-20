using Restaurant.DataBase;
using Restaurant.FormsLogic;
using Restaurant.FormsLogic.Objects;
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
            using (ToppingsForDinner toppings = new ToppingsForDinner(pizza))
            {
                if (toppings.ShowDialog() == DialogResult.OK)
                {
                    uiClbShopingCard.Items.Add(toppings.Pizza);
                    _orderCost += toppings.Pizza.Price();
                    uiTxtOrderCost.Text = _orderCost.ToString("C", _cultureInfo);
                }
            }
        }

        private void MainDishClickEvent(object sender, EventArgs e)
        {
            Button button = sender as Button;
            IMainDish mainDish = MainDishFactory.CreateMainDish(button.Tag as FoodInformation);
            using (ToppingsForDinner toppings = new ToppingsForDinner(mainDish))
            {
                if (toppings.ShowDialog() == DialogResult.OK)
                {
                    uiClbShopingCard.Items.Add(toppings.MainDish);
                    _orderCost += toppings.MainDish.Price();
                    uiTxtOrderCost.Text = _orderCost.ToString("C", _cultureInfo);
                }
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
                    IPizza pizza = uiClbShopingCard.CheckedItems[i] as IPizza;
                    _orderCost -= pizza.Price();
                    uiClbShopingCard.Items.RemoveAt(uiClbShopingCard.Items.IndexOf(uiClbShopingCard.CheckedItems[i]));
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
                    IMainDish mainDish = uiClbShopingCard.CheckedItems[i] as IMainDish;
                    _orderCost -= mainDish.Price();
                    uiClbShopingCard.Items.RemoveAt(uiClbShopingCard.Items.IndexOf(uiClbShopingCard.CheckedItems[i]));
                }
            }

            uiTxtOrderCost.Text = _orderCost.ToString("C", _cultureInfo);
        }

        private void uiBtnOrderHistory_Click(object sender, EventArgs e)
        {
            string message = string.Empty;
            if (!_orderLogic.EmailValidationToHistory(ref message, uiTxtEmail.Text))
            {
                MessageBox.Show(message, "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void uiBtnSendOrder_Click(object sender, EventArgs e)
        {
            string message;
            if(!_orderLogic.Validate(out message, uiTxtEmail.Text, uiClbShopingCard.Items.Count))
            {
                MessageBox.Show(message, "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AddressObject addressObject = _orderLogic.CreateAddress();

            if(addressObject == null)
            {
                MessageBox.Show("Zamówienie nie zostanie wysłane nie został podany adres.", "Uwaga", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            List<OrderProductObject> orderProductObjects = new List<OrderProductObject>();

            foreach(object obj in uiClbShopingCard.Items)
            {
                orderProductObjects.Add(new OrderProductObject(obj.ToString()));
            }

            OrderObject orderObject = CreateOrderObject();
            _orderLogic.CreateOrder(orderObject, addressObject, orderProductObjects);
        }

        private OrderObject CreateOrderObject()
        {
            OrderObject orderObject = new OrderObject();
            orderObject.Email = uiTxtEmail.Text;
            orderObject.ProductCount = uiClbShopingCard.Items.Count;
            orderObject.Price = _orderCost;
            orderObject.OrderDate = DateTime.Now;
            orderObject.AttentionToOrder = uiTxtAttentionToOrder.Text;

            return orderObject;
        }
    }
}
