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
using Microsoft.Extensions.DependencyInjection;

namespace TradersChamp.View.Customer
{
    public partial class CustomerPortal : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly Utility _utility;
        private Users User;
        public CustomerPortal(Users user)
        {
            InitializeComponent();
            this.User = user;
            _serviceProvider = Program.ServiceProvider;
            _utility = _serviceProvider.GetRequiredService<Utility>();

        }

        private void CustomerPortal_Load(object sender, EventArgs e)
        {

        }

        private void lblDashboard_Click(object sender, EventArgs e)
        {

        }

        private void btnCar_Click(object sender, EventArgs e)
        {
            _utility.LoadForm(new CarView(pnlMain, User), pnlMain);
        }

        private void btnCarParts_Click(object sender, EventArgs e)
        {
            _utility.LoadForm(new CarPartsView(pnlMain, User), pnlMain);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            _utility.LoadForm(new CustomerSettingsView(this), pnlMain);
        }
    }
}
