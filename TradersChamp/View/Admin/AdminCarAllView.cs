
using TradersChamp.Data;
using TradersChamp.Util;

namespace TradersChamp.View.Admin
{
    public partial class AdminCarAllView : Form
    {
        private Panel pnlMain;
        public AdminCarAllView(Panel pnlMain)
        {
            InitializeComponent();
            this.pnlMain = pnlMain;
            InitForm();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            Utility.LoadForm(new AddNewCarForm(pnlMain), pnlMain);
        }

        private void InitForm()
        {
            LoadCarTable();
        }

        private void LoadCarTable()
        {
            using (var db = new ApplicationDBContext())
            {
                var cars = db.Car.OrderByDescending(c => c.UpdatedAt).ToList();
                tblData.DataSource = cars;
                tblData.Columns["Id"].Visible = false;
            }
        }

        private void tblData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = tblData.Rows[e.RowIndex];
            var selectedRowId = selectedRow.Cells["Id"].Value;

            using (var db = new ApplicationDBContext())
            {
                var car = db.Car.Find(selectedRowId);
                if (car == null) return;
                Utility.LoadForm(new UpdateCarForm(pnlMain, car), pnlMain);                
            }

        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            var searchValue = txtSearch.Text;
            using (var db = new ApplicationDBContext())
            {
                var cars = db.Car.Where(c => c.Brand.Contains(searchValue) ||
                                             c.Model.Contains(searchValue) ||
                                             c.Year.Contains(searchValue) ||
                                             c.BodyStyle.Contains(searchValue) ||
                                             c.Engine.Contains(searchValue) ||
                                             c.Transmission.Contains(searchValue) ||
                                             c.Drivetrain.Contains(searchValue) ||
                                             c.FuelType.Contains(searchValue) ||
                                             c.Mileage.Contains(searchValue) ||
                                             c.VIN.Contains(searchValue) ||
                                             c.Color.Contains(searchValue) ||
                                             c.InteriorColor.Contains(searchValue) ||
                                             c.NumOfDoors.Contains(searchValue) ||
                                             c.SeatingCapacity.Contains(searchValue)).ToList();
                tblData.DataSource = cars;

            }
        }
    }
}
