using System.Data;
using TradersChamp.Data;
using TradersChamp.Util;
using Microsoft.Extensions.DependencyInjection;

namespace TradersChamp.View.Admin
{
    public partial class ViewAllCarParts : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly Utility _utility;

        private Panel pnlMain;
        public ViewAllCarParts(Panel pnlMain)
        {
            InitializeComponent();
            this.pnlMain = pnlMain;
            LoadDataTable();

            _serviceProvider = Program.ServiceProvider;
            _utility = _serviceProvider.GetRequiredService<Utility>();

        }

        private void LoadDataTable()
        {
            using (var db = new ApplicationDBContext())
            {
                var carParts = db.CarPart.ToList();
                tblData.DataSource = carParts;
                tblData.Columns["Id"].Visible = false;
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            _utility.LoadForm(new AddCarPart(pnlMain), pnlMain);
        }

        private void tblData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = tblData.Rows[e.RowIndex];
            var selectedRowId = selectedRow.Cells["Id"].Value;

            using (var db = new ApplicationDBContext())
            {
                var carPart = db.CarPart.Find(selectedRowId);
                if (carPart == null) return;
                _utility.LoadForm(new UpdateCarPart(pnlMain, carPart), pnlMain);
            }

        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            var searchTxt = txtSearch.Text;
            using (var db = new ApplicationDBContext())
            {
                var carParts = db.CarPart.Where(cp =>
                    cp.Name.Contains(searchTxt) ||
                    cp.Manufacturer.Contains(searchTxt) ||
                    cp.Description.Contains(searchTxt) ||
                    cp.Price.ToString().Contains(searchTxt)
                ).ToList();
                tblData.DataSource = carParts;
            }
        }
    }
}
