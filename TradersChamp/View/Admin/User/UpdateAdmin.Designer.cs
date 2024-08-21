namespace TradersChamp.View.Admin.User
{
    partial class UpdateAdmin
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
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtFullName = new TextBox();
            txtUsername = new TextBox();
            btnUpdate = new Button();
            txtRole = new TextBox();
            txtStatus = new TextBox();
            txtCreatedAt = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(228, 30);
            label1.TabIndex = 15;
            label1.Text = "Update Admin Details";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(12, 135);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = " Phone";
            txtPhone.Size = new Size(191, 23);
            txtPhone.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Enabled = false;
            txtEmail.Location = new Point(12, 106);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = " Email";
            txtEmail.Size = new Size(191, 23);
            txtEmail.TabIndex = 12;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(12, 77);
            txtFullName.Name = "txtFullName";
            txtFullName.PlaceholderText = " Full Name";
            txtFullName.Size = new Size(191, 23);
            txtFullName.TabIndex = 13;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(12, 48);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = " Username";
            txtUsername.Size = new Size(191, 23);
            txtUsername.TabIndex = 14;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(325, 175);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtRole
            // 
            txtRole.Location = new Point(209, 48);
            txtRole.Name = "txtRole";
            txtRole.PlaceholderText = " Role";
            txtRole.Size = new Size(191, 23);
            txtRole.TabIndex = 11;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(209, 77);
            txtStatus.Name = "txtStatus";
            txtStatus.PlaceholderText = " Status";
            txtStatus.Size = new Size(191, 23);
            txtStatus.TabIndex = 11;
            // 
            // txtCreatedAt
            // 
            txtCreatedAt.Enabled = false;
            txtCreatedAt.Location = new Point(209, 106);
            txtCreatedAt.Name = "txtCreatedAt";
            txtCreatedAt.PlaceholderText = " Registered Date";
            txtCreatedAt.Size = new Size(191, 23);
            txtCreatedAt.TabIndex = 11;
            // 
            // UpdateAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1583, 583);
            Controls.Add(label1);
            Controls.Add(txtCreatedAt);
            Controls.Add(txtStatus);
            Controls.Add(txtRole);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtFullName);
            Controls.Add(txtUsername);
            Controls.Add(btnUpdate);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateAdmin";
            Text = "UpdateAdmin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtFullName;
        private TextBox txtUsername;
        private Button btnUpdate;
        private TextBox txtRole;
        private TextBox txtStatus;
        private TextBox txtCreatedAt;
    }
}