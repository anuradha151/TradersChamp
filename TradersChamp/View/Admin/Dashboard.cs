using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TradersChamp.View.Admin;

namespace TradersChamp.View
{
    public partial class Dashboard : Form
    {

        private Form activeForm;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnCar_Click(object sender, EventArgs e)
        {
            //AdminCarAllView adminCarAllView = new AdminCarAllView();
            //pnlMain.Controls.Clear();
            //adminCarAllView.TopLevel = false;
            //adminCarAllView.FormBorderStyle = FormBorderStyle.None;
            //adminCarAllView.Size = pnlMain.Size;
            //adminCarAllView.Dock = DockStyle.Fill;
            //pnlMain.Controls.Add(adminCarAllView);
            //adminCarAllView.Show();

            OpenChildForm(new AdminCarAllView());
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(childForm);
            pnlMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

    }
}
