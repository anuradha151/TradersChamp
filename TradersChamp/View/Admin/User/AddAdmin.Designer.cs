namespace TradersChamp.View.Admin.User
{
    partial class AddAdmin
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
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtFullName = new TextBox();
            txtUsername = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(177, 30);
            label1.TabIndex = 24;
            label1.Text = "Add New Admin";
            // 
            // txtRole
            // 
            txtRole.Location = new Point(12, 164);
            txtRole.Name = "txtRole";
            txtRole.PlaceholderText = " Role";
            txtRole.Size = new Size(191, 23);
            txtRole.TabIndex = 19;
            txtRole.Text = "ADMIN";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(12, 135);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = " Phone";
            txtPhone.Size = new Size(191, 23);
            txtPhone.TabIndex = 20;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 106);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = " Email";
            txtEmail.Size = new Size(191, 23);
            txtEmail.TabIndex = 21;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(12, 77);
            txtFullName.Name = "txtFullName";
            txtFullName.PlaceholderText = " Full Name";
            txtFullName.Size = new Size(191, 23);
            txtFullName.TabIndex = 22;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(12, 48);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = " Username";
            txtUsername.Size = new Size(191, 23);
            txtUsername.TabIndex = 23;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(128, 193);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 16;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // AddAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1583, 583);
            Controls.Add(label1);
            Controls.Add(txtRole);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtFullName);
            Controls.Add(txtUsername);
            Controls.Add(btnSave);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddAdmin";
            Text = "AddAdmin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtRole;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtFullName;
        private TextBox txtUsername;
        private Button btnSave;
    }
}