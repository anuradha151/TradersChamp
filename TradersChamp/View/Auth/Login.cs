using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Data;
using TradersChamp.Data;
using TradersChamp.View;
using TradersChamp.View.Customer;

namespace TradersChamp
{
    public partial class Login : Form
    {
        private readonly IServiceProvider _serviceProvider;
        public Login(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            setTabIndexes();
            _serviceProvider = serviceProvider;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            var signUpForm = _serviceProvider.GetRequiredService<SignUp>();
            signUpForm.Show();
        }

        private void setTabIndexes()
        {
            txtUsername.TabIndex = 0;
            txtPassword.TabIndex = 1;
            btnLogin.TabIndex = 2;
            btnSignUp.TabIndex = 3;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username and password are required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            using(var db = new ApplicationDBContext())
            {
                var user = db.User.Where(u => u.Username == username || u.Email == username).FirstOrDefault();
                if(user == null)
                {
                    MessageBox.Show("Invalid username or email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if(user.Password != password)
                {
                    MessageBox.Show("Invalid password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if(user.Status != "ACTIVE")
                {
                    MessageBox.Show("Account is not active. Contact Admin for more information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                if (user.Role.Equals("ADMIN"))
                {
                    this.Hide();
                    new Dashboard().Show();
                }else if(user.Role.Equals("USER"))
                {
                    this.Hide();
                    new CustomerPortal(user).Show();
                }
                else
                {
                    MessageBox.Show("Assigned role is not supported at the moment. \nPlease contact admin for more information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
    }
}
