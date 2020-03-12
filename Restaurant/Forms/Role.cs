using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Restaurant.AppCode;

namespace Restaurant.Forms
{
    public partial class Role : Form
    {
        MyClient client;
        DataTable dt = new DataTable();
       

        public string role { get; set; }
        public string rolestr { get; set; }
       
        public Role(int id)
        {
            InitializeComponent();
            ShowData(id);
            this.Icon = IconExtractor.Extract("shell32.dll", 43, true);
        }
      
        private void ShowData(int id)
        {

            client = new MyClient();

            dt =client.GetTable("Select RoleName, Role,RoleStr From Users Where Id=" + id);
            
            if (dt.Rows.Count > 0)
            {   
             
                string rolename = dt.Rows[0]["RoleName"].ToString();
                string rolevalue = dt.Rows[0]["Role"].ToString();
                
                foreach (Control control in this.Controls)
                {
                    if ((control is CheckBox) && ((CheckBox)control).Checked)
                        ((CheckBox)control).Checked = false;
                }

                if (rolename == "Admin" && rolevalue.Length > 5)
                {
                    foreach (Control control in grUserRoles.Controls)
                    {
                        if ((control is CheckBox))
                        {
                            ((CheckBox)control).Checked = true;
                            ((CheckBox)control).Enabled =false;
                        }
                    }
                }
                else
                {
                    char[] delimiters = new char[] { ',' };
                    string[] parts = rolevalue.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < parts.Length; i++)
                    {
                        foreach (Control control in grUserRoles.Controls)
                        {
                            if ((control is CheckBox))
                            {
                                if (((CheckBox)control).Tag.ToString() == parts[i].ToString().Trim())
                                {
                                    ((CheckBox)control).Checked = true;
                                }
                            }
                        }

                    }
                }
            }
        }

      

        private void btnRoleSave_Click(object sender, EventArgs e)
        {
            string roles = "";

            foreach (Control control in grUserRoles.Controls)
            {
                if ((control is CheckBox) && ((CheckBox)control).Checked == true)
                {
                    this.role += "," + control.Tag.ToString();
                    this.rolestr +="," + control.Text.ToString();
                }
            }

            if (roles != null)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else { return; }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
