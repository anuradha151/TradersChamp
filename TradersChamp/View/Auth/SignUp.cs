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
using TradersChamp.Util;
using TradersChamp.Service;
using Microsoft.Extensions.DependencyInjection;

namespace TradersChamp.View
{
    public partial class SignUp : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly MailService _mailService;
        private readonly ApplicationDBContext _dbContext;

        public SignUp(IServiceProvider serviceProvider, MailService mailService, ApplicationDBContext dBContext)
        {
            InitializeComponent();
            InitForm();
            _serviceProvider = serviceProvider;
            _mailService = mailService;
            _dbContext = dBContext;
        }

        private void InitForm()
        {
            SetTabIndexes();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginForm = _serviceProvider.GetRequiredService<Login>();
            loginForm.Show();
        }

        private async void btnSignUp_Click(object sender, EventArgs e)
        {
            ValidateInputs();

            var Password = txtPassword.Text;
            var ConfirmPassword = txtConfirmPassword.Text;

            if (!Password.Equals(ConfirmPassword))
            {
                MessageBox.Show("Passwords do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var userByEmail = _dbContext.User.Where(u => u.Email == txtEmail.Text).FirstOrDefault();
            if (userByEmail != null)
            {
                MessageBox.Show("User with this email already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var userByUsername = _dbContext.User.Where(u => u.Username == txtUsername.Text).FirstOrDefault();
            if (userByUsername != null)
            {
                MessageBox.Show("User with this username already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var otp = Utility.GenerateOTPInt();
            var user = new Users
            {
                Id = Guid.NewGuid(),
                FullName = txtFullName.Text,
                Username = txtUsername.Text,
                Email = txtEmail.Text,
                Password = txtPassword.Text,
                Role = "USER",
                Status = "OTP_NOT_VERIFIED",
                Otp = otp,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };
            _dbContext.User.Add(user);
            _dbContext.SaveChanges();

            _mailService.SendEmailAsync(
                user.Email,
                "Your OTP Code for ABC Traders",
                $"""
                    Dear User,

                    Your One-Time Password (OTP) for completing your registration is: {otp}

                    Please enter this code in the application to verify your email address.
                    If you did not request this code, please ignore this email.

                    Best regards,
                    ABC Traders Team
                 """

            );

            ShowOtpConfirmationBox(user.Id);
            this.Hide();

        }


        private void ShowOtpConfirmationBox(Guid Id)
        {
            OtpConfirmationBox otpConfirmationBox = new OtpConfirmationBox(Id, _serviceProvider);
            otpConfirmationBox.Show();
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
