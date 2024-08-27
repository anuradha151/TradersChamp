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
using TradersChamp.Model;

namespace TradersChamp.View.Customer.CarParts
{
    public partial class CarPartsView : Form
    {
        private Panel pnlMain;
        private Users User;
        public CarPartsView(Panel pnlMain, Users User)
        {
            InitializeComponent();
            this.pnlMain = pnlMain;
            this.User = User;
            LoadTable();
        }

        private void LoadTable()
        {
            using (var db = new ApplicationDBContext())
            {
                var carParts = db.CarPart.ToList();
                tblData.DataSource = carParts;
                tblData.Columns["Id"].Visible = false;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var searchText = txtSearch.Text;
            using (var db = new ApplicationDBContext())
            {
                var carParts = db.CarPart.Where(c => c.Name.Contains(searchText) ||
                                                     c.Manufacturer.Contains(searchText) ||
                                                     c.Description.Contains(searchText) ||
                                                     c.Price.ToString().Contains(searchText)
                                                     ).ToList();
                tblData.DataSource = carParts;
            }
        }

        private void tblData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
