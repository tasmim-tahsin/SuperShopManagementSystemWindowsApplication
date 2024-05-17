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
    public partial class UcPOS : UserControl
    {
        private DataAccess Da { get; set; }
        public UcPOS()
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

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }

        private void comboSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBrandlbl_Click(object sender, EventArgs e)
        {

        }

        private void comboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboStatuslbl_Click(object sender, EventArgs e)
        {

        }

        private void gridOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UcPOS_Load(object sender, EventArgs e)
        {
            this.gridProduct.ClearSelection();
        }

        private void gridProduct_DoubleClick(object sender, EventArgs e)
        {
            try
            {
            this.txtProductId.Text = this.gridProduct.CurrentRow.Cells["Id"].Value.ToString();
            this.txtLabel.Text = this.gridProduct.CurrentRow.Cells["ProdLabel"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void ClearAll()
        {
            this.txtProductId.Clear();
            this.txtLabel.Clear();
            this.txtUnit.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private bool IsValidToSave()
        {
            if (String.IsNullOrEmpty(this.txtLabel.Text) || String.IsNullOrEmpty(this.txtUnit.Text) || String.IsNullOrEmpty(this.txtProductId.Text))
                return false;
            else
                return true;
        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the information");
                    return;
                }


                string query = null;
                var sql = "select * from Product where ProdId='" + this.txtProductId.Text + "' AND ProdLabel='" + this.txtLabel.Text + "';";
                var ds = this.Da.ExecuteQuery(sql);

                if (ds.Tables[0].Rows.Count == 0)
                {
                    //insert
                    query = "INSERT INTO Order () VALUES ('" + this.txtProductId.Text + "','" + this.txtUnit.Text + "');";
                    var count = this.Da.ExecuteDMLQuery(query);

                    if (count == 1)
                    {
                        MessageBox.Show("added to cart successfully.", "Successfully Added", MessageBoxButtons.OK);
                        this.PopulateGridView("select * from Order;");
                        this.ClearAll();
                    }
                    else
                    {
                        MessageBox.Show("Error while adding To Cart", "Error", MessageBoxButtons.OK);
                    }

                }
                else
                {
                    MessageBox.Show("Product not in list", "Error", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void txtSearchByName_TextChanged(object sender, EventArgs e)
        {
            var query = "select * from Product where ProdLabel like '" + this.txtSearchByName.Text + "%'";
            this.PopulateGridView(query);
        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the information");
                    return;
                }


                string query = null;
                var sql = "select * from Product where ProdId='" + this.txtProductId.Text + "' AND ProdLabel='" + this.txtLabel.Text + "';";
                var ds = this.Da.ExecuteQuery(sql);

                if (ds.Tables[0].Rows.Count == 0)
                {
                    //insert
                    query = "INSERT INTO Order () VALUES ('" + this.txtProductId.Text + "','" + this.txtUnit.Text + "');";
                    var count = this.Da.ExecuteDMLQuery(query);

                    if (count == 1)
                    {
                        MessageBox.Show("added to cart successfully.", "Successfully Added", MessageBoxButtons.OK);
                        this.PopulateGridView("select * from Order;");
                        this.ClearAll();
                    }
                    else
                    {
                        MessageBox.Show("Error while adding To Cart", "Error", MessageBoxButtons.OK);
                    }

                }
                else
                {
                    MessageBox.Show("Product not in list", "Error", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
