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
    public partial class UserControlChangePassword : UserControl
    {
        private DataAccess Da { get; set; }
        private string username;
        public UserControlChangePassword()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }
        public UserControlChangePassword(string username):this()
        {
            this.username = username;
        }

        private void ClearAll()
        {
            this.txtOldPassword.Clear();
            this.txtNewPassword.Clear();
            this.txtConfirmPassword.Clear();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private bool IsValidToSave()
        {
            if (String.IsNullOrEmpty(this.txtNewPassword.Text)|| String.IsNullOrEmpty(this.txtOldPassword.Text)|| String.IsNullOrEmpty(this.txtConfirmPassword.Text))
                return false;
            else
                return true;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the information");
                    return;
                }


                string query = null;
                var sql = "select * from UserInformation where UserName= '"+this.username+"' ;";
                var ds = this.Da.ExecuteQuery(sql);
                //var count1 = ds.Tables[0].Rows.Count;
                //MessageBox.Show(""+this.username);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    //update

                    if (this.txtOldPassword.Text == ds.Tables[0].Rows[0][1])
                    {
                        if(this.txtNewPassword.Text==this.txtConfirmPassword.Text)
                        {
                            query = "UPDATE UserInformation SET Password='" + this.txtConfirmPassword.Text + "';";
                            var count = this.Da.ExecuteDMLQuery(query);

                            if (count == 1)
                            {

                                MessageBox.Show("Password Info updated successfully.", "Successfully Updated", MessageBoxButtons.OK);
                                
                                this.ClearAll();
                            }
                            else
                            {
                                MessageBox.Show("Error");
                            }
                        }
                        else
                        {
                            MessageBox.Show("New password and Confirm password not matched.");
                        }
                    
                    }
                    else
                    {
                        MessageBox.Show("Old password not matched.");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Some error occours");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
