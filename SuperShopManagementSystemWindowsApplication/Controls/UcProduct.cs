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
    public partial class UcProduct : UserControl
    {
        private DataAccess Da { get; set; }
        public UcProduct()
        {
            InitializeComponent();
            
            this.Da = new DataAccess();
            var query3 = "select * from Product;";
            this.PopulateGridView(query3);

            
        }

        public void PopulateGridView(string query)
        {
            try
            {
                var ds = this.Da.ExecuteQuery(query);
                this.gridProduct.AutoGenerateColumns = false;
                this.gridProduct.DataSource = ds.Tables[0];

                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void txtSearchByName_TextChanged(object sender, EventArgs e)
        {
            var query = "select * from Product where ProdLabel like '" + this.txtSearchByName.Text + "%'";
            this.PopulateGridView(query);
        }

        private void UcProduct_Load(object sender, EventArgs e)
        {
            this.gridProduct.ClearSelection();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            

            //this.LoadComboBox();

        }

       

       
    }
}
