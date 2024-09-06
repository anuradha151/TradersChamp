using System.Data;
using TradersChamp.Data;
using TradersChamp.Model;
using TradersChamp.Util;
using Microsoft.Extensions.DependencyInjection;

namespace TradersChamp.View.Admin.User
{
    public partial class ViewAllAdmins : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly Utility _utility;

        private Panel pnlMain;
        public ViewAllAdmins(Panel pnlMain)
        {
            InitializeComponent();
            this.pnlMain = pnlMain;
            LoadTable();
            _serviceProvider = Program.ServiceProvider;
            _utility = _serviceProvider.GetRequiredService<Utility>();
        }

        private void LoadTable()
        {
            using (var db = new ApplicationDBContext())
            {
                var data = db.User.Where(u => u.Role == "ADMIN").OrderByDescending(u => u.CreatedAt).ToList();
                LoadTable(data);
            }

        }

        private void LoadTable(List<Users> data)
        {
            tblData.DataSource = data;
            tblData.Columns["Id"].Visible = false;
            tblData.Columns["Password"].Visible = false;
            tblData.Columns["Otp"].Visible = false;
            tblData.Columns["Address"].Visible = false;
            tblData.Columns["CarOrders"].Visible = false;

        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            var searchTxt = txtSearch.Text;
            using (var db = new ApplicationDBContext())
            {
                var data = db.User
                    .Where(u => u.Role == "ADMIN" && (u.FullName.Contains(searchTxt) || u.Email.Contains(searchTxt)))
                    .OrderByDescending(u => u.CreatedAt)
                    .ToList();
                LoadTable(data);
            }
        }

        private void tblData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = tblData.Rows[e.RowIndex];
            var selectedRowId = selectedRow.Cells["Id"].Value;

            using (var db = new ApplicationDBContext())
            {
                var data = db.User.Find(selectedRowId);
                if (data == null) return;
                _utility.LoadForm(new UpdateAdmin(pnlMain, data), pnlMain);
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            _utility.LoadForm(new AddAdmin(pnlMain), pnlMain);
        }
    }
}
