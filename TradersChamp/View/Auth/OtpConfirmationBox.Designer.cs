namespace TradersChamp.View.Auth
{
    partial class OtpConfirmationBox
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
            btnConfirm = new Button();
            label1 = new Label();
            txtOtp = new TextBox();
            SuspendLayout();
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(366, 254);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(75, 23);
            btnConfirm.TabIndex = 0;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(201, 161);
            label1.Name = "label1";
            label1.Size = new Size(417, 30);
            label1.TabIndex = 1;
            label1.Text = "An OTP has been sent to your email address. \r\nPlease check your inbox and enter the OTP here to complete your registration.";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtOtp
            // 
            txtOtp.Location = new Point(355, 210);
            txtOtp.Name = "txtOtp";
            txtOtp.Size = new Size(100, 23);
            txtOtp.TabIndex = 2;
            txtOtp.TextAlign = HorizontalAlignment.Center;
            // 
            // OtpConfirmationBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtOtp);
            Controls.Add(label1);
            Controls.Add(btnConfirm);
            Name = "OtpConfirmationBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OtpConfirmationBox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirm;
        private Label label1;
        private TextBox txtOtp;
    }
}