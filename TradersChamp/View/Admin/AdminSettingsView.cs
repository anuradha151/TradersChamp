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
    public partial class AdminSettingsView : Form
    {
        private Form Dashboard;
        public AdminSettingsView(Form Dashboard)
        {
            InitializeComponent();
            this.Dashboard = Dashboard;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Dashboard.Close();
            // Load the login form
            new Login().Show();            
        }
    }
}
