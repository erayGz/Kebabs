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

            var visible = orders.Where(o =>o.Status != "Rejected" && o.Status != "Delivered").ToList();

            dgvOrders.DataSource = visible;
            dgvOrders.ClearSelection();

            UpdateRestaurantButtons(null);

        }
        private Order GetSelectedOrder()
        {
            return dgvOrders.CurrentRow?.DataBoundItem as Order;
        }

        private void UpdateRestaurantButtons(string? status)
        {
            
            btnAccept.Enabled = false;
            btnReject.Enabled = false;
            btnPreparing.Enabled = false;
            btnReady.Enabled = false;

            if (string.IsNullOrEmpty(status)) return;

            switch (status)
            {
                case "Pending":
                    btnAccept.Enabled = true;
                    btnReject.Enabled = true;
                    break;

                case "Accepted":
                    btnPreparing.Enabled = true;
                    btnReject.Enabled = true;
                    break;

                case "Preparing":
                    btnReady.Enabled = true;
                    break;

                case "ReadyForPickup":

                    break;
            }
        }


        public RestaurantForm(User user)
        {
            InitializeComponent();
            _currentUser = user;

            LoadOrders();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            var order = GetSelectedOrder();
            if (order == null)
            {
                MessageBox.Show("Please Select An Order");
                return;
            }
            if (order.Status != "Pending")
            {
                MessageBox.Show("Only pending orders can be accepted.");
                return;
            }
            _orderService.UpdateStatus(order.Id, "Accepted");

            LoadOrders();
        }

        private void RestaurantForm_Load(object sender, EventArgs e)
        {
            lblRestaurantWelcome.Text = $"Welcome, {_currentUser.Username}";
            dgvOrders.AutoGenerateColumns = false;
            dgvOrders.Columns.Clear();

            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Order",
                DataPropertyName = "Id"
            });

            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Status",
                DataPropertyName = "Status"
            });

        }



        private void btnReject_Click(object sender, EventArgs e)
        {
            var order = GetSelectedOrder();
            if (order == null)
            {
                MessageBox.Show("Please select an order.");
                return;
            }
            if (order.Status == "Accepted" || order.Status == "Preparing" || order.Status == "ReadyForPickup")
            {
                var result = MessageBox.Show(
                    "This order was already accepted. Rejecting it may reduce your rating and add a penalty.\nAre you sure?",
                    "Warning",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result != DialogResult.Yes)
                    return;
            }

            _orderService.UpdateStatus(order.Id, "Rejected");

            LoadOrders();
        }

        private void btnPreparing_Click(object sender, EventArgs e)
        {
            var order = GetSelectedOrder();
            if (order == null) return;

            if (order.Status != "Accepted")
            {
                MessageBox.Show("Only accepted orders can be marked as preparing.");
                return;
            }

            _orderService.UpdateStatus(order.Id, "Preparing");
            LoadOrders();
        }

        private void btnReady_Click(object sender, EventArgs e)
        {
            var order = GetSelectedOrder();
            if (order == null) return;
            if (order.Status != "Preparing")
            {
                MessageBox.Show("Only preparing orders can be marked as ready for pickup.");
                return;
            }
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

        private void dgvOrders_SelectionChanged(object sender, EventArgs e)
        {
            var order = GetSelectedOrder();
            if (order == null) { UpdateRestaurantButtons(null); return; }
            var customer = InMemoryDatabase.Users.FirstOrDefault(u => u.Id == order.CustomerId);
            string customerAddress = customer?.Address ?? "-";

            lblOrderId.Text = $"Order: {order.Id}";
            lblCustomer.Text = $"Customer: {order.CustomerId}";
            lblOrderStatus.Text = $"Status: {order.Status}";
            lblAddress.Text = $"Address: {customerAddress}";

            dgvOrderItems.DataSource = null;
            dgvOrderItems.DataSource = order.Items;

            UpdateRestaurantButtons(order.Status);
        }
    }
}
