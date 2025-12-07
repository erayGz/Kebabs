using Kebabs.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Kebabs
{
    public partial class AdminForm : Form
    {
        private readonly User _currentUser;
        public AdminForm(User user)
        {
            InitializeComponent();
            _currentUser = user;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            lblAdminWelcome.Text = $"Welcome, {_currentUser.Username}";
            LoadUsers();
            LoadRestaurants();
            LoadOrders();
            LoadDeliveries();
        }

        private void LoadDeliveries()
        {
            var deliveries = InMemoryDatabase.Deliveries
                .Select(d => new
                {
                    d.Id,
                    d.OrderId,
                    d.CourierId,
                    d.RestaurantAddress,
                    d.CustomerAddress,
                    d.Status
                })
                .ToList();

            dgvDeliveriesAdmin.AutoGenerateColumns = true;
            dgvDeliveriesAdmin.DataSource = deliveries;
            dgvDeliveriesAdmin.ClearSelection();
        }

        private void LoadOrders()
        {
            var orders = InMemoryDatabase.Orders
                .Select(o => new
                {
                    o.Id,
                    o.CustomerId,
                    o.RestaurantId,
                    o.Status
                })
                .ToList();

            dgvOrdersAdmin.AutoGenerateColumns = true;
            dgvOrdersAdmin.DataSource = orders;
            dgvOrdersAdmin.ClearSelection();
        }

        private void LoadRestaurants()
        {
            var restaurants = InMemoryDatabase.Restaurants.ToList();

            dgvRestaurantsAdmin.AutoGenerateColumns = false;
            dgvRestaurantsAdmin.Columns.Clear();

            dgvRestaurantsAdmin.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Id",
                DataPropertyName = "Id",
                ReadOnly = true
            });

            dgvRestaurantsAdmin.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Name",
                DataPropertyName = "Name"
            });

            dgvRestaurantsAdmin.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Address",
                DataPropertyName = "Address"
            });

            dgvRestaurantsAdmin.DataSource = restaurants;
            dgvRestaurantsAdmin.ClearSelection();
        }

        private void LoadUsers()
        {
            var users = InMemoryDatabase.Users.ToList();

            dgvUsers.AutoGenerateColumns = false;
            dgvUsers.Columns.Clear();

            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Id",
                DataPropertyName = "Id",
                ReadOnly = true
            });

            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Username",
                DataPropertyName = "Username"
            });

            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Role",
                DataPropertyName = "Role"
            });

            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Address",
                DataPropertyName = "Address"
            });

            dgvUsers.DataSource = users;
            dgvUsers.ClearSelection();
        }

        private void btnRefreshLogs_Click(object sender, EventArgs e)
        {
            LoadOrders();
            LoadDeliveries();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            AppSession.CurrentUser = null;

            var loginForm = Application.OpenForms
                .OfType<Kebabs>()
                .FirstOrDefault();

            if (loginForm != null)
            {
                loginForm.ClearLoginFields();
                loginForm.Show();
            }
            else
            {
                var newLogin = new Kebabs();
                newLogin.Show();
            }

            this.Close();
        }

    }
}
