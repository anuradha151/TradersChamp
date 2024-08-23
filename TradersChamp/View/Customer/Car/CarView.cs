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
using TradersChamp.Util;
using TradersChamp.View.Admin;

namespace TradersChamp.View.Customer.Car
{
    public partial class CarView : Form
    {
        private Panel pnlMain;
        public CarView(Panel pnlMain)
        {
            InitializeComponent();
            this.pnlMain = pnlMain;
            LoadTable();
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

        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
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
                Utility.LoadForm(new CarOrder(pnlMain, car), pnlMain);
            }
        }
    }
}
