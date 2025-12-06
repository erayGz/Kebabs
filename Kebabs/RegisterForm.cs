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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            //Roles for Combobox

            cmbRole.Items.Add("Customer");
            cmbRole.Items.Add("Restaurant");
            cmbRole.Items.Add("Courier");
            cmbRole.SelectedIndex = 0;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtNewUsername.Text.Trim();
            string password = txtNewPassword.Text.Trim();
            string confirm = txtConfirmPassword.Text.Trim();
            string role = cmbRole.SelectedItem?.ToString()??" ";
            string address = txtAddress.Text.Trim();

            //VALIDATION
            if (string.IsNullOrEmpty(username)|| string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter username and password.");
                return;
            }
            if (password != confirm)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }
            if (string.IsNullOrEmpty(address)){
                MessageBox.Show("Please Enter Address");
                return;
            }
            bool exists = InMemoryDatabase.Users
            .Any(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase));
            if (exists) { MessageBox.Show("This username is already taken."); return; }

            //Create new ID
            int newId = (InMemoryDatabase.Users.Count == 0) ? 1 : InMemoryDatabase.Users.Max(u => u.Id) + 1;

            //Add User

            var newUser = new User
            {
                Id = newId,
                Username = username,
                Password = password,
                Role = role,
                Address = address
            };
            if (role == "Restaurant")
            {
                InMemoryDatabase.Restaurants.Add(new Restaurant
                {
                    Id = newId,
                    Name = username + " Restaurant",
                    Address = address   
                });

                MessageBox.Show("Registration successful!", "Success",
    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            InMemoryDatabase.Users.Add(newUser);
        }
    }
}
