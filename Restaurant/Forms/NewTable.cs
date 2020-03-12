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
    public partial class NewTable : Form
    {
        public string name { get; set; }
        public string number { get; set; }
        public int groupid { get; set; }
        public decimal amount { get; set; }
        public int amounttype { get; set; }
        public bool status { get; set; }

        MyClient client;
        DataSet ds;
        private int id;
        private string tablename;
        string defnum;

        public NewTable(int rowid)
        {
            InitializeComponent();
            id = rowid;
        }

        private void NewTable_Load(object sender, EventArgs e)
        {
            if (id != 0)
            {
                EditData(id);
            }
            else
                FillCombo();
            this.AcceptButton = btnSave;
        }

        private void EditData(int id)
        {
            string[] installs = new string[] { "Məbləğ", "Faiz" };
            cmbxAdditiontype.Items.AddRange(installs);

            client = new MyClient();
            ds = new DataSet();

            ds = client.GetDataSet("Select a.Id,a.Name,a.Number,b.Name As GroupName,a.Type,a.Amount,a.GroupId, a.Status" +
                " From Tables As a INNER JOIN TableGroup As b  ON a.Id = b.Id Where a.Id =" + id + "; Select Id, Name From TableGroup; Select Distinct Number  From  Tables");

            cmbxTableGroup.DataSource = ds.Tables[1].DefaultView;
            cmbxTableGroup.DisplayMember = "Name";
            cmbxTableGroup.ValueMember = "Id";


            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                txtName.Text = (dr["Name"].ToString());
                tablename = (dr["Name"].ToString());
                cmbxTableNumber.SelectedValue = (int)dr["Number"];
                defnum = (dr["Number"].ToString());
                cmbxTableGroup.SelectedValue = (int)dr["GroupId"];
                cmbxAdditiontype.SelectedIndex = (int)dr["Type"];
                txtAdditionAmount.Text = (dr["Amount"].ToString());
                chbxStatus.Checked = Convert.ToBoolean(dr["Status"]);
            }

            ds.Dispose();
            chbxStatus.Enabled = false;

            cmbxTableNumber.Items.Add(defnum);

            cmbxTableNumber.SelectedIndex = 0;

            for (int i = 1; i <= 100; i++)
            {
                int k = 0;
                foreach (DataRow dr in ds.Tables[2].Rows)
                {
                    if (i.ToString() != dr["Number"].ToString())
                    {
                        k++;
                    }
                }
                if (k == ds.Tables[2].Rows.Count)
                {
                    cmbxTableNumber.Items.Add(i.ToString());
                }
            }
        }

        private void FillCombo()
        {
            client = new MyClient();
            ds = new DataSet();

            ds = client.GetDataSet("Select Id,Name From TableGroup; Select Distinct Number  From  Tables");

            cmbxTableGroup.DataSource = ds.Tables[0].DefaultView;
            cmbxTableGroup.ValueMember = "Id";
            cmbxTableGroup.DisplayMember = "Name";
            cmbxTableGroup.SelectedIndex = 0;

            for (int i=1; i<=100; i++)
            {
                int k = 0;
                foreach (DataRow dr in ds.Tables[1].Rows)
                {
                    if (i.ToString() != dr["Number"].ToString())
                    {
                        k++;
                    }
                }
                if (k == ds.Tables[1].Rows.Count)
                {
                    cmbxTableNumber.Items.Add(i.ToString());
                }
            }

            string[] installs = new string[] { "Məbləğ", "Faiz"};
            cmbxAdditiontype.Items.AddRange(installs);
            cmbxTableNumber.SelectedIndex = 0;
        }
        private void cmbxTableNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtNumber.Text = cmbxTableNumber.SelectedItem.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text.ToString() != "" || txtName.Text.ToString() != " ")
            {
                if (id == 0)
                {
                    DataTable dt = new DataTable();
                    dt = client.GetTable("Select Count(*) From Tables Where Name =N'" + txtName.Text.Trim() + "'");
                    if (dt.Rows[0][0].ToString() == "0")
                    {
                        name = txtName.Text.ToString();
                        number = cmbxTableNumber.Text;
                        groupid = (int)cmbxTableGroup.SelectedValue;
                        amounttype = (int)cmbxAdditiontype.SelectedIndex;
                        amount = Convert.ToDecimal(txtAdditionAmount.Text);
                        status = chbxStatus.Checked ? true : false;

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
                else if (id != 0 && tablename != txtName.Text.ToString())
                {
                    DataTable dt = new DataTable();
                    dt = client.GetTable("Select Count(*) From Tables Where Name =N'" + txtName.Text.Trim() + "'");
                    if (dt.Rows[0][0].ToString() == "0")
                    {
                        name = txtName.Text.ToString();
                        number = cmbxTableNumber.Text;
                        groupid = (int)cmbxTableGroup.SelectedValue;
                        amounttype = (int)cmbxAdditiontype.SelectedIndex;
                        amount = Convert.ToDecimal(txtAdditionAmount.Text);
                        status = chbxStatus.Checked ? true : false;

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
                else if (id != 0 && tablename == txtName.Text.ToString())
                {
                    name = txtName.Text.ToString();
                    number = cmbxTableNumber.Text;
                    groupid = (int)cmbxTableGroup.SelectedValue;
                    amounttype = (int)cmbxAdditiontype.SelectedIndex;
                    amount = Convert.ToDecimal(txtAdditionAmount.Text);
                    status = chbxStatus.Checked ? true : false;

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                string mssg = "Ad hissə boş buraxıla bilməz";
                Msg msgg = new Msg(mssg, 237);
                msgg.ShowDialog();
            }
        }

        private void cmbxAdditiontype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxAdditiontype.SelectedIndex == 0)
            {
                lblAmount.Text = "AZN";
            }
            else
            {
                lblAmount.Text = "%";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
