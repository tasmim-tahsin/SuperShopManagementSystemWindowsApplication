using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperShopManagementSystemWindowsApplication.Controls
{
    public partial class UserControlMngProduct : UserControl
    {
        private DataAccess Da { get; set; }
        private string category = "";
        private string categorySearch = "";
        private string supplier = "";
        
        
        public UserControlMngProduct()
        {

            InitializeComponent();
            this.Da = new DataAccess();

            try
            {
                 var query3 = "select * from Product;";
                 this.PopulateGridView(query3);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error "+ex.Message.ToString());
            }

        }

        private void UserControlMngProduct_Load(object sender, EventArgs e)
        {
            this.gridProduct.ClearSelection();
        }

        private void LoadComboBox()
        {
            try {
                var query = "select * from Category;";
                var ds1 = this.Da.ExecuteQuery(query);
                this.comboCategory.DataSource = ds1.Tables[0];
                this.comboCategory.DisplayMember = "CatName";
                this.comboCategory.ValueMember = "CatId";
                this.comboCategory.SelectedIndex = -1;


                var sql = "select * from Supplier";
                var ds2 = this.Da.ExecuteQuery(sql);
                this.comboSupplier.DataSource = ds2.Tables[0];
                this.comboSupplier.DisplayMember = "SupName";
                this.comboSupplier.ValueMember = "SupId";
                this.comboSupplier.SelectedIndex = -1;

                var query2 = "select * from Category;";
                var ds3 = this.Da.ExecuteQuery(query2);
                this.comboSearch.DataSource = ds3.Tables[0];
                this.comboSearch.DisplayMember = "CatName";
                this.comboSearch.ValueMember = "CatId";
                this.comboSearch.SelectedIndex = -1;
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }
        private void ClearAll()
        {
            this.txtProductId.Clear();
            this.txtLabel.Clear();
            this.txtUnit.Clear();
            this.txtUnitPrice.Clear();
            this.comboCategory.SelectedIndex = -1;
            this.comboSupplier.SelectedIndex = -1;
            this.comboStatus.SelectedIndex = -1;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        public void PopulateGridView(string query)
        {
            try
            {
                var ds = this.Da.ExecuteQuery(query);
                this.gridProduct.AutoGenerateColumns = false;
                this.gridProduct.DataSource = ds.Tables[0];

                //this.LoadComboBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool IsValidToSave()
        {
            if (String.IsNullOrEmpty(this.txtLabel.Text) || String.IsNullOrEmpty(this.txtUnit.Text) || String.IsNullOrEmpty(this.txtUnitPrice.Text)|| this.comboCategory.SelectedIndex<0 ||this.comboStatus.SelectedIndex<0 )
                return false;
            else
                return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the information");
                    return;
                }


                string query = null;
                var sql = "select * from Product where ProdId='" + this.txtProductId.Text + "';";
                var ds = this.Da.ExecuteQuery(sql);

                if (ds.Tables[0].Rows.Count == 0)
                {
                    //insert
                    query = "INSERT INTO Product (ProdLabel, Category, Supplier, Status, Unit, UnitPrice) VALUES ('" + this.txtLabel.Text + "', '"+this.category+"', '" + this.supplier + "', '" +this.comboStatus.SelectedItem.ToString()+ "', '" + this.txtUnit.Text+ "', '"+ this.txtUnitPrice.Text+ "');";
                    var count = this.Da.ExecuteDMLQuery(query);

                    if (count == 1)
                    {
                        MessageBox.Show("Product Added successfully.", "Successfully Added", MessageBoxButtons.OK);
                        this.PopulateGridView("select * from Product;");
                        this.ClearAll();
                    }
                    else
                    {
                        MessageBox.Show("Error while adding Product", "Error", MessageBoxButtons.OK);
                    }

                }
                else
                {
                    //Update
                    query = "UPDATE Product SET ProdLabel='" + this.txtLabel.Text + "', Category = '" + this.category + "', Supplier= '" + this.supplier + "', Status='"+this.comboStatus.SelectedItem.ToString() +"',Unit='"+this.txtUnit.Text+"',UnitPrice='"+this.txtUnitPrice.Text+"' where ProdId='" + this.txtProductId.Text + "';";
                    var count = this.Da.ExecuteDMLQuery(query);

                    if (count == 1)
                    {

                        MessageBox.Show("Product Info updated successfully.", "Successfully Updated", MessageBoxButtons.OK);
                        this.PopulateGridView("select * from Product;");
                        this.ClearAll();
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void gridProduct_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                this.txtProductId.Text = this.gridProduct.CurrentRow.Cells[0].Value.ToString();
                this.txtLabel.Text = this.gridProduct.CurrentRow.Cells[1].Value.ToString();
                this.txtUnit.Text = this.gridProduct.CurrentRow.Cells["Unit"].Value.ToString();
                this.txtUnitPrice.Text = this.gridProduct.CurrentRow.Cells["UnitPrice"].Value.ToString();
                this.comboCategory.Text = this.gridProduct.CurrentRow.Cells["Catagory"].Value.ToString();
                this.comboSupplier.Text = this.gridProduct.CurrentRow.Cells["suppliere"].Value.ToString();
                this.comboStatus.Text = this.gridProduct.CurrentRow.Cells["StockStatus"].Value.ToString();

                //MessageBox.Show("Error"+ this.gridProduct.CurrentRow.Cells["Catagory"].Value);
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.ToString()); 
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.gridProduct.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to remove the data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure to remove the data?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.No)
                    return;

                var id = this.gridProduct.CurrentRow.Cells[0].Value.ToString();
                var Name = this.gridProduct.CurrentRow.Cells[1].Value.ToString();

                var query = "delete from Product where ProdId = '" + id + "';";
                var count = this.Da.ExecuteDMLQuery(query);

                if (count == 1)
                    MessageBox.Show(Name.ToUpper() + " has been removed from the Product.");
                else
                    MessageBox.Show("Product remove failed");

                this.PopulateGridView("select * from Product;");
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error has occured:\n" + exc.Message);
            }
        }

        private void txtSearchByName_TextChanged(object sender, EventArgs e)
        {
            var query = "select * from Product where ProdLabel like '" + this.txtSearchByName.Text + "%'";
            this.PopulateGridView(query);
        }

        private void comboSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            

            if (this.comboSearch.SelectedItem != null)
            {
                DataRowView drv = this.comboSearch.SelectedItem as DataRowView;

                this.categorySearch = drv.Row["CatName"].ToString();
                //MessageBox.Show(category);

            }
            var query = "select * from Product where Category = '" + this.categorySearch + "'";
            this.PopulateGridView(query);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
           /* this.LoadComboBox();
            var query3 = "select * from Product;";
            this.PopulateGridView(query3);
           */
           this.Refresh(); 

        }
        public void Refresh()
        {
            this.LoadComboBox();
            var query3 = "select * from Product;";
            this.PopulateGridView(query3);
        }

        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboCategory.SelectedItem != null)
            {
                DataRowView drv = this.comboCategory.SelectedItem as DataRowView;

                this.category= drv.Row["CatName"].ToString();
                //MessageBox.Show(category);
                
            }
        }

        private void comboSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboSupplier.SelectedItem != null)
            {
                DataRowView drv = this.comboSupplier.SelectedItem as DataRowView;

                this.supplier = drv.Row["SupName"].ToString();
                //MessageBox.Show(category);

            }
        }

        
    }
}
