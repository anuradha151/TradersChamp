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

using TradersChamp.Util;

namespace TradersChamp.View.Customer.Car
{
    public partial class CarOrder : Form
    {
        private Panel pnlMain;
        
        public CarOrder(Panel pnlMain, TradersChamp.Model.Car car)
        {
            InitializeComponent();
            this.pnlMain = pnlMain;


        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
