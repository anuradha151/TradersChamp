using TradersChamp.Data;
using TradersChamp.Model;
using TradersChamp.Service;
using TradersChamp.Util;

namespace TradersChamp.View.Admin.User
{
    public partial class AddAdmin : Form
    {
        private MailService MailService = new MailService();
        private Panel pnlMain;
        public AddAdmin(Panel pnlMain)
        {
            InitializeComponent();
            this.pnlMain = pnlMain;
            SetTabIndexes();
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
            var otp = Utility.GenerateOTPText();
            using (var db = new ApplicationDBContext())
            {
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
                db.User.Add(admin);
                db.SaveChanges();
                MailService.SendEmail(admin.Email, "OTP Verification", "Your OTP is " + otp);
            }
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
