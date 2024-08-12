using TradersChamp.Data;
using TradersChamp.Util;

namespace TradersChamp.View.Admin
{
    public partial class AddNewCarForm : Form
    {
        private Panel pnlMain;
        public AddNewCarForm(Panel pnlMain)
        {
            this.pnlMain = pnlMain;
            InitializeComponent();
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
            btnSave.TabIndex = 14;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ValidateInputs();
            SaveCar();

        }

        private void SaveCar()
        {
            var car = new Model.Car
            {
                Brand = txtBrand.Text,
                Model = txtModel.Text,
                Year = txtYear.Text,
                BodyStyle = txtBodyStyle.Text,
                Engine = txtEngine.Text,
                Transmission = txtTransmission.Text,
                Drivetrain = txtDrivetrain.Text,
                FuelType = txtFuelType.Text,
                Mileage = txtMileage.Text,
                VIN = txtVIN.Text,
                Color = txtColor.Text,
                InteriorColor = txtInteriorColor.Text,
                NumOfDoors = txtDoors.Text,
                SeatingCapacity = txtSeatingCapacity.Text,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
                
            };

            using (var db = new ApplicationDBContext())
            {
                db.Car.Add(car);
                db.SaveChanges();
            }

            MessageBox.Show("Car saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            Utility.LoadForm(new AdminCarAllView(pnlMain), pnlMain);
        }

        private void ValidateInputs()
        {
            if (string.IsNullOrEmpty(txtModel.Text))
            {
                MessageBox.Show("Car Model is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtBrand.Text))
            {
                MessageBox.Show("Car Brand is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }
    }
}
