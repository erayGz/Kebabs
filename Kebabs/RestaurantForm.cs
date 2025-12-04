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
    public partial class RestaurantForm : Form
    {
        private readonly User _currentUser;
        public RestaurantForm(User user)
        {
            InitializeComponent();
            _currentUser = user;

            lblRestaurantWelcome.Text = $"Welcome, {_currentUser.Username}";
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {

        }
    }
}
