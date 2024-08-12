using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TradersChamp.Data;
using TradersChamp.Model;
using TradersChamp.View.Auth;

namespace TradersChamp.View
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            InitForm();
        }

        private void InitForm()
        {
            SetTabIndexes();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            ValidateInputs();

            var Password = txtPassword.Text;
            var ConfirmPassword = txtConfirmPassword.Text;

            if (!Password.Equals(ConfirmPassword))
            {
                MessageBox.Show("Passwords do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var db = new ApplicationDBContext())
            {
                
                var userByEmail = db.User.Where(u => u.Email == txtEmail.Text).FirstOrDefault();
                if (userByEmail != null)
                {
                    MessageBox.Show("User with this email already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var userByUsername= db.User.Where(u => u.Username == txtUsername.Text).FirstOrDefault();
                if (userByUsername != null)
                {
                    MessageBox.Show("User with this username already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                var otp = GetNewOtp();
                var user = new User
                {
                    Id = Guid.NewGuid(),
                    FullName = txtFullName.Text,
                    Username = txtUsername.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    Role = "USER",
                    Status = "OTP_NOT_VERIFIED",
                    Otp = otp,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                    
                };
                db.User.Add(user);
                db.SaveChanges();               

                SendOtpEmail(txtEmail.Text, otp.ToString());
                ShowOtpConfirmationBox(user.Id);
                this.Hide();

            }

        }

        private void ShowOtpConfirmationBox(Guid Id)
        {
            OtpConfirmationBox otpConfirmationBox = new OtpConfirmationBox(Id);
            otpConfirmationBox.Show();
        }

        private int GetNewOtp()
        {
            return new Random().Next(100000, 999999);            
        }

        private void ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {               
                MessageBox.Show("Full Name is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Username is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Password is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                MessageBox.Show("Confirm Password is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }            

        }
        public void SendOtpEmail(string toEmail, string otp)
        {
            try
            {
                var client = new SmtpClient("sandbox.smtp.mailtrap.io", 2525)
                {
                    Credentials = new NetworkCredential("56fc7bb8e4051f", "327c1031e8fae8"),
                    EnableSsl = true
                };

                string subject = "Your OTP Code for ABC Traders";
                string body = $"Dear User,\n\nYour One-Time Password (OTP) for completing your registration is: {otp}\n\n" +
                              "Please enter this code in the application to verify your email address.\n\n" +
                              "If you did not request this code, please ignore this email.\n\n" +
                              "Best regards,\nABC Traders Team";


                
                Console.WriteLine("Sending email to: " + toEmail);
                client.Send("no-reply@abctraders.com", toEmail, subject, body);
                Console.WriteLine("Email sent successfully to: " + toEmail);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to send email: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void SetTabIndexes()
        {
            txtFullName.TabIndex = 0;
            txtUsername.TabIndex = 1;
            txtEmail.TabIndex = 2;
            txtPassword.TabIndex = 3;
            txtConfirmPassword.TabIndex = 4;
            btnSignUp.TabIndex = 5;
            btnBack.TabIndex = 6;
        }

        private void ClearInputs()
        {
            txtFullName.Text = "";
            txtUsername.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
        }
    }
}
