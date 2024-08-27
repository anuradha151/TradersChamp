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
using TradersChamp.Model;
using TradersChamp.Util;

namespace TradersChamp.View.Customer.Order
{
    public partial class CarOrder : Form
    {
        private Panel pnlMain;

        public CarOrder(Panel pnlMain, Car car)
        {
            InitializeComponent();
            this.pnlMain = pnlMain;
            UpdateLabels(car);
            UpdateTotal();

        }

        private void UpdateTotal()
        {
            if (txtPrice.Text != "" && txtQty.Text != "")
                txtTotal.Text = Convert.ToString(Convert.ToInt32(txtQty.Text) * Convert.ToInt32(txtPrice.Text));
        }

        private void UpdateLabels(Car car)
        {
            lblBrandName.Text = car.Brand;
            lblModelName.Text = car.Model;
            lblYear.Text = car.Year;
            lblBodyStyle.Text = car.BodyStyle;
            lblEngine.Text = car.Engine;
            lblTransmission.Text = car.Transmission;
            lblDrivetrain.Text = car.Drivetrain;
            lblFuelType.Text = car.FuelType;
            lblMileage.Text = car.Mileage;
            lblVIN.Text = car.VIN;
            lblColor.Text = car.Color;
            lblInteriorColor.Text = car.InteriorColor;
            lblDoorsCount.Text = car.NumOfDoors;
            lblSeatingCapacity.Text = car.SeatingCapacity;
            lblPrice.Text = Convert.ToString(car.Price);
            txtPrice.Text = Convert.ToString(car.Price);
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            UpdateTotal();
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            UpdateTotal();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {

        }
    }
}
