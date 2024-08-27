using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TradersChamp.Model;
using TradersChamp.Util;
using TradersChamp.View.Admin;
using TradersChamp.View.Customer.CarParts;
using TradersChamp.View.Customer.Order;

namespace TradersChamp.View.Customer
{
    public partial class CustomerPortal : Form
    {
        private Users User;
        public CustomerPortal(Users user)
        {
            InitializeComponent();
            this.User = user;
        }

        private void CustomerPortal_Load(object sender, EventArgs e)
        {

        }

        private void lblDashboard_Click(object sender, EventArgs e)
        {

        }

        private void btnCar_Click(object sender, EventArgs e)
        {
            Utility.LoadForm(new CarView(pnlMain, User), pnlMain);
        }

        private void btnCarParts_Click(object sender, EventArgs e)
        {
            Utility.LoadForm(new CarPartsView(pnlMain, User), pnlMain);
        }
    }
}
