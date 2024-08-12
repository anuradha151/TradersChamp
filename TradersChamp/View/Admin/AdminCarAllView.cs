using TradersChamp.Data;

namespace TradersChamp.View.Admin
{
    public partial class AdminCarAllView : Form
    {
        public AdminCarAllView()
        {
            InitializeComponent();
            InitForm();
        }



        private void btnAddNew_Click(object sender, EventArgs e)
        {



        }

        private void InitForm()
        {
            LoadCarTable();
        }

        private void LoadCarTable()
        {
            using (var db = new ApplicationDBContext())
            {
                var cars = db.Car.ToList();
                tblData.DataSource = cars;
                tblData.Columns["Id"].Visible = false;
            }
        }

        private void tblData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = tblData.Rows[e.RowIndex];
            var selectedRowId = selectedRow.Cells["Id"].Value;
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            var searchValue = txtSearch.Text;
            using (var db = new ApplicationDBContext())
            {
                // search by every column in Car table
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
