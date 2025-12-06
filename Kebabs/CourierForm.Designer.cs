namespace Kebabs
{
    partial class CourierForm
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
            lblHeaderInfo = new Label();
            btnLogout = new Button();
            lblCourierWelcome = new Label();
            splitMain = new SplitContainer();
            grpDeliveries = new GroupBox();
            dgvDeliveries = new DataGridView();
            grpDeliveryDetails = new GroupBox();
            lblPickupAddress = new Label();
            lblDropoffAddress = new Label();
            lblOrderId = new Label();
            lblRestaurant = new Label();
            lblStatus = new Label();
            lblDeliveryId = new Label();
            panelActions = new Panel();
            btnDelivered = new Button();
            btnPickUp = new Button();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitMain).BeginInit();
            splitMain.Panel1.SuspendLayout();
            splitMain.Panel2.SuspendLayout();
            splitMain.SuspendLayout();
            grpDeliveries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDeliveries).BeginInit();
            grpDeliveryDetails.SuspendLayout();
            panelActions.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = SystemColors.ActiveBorder;
            panelHeader.Controls.Add(lblHeaderInfo);
            panelHeader.Controls.Add(btnLogout);
            panelHeader.Controls.Add(lblCourierWelcome);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(982, 60);
            panelHeader.TabIndex = 0;
            // 
            // lblHeaderInfo
            // 
            lblHeaderInfo.AutoSize = true;
            lblHeaderInfo.Location = new Point(373, 20);
            lblHeaderInfo.Name = "lblHeaderInfo";
            lblHeaderInfo.Size = new Size(280, 20);
            lblHeaderInfo.TabIndex = 3;
            lblHeaderInfo.Text = "Your assigned deliveries are listed below.";
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogout.Location = new Point(850, 19);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 29);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblCourierWelcome
            // 
            lblCourierWelcome.AutoSize = true;
            lblCourierWelcome.Font = new Font("Segoe UI", 14F);
            lblCourierWelcome.Location = new Point(12, 9);
            lblCourierWelcome.Name = "lblCourierWelcome";
            lblCourierWelcome.Size = new Size(280, 32);
            lblCourierWelcome.TabIndex = 0;
            lblCourierWelcome.Text = "Welcome, [courier name]";
            // 
            // splitMain
            // 
            splitMain.Dock = DockStyle.Fill;
            splitMain.Location = new Point(0, 60);
            splitMain.Name = "splitMain";
            splitMain.Orientation = Orientation.Horizontal;
            // 
            // splitMain.Panel1
            // 
            splitMain.Panel1.Controls.Add(grpDeliveries);
            // 
            // splitMain.Panel2
            // 
            splitMain.Panel2.Controls.Add(grpDeliveryDetails);
            splitMain.Size = new Size(982, 543);
            splitMain.SplitterDistance = 300;
            splitMain.TabIndex = 1;
            // 
            // grpDeliveries
            // 
            grpDeliveries.Controls.Add(dgvDeliveries);
            grpDeliveries.Dock = DockStyle.Fill;
            grpDeliveries.Location = new Point(0, 0);
            grpDeliveries.Name = "grpDeliveries";
            grpDeliveries.Size = new Size(982, 300);
            grpDeliveries.TabIndex = 0;
            grpDeliveries.TabStop = false;
            grpDeliveries.Text = "Assigned Deliveries";
            // 
            // dgvDeliveries
            // 
            dgvDeliveries.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDeliveries.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDeliveries.Dock = DockStyle.Fill;
            dgvDeliveries.Location = new Point(3, 23);
            dgvDeliveries.MultiSelect = false;
            dgvDeliveries.Name = "dgvDeliveries";
            dgvDeliveries.ReadOnly = true;
            dgvDeliveries.RowHeadersWidth = 51;
            dgvDeliveries.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDeliveries.Size = new Size(976, 274);
            dgvDeliveries.TabIndex = 0;
            dgvDeliveries.SelectionChanged += dgvDeliveries_SelectionChanged;
            // 
            // grpDeliveryDetails
            // 
            grpDeliveryDetails.Controls.Add(lblPickupAddress);
            grpDeliveryDetails.Controls.Add(lblDropoffAddress);
            grpDeliveryDetails.Controls.Add(lblOrderId);
            grpDeliveryDetails.Controls.Add(lblRestaurant);
            grpDeliveryDetails.Controls.Add(lblStatus);
            grpDeliveryDetails.Controls.Add(lblDeliveryId);
            grpDeliveryDetails.Controls.Add(panelActions);
            grpDeliveryDetails.Dock = DockStyle.Fill;
            grpDeliveryDetails.Location = new Point(0, 0);
            grpDeliveryDetails.Name = "grpDeliveryDetails";
            grpDeliveryDetails.Size = new Size(982, 239);
            grpDeliveryDetails.TabIndex = 0;
            grpDeliveryDetails.TabStop = false;
            grpDeliveryDetails.Text = "Delivery Details";
            // 
            // lblPickupAddress
            // 
            lblPickupAddress.AutoSize = true;
            lblPickupAddress.Location = new Point(536, 31);
            lblPickupAddress.Name = "lblPickupAddress";
            lblPickupAddress.Size = new Size(65, 20);
            lblPickupAddress.TabIndex = 6;
            lblPickupAddress.Text = "Pickup: -";
            // 
            // lblDropoffAddress
            // 
            lblDropoffAddress.AutoSize = true;
            lblDropoffAddress.Location = new Point(536, 81);
            lblDropoffAddress.Name = "lblDropoffAddress";
            lblDropoffAddress.Size = new Size(81, 20);
            lblDropoffAddress.TabIndex = 5;
            lblDropoffAddress.Text = "Drop-off: -";
            // 
            // lblOrderId
            // 
            lblOrderId.AutoSize = true;
            lblOrderId.Location = new Point(12, 81);
            lblOrderId.Name = "lblOrderId";
            lblOrderId.Size = new Size(60, 20);
            lblOrderId.TabIndex = 4;
            lblOrderId.Text = "Order: -";
            // 
            // lblRestaurant
            // 
            lblRestaurant.AutoSize = true;
            lblRestaurant.Location = new Point(12, 131);
            lblRestaurant.Name = "lblRestaurant";
            lblRestaurant.Size = new Size(92, 20);
            lblRestaurant.TabIndex = 3;
            lblRestaurant.Text = "Restaurant: -";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(536, 131);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(62, 20);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "Status: -";
            // 
            // lblDeliveryId
            // 
            lblDeliveryId.AutoSize = true;
            lblDeliveryId.Location = new Point(12, 31);
            lblDeliveryId.Name = "lblDeliveryId";
            lblDeliveryId.Size = new Size(76, 20);
            lblDeliveryId.TabIndex = 1;
            lblDeliveryId.Text = "Delivery: -";
            // 
            // panelActions
            // 
            panelActions.Controls.Add(btnDelivered);
            panelActions.Controls.Add(btnPickUp);
            panelActions.Dock = DockStyle.Bottom;
            panelActions.Location = new Point(3, 156);
            panelActions.Name = "panelActions";
            panelActions.Size = new Size(976, 80);
            panelActions.TabIndex = 0;
            // 
            // btnDelivered
            // 
            btnDelivered.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDelivered.Location = new Point(873, 42);
            btnDelivered.Name = "btnDelivered";
            btnDelivered.Size = new Size(94, 29);
            btnDelivered.TabIndex = 2;
            btnDelivered.Text = "Delivered";
            btnDelivered.UseVisualStyleBackColor = true;
            btnDelivered.Click += btnDelivered_Click;
            // 
            // btnPickUp
            // 
            btnPickUp.Location = new Point(773, 42);
            btnPickUp.Name = "btnPickUp";
            btnPickUp.Size = new Size(94, 29);
            btnPickUp.TabIndex = 0;
            btnPickUp.Text = "Pick Up";
            btnPickUp.UseVisualStyleBackColor = true;
            btnPickUp.Click += btnPickUp_Click;
            // 
            // CourierForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 603);
            Controls.Add(splitMain);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CourierForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kebabs Delivery - Courier Panel";
            Load += CourierForm_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            splitMain.Panel1.ResumeLayout(false);
            splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitMain).EndInit();
            splitMain.ResumeLayout(false);
            grpDeliveries.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDeliveries).EndInit();
            grpDeliveryDetails.ResumeLayout(false);
            grpDeliveryDetails.PerformLayout();
            panelActions.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Button btnLogout;
        private Label lblCourierWelcome;
        private Label lblHeaderInfo;
        private SplitContainer splitMain;
        private GroupBox grpDeliveries;
        private DataGridView dgvDeliveries;
        private GroupBox grpDeliveryDetails;
        private Label lblPickupAddress;
        private Label lblDropoffAddress;
        private Label lblOrderId;
        private Label lblRestaurant;
        private Label lblStatus;
        private Label lblDeliveryId;
        private Panel panelActions;
        private Button btnDelivered;
        private Button btnPickUp;
    }
}