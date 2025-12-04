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
    public partial class CourierForm : Form
    {
        private readonly User _currentUser;
        public CourierForm(User user)
        {
            InitializeComponent();
            _currentUser = user;

            lblCourierWelcome.Text = $"Welcome, {_currentUser.Username}"; ;
        }
    }
}
