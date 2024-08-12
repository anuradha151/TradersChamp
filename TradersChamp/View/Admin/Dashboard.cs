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
using TradersChamp.View.Admin.Customer;

namespace TradersChamp.View
{
    public partial class Dashboard : Form
    {

        private Form activeForm;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnCar_Click(object sender, EventArgs e)
        {
            Utility.LoadForm(new ViewAllCars(pnlMain), pnlMain);
        }

        private void btnCarParts_Click(object sender, EventArgs e)
        {
            Utility.LoadForm(new ViewAllCarParts(pnlMain), pnlMain);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            Utility.LoadForm(new ViewAllCustomers(pnlMain), pnlMain);
        }
    }
}
