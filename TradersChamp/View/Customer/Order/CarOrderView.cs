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
using TradersChamp.View.Admin;

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
            UpdateTotal(txtQty.Text, txtPrice.Text);

        }

        private void UpdateTotal(string Qty, string Price)
        {
            if (int.TryParse(Qty, out int qty) && int.TryParse(Price, out int price))
            {
                txtTotal.Text = (qty * price).ToString();
            }
           
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
            lblInteriorColor.Text = Car.InteriorColor;
            lblDoorsCount.Text = Car.NumOfDoors;
            lblSeatingCapacity.Text = Car.SeatingCapacity;
            lblPrice.Text = Convert.ToString(Car.Price);
            txtPrice.Text = Convert.ToString(Car.Price);
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
                    PaymentMethod = "CASH",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now

                };

                db.CarOrder.Add(order);
                db.SaveChanges();
            }

            MessageBox.Show("Your Car order is completed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            Utility.LoadForm(new CarView(pnlMain, User), pnlMain);
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            UpdateTotal(txtQty.Text, txtPrice.Text);
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            UpdateTotal(txtQty.Text, txtPrice.Text);
        }
    }
}
