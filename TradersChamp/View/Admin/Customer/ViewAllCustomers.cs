using System.Data;
using TradersChamp.Data;
using TradersChamp.Util;
using Microsoft.Extensions.DependencyInjection;


namespace TradersChamp.View.Admin.Customer
{
    public partial class ViewAllCustomers : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ApplicationDBContext _dbContext;
        private readonly Utility _utility;

        private Panel pnlMain;
        public ViewAllCustomers(Panel pnlMain)
        {
            InitializeComponent();
            this.pnlMain = pnlMain;
            LoadTable();

            _serviceProvider = Program.ServiceProvider;
            _dbContext = _serviceProvider.GetRequiredService<ApplicationDBContext>();
            _utility = _serviceProvider.GetRequiredService<Utility>();

        }

        private void LoadTable()
        {
            var data = _dbContext.User
                .Where(u => u.Role == "USER")
                .OrderByDescending(u => u.CreatedAt)
                .ToList();
            tblData.DataSource = data;
            tblData.Columns["Id"].Visible = false;
            tblData.Columns["Password"].Visible = false;
            tblData.Columns["Otp"].Visible = false;
            tblData.Columns["CarOrders"].Visible = false;
        }

        private void tblData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = tblData.Rows[e.RowIndex];
            var selectedRowId = selectedRow.Cells["Id"].Value;

            var data = _dbContext.User.Find(selectedRowId);
            if (data == null) return;
            _utility.LoadForm(new UpdateCustomer(pnlMain, data), pnlMain);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            var searchText = txtSearch.Text;
            var data = _dbContext.User
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
            tblData.Columns["Id"].Visible = false;
            tblData.Columns["Password"].Visible = false;
            tblData.Columns["Otp"].Visible = false;
        }
    }
}
