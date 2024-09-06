using TradersChamp.Data;
using TradersChamp.Model;
using TradersChamp.Service;
using TradersChamp.Util;
using Microsoft.Extensions.DependencyInjection;

namespace TradersChamp.View.Admin.User
{
    public partial class AddAdmin : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly MailService _mailService;
        private readonly ApplicationDBContext _dbContext;
        private readonly Utility _utility;

        private Panel pnlMain;
        public AddAdmin(Panel pnlMain)
        {
            InitializeComponent();
            this.pnlMain = pnlMain;
            SetTabIndexes();

            _serviceProvider = Program.ServiceProvider;
            _mailService = _serviceProvider.GetRequiredService<MailService>();
            _dbContext = _serviceProvider.GetRequiredService<ApplicationDBContext>();
            _utility = _serviceProvider.GetRequiredService<Utility>();
        }

        private void SetTabIndexes()
        {
            txtUsername.TabIndex = 0;
            txtFullName.TabIndex = 1;
            txtEmail.TabIndex = 2;
            txtPhone.TabIndex = 3;
            txtRole.TabIndex = 4;
            btnSave.TabIndex = 5;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            validateInputs();
            var otp = _utility.GenerateOTP();

            var admin = new Users
            {
                Username = txtUsername.Text,
                FullName = txtFullName.Text,
                Email = txtEmail.Text,
                Phone = txtPhone.Text,
                Role = txtRole.Text,
                Otp = otp,
                Status = "OTP_NOT_VERIFIED",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };
            _dbContext.User.Add(admin);
            _dbContext.SaveChanges();
            _mailService.SendEmailAsync(admin.Email, "OTP Verification", "Your OTP is " + otp);

            MessageBox.Show("Admin added successfully. OTP has been sent to " + txtEmail.Text, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();

        }

        private void validateInputs()
        {
            if (string.IsNullOrEmpty(txtFullName.Text))
            {
                MessageBox.Show("Full Name is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Username is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Email is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBox.Show("Phone is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtRole.Text))
            {
                MessageBox.Show("Role is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
