namespace TradersChamp.View.Admin.Customer
{
    partial class UpdateCustomer
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
            txtRole = new TextBox();
            txtUsername = new TextBox();
            txtFullName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtStatus = new TextBox();
            txtCreatedAt = new TextBox();
            txtAddress = new TextBox();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(205, 30);
            label1.TabIndex = 5;
            label1.Text = "Update User Details";
            // 
            // txtRole
            // 
            txtRole.Enabled = false;
            txtRole.Location = new Point(12, 168);
            txtRole.Name = "txtRole";
            txtRole.PlaceholderText = " Role";
            txtRole.Size = new Size(191, 23);
            txtRole.TabIndex = 3;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(12, 52);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = " Username";
            txtUsername.Size = new Size(191, 23);
            txtUsername.TabIndex = 4;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(12, 81);
            txtFullName.Name = "txtFullName";
            txtFullName.PlaceholderText = " Full Name";
            txtFullName.Size = new Size(191, 23);
            txtFullName.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 110);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = " Email";
            txtEmail.Size = new Size(191, 23);
            txtEmail.TabIndex = 4;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(12, 139);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = " Phone";
            txtPhone.Size = new Size(191, 23);
            txtPhone.TabIndex = 4;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(12, 197);
            txtStatus.Name = "txtStatus";
            txtStatus.PlaceholderText = " Status";
            txtStatus.Size = new Size(191, 23);
            txtStatus.TabIndex = 4;
            // 
            // txtCreatedAt
            // 
            txtCreatedAt.Enabled = false;
            txtCreatedAt.Location = new Point(209, 81);
            txtCreatedAt.Name = "txtCreatedAt";
            txtCreatedAt.PlaceholderText = " Registered Date";
            txtCreatedAt.Size = new Size(191, 23);
            txtCreatedAt.TabIndex = 4;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(209, 52);
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = " Address";
            txtAddress.Size = new Size(191, 23);
            txtAddress.TabIndex = 4;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(325, 246);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // UpdateCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1583, 583);
            Controls.Add(btnUpdate);
            Controls.Add(label1);
            Controls.Add(txtRole);
            Controls.Add(txtCreatedAt);
            Controls.Add(txtStatus);
            Controls.Add(txtAddress);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtFullName);
            Controls.Add(txtUsername);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateCustomer";
            Text = "UpdateCustomer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtRole;
        private TextBox txtUsername;
        private TextBox txtFullName;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtStatus;
        private TextBox txtCreatedAt;
        private TextBox txtAddress;
        private Button btnUpdate;
    }
}