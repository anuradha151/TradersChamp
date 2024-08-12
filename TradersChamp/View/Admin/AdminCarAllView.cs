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
    }
}
