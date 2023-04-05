namespace PasswordManager.Win {
    partial class LoginF {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            lblPasswordManager = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            lblSignin = new Label();
            btnLogin = new Button();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // lblPasswordManager
            // 
            lblPasswordManager.AutoSize = true;
            lblPasswordManager.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPasswordManager.Location = new Point(180, 9);
            lblPasswordManager.Name = "lblPasswordManager";
            lblPasswordManager.Size = new Size(241, 37);
            lblPasswordManager.TabIndex = 0;
            lblPasswordManager.Text = "Password Manager";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsername.Location = new Point(141, 98);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(106, 25);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username: ";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(141, 152);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(100, 25);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password: ";
            // 
            // lblSignin
            // 
            lblSignin.AutoSize = true;
            lblSignin.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSignin.Location = new Point(267, 64);
            lblSignin.Name = "lblSignin";
            lblSignin.Size = new Size(73, 25);
            lblSignin.TabIndex = 3;
            lblSignin.Text = "Sign-In";
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Location = new Point(93, 222);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(163, 39);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUser.Location = new Point(253, 98);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(180, 33);
            txtUser.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(253, 149);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(180, 33);
            txtPassword.TabIndex = 6;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegister.Location = new Point(323, 222);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(163, 39);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // LoginF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 342);
            Controls.Add(btnRegister);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(btnLogin);
            Controls.Add(lblSignin);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(lblPasswordManager);
            Name = "LoginF";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPasswordManager;
        private Label lblUsername;
        private Label lblPassword;
        private Label lblSignin;
        private Button btnLogin;
        private TextBox txtUser;
        private TextBox txtPassword;
        private Button btnRegister;
    }
}