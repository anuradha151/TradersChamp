using System.Data;
using TradersChamp.Data;
using TradersChamp.Util;

namespace TradersChamp.View.Admin.Customer
{
    public partial class ViewAllCustomers : Form
    {
        private Panel pnlMain;
        public ViewAllCustomers(Panel pnlMain)
        {
            InitializeComponent();
            this.pnlMain = pnlMain;
            LoadTable();
        }

        private void LoadTable()
        {
            using (var db = new ApplicationDBContext())
            {
                var data = db.User
                    .Where(u => u.Role == "USER")
                    .OrderByDescending(u => u.CreatedAt)
                    .ToList();
                tblData.DataSource = data;
                tblData.Columns["Id"].Visible = false;
                tblData.Columns["Password"].Visible = false;
                tblData.Columns["Otp"].Visible = false;
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
                Utility.LoadForm(new UpdateCustomer(pnlMain, data), pnlMain);
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            var searchText = txtSearch.Text;
            using (var db = new ApplicationDBContext())
            {
                var data = db.User
                    .Where(u => u.Role == "USER" &&
                                (u.Username.Contains(searchText) ||
                                 u.FullName.Contains(searchText) ||
                                 u.Email.Contains(searchText) ||
                                 u.Phone.Contains(searchText) ||
                                 u.Address.Contains(searchText) ||
                                 u.Status.Contains(searchText)))
                    .OrderByDescending(u => u.CreatedAt)
                    .ToList();
                tblData.DataSource = data;
            }
        }
    }
}
