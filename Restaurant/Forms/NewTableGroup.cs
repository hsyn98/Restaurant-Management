using Restaurant.AppCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant.Forms
{
    public partial class NewTableGroup : Form
    {
        public string name { get; set; }
        public bool status { get; set; }

        MyClient client;
        DataTable dt;
        private int id;
        private string groupname;
        public NewTableGroup(int rowid)
        {
            InitializeComponent();
            id = rowid;
        }
        private void NewTableGroup_Load(object sender, EventArgs e)
        {
            if (id != 0)
            {
                EditData(id);
            }
            this.AcceptButton = btnSave;
        }

        private void EditData(int id)
        {
            client = new MyClient();
            dt = new DataTable();

            dt = client.GetTable("Select * From TableGroup Where Id =" + id + "");

            foreach (DataRow dr in dt.Rows)
            {
                txtName.Text = (dr["Name"].ToString());
                groupname = (dr["Name"].ToString());
                chbStatus.Checked = Convert.ToBoolean(dr["Status"]);
            }

            dt.Dispose();

            chbStatus.Enabled = false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            client = new MyClient();

            if (id == 0)
            {
                dt = new DataTable();
                dt = client.GetTable("Select Count(*) From TableGroup Where Name =N'" + txtName.Text.ToString() + "'");
                if (dt.Rows[0][0].ToString() == "0")
                {
                    name = txtName.Text.ToString();
                    status = chbStatus.Checked ? true : false;

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    string msg = "Məlumat bazada artıq mövcuddur";
                    Msg msgg = new Msg(msg, 237);
                    msgg.ShowDialog();
                    txtName.Focus();
                    return;
                }
            }
            else if (id != 0 && groupname != txtName.Text.ToString())
            {
                dt = new DataTable();
                dt = client.GetTable("Select Id From TableGroup Where Name =N'" + txtName.Text.Trim() + "'");

                if (dt.Rows.Count ==0)
                {
                    name = txtName.Text.ToString();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    string msg = "Məlumat bazada artıq mövcuddur";
                    Msg msgg = new Msg(msg, 237);
                    msgg.ShowDialog();
                    txtName.Focus();
                    return;
                }
            }
            else if (id != 0 && groupname == txtName.Text.ToString())
            {
                name = txtName.Text.ToString();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
