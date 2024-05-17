using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperShopManagementSystemWindowsApplication
{
    public partial class FormAdmin : MetroForm
    {

        Controls.UserControlSalesReport ucSalesReport = new Controls.UserControlSalesReport();
        Controls.UserControlUserManagement ucUserManagement = new Controls.UserControlUserManagement();
        Controls.UserControlCategory ucCategory = new Controls.UserControlCategory();
        Controls.UserControlSupplier ucSupplier = new Controls.UserControlSupplier();
        Controls.UserControlMngProduct ucMngProduct= new Controls.UserControlMngProduct();


        private FormLogin formLogin;
        public FormAdmin()
        {
            InitializeComponent();
        }
        public FormAdmin(string username, FormLogin fl):this()
        {
            this.formLogin = fl;
            this.lblUserName.Text += username.ToUpper();
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            this.formLogin.Show();
        }

        private void FormAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            this.formLogin.Show();
        }

        private void btnSalesReport(object sender, EventArgs e)
        {
            this.panelMain.Controls.Clear();
            this.panelMain.Controls.Add(ucSalesReport); 
            ucSalesReport.Dock = DockStyle.Fill;

        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            this.panelMain.Controls.Clear();
            this.panelMain.Controls.Add(ucSalesReport);
            ucSalesReport.Dock = DockStyle.Fill;
            this.ucSalesReport.Refresh();
        }


        private void btnManageCategory_Click(object sender, EventArgs e)
        {
            this.panelMain.Controls.Clear();
            this.panelMain.Controls.Add(ucCategory);
            ucCategory.Dock = DockStyle.Fill;
        }

        private void btnMngUser_Click(object sender, EventArgs e)
        {
            this.panelMain.Controls.Clear();
            this.panelMain.Controls.Add(ucUserManagement);
            ucUserManagement.Dock = DockStyle.Fill;
        }

        private void btnMngSupplier_Click(object sender, EventArgs e)
        {
            this.panelMain.Controls.Clear();
            this.panelMain.Controls.Add(ucSupplier);
            ucSupplier.Dock = DockStyle.Fill;
        }

        private void btnMngProduct_Click(object sender, EventArgs e)
        {
            this.panelMain.Controls.Clear();
            this.panelMain.Controls.Add(ucMngProduct);
            ucMngProduct.Dock = DockStyle.Fill;
            //ucMngProduct.Refresh();
            this.ucMngProduct.Refresh();
        }
    }
}
