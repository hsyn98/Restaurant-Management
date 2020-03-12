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
    public partial class Sales : Form
    {
        MyClient client;
        DataTable dt;
        string userId;
        Button btn;

        public Sales(string id)
        {
            InitializeComponent();
            userId = Properties.Settings.Default.UserId;
            this.ActiveControl = flowLayoutMenu;
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            LoadMenu();
        }

        private void LoadMenu()
        {
            client = new MyClient();
            DataTable dt = new DataTable();

            string query = "SELECT * From MenuAltGroup Where Status = 1";

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
                    btn.Height = 60;
                    btn.Width = 157;
                    btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    btn.Font = new Font("Gadugi", 12.0F, FontStyle.Regular);
                    btn.ForeColor = Color.DarkBlue;
                    btn.BackColor = Color.Chartreuse;

                    btn.Click += new EventHandler(this.Btn_Click);

                    flowLayoutMenu.Controls.Add(btn);
                }
            }
        }

        void Btn_Click(Object sender, EventArgs e)
        {
            flowLayoutSubMenu.Controls.Clear();
            Button btn = (Button)sender;
            string id = btn.Tag.ToString();

            this.ActiveControl = flowLayoutSubMenu;

            client = new MyClient();
            DataTable dt = new DataTable();

            string query = "SELECT * From Menu Where MenuAltId = "+id;

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
                    btn.Height = 120;
                    btn.Width = 120;
                    btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    btn.Font = new Font("Gadugi", 12.0F, FontStyle.Regular);
                    btn.ForeColor = Color.DarkBlue;
                    btn.BackColor = Color.LightCoral;

                    btn.Click += new EventHandler(this.Btn_Click);

                    flowLayoutSubMenu.Controls.Add(btn);
                }
            }
        }
    }
}
