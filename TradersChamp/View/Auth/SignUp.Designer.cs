namespace TradersChamp.View
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            btnSignUp = new Button();
            label1 = new Label();
            txtFullName = new TextBox();
            txtEmail = new TextBox();
            label3 = new Label();
            txtUsername = new TextBox();
            Username = new Label();
            txtPassword = new TextBox();
            label2 = new Label();
            txtConfirmPassword = new TextBox();
            label4 = new Label();
            btnBack = new Button();
            pbSignUp = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbSignUp).BeginInit();
            SuspendLayout();
            // 
            // btnSignUp
            // 
            btnSignUp.Location = new Point(602, 282);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(75, 23);
            btnSignUp.TabIndex = 0;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(442, 130);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 1;
            label1.Text = "Full Name";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(509, 127);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(168, 23);
            txtFullName.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(509, 185);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(168, 23);
            txtEmail.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(467, 188);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 1;
            label3.Text = "Email";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(509, 156);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(168, 23);
            txtUsername.TabIndex = 2;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Location = new Point(442, 159);
            Username.Name = "Username";
            Username.Size = new Size(60, 15);
            Username.TabIndex = 1;
            Username.Text = "Username";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(509, 214);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(168, 23);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(446, 217);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(509, 243);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(168, 23);
            txtConfirmPassword.TabIndex = 2;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(399, 246);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 1;
            label4.Text = "Confirm Password";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(521, 282);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 0;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // pbSignUp
            // 
            pbSignUp.BackgroundImageLayout = ImageLayout.Zoom;
            pbSignUp.Dock = DockStyle.Left;
            pbSignUp.Image = (Image)resources.GetObject("pbSignUp.Image");
            pbSignUp.Location = new Point(0, 0);
            pbSignUp.Name = "pbSignUp";
            pbSignUp.Size = new Size(346, 450);
            pbSignUp.SizeMode = PictureBoxSizeMode.Zoom;
            pbSignUp.TabIndex = 3;
            pbSignUp.TabStop = false;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pbSignUp);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtUsername);
            Controls.Add(txtFullName);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(Username);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(btnSignUp);
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUp";
            ((System.ComponentModel.ISupportInitialize)pbSignUp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSignUp;
        private Label label1;
        private TextBox txtFullName;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtUsername;
        private Label Username;
        private TextBox txtPassword;
        private Label label2;
        private TextBox txtConfirmPassword;
        private Label label4;
        private Button btnBack;
        private PictureBox pbSignUp;
    }
}