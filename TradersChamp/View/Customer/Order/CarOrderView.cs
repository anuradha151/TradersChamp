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
    public partial class CarOrderView : Form
    {
        private Panel pnlMain;
        private Car Car;
        private Users User;

        public CarOrderView(Panel pnlMain, Car car, Users user)
        {
            InitializeComponent();
            this.pnlMain = pnlMain;
            this.Car = car;
            this.User = user;
            UpdateLabels();
            UpdateTotal();

        }

        private void UpdateTotal()
        {
            txtTotal.Clear();
            if (txtPrice.Text != "" && txtQty.Text != "")
                txtTotal.Text = Convert.ToString(Convert.ToInt32(txtQty.Text) * Convert.ToInt32(txtPrice.Text));
        }

        private void UpdateLabels()
        {
            lblBrandName.Text = Car.Brand;
            lblModelName.Text = Car.Model;
            lblYear.Text = Car.Year;
            lblBodyStyle.Text = Car.BodyStyle;
            lblEngine.Text = Car.Engine;
            lblTransmission.Text = Car.Transmission;
            lblDrivetrain.Text = Car.Drivetrain;
            lblFuelType.Text = Car.FuelType;
            lblMileage.Text = Car.Mileage;
            lblMileage.Text = Car.Mileage;
            lblVIN.Text = Car.VIN;
            lblColor.Text = Car.Color;
            lblInteriorColor.   Text = Car.InteriorColor;
            lblDoorsCount.Text = Car.NumOfDoors;
            lblSeatingCapacity.Text = Car.SeatingCapacity;
            lblPrice.Text = Convert.ToString(Car.Price);
            txtPrice.Text = Convert.ToString(Car.Price);
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
            

            var Qty = Convert.ToInt32(txtQty.Text);
            var Total = Convert.ToDouble(txtTotal.Text);

            using (var db = new ApplicationDBContext())
            {
                var order = new CarOrder
                {
                    CarId = Car.Id,
                    UserId = User.Id,
                    Quantity = Qty,
                    Price = Total,
                    CreatedAt = DateTime.Now
                };

                db.CarOrder.Add(order); 
                db.SaveChanges();
            }
        }

    }
}
