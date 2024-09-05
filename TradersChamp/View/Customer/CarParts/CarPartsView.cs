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
using TradersChamp.Dto;
using TradersChamp.Migrations;
using TradersChamp.Model;

namespace TradersChamp.View.Customer.CarParts
{
    public partial class CarPartsView : Form
    {
        private Panel pnlMain;
        private Users User;
        private object selectedRowId;
        private BindingList<CarPartCartItemDto> carParts = new BindingList<CarPartCartItemDto>();

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
            var selectedRow = tblData.Rows[e.RowIndex];
            this.selectedRowId = selectedRow.Cells["Id"].Value;

            using (var db = new ApplicationDBContext())
            {
                var carPart = db.CarPart.Find(selectedRowId);
                txtItemName.Text = carPart?.Name;
                txtPrice.Text = carPart?.Price.ToString();
                UpdateAmount(txtQty.Text, txtPrice.Text);
            }

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            UpdateAmount(txtQty.Text, txtPrice.Text);
        }

        private void UpdateAmount(string Qty, string Price)
        {
            if (int.TryParse(Qty, out int qty) && double.TryParse(Price, out double price))
            {
                txtAmount.Text = (qty * price).ToString();
            }

        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            UpdateAmount(txtQty.Text, txtPrice.Text);
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            var carPartCartItemDto = new CarPartCartItemDto
            {
                ItemName = txtItemName.Text,
                UnitPrice = Convert.ToDouble(txtPrice.Text),
                Quantity = Convert.ToInt32(txtQty.Text),
                Amount = Convert.ToDouble(txtAmount.Text)
            };

            carParts.Add(carPartCartItemDto);
            UpdateCart();
        }

        private void UpdateCart()
        {
            tblCart.DataSource = carParts;
            UpdateTotal();
        }

        private void UpdateTotal()
        {
            txtTotal.Text = carParts.Sum(c => c.Amount).ToString();
        }
    }
}
