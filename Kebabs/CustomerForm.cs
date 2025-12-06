using Kebabs.Models;
using Kebabs.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Kebabs
{
    public partial class CustomerForm : Form
    {
        private readonly User _currentUser;
        private readonly RestaurantService _restaurantService = new RestaurantService();
        private readonly MenuService _menuService = new MenuService();
        private readonly OrderService _orderService = new OrderService();

        private int _selectedRestaurantId = -1;
        private List<OrderItem> _cart = new List<OrderItem>();

        private void RefreshCartGrid()
        {
            dgvCart.DataSource = null;
            dgvCart.DataSource = _cart;

            decimal total = _cart.Sum(x => x.Subtotal);
            lblTotalAmount.Text = $"{total:0.00} €";
        }

        public CustomerForm(User user)
        {
            InitializeComponent();
            _currentUser = user;


        }
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Welcome, {_currentUser.Username}";

            var restaurants = _restaurantService.GetRestaurants();
            dgvRestaurants.DataSource = restaurants;
        }

        private void btnViewMenu_Click(object sender, EventArgs e)
        {
            if (dgvRestaurants.CurrentRow == null)
            {
                MessageBox.Show("Please select a restaurant.");
                return;
            }

            var restaurant = (Restaurant)dgvRestaurants.CurrentRow.DataBoundItem;
            _selectedRestaurantId = restaurant.Id;

            lblSelectedRestaurant.Text = $"Restaurant : {restaurant.Name}";

            var menu = _menuService.GetMenu(restaurant.Id);
            dgvMenu.DataSource = menu;

            dgvMenu.ClearSelection();
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (dgvMenu.CurrentRow == null)
            {
                MessageBox.Show("Please Select a Food Item.");
                return;
            }

            if (_selectedRestaurantId == -1)
            {
                MessageBox.Show("Please Select a restaurant first. ");
                return;
            }
            Food food = (Food)dgvMenu.CurrentRow.DataBoundItem;

            int quantity = (int)numQuantity.Value;

            if (quantity <= 0)
            {
                MessageBox.Show("Quantity must be at least 1.");
                return;
            }

            OrderItem item = new OrderItem
            {
                FoodName = food.Name,
                UnitPrice = food.Price,
                Quantity = quantity
            };

            _cart.Add(item);

            RefreshCartGrid();
        }



        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            if (_cart.Count == 0)
            {
                MessageBox.Show("Your cart is empty.");
                return;
            }
            if (_selectedRestaurantId == -1)
            {
                MessageBox.Show("Please select a restaurant.");
                return;
            }

            var order = _orderService.CreateOrder(_currentUser.Id, _selectedRestaurantId, _cart);

            MessageBox.Show($"Your order has been placed successfully! \n Order ID: {order.Id}", "Order Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _cart.Clear();
            RefreshCartGrid();
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (dgvCart.CurrentRow == null)
            {
                MessageBox.Show("Please select an item to remove.");
                return;
            }
            var item = (OrderItem)dgvCart.CurrentRow.DataBoundItem;

            _cart.Remove(item);

            RefreshCartGrid();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            AppSession.CurrentUser = null;

            //Find login form from open forms
            var loginForm = Application.OpenForms
                .OfType<Kebabs>()
                .FirstOrDefault();

            if (loginForm != null)
            {
                loginForm.ClearLoginFields();   //Delete username and password
                loginForm.Show();               //Bring back to login form
            }
            else
            {
                //if we dont have any login form open a new login form
                var newLogin = new Kebabs();
                newLogin.Show();
            }

            this.Close();   // Close the form we are using
        }
    }
}
