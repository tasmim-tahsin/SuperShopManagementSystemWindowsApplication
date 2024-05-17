using MetroFramework.Forms;
using SuperShopManagementSystemWindowsApplication.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SuperShopManagementSystemWindowsApplication
{
    public partial class FormSeller : MetroForm
    {
        private FormLogin formLogin;
        private string username = "";

        Controls.UserControlChangePassword ucChangePass= new Controls.UserControlChangePassword();
        Controls.UcPOS ucPOS = new Controls.UcPOS();
        Controls.UcProduct ucProduct = new Controls.UcProduct();

        public FormSeller()
        {
            InitializeComponent();

            this.PanelMainSeller.Controls.Clear();
            this.PanelMainSeller.Controls.Add(ucPOS);
            ucPOS.Dock = DockStyle.Fill;

            
        }
        public FormSeller(string username, FormLogin fl) :this()
        {
            this.formLogin = fl;
            this.lblUserName.Text += username.ToUpper();
            this.username = username;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            this.formLogin.Show();
        }

        private void FormSeller_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            this.formLogin.Show();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            this.PanelMainSeller.Controls.Clear();
            this.PanelMainSeller.Controls.Add(new UserControlChangePassword(this.username));
            ucChangePass.Dock = DockStyle.Fill;
            //new UserControlChangePassword(this.username);
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {

            this.PanelMainSeller.Controls.Clear();
            this.PanelMainSeller.Controls.Add(ucProduct);
            ucProduct.Dock = DockStyle.Fill;
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            this.PanelMainSeller.Controls.Clear();
            this.PanelMainSeller.Controls.Add(ucPOS);
            ucPOS.Dock = DockStyle.Fill;
        }
    }
}
