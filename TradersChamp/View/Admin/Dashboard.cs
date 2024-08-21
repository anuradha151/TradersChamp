using TradersChamp.Util;
using TradersChamp.View.Admin;
using TradersChamp.View.Admin.Customer;
using TradersChamp.View.Admin.User;

namespace TradersChamp.View
{
    public partial class Dashboard : Form
    {
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

        private void btnAdminManager_Click(object sender, EventArgs e)
        {
            Utility.LoadForm(new ViewAllAdmins(pnlMain), pnlMain);
        }
    }
}
