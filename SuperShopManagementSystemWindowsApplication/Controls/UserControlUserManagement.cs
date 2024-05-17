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
    public partial class UserControlUserManagement : UserControl
    {
        private DataAccess Da { get; set; }
        public UserControlUserManagement()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            
            var query = "select * from UserInformation;";
            this.PopulateGridView(query);
            
        }
        public void PopulateGridView(string query)
        {
            try
            {
                var ds = this.Da.ExecuteQuery(query);
                this.userGrid.AutoGenerateColumns = false;
                this.userGrid.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        

        private void showDetails_Click(object sender, EventArgs e)
        {
            string query = "select * from UserInformation;";
            this.PopulateGridView(query);
        }

        private void userGrid_DoubleClick(object sender, EventArgs e)
        {
            this.txtUserName.Text = this.userGrid.CurrentRow.Cells["UserName"].Value.ToString();
            this.txtEmail.Text = this.userGrid.CurrentRow.Cells["Email"].Value.ToString();
            this.txtAddress.Text = this.userGrid.CurrentRow.Cells["Address"].Value.ToString();
            this.txtContactNo.Text = this.userGrid.CurrentRow.Cells["ContactNo"].Value.ToString();
            this.txtPassword.Text = this.userGrid.CurrentRow.Cells["Password"].Value.ToString();
            //this.comboRole.SelectedIndex = this.userGrid.CurrentRow.Cells["Role"].Value.ToString();
            if(this.userGrid.CurrentRow.Cells["Role"].Value.ToString().ToLower()=="admin")
            {
                this.comboRole.SelectedIndex = 0;
            }
            else
            {
                this.comboRole.SelectedIndex = 1;
            }
        }

        private void txtSearchByUserName_TextChanged(object sender, EventArgs e)
        {
            var query = "select * from UserInformation where UserName like '"+this.txtSearchByUserName.Text+"%'";
            this.PopulateGridView(query);
        }

        private void UserControlUserManagement_Load(object sender, EventArgs e)
        {
            /*var query = "select * from UserInformation;";
            this.PopulateGridView(query);
            */
            this.userGrid.ClearSelection();
        }

        private void ClearAll()
        {
            this.txtUserName.Clear();
            this.txtEmail.Clear();
            this.txtAddress.Clear();
            this.txtContactNo.Clear();
            this.txtPassword.Clear();
            this.comboRole.SelectedIndex = -1;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
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
                var sql = "select * from UserInformation where UserName='" + this.txtUserName.Text + "';";
                var ds = this.Da.ExecuteQuery(sql);


                if (ds.Tables[0].Rows.Count == 1)
                {
                    //update

                    
                    query = "UPDATE UserInformation SET Role='"+this.comboRole.SelectedItem+"', Email = '"+this.txtEmail.Text+"', Address='"+this.txtAddress.Text+"',ContactNo='"+this.txtContactNo.Text+ "', Password='"+this.txtPassword.Text+"' where UserName='"+this.txtUserName.Text+"';";
                    var count = this.Da.ExecuteDMLQuery(query);

                    if(count == 1)
                    {
                        
                        MessageBox.Show("User Info updated successfully.","Successfully Updated",MessageBoxButtons.OK);
                        this.PopulateGridView("select * from UserInformation;");
                        this.ClearAll();
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }
                
                else
                {
                    //insert
                    query = "INSERT INTO UserInformation(UserName,Role,Email,Address,ContactNo,Password) VALUES ('"+this.txtUserName.Text+"', '"+this.comboRole.SelectedItem+"', '" + this.txtEmail.Text + "','" + this.txtAddress.Text + "','" + this.txtContactNo.Text + "','"+this.txtPassword.Text+"');";
                    var count = this.Da.ExecuteDMLQuery(query);
                    if (count == 1)
                    {
                        MessageBox.Show("User Info Added successfully.", "Successfully Updated", MessageBoxButtons.OK);
                        this.PopulateGridView("select * from UserInformation;");
                        this.ClearAll();
                    }
                    else
                    {
                        MessageBox.Show("Error while adding user","Error",MessageBoxButtons.OK);
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
            if (String.IsNullOrEmpty(this.txtEmail.Text) || String.IsNullOrEmpty(this.txtPassword.Text)
            || String.IsNullOrEmpty(this.txtUserName.Text) || this.comboRole.SelectedItem == null)
                return false;
            else
                return true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.userGrid.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to remove the data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure to remove the data?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.No)
                    return;

                var username = this.userGrid.CurrentRow.Cells[0].Value.ToString();
                
                var query = "delete from UserInformation where UserName = '" +username+ "';";
                var count = this.Da.ExecuteDMLQuery(query);

                if (count == 1)
                    MessageBox.Show(username.ToUpper() + " has been removed from the UserList.");
                else
                    MessageBox.Show("User remove failed");

                this.PopulateGridView("select * from UserInformation;");
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error has occured:\n" + exc.Message);
            }
        }
    }
}
