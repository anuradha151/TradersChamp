using System.Data;
using TradersChamp.Data;
using TradersChamp.Model;
using TradersChamp.View.Auth;
using TradersChamp.Util;
using TradersChamp.Service;
using Microsoft.Extensions.DependencyInjection;
using System.Text.RegularExpressions;


namespace TradersChamp.View
{
    public partial class SignUp : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly MailService _mailService;
        private readonly ApplicationDBContext _dbContext;
        private readonly Utility _utility;

        public SignUp(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            InitForm();

            _serviceProvider = serviceProvider;
            _mailService = _serviceProvider.GetRequiredService<MailService>();
            _dbContext = _serviceProvider.GetRequiredService<ApplicationDBContext>();
            _utility = _serviceProvider.GetRequiredService<Utility>();
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
            try
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

                var otp = _utility.GenerateOTP();
                var hashedPassword = BCrypt.Net.BCrypt.HashPassword(txtPassword.Text);
                var user = new Users
                {
                    Id = Guid.NewGuid(),
                    FullName = txtFullName.Text,
                    Username = txtUsername.Text,
                    Email = txtEmail.Text,
                    Password = hashedPassword,
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void ShowOtpConfirmationBox(Guid Id)
        {
            OtpConfirmationBox otpConfirmationBox = new OtpConfirmationBox(Id);
            otpConfirmationBox.Show();
        }

        private void ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                throw new InvalidDataException("Full Name is required");                
            }

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                throw new InvalidDataException("Username is required");
            }


            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                throw new InvalidDataException("Email is required");
            }

            if (!Regex.IsMatch(txtEmail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                throw new InvalidDataException("Invalid email address");
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                throw new InvalidDataException("Password is required");
            }

            if (string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                throw new InvalidDataException("Confirm Password is required");
            }

            var password = txtPassword.Text;

            if (password.Length <= 8)
            {
                throw new InvalidDataException("Password must be at least 8 characters long");
            }


            if (!password.Any(char.IsUpper))
            {
                throw new InvalidDataException("Password must contain at least one uppercase letter");
            }


            if (!password.Any(char.IsLower))
            {
                throw new InvalidDataException("Password must contain at least one lowercase letter");
            }


            if (!password.Any(char.IsDigit))
            {
                throw new InvalidDataException("Password must contain at least one digit");
            }

            if (!Regex.IsMatch(password, @"[\W_]"))
            {
                throw new InvalidDataException("Password must contain at least one special character");
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
