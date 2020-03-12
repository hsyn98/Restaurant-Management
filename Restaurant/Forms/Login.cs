using Restaurant.AppCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Windows.Forms;

namespace Restaurant.Forms
{
    public partial class Login : Form
    {
        MyClient client;
        List<string> list = new List<string>();
        string login = null;
        public Login()
        {
            InitializeComponent();
            //this.Icon = IconExtractor.Extract("shell32.dll", 44, true);
            //btnClear.Image = IconExtractor.Extract("shell32.dll", 238, true).ToBitmap();
            //btnSubmit.Image = IconExtractor.Extract("shell32.dll", 301, true).ToBitmap();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void ShowData()
        {
            client = new MyClient();
            DataTable dt = new DataTable();
            dt= client.GetTable("Select Id,UserName From Users Where ClosedDate Is NULL order by UserName");
           
            cboUsers.DataSource = dt.DefaultView;
            cboUsers.ValueMember = "UserName";
            cboUsers_SelectedIndexChanged(null, null);
            txtPass0.Focus();
            this.AcceptButton = btnSubmit;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            txtPass0.Text = "";
            txtPass1.Text = "";
            txtPass2.Text = "";
            txtPass3.Text = "";

            Button button = sender as Button;
            if (button != null)
            {
                list.Add(button.Tag.ToString());
            }



            switch (list.Count)
            {
                case 1:
                    txtPass0.Text = list[0].ToString();
                    break;
                case 2:
                    txtPass0.Text = list[0].ToString();
                    txtPass1.Text = list[1].ToString();
                    break;
                case 3:
                    txtPass0.Text = list[0].ToString();
                    txtPass1.Text = list[1].ToString();
                    txtPass2.Text = list[2].ToString();
                    break;
                case 4:
                    txtPass0.Text = list[0].ToString();
                    txtPass1.Text = list[1].ToString();
                    txtPass2.Text = list[2].ToString();
                    txtPass3.Text = list[3].ToString();
                    break;
                default:
                    txtPass0.Text = list[0].ToString();
                    txtPass1.Text = list[1].ToString();
                    txtPass2.Text = list[2].ToString();
                    txtPass3.Text = list[3].ToString();
                    break;
            }
        }


        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void onePassTxt_KeyDown(object sender, KeyEventArgs e)
        {
            txtPass1.Focus();
        }

        private void secondPassTxt_KeyDown(object sender, KeyEventArgs e)
        {
            txtPass2.Focus();
        }

        private void threePassTxt_KeyDown(object sender, KeyEventArgs e)
        {
            txtPass3.Focus();
        }

        private void fourPassTxt_KeyDown(object sender, KeyEventArgs e)
        {
            btnSubmit.Focus();
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cboUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboUsers.SelectedIndex > -1)
                login = cboUsers.SelectedValue.ToString();
                list.Clear();
                txtPass0.Text = "";
                txtPass1.Text = "";
                txtPass2.Text = "";
                txtPass3.Text = "";
                txtPass0.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            list.Clear();
            txtPass0.Text = "";
            txtPass1.Text = "";
            txtPass2.Text = "";
            txtPass3.Text = "";
            txtPass0.Focus();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            client = new MyClient();

            string pass = null;
            string msg = null;

            if (login.Length > 0 && txtPass0.Text != String.Empty && txtPass1.Text != String.Empty && txtPass2.Text != String.Empty && txtPass3.Text != String.Empty)
            {
                pass = Convert.ToString(txtPass0.Text + txtPass1.Text + txtPass2.Text + txtPass3.Text);

                DataTable dt = new DataTable();

                dt = client.GetTable("Select Id,UserName,RoleName,Role,OfficeId ,(SurName + ' ' + Name ) As  UserFullName From   Users Where UserName='" + login.TrimEnd() + "' And PasswordHash='" + client.PassHash(pass).TrimEnd() + "'");

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        Properties.Settings.Default.UserId = dr[0].ToString();
                        Properties.Settings.Default.UserName = dr[1].ToString();
                        Properties.Settings.Default.RoleName = dr[2].ToString();
                        Properties.Settings.Default.Role = dr[3].ToString();
                        Properties.Settings.Default.OfficeId = dr[4].ToString();
                        Properties.Settings.Default.UserFullName = dr["UserFullName"].ToString();
                    }

                    Properties.Settings.Default.Save();

                    dt.Dispose();

                    this.Hide();

                    Main fMain = new Main();
                    fMain.ShowDialog();

                    //Users fUsers = new Users();
                    //fUsers.ShowDialog();

                }

                else
                {
                    msg = "İstifadəçi sistemə daxil ola bilmədi!\nİstifadəçi adı və ya şifrə düz daxil edilmir və ya bu istifadəçi sistemdə mövcud deyil.\nXahiş edirik diqqətli olun!";
                    GetMessageBox(msg, 0);
                    btnClear_Click(null, null);
                }
            }
            else
            {
                msg = "İstifadəçi adı və ya şifrə boş ola bilməz!\nXahiş edirik diqqətli olun!";
                GetMessageBox(msg, 237);
                btnClear_Click(null, null);
            }
        }

        private void GetMessageBox(string msg, Int16 imgnum)
        {
            if (Application.OpenForms["FormMsg"] == null)
            {
                Msg fMsg = new Msg(msg, imgnum);
                fMsg.ShowDialog();
            }
            else
                return;
        }
    }
}
