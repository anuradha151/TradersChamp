using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TradersChamp.Util
{
    public class Utility
    {
        public void LoadForm(Form form, Panel panel)
        {
            panel.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Size = panel.Size;
            form.Dock = DockStyle.Fill;
            panel.Controls.Add(form);
            form.Show();
        }

        public string GenerateOTP()
        {
            return new Random().Next(100000, 999999).ToString();
        }

    }
}
