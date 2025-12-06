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
        public CourierForm(User user)
        {
            InitializeComponent();
            _currentUser = user;


        }

        private void CourierForm_Load(object sender, EventArgs e)
        {
            lblCourierWelcome.Text = $"Welcome, {_currentUser.Username}";
            LoadDeliveries();
        }

        private void LoadDeliveries()
        {
            var deliveries = _deliveryService.GetAssignmentDeliveries(_currentUser.Id);
            dgvDeliveries.DataSource = deliveries;
            dgvDeliveries.ClearSelection();
        }



        private void dgvDeliveries_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDeliveries.CurrentRow == null) return;

            var delivery = dgvDeliveries.CurrentRow.DataBoundItem as Delivery;
            if (delivery == null) return;

            lblDeliveryId.Text = $"Delivery: {delivery.Id}";
            lblOrderId.Text = $"Order: {delivery.OrderId}";
            lblRestaurant.Text = $"Restaurant: {delivery.RestaurantAddress}";
            lblPickupAddress.Text = $"Pickup: {delivery.RestaurantAddress}";
            lblDropoffAddress.Text = $"Drop-off: {delivery.CustomerAddress}";
            lblStatus.Text = $"Status: {delivery.Status}";
        }
        private Delivery GetSelectedDelivery()
        {
            return dgvDeliveries.CurrentRow?.DataBoundItem as Delivery;
        }
        private void btnPickUp_Click(object sender, EventArgs e)
        {
            var delivery = GetSelectedDelivery();
            if (delivery == null)
            {
                MessageBox.Show("Please Select a Delivery. ");
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
