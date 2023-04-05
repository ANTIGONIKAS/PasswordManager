namespace PasswordManager.Win {
    partial class HomeF {
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
            btnAddNew = new Button();
            grdPasswords = new DataGridView();
            btnEdit = new Button();
            btnDelete = new Button();
            btnDetails = new Button();
            btnLogout = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)grdPasswords).BeginInit();
            SuspendLayout();
            // 
            // btnAddNew
            // 
            btnAddNew.Location = new Point(93, 23);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(101, 31);
            btnAddNew.TabIndex = 0;
            btnAddNew.Text = "Add new ";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // grdPasswords
            // 
            grdPasswords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdPasswords.Location = new Point(93, 71);
            grdPasswords.Name = "grdPasswords";
            grdPasswords.RowTemplate.Height = 25;
            grdPasswords.Size = new Size(525, 215);
            grdPasswords.TabIndex = 1;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.Location = new Point(93, 303);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(101, 31);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit ";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(289, 303);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(101, 31);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnDetails
            // 
            btnDetails.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDetails.Location = new Point(517, 303);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(101, 31);
            btnDetails.TabIndex = 4;
            btnDetails.Text = "Details";
            btnDetails.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogout.Location = new Point(606, 401);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(101, 37);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(238, 23);
            label1.Name = "label1";
            label1.Size = new Size(241, 25);
            label1.TabIndex = 6;
            label1.Text = "Password List Home Screen";
            // 
            // HomeF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 450);
            Controls.Add(label1);
            Controls.Add(btnLogout);
            Controls.Add(btnDetails);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(grdPasswords);
            Controls.Add(btnAddNew);
            Name = "HomeF";
            Text = "HomeF";
            ((System.ComponentModel.ISupportInitialize)grdPasswords).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddNew;
        private DataGridView grdPasswords;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnDetails;
        private Button btnLogout;
        private Label label1;
    }
}