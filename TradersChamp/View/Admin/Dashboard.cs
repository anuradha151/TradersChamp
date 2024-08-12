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
            Utility.LoadForm(new AdminCarAllView(pnlMain), pnlMain);
        }

        private void btnCarParts_Click(object sender, EventArgs e)
        {
            Utility.LoadForm(new CarPartAllView(pnlMain), pnlMain);
        }

    }
}
