using TradersChamp.Data;
using TradersChamp.Util;
using Microsoft.Extensions.DependencyInjection;
using TradersChamp.Enums;

namespace TradersChamp.View.Admin
{
    public partial class AddCar : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ApplicationDBContext _dbContext;
        private readonly Utility _utility;

        private Panel pnlMain;

        public AddCar(Panel pnlMain)
        {
            this.pnlMain = pnlMain;
            InitializeComponent();
            SetTabIndexes();

            _serviceProvider = Program.ServiceProvider;
            _dbContext = _serviceProvider.GetRequiredService<ApplicationDBContext>();
            _utility = _serviceProvider.GetRequiredService<Utility>();
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
                Price = Convert.ToDouble(txtPrice.Text),
                Status = CommonStatus.ACTIVE,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now

            };

            _dbContext.Car.Add(car);
            _dbContext.SaveChanges();


            MessageBox.Show("Car saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            _utility.LoadForm(new ViewAllCars(pnlMain), pnlMain);
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
