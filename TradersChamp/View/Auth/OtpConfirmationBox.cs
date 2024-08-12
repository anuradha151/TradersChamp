﻿using System;
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
        private Guid Id;

        public OtpConfirmationBox(Guid Id)
        {
            InitializeComponent();
            this.Id = Id;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var otp = txtOtp.Text;
            using (var db = new ApplicationDBContext())
            {
                var user = db.User.Where(u => u.Id == Id).FirstOrDefault();
                if (user == null)
                {
                    MessageBox.Show("User not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (user.Otp == null || user.Otp != int.Parse(otp))
                {
                    MessageBox.Show("Invalid OTP", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                user.Status = "ACTIVE";
                user.UpdatedAt = DateTime.Now;
                db.SaveChanges();
                MessageBox.Show("Account activated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                new Login().Show();
            }

        }
    }
}
