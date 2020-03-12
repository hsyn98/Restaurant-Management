using Restaurant.AppCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant.Forms
{
    public partial class Menu : Form
    {
        MyClient client;
        DataSet ds = new DataSet();
        SqlConnection conn;
        SqlCommand cmd;
        string connStr = null;

        private int id;
        int? resultt = null;
        DataGridViewRow selectedRow;
        string closed;

        public Menu()
        {
            InitializeComponent();
            connStr = Properties.Settings.Default.ConnectionUrl;
        }
        private void Menu_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void ShowData()
        {
            client = new MyClient();
            ds = new DataSet();

            ds.Tables.Add(client.GetTable("Select a.Id, a.Name, b.Name As AltGroup, c.Name As MainGroup, a.Price from Menu As a" 
                                                                           +" INNER JOIN MenuAltGroup As b ON a.MenuAltId = b.Id"
                                                                           +" INNER JOIN MenuMainGroup As c ON a.MenuMainId = c.Id"));
            ds.Tables.Add(client.GetTable("Select Id,Name From MenuAltGroup"));
            ds.Tables.Add(client.GetTable("Select Id,Name From MenuMainGroup"));

            dgvUsers.DataSource = null;
            dgvUsers.Columns.Clear();

            dgvUsers.DataSource = ds.Tables[0].DefaultView;
            //cmbShow.SelectedIndex = 0;
            //cmbShow_SelectedIndexChanged(null, null);

            dgvUsers.Columns[0].HeaderText = "Kodu";
            dgvUsers.Columns[1].HeaderText = "Adı";
            dgvUsers.Columns[2].HeaderText = "Alt Qrup";
            dgvUsers.Columns[3].HeaderText = "Əsas Qrup";
            dgvUsers.Columns[4].HeaderText = "Qiymət";



            //DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            //col.HeaderText = "Ümumi";
            //col.Name = "column14";
            //col.Width = 40;
            //col.Text = "...";
            //col.DefaultCellStyle.Font = new System.Drawing.Font("Palatino Linotype", 7.5F, FontStyle.Bold);
            //col.FlatStyle = FlatStyle.System;
            //col.UseColumnTextForButtonValue = true;
            //dgvUsers.Columns.Insert(14, col);
            //dgvUsers.Columns[14].Width = 40;
            //dgvUsers.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgvUsers.Columns[12].Width = 60;

            //for (int i = 0; i < dgvUsers.Columns.Count; i++)
            //    if (dgvUsers.Columns[i] is DataGridViewImageColumn)
            //    {
            //        ((DataGridViewImageColumn)dgvUsers.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Zoom;
            //        break;
            //    }

            dgvUsers.Columns[4].Width = 70;
            //dgvUsers.Columns[8].Width = 50;
            dgvUsers.Columns[0].Width = 50;
            //dgvUsers.Columns[13].Visible = false;

            //label2.Image = IconExtractor.Extract("shell32.dll", 209, true).ToBitmap();

        }

        private void tsbtnNew_Click(object sender, EventArgs e)
        {

        }

        private void tsbtnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
