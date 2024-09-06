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
using Microsoft.Extensions.DependencyInjection;

namespace TradersChamp.View.Admin.CarOrder
{
    public partial class CarOrdersView : Form
    {

        private readonly IServiceProvider _serviceProvider;
        private readonly ApplicationDBContext _dbContext;

        public CarOrdersView()
        {
            InitializeComponent();
            LoadTable();

            _serviceProvider = Program.ServiceProvider;
            _dbContext = _serviceProvider.GetRequiredService<ApplicationDBContext>();
        }

        private void LoadTable()
        {
           var orders = _dbContext.CarOrder.ToList();

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
