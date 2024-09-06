using TradersChamp.Data;
using TradersChamp.Model;
using TradersChamp.Util;
using Microsoft.Extensions.DependencyInjection;

namespace TradersChamp.View.Admin
{
    public partial class UpdateCarPart : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly Utility _utility;

        private Panel pnlMain;
        private Guid id;
        public UpdateCarPart(Panel pnlMain, CarPart carPart)
        {
            InitializeComponent();
            this.pnlMain = pnlMain;
            UpdateInputs(carPart);
            SetTabIndexes();

            _serviceProvider = Program.ServiceProvider;
            _utility = _serviceProvider.GetRequiredService<Utility>();
        }

        private void SetTabIndexes()
        {
            txtName.TabIndex = 0;
            txtManufacturer.TabIndex = 1;
            txtDescription.TabIndex = 2;
            txtPrice.TabIndex = 3;
            btnUpdate.TabIndex = 4;
        }

        private void UpdateInputs(CarPart carPart)
        {
            this.id = carPart.Id;
            txtName.Text = carPart.Name;
            txtManufacturer.Text = carPart.Manufacturer;
            txtDescription.Text = carPart.Description;
            txtPrice.Text = carPart.Price.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var db = new ApplicationDBContext())
            {
                var carPart = db.CarPart.Find(id);
                if (carPart == null)
                {
                    MessageBox.Show("Car part not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                carPart.Name = txtName.Text;
                carPart.Manufacturer = txtManufacturer.Text;
                carPart.Description = txtDescription.Text;
                carPart.Price = Convert.ToDouble(txtPrice.Text);
                db.SaveChanges();
            }
            MessageBox.Show("Car part updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _utility.LoadForm(new ViewAllCarParts(pnlMain), pnlMain);
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
