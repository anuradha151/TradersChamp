using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TradersChamp.Util;
using TradersChamp.View.Admin;
using TradersChamp.View.Customer.Car;

namespace TradersChamp.View.Customer
{
    public partial class CustomerPortal : Form
    {
        public CustomerPortal()
        {
            InitializeComponent();
        }

        private void CustomerPortal_Load(object sender, EventArgs e)
        {

        }

        private void lblDashboard_Click(object sender, EventArgs e)
        {

        }

        private void btnCar_Click(object sender, EventArgs e)
        {
            Utility.LoadForm(new CarView(pnlMain), pnlMain);
        }
    }
}
