using TradersChamp.Data;
using TradersChamp.Model;
using TradersChamp.Util;

namespace TradersChamp.View.Admin
{
    public partial class UpdateCar : Form
    {
        private Panel pnlMain;
        private Guid id;
        public UpdateCar(Panel pnlMain, Car car)
        {
            InitializeComponent();
            this.pnlMain = pnlMain;
            UpdateInputs(car);
            SetTabIndexes();
        }

        private void SetTabIndexes()
        {
            txtBrand.TabIndex = 0;
            txtModel.TabIndex = 1;
            txtYear.TabIndex = 2;
            txtBodyStyle.TabIndex = 3;
            txtEngine.TabIndex = 4;
            txtTransmission.TabIndex = 5;
            txtDrivetrain.TabIndex = 6;
            txtFuelType.TabIndex = 7;
            txtMileage.TabIndex = 8;
            txtVIN.TabIndex = 9;
            txtColor.TabIndex = 10;
            txtInteriorColor.TabIndex = 11;
            txtDoors.TabIndex = 12;
            txtSeatingCapacity.TabIndex = 13;
            btnUpdate.TabIndex = 14;

        }

        private void UpdateInputs(Car car)
        {
            id = car.Id;
            txtBrand.Text = car.Brand;
            txtModel.Text = car.Model;
            txtYear.Text = car.Year;
            txtBodyStyle.Text = car.BodyStyle;
            txtEngine.Text = car.Engine;
            txtTransmission.Text = car.Transmission;
            txtDrivetrain.Text = car.Drivetrain;
            txtFuelType.Text = car.FuelType;
            txtMileage.Text = car.Mileage;
            txtVIN.Text = car.VIN;
            txtColor.Text = car.Color;
            txtInteriorColor.Text = car.InteriorColor;
            txtDoors.Text = car.NumOfDoors;
            txtSeatingCapacity.Text = car.SeatingCapacity;
            txtPrice.Text = Convert.ToString(car.Price);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            using (var db = new ApplicationDBContext())
            {
                var car = db.Car.Find(id);
                if (car == null)
                {
                    MessageBox.Show("Cannot Update Car Details. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                car.Brand = txtBrand.Text;
                car.Model = txtModel.Text;
                car.Year = txtYear.Text;
                car.BodyStyle = txtBodyStyle.Text;
                car.Engine = txtEngine.Text;
                car.Transmission = txtTransmission.Text;
                car.Drivetrain = txtDrivetrain.Text;
                car.FuelType = txtFuelType.Text;
                car.Mileage = txtMileage.Text;
                car.VIN = txtVIN.Text;
                car.Color = txtColor.Text;
                car.InteriorColor = txtInteriorColor.Text;
                car.NumOfDoors = txtDoors.Text;
                car.SeatingCapacity = txtSeatingCapacity.Text;
                car.Price = Convert.ToDouble(txtPrice.Text);
                car.UpdatedAt = DateTime.Now;
                db.SaveChanges();
            }
            MessageBox.Show("Car updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Utility.LoadForm(new ViewAllCars(pnlMain), pnlMain);


        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control keys (backspace, delete, etc.)
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // Allow digits and one decimal point
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Allow only one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }
    }
}
