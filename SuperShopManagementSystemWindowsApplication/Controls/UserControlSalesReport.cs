using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperShopManagementSystemWindowsApplication.Controls
{
    public partial class UserControlSalesReport : UserControl
    {
        private DataAccess Da { get; set; }
        public UserControlSalesReport()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.LoadTotalUser();
            this.LoadTotalProduct();
            this.LoadOutStock();

        }

        public void LoadTotalUser()
        {
            var query = "select * from UserInformation;";
            var ds = this.Da.ExecuteQuery(query);
            var count = ds.Tables[0].Rows.Count;
            this.lblTotalUser.Text = count.ToString();
        }
        public void LoadOutStock()
        {
            var query = "select * from Product where Status='Out Of Stock';";
            var ds = this.Da.ExecuteQuery(query);
            var count = ds.Tables[0].Rows.Count;
            this.lblOutStock.Text = count.ToString();
        }
        public void LoadTotalProduct()
        {
            var query = "select * from Product;";
            var ds = this.Da.ExecuteQuery(query);
            var count = ds.Tables[0].Rows.Count;
            this.lblTotalProduct.Text = count.ToString();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }
        public void Refresh()
        {
            this.LoadTotalUser();
            this.LoadTotalProduct();
            this.LoadOutStock();
        }
    }
}
