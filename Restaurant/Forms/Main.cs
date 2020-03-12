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
    public partial class Main : Form
    {
        MyClient client;
        DataTable dt;
        string userId;
        Button btn;
        public Main()
        {
            InitializeComponent();
            //tsbtnUsers.Image = IconExtractor.Extract("shell32.dll", 160, true).ToBitmap();
            userId = Properties.Settings.Default.UserId;
            this.ActiveControl = flowLayoutTable;
            FillStatusbar();
        }
      
        private void Main_Load(object sender, EventArgs e)
        {
            client = new MyClient();
            dt = new DataTable();
            dt = client.GetTable("Select PasswordHash from Users Where Id=" + userId);

            string hashcode = client.PassHash("1234");
            if (hashcode == dt.Rows[0][0].ToString())
            {
                PasswordChange pswrch = new PasswordChange();
                pswrch.ShowDialog();
            }

            LoadMenu();
        }

        private void LoadMenu()
        {
            client = new MyClient();
            DataTable dt = new DataTable();

            string query = "SELECT * From Tables Where Status = 1";

            dt = client.GetTable(query);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    btn = new Button();

                    //btn.Image = global::Restaurant.Properties.Resources.ico3;
                    //btn.BackgroundImage = global::Terminal.Properties.Resources.n29;// Image.FromFile(@"E:\MyApp\Terminal\Terminal\Img\29.bmp");
                    btn.ImageAlign = ContentAlignment.TopCenter;
                    btn.Name = "btn" + dr["Id"].ToString().Trim();
                    btn.Tag = dr["Id"].ToString().Trim();
                    btn.Text = dr["Name"].ToString();
                    btn.FlatStyle = FlatStyle.Popup;
                    btn.Height = 90;
                    btn.Width = 150;
                    btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                    btn.Font = new Font("Gadugi", 12.0F, FontStyle.Bold);
                    btn.ForeColor = Color.DarkBlue;
                    btn.BackColor = Color.Azure;

                    btn.Click += new EventHandler(this.Btn_Click);

                    flowLayoutTable.Controls.Add(btn);

                }
            }

            CheckTable();
        }

        private void CheckTable()
        {
            client = new MyClient();
            DataTable dt = new DataTable();
            dt = client.GetTable("SELECT Id From Tables Where Id In (Select Distinct  TabId From Sales Where IsPayment = 0 And  Convert(nchar(8), SalesDate, 112)='" + DateTime.Now.ToString("yyyyMMdd") + "')");
            DataColumn[] dcPk = new DataColumn[1];

            dcPk[0] = dt.Columns[0];
            dt.PrimaryKey = dcPk;

            foreach (Control c in this.flowLayoutTable.Controls)
            {
                if (c is Button)
                {
                    string tag = c.Tag.ToString();

                    DataRow foundRow = dt.Rows.Find(tag);
                    c.BackColor = foundRow != null ? Color.Pink : Color.Azure;

                }
            }
        }

        void Btn_Click(Object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string id = btn.Tag.ToString();

            Sales formSales = new Sales(id);

            var result = formSales.ShowDialog(Application.OpenForms["FormSales"]);
            if (result == DialogResult.OK)
            {
                CheckTable();
                this.Refresh();
            }
            else { return; }
        }

        private void FillStatusbar()
        {
            lblMachineName.Text ="Machinename :" +  Environment.MachineName.ToString();
            lblUserName.Text = "Username :" + Properties.Settings.Default.UserId + "-" + Properties.Settings.Default.UserName;
        }

        private void tsbtnUsers_Click(object sender, EventArgs e)
        {
            Users usr = new Users();
            usr.ShowDialog();
        }

        private void qruplarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableGroups tbgroup = new TableGroups();
            tbgroup.ShowDialog();
        }

        private void masalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tables tb = new Tables();
            tb.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsbtnMenu_Click(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            mn.ShowDialog();
        }
    }
}
