
using TradersChamp.Data;
using TradersChamp.Util;
using Microsoft.Extensions.DependencyInjection;
using TradersChamp.Enums;

namespace TradersChamp.View.Admin
{
    public partial class ViewAllCars : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly Utility _utility;

        private Panel pnlMain;
        public ViewAllCars(Panel pnlMain)
        {
            InitializeComponent();
            this.pnlMain = pnlMain;
            LoadTable();
            _serviceProvider = Program.ServiceProvider;
            _utility = _serviceProvider.GetRequiredService<Utility>();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            _utility.LoadForm(new AddCar(pnlMain), pnlMain);
        }

        private void LoadTable()
        {
            using (var db = new ApplicationDBContext())
            {
                // load Status ACTIVE cars only orderby updatedAt descending
                var cars = db.Car.Where(c => c.Status == CommonStatus.ACTIVE).OrderByDescending(c => c.UpdatedAt).ToList();
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
                _utility.LoadForm(new UpdateCar(pnlMain, car), pnlMain);
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
                                             c.SeatingCapacity.Contains(searchValue)
                                             ).ToList();
                tblData.DataSource = cars;

            }
        }
    }
}
