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
    public partial class UserControlSupplier : UserControl
    {
        private DataAccess Da { get; set; }
        //private string supId;

        public UserControlSupplier()
        {
            InitializeComponent();
            var query = "select * from Supplier";
            this.Da = new DataAccess();
            this.PopulateGridView(query);
        }

        private void gridSupplier_DoubleClick(object sender, EventArgs e)
        {
            this.txtSupName.Text= this.gridSupplier.CurrentRow.Cells["SupName"].Value.ToString();
            this.txtSupEmail.Text= this.gridSupplier.CurrentRow.Cells["SupEmail"].Value.ToString();
            this.txtSupContactNo.Text= this.gridSupplier.CurrentRow.Cells["SupContactNo"].Value.ToString();
            this.txtSupId.Text= this.gridSupplier.CurrentRow.Cells["SupId"].Value.ToString();

            //this.supId = this.gridSupplier.CurrentRow.Cells["SupId"].Value.ToString();
        }
        public void PopulateGridView(string query)
        {
            try
            {
                var ds = this.Da.ExecuteQuery(query);
                this.gridSupplier.AutoGenerateColumns = false;
                this.gridSupplier.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ClearAll()
        {
            this.txtSupName.Clear();
            this.txtSupId.Clear();
            this.txtSupEmail.Clear();
            this.txtSupContactNo.Clear();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.gridSupplier.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to remove the data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure to remove the data?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.No)
                    return;

                var id = this.gridSupplier.CurrentRow.Cells[0].Value.ToString();
                var Name = this.gridSupplier.CurrentRow.Cells[1].Value.ToString();

                var query = "delete from Supplier where SupId = '" + id + "';";
                var count = this.Da.ExecuteDMLQuery(query);

                if (count == 1)
                    MessageBox.Show(Name.ToUpper() + " has been removed from the Supplier.");
                else
                    MessageBox.Show("Supplier remove failed");

                this.PopulateGridView("select * from Supplier;");
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error has occured:\n" + exc.Message);
            }
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
                var sql = "select * from Supplier where SupId='" + this.txtSupId.Text + "';";
                var ds = this.Da.ExecuteQuery(sql);

                if (ds.Tables[0].Rows.Count == 0)
                {
                    //insert
                    query = "INSERT INTO Supplier (SupName,SupEmail,SupContactNo) VALUES ('" + this.txtSupName.Text + "', '"+this.txtSupEmail.Text+"', '"+this.txtSupContactNo.Text+"');";
                    var count = this.Da.ExecuteDMLQuery(query);

                    if (count == 1)
                    {
                        MessageBox.Show("Supplier Added successfully.", "Successfully Added", MessageBoxButtons.OK);
                        this.PopulateGridView("select * from Supplier;");
                        this.ClearAll();
                    }
                    else
                    {
                        MessageBox.Show("Error while adding Supplier", "Error", MessageBoxButtons.OK);
                    }

                }
                else
                {
                    //update
                    query = "UPDATE Supplier SET SupName='" + this.txtSupName.Text + "', SupEmail = '" + this.txtSupEmail.Text + "',SupContactNo='" + this.txtSupContactNo.Text + "' where SupName='"+this.txtSupId.Text+"';";
                    var count = this.Da.ExecuteDMLQuery(query);

                    if (count == 1)
                    {

                        MessageBox.Show("Supplier Info updated successfully.", "Successfully Updated", MessageBoxButtons.OK);
                        this.PopulateGridView("select * from Supplier;");
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
                MessageBox.Show(ex.ToString());
            }
        }
        private bool IsValidToSave()
        {
            if (String.IsNullOrEmpty(this.txtSupName.Text))
                return false;
            else
                return true;
        }

        private void UserControlSupplier_Load(object sender, EventArgs e)
        {
            this.gridSupplier.ClearSelection();
        }

        private void txtSearchBySupName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var query = "select * from Supplier where SupName like '" + this.txtSearchBySupName.Text + "%'";
                this.PopulateGridView(query);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            
        }

        private void metroPanel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
