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
using TradersChamp.Model;
using TradersChamp.Util;

namespace TradersChamp.View.Admin.Customer
{
    public partial class UpdateCustomer : Form
    {
        private Panel pnlMain;
        private Guid id;
        public UpdateCustomer(Panel pnlMain, User customer)
        {
            InitializeComponent();
            this.pnlMain = pnlMain;
            UpdateInputs(customer);
            SetTabIndexes();


        }

        private void SetTabIndexes()
        {
            txtUsername.TabIndex = 0;
            txtFullName.TabIndex = 1;
            txtEmail.TabIndex = 2;
            txtPhone.TabIndex = 3;
            txtRole.TabIndex = 4;
            txtStatus.TabIndex = 5;
            txtAddress.TabIndex = 6;
            txtCreatedAt.TabIndex = 7;
            btnUpdate.TabIndex = 8;


        }

        private void UpdateInputs(User customer)
        {
            this.id = customer.Id;
            txtFullName.Text = customer.FullName;
            txtUsername.Text = customer.Username;
            txtEmail.Text = customer.Email;
            txtPhone.Text = customer.Phone;
            txtRole.Text = customer.Role;
            txtStatus.Text = customer.Status;
            txtAddress.Text = customer.Address;
            txtCreatedAt.Text = customer.CreatedAt.ToString();

        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using(var db = new ApplicationDBContext())
            {
                var customer = db.User.Find(id);
                if(customer == null)
                {
                    MessageBox.Show("Customer not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                customer.FullName = txtFullName.Text;
                customer.Username = txtUsername.Text;
                customer.Email = txtEmail.Text;
                customer.Phone = txtPhone.Text;
                customer.Status = txtStatus.Text;
                customer.Address = txtAddress.Text;
                db.SaveChanges();
            }
            MessageBox.Show("Customer updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Utility.LoadForm(new ViewAllCustomers(pnlMain), pnlMain);

        }
    }
}
