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
    public partial class FormLogin : MetroForm
    {
        private DataAccess Da { get; set; }
        public FormLogin()
        {
            InitializeComponent();
            this.txtPassword.UseSystemPasswordChar = true;
            this.Da = new DataAccess();

        }
        private void chkBoxShowPassword_CheckedChanged_1(object sender, EventArgs e)
        {
            if (this.chkBoxShowPassword.Checked)
            {
                this.txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                this.txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var sql = "select * from UserInformation where UserName = '" + this.txtUsername.Text + "' and Password = '" + this.txtPassword.Text + "';";
                var ds = this.Da.ExecuteQuery(sql);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    if (ds.Tables[0].Rows[0][2].ToString().ToLower() == "admin")
                    {
                        this.Hide();
                        new FormAdmin(this.txtUsername.Text,this).Show();



                    }
                    else if (ds.Tables[0].Rows[0][2].ToString().ToLower() == "seller")
                    {
                        this.Hide();
                        new FormSeller(this.txtUsername.Text,this).Show();

                    }
                    
                }
                else
                {
                    MessageBox.Show("Invalid User");
                }

            }
            catch(Exception ex) {
                MessageBox.Show(e.ToString());
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtUsername.Clear();
            this.txtPassword.Clear();
        }
    }
}
