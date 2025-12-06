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
    public partial class CourierForm : Form
    {
        private readonly User _currentUser;
        private readonly DeliveryService _deliveryService = new DeliveryService();
        private Delivery GetSelectedDelivery()
        {
            return dgvDeliveries.CurrentRow?.DataBoundItem as Delivery;
        }
        private void UpdateCourierButtons(string? status)
        {
            btnPickUp.Enabled = false;
            btnDelivered.Enabled = false;

            if (status == "ReadyForPickup")
            {
                btnPickUp.Enabled = true;      // if it is ready it can pickup
            }
            else if (status == "PickedUp")
            {
                btnDelivered.Enabled = true;   //only pickup after delivered
            }
        }
        public void UpdateStatus(int deliveryId, string status)
        {
            var delivery = InMemoryDatabase.Deliveries
                .FirstOrDefault(d => d.Id == deliveryId);

            if (delivery == null)return;
            delivery.Status = status;

            if (status == "PickedUp" || status == "Delivered")
            {
                var order = InMemoryDatabase.Orders.FirstOrDefault(o => o.Id == delivery.OrderId);

                if (order != null)order.Status = status;
            }
        }


        public CourierForm(User user)
        {
            InitializeComponent();
            _currentUser = user;


        }

        private void CourierForm_Load(object sender, EventArgs e)
        {
            lblCourierWelcome.Text = $"Welcome, {_currentUser.Username}";
            LoadDeliveries();

            dgvDeliveries.AutoGenerateColumns = false;
            dgvDeliveries.Columns.Clear();

            dgvDeliveries.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Restaurant",
                DataPropertyName = "RestaurantAddress"
            });

            dgvDeliveries.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Customer",
                DataPropertyName = "CustomerAddress"
            });

            dgvDeliveries.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Status",
                DataPropertyName = "Status"
            });

        }

        private void LoadDeliveries()
        {
            var deliveries = _deliveryService.GetAssignmentDeliveries(_currentUser.Id);
            var visible = deliveries.Where(d => d.Status != "Delivered").Where(d =>
            {
                var order = InMemoryDatabase.Orders.FirstOrDefault(o => o.Id == d.OrderId);
                return order == null || order.Status != "Rejected";
            }).ToList();
            dgvDeliveries.DataSource = deliveries;
            dgvDeliveries.ClearSelection();
        }

        private void dgvDeliveries_SelectionChanged(object sender, EventArgs e)
        {

            var delivery = GetSelectedDelivery();
            if (delivery == null) return;

            lblDeliveryId.Text = $"Delivery: {delivery.Id}";
            lblOrderId.Text = $"Order: {delivery.OrderId}";
            lblRestaurant.Text = $"Restaurant: {delivery.RestaurantAddress}";
            lblPickupAddress.Text = $"Pickup: {delivery.RestaurantAddress}";
            lblDropoffAddress.Text = $"Drop-off: {delivery.CustomerAddress}";
            lblStatus.Text = $"Status: {delivery.Status}";

            UpdateCourierButtons(delivery.Status);

        }

        private void btnPickUp_Click(object sender, EventArgs e)
        {
            var delivery = GetSelectedDelivery();
            if (delivery == null)
            {
                MessageBox.Show("Please Select a Delivery. ");
                return;
            }
            if (delivery.Status != "ReadyForPickup")
            {
                MessageBox.Show("You can only pick up orders that are ready for pickup.");
                return;
            }
            _deliveryService.UpdateStatus(delivery.Id, "PickedUp");
            LoadDeliveries();
        }

        private void btnDelivered_Click(object sender, EventArgs e)
        {
            var delivery = GetSelectedDelivery();
            if (delivery == null)
            {
                MessageBox.Show("Please Select a Delivery.");
                return;
            }
            if (delivery.Status != "PickedUp")
            {
                MessageBox.Show("You can only mark orders as delivered after picking them up.");
                return;
            }
                _deliveryService.UpdateStatus(delivery.Id, "Delivered");
            LoadDeliveries();
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
