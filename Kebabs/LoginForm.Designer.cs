namespace Kebabs
{
    partial class Kebabs
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kebabs));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btnShowPassword = new Button();
            lnkForgetPw = new LinkLabel();
            btnRegister = new Button();
            btnLogin = new Button();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtUserName = new TextBox();
            lblUsername = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(727, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(210, 201);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(106, 106, 106);
            panel1.Controls.Add(btnShowPassword);
            panel1.Controls.Add(lnkForgetPw);
            panel1.Controls.Add(btnRegister);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(lblPassword);
            panel1.Controls.Add(txtUserName);
            panel1.Controls.Add(lblUsername);
            panel1.Location = new Point(255, 467);
            panel1.Name = "panel1";
            panel1.Size = new Size(494, 269);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // btnShowPassword
            // 
            btnShowPassword.Location = new Point(382, 113);
            btnShowPassword.Name = "btnShowPassword";
            btnShowPassword.Size = new Size(32, 27);
            btnShowPassword.TabIndex = 9;
            btnShowPassword.Text = "👁";
            btnShowPassword.UseVisualStyleBackColor = true;
            btnShowPassword.MouseDown += btnShowPassword_MouseDown;
            btnShowPassword.MouseUp += btnShowPassword_MouseUp;
            // 
            // lnkForgetPw
            // 
            lnkForgetPw.AutoSize = true;
            lnkForgetPw.BackColor = Color.Transparent;
            lnkForgetPw.Location = new Point(179, 215);
            lnkForgetPw.Name = "lnkForgetPw";
            lnkForgetPw.Size = new Size(125, 20);
            lnkForgetPw.TabIndex = 8;
            lnkForgetPw.TabStop = true;
            lnkForgetPw.Text = "I Forget Password";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(255, 140, 40);
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(272, 160);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(142, 39);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(220, 20, 20);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(79, 160);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(139, 39);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Log In";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.ForeColor = Color.DimGray;
            txtPassword.Location = new Point(79, 113);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(335, 27);
            txtPassword.TabIndex = 5;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Segoe UI", 10F);
            lblPassword.ForeColor = Color.White;
            lblPassword.Location = new Point(79, 87);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(80, 23);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password";
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.White;
            txtUserName.BorderStyle = BorderStyle.FixedSingle;
            txtUserName.ForeColor = Color.DimGray;
            txtUserName.Location = new Point(79, 43);
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "User Name / E-mail";
            txtUserName.Size = new Size(335, 27);
            txtUserName.TabIndex = 3;
            txtUserName.Tag = "";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.Transparent;
            lblUsername.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(79, 17);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(160, 23);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "User Name / E-mail";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(245, 389);
            label1.Name = "label1";
            label1.Size = new Size(520, 50);
            label1.TabIndex = 1;
            label1.Text = "Welcome To Kebabs Delivery!";
            // 
            // Kebabs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Brown;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1006, 977);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Kebabs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kebab - Login Page";
            Load += Kebabs_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtUserName;
        private Button btnLogin;
        private Button btnRegister;
        private LinkLabel lnkForgetPw;
        private Label lblUsername;
        private Button btnShowPassword;
    }
}
