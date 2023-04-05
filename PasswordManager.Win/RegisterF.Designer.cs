namespace PasswordManager.Win {
    partial class RegisterF {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            txtName = new TextBox();
            txtSurname = new TextBox();
            txtEmail = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtPhone = new TextBox();
            btnRegister = new Button();
            btnCancel = new Button();
            lblName = new Label();
            lblSurname = new Label();
            lblEmail = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            lblPnone = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(252, 77);
            txtName.Name = "txtName";
            txtName.Size = new Size(186, 23);
            txtName.TabIndex = 0;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(252, 110);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(186, 23);
            txtSurname.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(252, 140);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(186, 23);
            txtEmail.TabIndex = 2;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(252, 168);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(186, 23);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(252, 202);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(186, 23);
            txtPassword.TabIndex = 4;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(252, 232);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(186, 23);
            txtPhone.TabIndex = 5;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegister.Location = new Point(146, 265);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(142, 41);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(343, 265);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(142, 41);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(152, 70);
            lblName.Name = "lblName";
            lblName.Size = new Size(69, 30);
            lblName.TabIndex = 8;
            lblName.Text = "Name";
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblSurname.Location = new Point(152, 101);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(95, 30);
            lblSurname.TabIndex = 9;
            lblSurname.Text = "Surname";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(158, 131);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(63, 30);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Email";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsername.Location = new Point(146, 161);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(106, 30);
            lblUsername.TabIndex = 11;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(149, 195);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(99, 30);
            lblPassword.TabIndex = 12;
            lblPassword.Text = "Password";
            // 
            // lblPnone
            // 
            lblPnone.AutoSize = true;
            lblPnone.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPnone.Location = new Point(158, 225);
            lblPnone.Name = "lblPnone";
            lblPnone.Size = new Size(72, 30);
            lblPnone.TabIndex = 13;
            lblPnone.Text = "Phone";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(242, 23);
            label1.Name = "label1";
            label1.Size = new Size(196, 25);
            label1.TabIndex = 14;
            label1.Text = "Register New Account";
            // 
            // RegisterF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 368);
            Controls.Add(label1);
            Controls.Add(lblPnone);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(lblEmail);
            Controls.Add(lblSurname);
            Controls.Add(lblName);
            Controls.Add(btnCancel);
            Controls.Add(btnRegister);
            Controls.Add(txtPhone);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtEmail);
            Controls.Add(txtSurname);
            Controls.Add(txtName);
            Name = "RegisterF";
            Text = "RegisterF";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtSurname;
        private TextBox txtEmail;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtPhone;
        private Button btnRegister;
        private Button btnCancel;
        private Label lblName;
        private Label lblSurname;
        private Label lblEmail;
        private Label lblUsername;
        private Label lblPassword;
        private Label lblPnone;
        private Label label1;
    }
}