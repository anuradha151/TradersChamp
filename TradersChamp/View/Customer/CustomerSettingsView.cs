using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradersChamp.View.Admin
{
    public partial class CustomerSettingsView : Form
    {
        private Form CustomerPortal;
        public CustomerSettingsView(Form CustomerPortal)
        {
            InitializeComponent();
            this.CustomerPortal = CustomerPortal;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.CustomerPortal.Close();
            new Login().Show();
        }
    }
}
