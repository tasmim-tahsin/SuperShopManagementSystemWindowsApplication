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
    public partial class UserControlCategory : UserControl
    {

        private DataAccess Da { get; set; }
        public UserControlCategory()
        {
            InitializeComponent();
            var query = "select * from Category";
            this.Da = new DataAccess();
            this.PopulateGridView(query);

        }

        public void PopulateGridView(string query)
        {
            try
            {
                var ds = this.Da.ExecuteQuery(query);
                this.gridCategory.AutoGenerateColumns = false;
                this.gridCategory.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtCategory.Clear();
        }

        private void gridCategory_DoubleClick(object sender, EventArgs e)
        {
            this.txtCategory.Text=this.gridCategory.CurrentRow.Cells["CatName"].Value.ToString();
        }

        private bool IsValidToSave()
        {
            if (String.IsNullOrEmpty(this.txtCategory.Text))
                return false;
            else
                return true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                if (this.gridCategory.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to remove the data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure to remove the data?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.No)
                    return;

                var id = this.gridCategory.CurrentRow.Cells[0].Value.ToString();
                var catName= this.gridCategory.CurrentRow.Cells[1].Value.ToString();

                var query = "delete from Category where CatId = '" + id + "';";
                var count = this.Da.ExecuteDMLQuery(query);

                if (count == 1)
                    MessageBox.Show(catName.ToUpper() + " has been removed from the Category.");
                else
                    MessageBox.Show("Category remove failed");

                this.PopulateGridView("select * from Category;");
                this.txtCategory.Clear();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error has occured:\n" + exc.Message);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the information");
                    return;
                }


                string query = null;
                var sql = "select * from Category where CatName='" + this.txtCategory.Text + "';";
                var ds = this.Da.ExecuteQuery(sql);

                if(ds.Tables[0].Rows.Count == 0)
                {
                    //insert
                    query = "INSERT INTO Category (CatName) VALUES ('" + this.txtCategory.Text + "');";
                    var count = this.Da.ExecuteDMLQuery(query);

                    if (count == 1)
                    {
                        MessageBox.Show("Category Added successfully.", "Successfully Added", MessageBoxButtons.OK);
                        this.PopulateGridView("select * from Category;");
                        this.txtCategory.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Error while adding Category", "Error", MessageBoxButtons.OK);
                    }

                }
                else
                {
                    MessageBox.Show("Category already Exist.", "Error", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void UserControlCategory_Load(object sender, EventArgs e)
        {
            this.gridCategory.ClearSelection();
        }
    }
}
