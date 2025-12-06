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
    public partial class RestaurantForm : Form
    {
        private readonly User _currentUser;
        private readonly OrderService _orderService = new OrderService();
        private readonly DeliveryService _deliveryService = new DeliveryService();

        private Order? _selectedOrder;

        private void LoadOrders()
        {
            var orders = _orderService.GetORdersByRestaurant(_currentUser.Id);

            dgvOrders.DataSource = orders;

            dgvOrders.ClearSelection();
        }

        public RestaurantForm(User user)
        {
            InitializeComponent();
            _currentUser = user;

            LoadOrders();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            var order = dgvOrders.CurrentRow?.DataBoundItem as Order;
            if (order == null)
            {
                MessageBox.Show("Please Select An Order");
                return;
            }

            _orderService.UpdateStatus(order.Id, "Accepted");

            LoadOrders();
        }

        private void RestaurantForm_Load(object sender, EventArgs e)
        {
            lblRestaurantWelcome.Text = $"Welcome, {_currentUser.Username}";
        }



        private void btnReject_Click(object sender, EventArgs e)
        {
            var order = dgvOrders.CurrentRow?.DataBoundItem as Order;
            if (order == null)
            {
                MessageBox.Show("Please select an order.");
                return;
            }

            _orderService.UpdateStatus(order.Id, "Rejected");

            LoadOrders();
        }

        private void btnPreparing_Click(object sender, EventArgs e)
        {
            var order = dgvOrders.CurrentRow?.DataBoundItem as Order;
            if (order == null) return;

            _orderService.UpdateStatus(order.Id, "Preparing");
            LoadOrders();
        }

        private void btnReady_Click(object sender, EventArgs e)
        {
            var order = dgvOrders.CurrentRow?.DataBoundItem as Order;
            if (order == null) return;

            _orderService.UpdateStatus(order.Id, "ReadyForPickup");

            // find order and drop to courier
            var delivery = InMemoryDatabase.Deliveries
                .FirstOrDefault(d => d.OrderId == order.Id);

            if (delivery != null)
                delivery.Status = "ReadyForPickup";

            LoadOrders();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            AppSession.CurrentUser = null;
            var loginForm = new Kebabs();
            loginForm.Show();
            this.Close();
        }

        private void dgvOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow == null) return;

            var order = dgvOrders.CurrentRow.DataBoundItem as Order;
            if (order == null) return;

            lblOrderId.Text = $"Order: {order.Id}";
            lblCustomer.Text = $"Customer: {order.CustomerId}";
            lblOrderStatus.Text = $"Status: {order.Status}";

            dgvOrderItems.DataSource = null;
            dgvOrderItems.DataSource = order.Items;
        }
    }
}
