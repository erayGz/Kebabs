namespace Kebabs
{
    partial class RegisterForm
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
            label1 = new Label();
            txtNewUsername = new TextBox();
            label2 = new Label();
            txtNewPassword = new TextBox();
            label3 = new Label();
            txtConfirmPassword = new TextBox();
            lblRole = new Label();
            cmbRole = new ComboBox();
            btnRegister = new Button();
            btnCancel = new Button();
            label4 = new Label();
            txtAddress = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // txtNewUsername
            // 
            txtNewUsername.Location = new Point(188, 33);
            txtNewUsername.Name = "txtNewUsername";
            txtNewUsername.Size = new Size(311, 27);
            txtNewUsername.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 87);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(188, 87);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(311, 27);
            txtNewPassword.TabIndex = 3;
            txtNewPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 138);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 4;
            label3.Text = "Confirm Password";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(188, 131);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(311, 27);
            txtConfirmPassword.TabIndex = 5;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(12, 188);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(39, 20);
            lblRole.TabIndex = 6;
            lblRole.Text = "Role";
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(188, 180);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(311, 28);
            cmbRole.TabIndex = 7;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(188, 283);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 29);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(405, 283);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 235);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 10;
            label4.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(188, 232);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(311, 27);
            txtAddress.TabIndex = 11;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(654, 371);
            Controls.Add(txtAddress);
            Controls.Add(label4);
            Controls.Add(btnCancel);
            Controls.Add(btnRegister);
            Controls.Add(cmbRole);
            Controls.Add(lblRole);
            Controls.Add(txtConfirmPassword);
            Controls.Add(label3);
            Controls.Add(txtNewPassword);
            Controls.Add(label2);
            Controls.Add(txtNewUsername);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNewUsername;
        private Label label2;
        private TextBox txtNewPassword;
        private Label label3;
        private TextBox txtConfirmPassword;
        private Label lblRole;
        private ComboBox cmbRole;
        private Button btnRegister;
        private Button btnCancel;
        private Label label4;
        private TextBox txtAddress;
    }
}