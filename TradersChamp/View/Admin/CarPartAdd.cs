using TradersChamp.Data;
using TradersChamp.Model;
using TradersChamp.Util;

namespace TradersChamp.View.Admin
{
    public partial class CarPartAdd : Form
    {
        private Panel pnlMain;
        public CarPartAdd(Panel pnlMain)
        {
            InitializeComponent();
            this.pnlMain = pnlMain;
            SetTabIndexes();
        }

        private void SetTabIndexes()
        {
            txtName.TabIndex = 0;
            txtManufacturer.TabIndex = 1;
            txtDescription.TabIndex = 2;
            txtPrice.TabIndex = 3;
            btnSave.TabIndex = 4;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            var carPart = new CarPart
            {
                Name = txtName.Text,
                Manufacturer = txtManufacturer.Text,
                Description = txtDescription.Text,
                Price = Convert.ToDouble(txtPrice.Text),
            };
            using(var db = new ApplicationDBContext())
            {
                db.CarPart.Add(carPart);
                db.SaveChanges();
            }
            MessageBox.Show("Car part added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Utility.LoadForm(new CarPartAllView(pnlMain), pnlMain);
            
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
