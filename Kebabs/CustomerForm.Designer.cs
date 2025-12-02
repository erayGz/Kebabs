namespace Kebabs
{
    partial class CustomerForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            panelHeader = new Panel();
            btnLogout = new Button();
            lblWelcome = new Label();
            splitMain = new SplitContainer();
            grpRestaurants = new GroupBox();
            btnViewMenu = new Button();
            dgvRestaurants = new DataGridView();
            lblRestaurantsInfo = new Label();
            splitRight = new SplitContainer();
            grpMenu = new GroupBox();
            dgvMenu = new DataGridView();
            lblSelectedRestaurant = new Label();
            panelMenuButtons = new Panel();
            numericUpDown1 = new NumericUpDown();
            btnAddToCart = new Button();
            grpCart = new GroupBox();
            dgvCart = new DataGridView();
            FoodName = new DataGridViewTextBoxColumn();
            UnitPrice = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            panelCartBottom = new Panel();
            lblTotalText = new Label();
            lblTotalAmount = new Label();
            btnConfirmOrder = new Button();
            btnRemoveItem = new Button();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitMain).BeginInit();
            splitMain.Panel1.SuspendLayout();
            splitMain.Panel2.SuspendLayout();
            splitMain.SuspendLayout();
            grpRestaurants.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRestaurants).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitRight).BeginInit();
            splitRight.Panel1.SuspendLayout();
            splitRight.Panel2.SuspendLayout();
            splitRight.SuspendLayout();
            grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMenu).BeginInit();
            panelMenuButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            grpCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            panelCartBottom.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelHeader.BackColor = SystemColors.AppWorkspace;
            panelHeader.Controls.Add(btnLogout);
            panelHeader.Controls.Add(lblWelcome);
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1006, 60);
            panelHeader.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(900, 12);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 29);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 14F);
            lblWelcome.Location = new Point(20, 20);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(244, 32);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome, [username]";
            // 
            // splitMain
            // 
            splitMain.Location = new Point(3, 55);
            splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            splitMain.Panel1.Controls.Add(grpRestaurants);
            // 
            // splitMain.Panel2
            // 
            splitMain.Panel2.Controls.Add(splitRight);
            splitMain.Size = new Size(1006, 700);
            splitMain.SplitterDistance = 335;
            splitMain.TabIndex = 1;
            // 
            // grpRestaurants
            // 
            grpRestaurants.Controls.Add(btnViewMenu);
            grpRestaurants.Controls.Add(dgvRestaurants);
            grpRestaurants.Controls.Add(lblRestaurantsInfo);
            grpRestaurants.Dock = DockStyle.Fill;
            grpRestaurants.Location = new Point(0, 0);
            grpRestaurants.Name = "grpRestaurants";
            grpRestaurants.Size = new Size(335, 700);
            grpRestaurants.TabIndex = 0;
            grpRestaurants.TabStop = false;
            grpRestaurants.Text = "Restaurants";
            // 
            // btnViewMenu
            // 
            btnViewMenu.Dock = DockStyle.Bottom;
            btnViewMenu.Location = new Point(3, 668);
            btnViewMenu.Name = "btnViewMenu";
            btnViewMenu.Size = new Size(329, 29);
            btnViewMenu.TabIndex = 2;
            btnViewMenu.Text = "View Menu";
            btnViewMenu.UseVisualStyleBackColor = true;
            // 
            // dgvRestaurants
            // 
            dgvRestaurants.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRestaurants.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRestaurants.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvRestaurants.DefaultCellStyle = dataGridViewCellStyle2;
            dgvRestaurants.Location = new Point(-3, 46);
            dgvRestaurants.MultiSelect = false;
            dgvRestaurants.Name = "dgvRestaurants";
            dgvRestaurants.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvRestaurants.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvRestaurants.RowHeadersWidth = 51;
            dgvRestaurants.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRestaurants.Size = new Size(338, 400);
            dgvRestaurants.TabIndex = 1;
            // 
            // lblRestaurantsInfo
            // 
            lblRestaurantsInfo.AutoSize = true;
            lblRestaurantsInfo.Location = new Point(18, 23);
            lblRestaurantsInfo.Name = "lblRestaurantsInfo";
            lblRestaurantsInfo.Size = new Size(243, 20);
            lblRestaurantsInfo.TabIndex = 0;
            lblRestaurantsInfo.Text = "Select a restaurant to view its menu";
            // 
            // splitRight
            // 
            splitRight.Dock = DockStyle.Fill;
            splitRight.Location = new Point(0, 0);
            splitRight.Name = "splitRight";
            splitRight.Orientation = Orientation.Horizontal;
            // 
            // splitRight.Panel1
            // 
            splitRight.Panel1.Controls.Add(grpMenu);
            // 
            // splitRight.Panel2
            // 
            splitRight.Panel2.Controls.Add(grpCart);
            splitRight.Size = new Size(667, 700);
            splitRight.SplitterDistance = 350;
            splitRight.TabIndex = 0;
            // 
            // grpMenu
            // 
            grpMenu.AutoSize = true;
            grpMenu.Controls.Add(panelMenuButtons);
            grpMenu.Controls.Add(dgvMenu);
            grpMenu.Controls.Add(lblSelectedRestaurant);
            grpMenu.Dock = DockStyle.Fill;
            grpMenu.Location = new Point(0, 0);
            grpMenu.Name = "grpMenu";
            grpMenu.Size = new Size(667, 350);
            grpMenu.TabIndex = 0;
            grpMenu.TabStop = false;
            grpMenu.Text = "Menu";
            // 
            // dgvMenu
            // 
            dgvMenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvMenu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvMenu.DefaultCellStyle = dataGridViewCellStyle5;
            dgvMenu.Location = new Point(0, 46);
            dgvMenu.MultiSelect = false;
            dgvMenu.Name = "dgvMenu";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvMenu.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvMenu.RowHeadersWidth = 51;
            dgvMenu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMenu.Size = new Size(667, 250);
            dgvMenu.TabIndex = 1;
            dgvMenu.CellContentClick += dgvMenu_CellContentClick;
            // 
            // lblSelectedRestaurant
            // 
            lblSelectedRestaurant.AutoSize = true;
            lblSelectedRestaurant.Location = new Point(10, 20);
            lblSelectedRestaurant.Name = "lblSelectedRestaurant";
            lblSelectedRestaurant.Size = new Size(92, 20);
            lblSelectedRestaurant.TabIndex = 0;
            lblSelectedRestaurant.Text = "Restaurant: -";
            // 
            // panelMenuButtons
            // 
            panelMenuButtons.Controls.Add(btnAddToCart);
            panelMenuButtons.Controls.Add(numericUpDown1);
            panelMenuButtons.Dock = DockStyle.Bottom;
            panelMenuButtons.Location = new Point(3, 320);
            panelMenuButtons.Name = "panelMenuButtons";
            panelMenuButtons.Size = new Size(661, 27);
            panelMenuButtons.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Dock = DockStyle.Left;
            numericUpDown1.Location = new Point(0, 0);
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 0;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // btnAddToCart
            // 
            btnAddToCart.Dock = DockStyle.Right;
            btnAddToCart.Location = new Point(567, 0);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(94, 27);
            btnAddToCart.TabIndex = 1;
            btnAddToCart.Text = "Add To Cart";
            btnAddToCart.UseVisualStyleBackColor = true;
            // 
            // grpCart
            // 
            grpCart.Controls.Add(panelCartBottom);
            grpCart.Controls.Add(dgvCart);
            grpCart.Dock = DockStyle.Fill;
            grpCart.Location = new Point(0, 0);
            grpCart.Name = "grpCart";
            grpCart.Size = new Size(667, 346);
            grpCart.TabIndex = 0;
            grpCart.TabStop = false;
            grpCart.Text = "Cart";
            // 
            // dgvCart
            // 
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.Columns.AddRange(new DataGridViewColumn[] { FoodName, UnitPrice, Quantity, Subtotal });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvCart.DefaultCellStyle = dataGridViewCellStyle8;
            dgvCart.Dock = DockStyle.Top;
            dgvCart.Location = new Point(3, 23);
            dgvCart.Name = "dgvCart";
            dgvCart.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvCart.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvCart.RowHeadersWidth = 51;
            dgvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCart.Size = new Size(661, 200);
            dgvCart.TabIndex = 0;
            // 
            // FoodName
            // 
            FoodName.HeaderText = "Food Name";
            FoodName.MinimumWidth = 6;
            FoodName.Name = "FoodName";
            FoodName.ReadOnly = true;
            FoodName.Width = 125;
            // 
            // UnitPrice
            // 
            UnitPrice.HeaderText = "Unit Price";
            UnitPrice.MinimumWidth = 6;
            UnitPrice.Name = "UnitPrice";
            UnitPrice.ReadOnly = true;
            UnitPrice.Width = 125;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            Quantity.Width = 125;
            // 
            // Subtotal
            // 
            Subtotal.HeaderText = "Subtotal";
            Subtotal.MinimumWidth = 6;
            Subtotal.Name = "Subtotal";
            Subtotal.ReadOnly = true;
            Subtotal.Width = 125;
            // 
            // panelCartBottom
            // 
            panelCartBottom.Controls.Add(btnRemoveItem);
            panelCartBottom.Controls.Add(btnConfirmOrder);
            panelCartBottom.Controls.Add(lblTotalAmount);
            panelCartBottom.Controls.Add(lblTotalText);
            panelCartBottom.Dock = DockStyle.Bottom;
            panelCartBottom.Location = new Point(3, 283);
            panelCartBottom.Name = "panelCartBottom";
            panelCartBottom.Size = new Size(661, 60);
            panelCartBottom.TabIndex = 1;
            // 
            // lblTotalText
            // 
            lblTotalText.AutoSize = true;
            lblTotalText.Location = new Point(33, 19);
            lblTotalText.Name = "lblTotalText";
            lblTotalText.Size = new Size(45, 20);
            lblTotalText.TabIndex = 0;
            lblTotalText.Text = "Total:";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTotalAmount.Location = new Point(84, 19);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(53, 20);
            lblTotalAmount.TabIndex = 1;
            lblTotalAmount.Text = "0.00 €";
            // 
            // btnConfirmOrder
            // 
            btnConfirmOrder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnConfirmOrder.Location = new Point(492, 15);
            btnConfirmOrder.Name = "btnConfirmOrder";
            btnConfirmOrder.Size = new Size(157, 29);
            btnConfirmOrder.TabIndex = 2;
            btnConfirmOrder.Text = "Confirm Order";
            btnConfirmOrder.UseVisualStyleBackColor = true;
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.Location = new Point(358, 15);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.Size = new Size(128, 29);
            btnRemoveItem.TabIndex = 3;
            btnRemoveItem.Text = "Remove Item";
            btnRemoveItem.UseVisualStyleBackColor = true;
            btnRemoveItem.Click += button1_Click;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1006, 754);
            Controls.Add(splitMain);
            Controls.Add(panelHeader);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "CustomerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kebabs Delivery - Customer";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            splitMain.Panel1.ResumeLayout(false);
            splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitMain).EndInit();
            splitMain.ResumeLayout(false);
            grpRestaurants.ResumeLayout(false);
            grpRestaurants.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRestaurants).EndInit();
            splitRight.Panel1.ResumeLayout(false);
            splitRight.Panel1.PerformLayout();
            splitRight.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitRight).EndInit();
            splitRight.ResumeLayout(false);
            grpMenu.ResumeLayout(false);
            grpMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMenu).EndInit();
            panelMenuButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            grpCart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            panelCartBottom.ResumeLayout(false);
            panelCartBottom.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblWelcome;
        private Button btnLogout;
        private SplitContainer splitMain;
        private GroupBox grpRestaurants;
        private DataGridView dgvRestaurants;
        private Label lblRestaurantsInfo;
        private Button btnViewMenu;
        private SplitContainer splitRight;
        private GroupBox grpMenu;
        private Label lblSelectedRestaurant;
        private DataGridView dgvMenu;
        private Panel panelMenuButtons;
        private NumericUpDown numericUpDown1;
        private Button btnAddToCart;
        private GroupBox grpCart;
        private DataGridView dgvCart;
        private DataGridViewTextBoxColumn FoodName;
        private DataGridViewTextBoxColumn UnitPrice;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Subtotal;
        private Panel panelCartBottom;
        private Button btnRemoveItem;
        private Button btnConfirmOrder;
        private Label lblTotalAmount;
        private Label lblTotalText;
    }
}