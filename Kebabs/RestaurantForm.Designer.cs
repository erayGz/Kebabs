namespace Kebabs
{
    partial class RestaurantForm
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
            panelHeader = new Panel();
            lblStatusInfo = new Label();
            btnLogout = new Button();
            lblRestaurantWelcome = new Label();
            splitContainer1 = new SplitContainer();
            grpIncomingOrders = new GroupBox();
            panel1 = new Panel();
            btnRefreshOrders = new Button();
            dgvOrders = new DataGridView();
            grpOrderDetails = new GroupBox();
            panelActions = new Panel();
            btnReady = new Button();
            btnPreparing = new Button();
            btnReject = new Button();
            btnAccept = new Button();
            dgvOrderItems = new DataGridView();
            lblOrderStatus = new Label();
            lblAddress = new Label();
            lblCustomer = new Label();
            lblOrderId = new Label();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            grpIncomingOrders.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            grpOrderDetails.SuspendLayout();
            panelActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderItems).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = SystemColors.ActiveBorder;
            panelHeader.Controls.Add(lblStatusInfo);
            panelHeader.Controls.Add(btnLogout);
            panelHeader.Controls.Add(lblRestaurantWelcome);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1182, 60);
            panelHeader.TabIndex = 0;
            // 
            // lblStatusInfo
            // 
            lblStatusInfo.AutoSize = true;
            lblStatusInfo.Location = new Point(529, 19);
            lblStatusInfo.Name = "lblStatusInfo";
            lblStatusInfo.Size = new Size(236, 20);
            lblStatusInfo.TabIndex = 2;
            lblStatusInfo.Text = "Incoming orders are shown below.";
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogout.Location = new Point(1020, 15);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 29);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblRestaurantWelcome
            // 
            lblRestaurantWelcome.AutoSize = true;
            lblRestaurantWelcome.Font = new Font("Segoe UI", 14F);
            lblRestaurantWelcome.Location = new Point(28, 15);
            lblRestaurantWelcome.Name = "lblRestaurantWelcome";
            lblRestaurantWelcome.Size = new Size(315, 32);
            lblRestaurantWelcome.TabIndex = 0;
            lblRestaurantWelcome.Text = "Welcome, [RestaurantName]";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 60);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(grpIncomingOrders);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(grpOrderDetails);
            splitContainer1.Size = new Size(1182, 593);
            splitContainer1.SplitterDistance = 450;
            splitContainer1.TabIndex = 1;
            // 
            // grpIncomingOrders
            // 
            grpIncomingOrders.Controls.Add(panel1);
            grpIncomingOrders.Controls.Add(dgvOrders);
            grpIncomingOrders.Dock = DockStyle.Fill;
            grpIncomingOrders.Location = new Point(0, 0);
            grpIncomingOrders.Name = "grpIncomingOrders";
            grpIncomingOrders.Size = new Size(450, 593);
            grpIncomingOrders.TabIndex = 0;
            grpIncomingOrders.TabStop = false;
            grpIncomingOrders.Text = "Incoming Orders";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnRefreshOrders);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 550);
            panel1.Name = "panel1";
            panel1.Size = new Size(444, 40);
            panel1.TabIndex = 1;
            // 
            // btnRefreshOrders
            // 
            btnRefreshOrders.Location = new Point(347, 8);
            btnRefreshOrders.Name = "btnRefreshOrders";
            btnRefreshOrders.Size = new Size(94, 29);
            btnRefreshOrders.TabIndex = 0;
            btnRefreshOrders.Text = "Refresh";
            btnRefreshOrders.UseVisualStyleBackColor = true;
            // 
            // dgvOrders
            // 
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Dock = DockStyle.Fill;
            dgvOrders.Location = new Point(3, 23);
            dgvOrders.MultiSelect = false;
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dgvOrders.RowHeadersWidth = 51;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.Size = new Size(444, 567);
            dgvOrders.TabIndex = 0;
            dgvOrders.SelectionChanged += dgvOrders_SelectionChanged;
            // 
            // grpOrderDetails
            // 
            grpOrderDetails.AutoSize = true;
            grpOrderDetails.Controls.Add(panelActions);
            grpOrderDetails.Controls.Add(dgvOrderItems);
            grpOrderDetails.Controls.Add(lblOrderStatus);
            grpOrderDetails.Controls.Add(lblAddress);
            grpOrderDetails.Controls.Add(lblCustomer);
            grpOrderDetails.Controls.Add(lblOrderId);
            grpOrderDetails.Dock = DockStyle.Fill;
            grpOrderDetails.Location = new Point(0, 0);
            grpOrderDetails.Name = "grpOrderDetails";
            grpOrderDetails.Size = new Size(728, 593);
            grpOrderDetails.TabIndex = 0;
            grpOrderDetails.TabStop = false;
            grpOrderDetails.Text = "Order Details";
            // 
            // panelActions
            // 
            panelActions.Controls.Add(btnReady);
            panelActions.Controls.Add(btnPreparing);
            panelActions.Controls.Add(btnReject);
            panelActions.Controls.Add(btnAccept);
            panelActions.Dock = DockStyle.Bottom;
            panelActions.Location = new Point(3, 510);
            panelActions.Name = "panelActions";
            panelActions.Size = new Size(722, 80);
            panelActions.TabIndex = 5;
            // 
            // btnReady
            // 
            btnReady.Location = new Point(553, 25);
            btnReady.Name = "btnReady";
            btnReady.Size = new Size(160, 29);
            btnReady.TabIndex = 3;
            btnReady.Text = "Ready for Pickup";
            btnReady.UseVisualStyleBackColor = true;
            btnReady.Click += btnReady_Click;
            // 
            // btnPreparing
            // 
            btnPreparing.Location = new Point(366, 25);
            btnPreparing.Name = "btnPreparing";
            btnPreparing.Size = new Size(160, 29);
            btnPreparing.TabIndex = 2;
            btnPreparing.Text = "Mark as Preparing";
            btnPreparing.UseVisualStyleBackColor = true;
            btnPreparing.Click += btnPreparing_Click;
            // 
            // btnReject
            // 
            btnReject.Location = new Point(182, 25);
            btnReject.Name = "btnReject";
            btnReject.Size = new Size(160, 29);
            btnReject.TabIndex = 1;
            btnReject.Text = "Reject Order";
            btnReject.UseVisualStyleBackColor = true;
            btnReject.Click += btnReject_Click;
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(3, 25);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(160, 29);
            btnAccept.TabIndex = 0;
            btnAccept.Text = "Accept Order";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // dgvOrderItems
            // 
            dgvOrderItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrderItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderItems.Location = new Point(-1, 172);
            dgvOrderItems.Name = "dgvOrderItems";
            dgvOrderItems.ReadOnly = true;
            dgvOrderItems.RowHeadersWidth = 51;
            dgvOrderItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrderItems.Size = new Size(726, 332);
            dgvOrderItems.TabIndex = 4;
            // 
            // lblOrderStatus
            // 
            lblOrderStatus.AutoSize = true;
            lblOrderStatus.Location = new Point(34, 142);
            lblOrderStatus.Name = "lblOrderStatus";
            lblOrderStatus.Size = new Size(109, 20);
            lblOrderStatus.TabIndex = 3;
            lblOrderStatus.Text = "Status: Pending";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(34, 110);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(75, 20);
            lblAddress.TabIndex = 2;
            lblAddress.Text = "Address: -";
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Location = new Point(34, 74);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(85, 20);
            lblCustomer.TabIndex = 1;
            lblCustomer.Text = "Customer: -";
            // 
            // lblOrderId
            // 
            lblOrderId.AutoSize = true;
            lblOrderId.Location = new Point(34, 39);
            lblOrderId.Name = "lblOrderId";
            lblOrderId.Size = new Size(60, 20);
            lblOrderId.TabIndex = 0;
            lblOrderId.Text = "Order: -";
            // 
            // RestaurantForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 653);
            Controls.Add(splitContainer1);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "RestaurantForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kebabs Delivery - Restaurant Panel";
            Load += RestaurantForm_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            grpIncomingOrders.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            grpOrderDetails.ResumeLayout(false);
            grpOrderDetails.PerformLayout();
            panelActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOrderItems).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblRestaurantWelcome;
        private Label lblStatusInfo;
        private Button btnLogout;
        private SplitContainer splitContainer1;
        private GroupBox grpIncomingOrders;
        private DataGridView dgvOrders;
        private Panel panel1;
        private Button btnRefreshOrders;
        private GroupBox grpOrderDetails;
        private DataGridView dgvOrderItems;
        private Label lblOrderStatus;
        private Label lblAddress;
        private Label lblCustomer;
        private Label lblOrderId;
        private Panel panelActions;
        private Button btnReady;
        private Button btnPreparing;
        private Button btnReject;
        private Button btnAccept;
    }
}