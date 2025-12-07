namespace Kebabs
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblAdminWelcome = new Label();
            btnLogout = new Button();
            tabControl1 = new TabControl();
            tabUsers = new TabPage();
            dgvUsers = new DataGridView();
            tabRestaurants = new TabPage();
            dgvRestaurantsAdmin = new DataGridView();
            tabLogs = new TabPage();
            btnRefreshLogs = new Button();
            dgvOrdersAdmin = new DataGridView();
            dgvDeliveriesAdmin = new DataGridView();
            tabControl1.SuspendLayout();
            tabUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            tabRestaurants.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRestaurantsAdmin).BeginInit();
            tabLogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrdersAdmin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDeliveriesAdmin).BeginInit();
            SuspendLayout();
            // 
            // lblAdminWelcome
            // 
            lblAdminWelcome.AutoSize = true;
            lblAdminWelcome.Location = new Point(24, 9);
            lblAdminWelcome.Name = "lblAdminWelcome";
            lblAdminWelcome.Size = new Size(130, 20);
            lblAdminWelcome.TabIndex = 0;
            lblAdminWelcome.Text = "Welcome, [admin]";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(710, 6);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(99, 27);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabUsers);
            tabControl1.Controls.Add(tabRestaurants);
            tabControl1.Controls.Add(tabLogs);
            tabControl1.Location = new Point(1, 42);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(812, 482);
            tabControl1.TabIndex = 2;
            // 
            // tabUsers
            // 
            tabUsers.Controls.Add(dgvUsers);
            tabUsers.Location = new Point(4, 29);
            tabUsers.Name = "tabUsers";
            tabUsers.Padding = new Padding(3);
            tabUsers.Size = new Size(804, 449);
            tabUsers.TabIndex = 0;
            tabUsers.Text = "Users";
            tabUsers.UseVisualStyleBackColor = true;
            // 
            // dgvUsers
            // 
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Dock = DockStyle.Fill;
            dgvUsers.Location = new Point(3, 3);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.Size = new Size(798, 443);
            dgvUsers.TabIndex = 0;
            // 
            // tabRestaurants
            // 
            tabRestaurants.Controls.Add(dgvRestaurantsAdmin);
            tabRestaurants.Location = new Point(4, 29);
            tabRestaurants.Name = "tabRestaurants";
            tabRestaurants.Padding = new Padding(3);
            tabRestaurants.Size = new Size(804, 449);
            tabRestaurants.TabIndex = 1;
            tabRestaurants.Text = "Restaurants";
            tabRestaurants.UseVisualStyleBackColor = true;
            // 
            // dgvRestaurantsAdmin
            // 
            dgvRestaurantsAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRestaurantsAdmin.Dock = DockStyle.Fill;
            dgvRestaurantsAdmin.Location = new Point(3, 3);
            dgvRestaurantsAdmin.Name = "dgvRestaurantsAdmin";
            dgvRestaurantsAdmin.RowHeadersWidth = 51;
            dgvRestaurantsAdmin.Size = new Size(798, 443);
            dgvRestaurantsAdmin.TabIndex = 0;
            // 
            // tabLogs
            // 
            tabLogs.Controls.Add(btnRefreshLogs);
            tabLogs.Controls.Add(dgvOrdersAdmin);
            tabLogs.Controls.Add(dgvDeliveriesAdmin);
            tabLogs.Location = new Point(4, 29);
            tabLogs.Name = "tabLogs";
            tabLogs.Padding = new Padding(3);
            tabLogs.Size = new Size(804, 449);
            tabLogs.TabIndex = 2;
            tabLogs.Text = "Orders & Deliveries";
            tabLogs.UseVisualStyleBackColor = true;
            // 
            // btnRefreshLogs
            // 
            btnRefreshLogs.Location = new Point(704, 414);
            btnRefreshLogs.Name = "btnRefreshLogs";
            btnRefreshLogs.Size = new Size(94, 29);
            btnRefreshLogs.TabIndex = 2;
            btnRefreshLogs.Text = "Refresh";
            btnRefreshLogs.UseVisualStyleBackColor = true;
            btnRefreshLogs.Click += btnRefreshLogs_Click;
            // 
            // dgvOrdersAdmin
            // 
            dgvOrdersAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrdersAdmin.Dock = DockStyle.Top;
            dgvOrdersAdmin.Location = new Point(3, 3);
            dgvOrdersAdmin.Name = "dgvOrdersAdmin";
            dgvOrdersAdmin.RowHeadersWidth = 51;
            dgvOrdersAdmin.Size = new Size(798, 200);
            dgvOrdersAdmin.TabIndex = 1;
            // 
            // dgvDeliveriesAdmin
            // 
            dgvDeliveriesAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDeliveriesAdmin.Dock = DockStyle.Fill;
            dgvDeliveriesAdmin.Location = new Point(3, 3);
            dgvDeliveriesAdmin.Name = "dgvDeliveriesAdmin";
            dgvDeliveriesAdmin.RowHeadersWidth = 51;
            dgvDeliveriesAdmin.Size = new Size(798, 443);
            dgvDeliveriesAdmin.TabIndex = 0;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 543);
            Controls.Add(tabControl1);
            Controls.Add(btnLogout);
            Controls.Add(lblAdminWelcome);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kebabs Delivery - Admin Panel";
            Load += AdminForm_Load;
            tabControl1.ResumeLayout(false);
            tabUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            tabRestaurants.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRestaurantsAdmin).EndInit();
            tabLogs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOrdersAdmin).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDeliveriesAdmin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAdminWelcome;
        private Button btnLogout;
        private TabControl tabControl1;
        private TabPage tabUsers;
        private TabPage tabRestaurants;
        private TabPage tabLogs;
        private DataGridView dgvUsers;
        private DataGridView dgvRestaurantsAdmin;
        private Button btnRefreshLogs;
        private DataGridView dgvOrdersAdmin;
        private DataGridView dgvDeliveriesAdmin;
    }
}