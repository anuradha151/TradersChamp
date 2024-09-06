using TradersChamp.Util;
using TradersChamp.View.Admin;
using TradersChamp.View.Admin.Customer;
using TradersChamp.View.Admin.User;
using Microsoft.Extensions.DependencyInjection;
using TradersChamp.View.Admin.Report;

namespace TradersChamp.View
{
    public partial class Dashboard : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly Utility _utility;

        public Dashboard()
        {
            InitializeComponent();

            _serviceProvider = Program.ServiceProvider;
            _utility = _serviceProvider.GetRequiredService<Utility>();
        }

        private void btnCar_Click(object sender, EventArgs e)
        {
            _utility.LoadForm(new ViewAllCars(pnlMain), pnlMain);
        }

        private void btnCarParts_Click(object sender, EventArgs e)
        {
            _utility.LoadForm(new ViewAllCarParts(pnlMain), pnlMain);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            _utility.LoadForm(new ViewAllCustomers(pnlMain), pnlMain);
        }

        private void btnAdminManager_Click(object sender, EventArgs e)
        {
            _utility.LoadForm(new ViewAllAdmins(pnlMain), pnlMain);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            _utility.LoadForm(new AdminSettingsView(this), pnlMain);
        }

        private void btnCarOrders_Click(object sender, EventArgs e)
        {
            _utility.LoadForm(new CarReport(), pnlMain);
        }
    }
}
