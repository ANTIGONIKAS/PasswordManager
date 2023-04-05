namespace PasswordManager.Win {
    partial class EditPasswordF {
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
            btnEditCreate = new Button();
            btnCancel = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtWebsite = new TextBox();
            lblUsername = new Label();
            lblPassword = new Label();
            lblWebsite = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnEditCreate
            // 
            btnEditCreate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditCreate.Location = new Point(140, 214);
            btnEditCreate.Name = "btnEditCreate";
            btnEditCreate.Size = new Size(110, 40);
            btnEditCreate.TabIndex = 0;
            btnEditCreate.Text = "Edit/Create";
            btnEditCreate.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(292, 214);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 42);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(243, 83);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(159, 33);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(243, 125);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(159, 33);
            txtPassword.TabIndex = 3;
            // 
            // txtWebsite
            // 
            txtWebsite.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtWebsite.Location = new Point(243, 164);
            txtWebsite.Name = "txtWebsite";
            txtWebsite.Size = new Size(159, 33);
            txtWebsite.TabIndex = 4;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsername.Location = new Point(140, 86);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(97, 25);
            lblUsername.TabIndex = 5;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(140, 125);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(91, 25);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "Password";
            // 
            // lblWebsite
            // 
            lblWebsite.AutoSize = true;
            lblWebsite.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblWebsite.Location = new Point(140, 164);
            lblWebsite.Name = "lblWebsite";
            lblWebsite.Size = new Size(79, 25);
            lblWebsite.TabIndex = 7;
            lblWebsite.Text = "Website";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(189, 27);
            label1.Name = "label1";
            label1.Size = new Size(151, 25);
            label1.TabIndex = 8;
            label1.Text = "Create Password";
            // 
            // EditPasswordF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 318);
            Controls.Add(label1);
            Controls.Add(lblWebsite);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(txtWebsite);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(btnCancel);
            Controls.Add(btnEditCreate);
            Name = "EditPasswordF";
            Text = "EditPasswordF";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEditCreate;
        private Button btnCancel;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtWebsite;
        private Label lblUsername;
        private Label lblPassword;
        private Label lblWebsite;
        private Label label1;
    }
}