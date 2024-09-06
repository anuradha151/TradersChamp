using TradersChamp.Data;
using TradersChamp.Model;
using TradersChamp.Util;
using Microsoft.Extensions.DependencyInjection;

namespace TradersChamp.View.Admin.User
{
    public partial class UpdateAdmin : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly Utility _utility;

        private Panel pnlMain;
        private Guid id;
        public UpdateAdmin(Panel pnlMain, Users admin)
        {
            InitializeComponent();
            this.pnlMain = pnlMain;
            LoadInputs(admin);
            SetTabIndexes();

            _serviceProvider = Program.ServiceProvider;
            _utility = _serviceProvider.GetRequiredService<Utility>();

        }

        private void SetTabIndexes()
        {
            txtUsername.TabIndex = 0;
            txtFullName.TabIndex = 1;
            txtEmail.TabIndex = 2;
            txtPhone.TabIndex = 3;
            txtRole.TabIndex = 4;
            txtStatus.TabIndex = 5;
            txtCreatedAt.TabIndex = 6;
            btnUpdate.TabIndex = 7;
            
        }

        private void LoadInputs(Users admin)
        {
            this.id = admin.Id;
            txtFullName.Text = admin.FullName;
            txtUsername.Text = admin.Username;
            txtEmail.Text = admin.Email;
            txtPhone.Text = admin.Phone;
            txtRole.Text = admin.Role;
            txtStatus.Text = admin.Status;
            txtCreatedAt.Text = admin.CreatedAt.ToString();
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var db = new ApplicationDBContext())
            {
                var admin = db.User.Find(id);
                if (admin == null)
                {
                    MessageBox.Show("Admin not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                admin.FullName = txtFullName.Text;
                admin.Username = txtUsername.Text;
                admin.Phone = txtPhone.Text;
                admin.Role = txtRole.Text;
                admin.Status = txtStatus.Text;
                db.SaveChanges();
            }
            MessageBox.Show("Admin updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _utility.LoadForm(new ViewAllAdmins(pnlMain), pnlMain);

        }
    }
}
