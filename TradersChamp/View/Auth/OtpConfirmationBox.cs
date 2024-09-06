using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TradersChamp.Data;

namespace TradersChamp.View.Auth
{
    public partial class OtpConfirmationBox : Form
    {

        private readonly IServiceProvider _serviceProvider;
        private readonly ApplicationDBContext _dbContext;
        private Guid Id;

        public OtpConfirmationBox(Guid Id)
        {
            InitializeComponent();
            this.Id = Id;
            _serviceProvider = Program.ServiceProvider;
            _dbContext = _serviceProvider.GetRequiredService<ApplicationDBContext>();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var otp = txtOtp.Text;

            var user = _dbContext.User.Where(u => u.Id == Id).FirstOrDefault();
            if (user == null)
            {
                MessageBox.Show("User not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (user.Otp == null || !user.Otp.Equals(otp))
            {
                MessageBox.Show("Invalid OTP", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            user.Status = "ACTIVE";
            user.UpdatedAt = DateTime.Now;
            _dbContext.SaveChanges();
            MessageBox.Show("Account activated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            var loginForm = _serviceProvider.GetRequiredService<Login>();
            loginForm.Show();



        }
    }
}
