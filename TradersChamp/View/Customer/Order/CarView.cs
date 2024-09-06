using System.Data;
using TradersChamp.Data;
using TradersChamp.Model;
using TradersChamp.Util;
using Microsoft.Extensions.DependencyInjection;

namespace TradersChamp.View.Customer.Order
{
    public partial class CarView : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly Utility _utility;

        private Panel pnlMain;
        private Users User;
        public CarView(Panel pnlMain, Users user)
        {
            InitializeComponent();
            this.pnlMain = pnlMain;
            this.User = user;
            LoadTable();

            _serviceProvider = Program.ServiceProvider;
            _utility = _serviceProvider.GetRequiredService<Utility>();

        }

        private void LoadTable()
        {
            using (var db = new ApplicationDBContext())
            {
                var cars = db.Car.OrderByDescending(c => c.UpdatedAt).ToList();
                tblData.DataSource = cars;
                tblData.Columns["Id"].Visible = false;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
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

        private void tblData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = tblData.Rows[e.RowIndex];
            var selectedRowId = selectedRow.Cells["Id"].Value;

            using (var db = new ApplicationDBContext())
            {
                var car = db.Car.Find(selectedRowId);
                if (car == null) return;
                _utility.LoadForm(new CarOrderView(pnlMain, car, User), pnlMain);
            }
        }
    }
}
