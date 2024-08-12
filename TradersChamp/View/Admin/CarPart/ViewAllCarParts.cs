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

namespace TradersChamp.View.Admin
{
    public partial class ViewAllCarParts : Form
    {
        private Panel pnlMain;
        public ViewAllCarParts(Panel pnlMain)
        {
            InitializeComponent();
            this.pnlMain = pnlMain;
            LoadDataTable();
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
            Utility.LoadForm(new AddCarPart(pnlMain), pnlMain);
        }

        private void tblData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = tblData.Rows[e.RowIndex];
            var selectedRowId = selectedRow.Cells["Id"].Value;

            using (var db = new ApplicationDBContext())
            {
                var carPart = db.CarPart.Find(selectedRowId);
                if (carPart == null) return;
                Utility.LoadForm(new UpdateCarPart(pnlMain, carPart), pnlMain);
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
