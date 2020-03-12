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
    public partial class PasswordChange : Form
    {
        MyClient client;
        SqlConnection conn;
        SqlCommand cmd;

        List<string> list1 = new List<string>();
        List<string> list2 = new List<string>();

        string connstr = null;
        int? resultt = null;
        string userid;
        string pass1;
        string pass2;

        public PasswordChange()
        {
            InitializeComponent();
            connstr = Properties.Settings.Default.ConnectionUrl;
            //btnSave.Image = IconExtractor.Extract("shell32.dll", 301, true).ToBitmap();
            //btnClear1.Image = IconExtractor.Extract("shell32.dll", 238, true).ToBitmap();
            //btnClear2.Image = IconExtractor.Extract("shell32.dll", 238, true).ToBitmap();
            userid = Properties.Settings.Default.UserId;
        }
        private void PasswordChange_Load(object sender, EventArgs e)
        {
            txtPass0_1.Focus();
            this.AcceptButton = btnSave;
        }
        private void Button_Click(object sender, EventArgs e)
        {
            txtPass0_1.Text = "";
            txtPass1_1.Text = "";
            txtPass2_1.Text = "";
            txtPass3_1.Text = "";

            txtPass0_2.Text = "";
            txtPass1_2.Text = "";
            txtPass2_2.Text = "";
            txtPass3_2.Text = "";

            Button button = sender as Button;
            if (button != null)
            {
                list1.Add(button.Tag.ToString());
                list2.Add(button.Tag.ToString());
            }

            switch (list1.Count)
            {
                case 1:
                    txtPass0_1.Text = list1[0].ToString();
                    break;
                case 2:
                    txtPass0_1.Text = list1[0].ToString();
                    txtPass1_1.Text = list1[1].ToString();
                    break;
                case 3:
                    txtPass0_1.Text = list1[0].ToString();
                    txtPass1_1.Text = list1[1].ToString();
                    txtPass2_1.Text = list1[2].ToString();
                    break;
                case 4:
                    txtPass0_1.Text = list1[0].ToString();
                    txtPass1_1.Text = list1[1].ToString();
                    txtPass2_1.Text = list1[2].ToString();
                    txtPass3_1.Text = list1[3].ToString();
                    break;
                default:
                    txtPass0_1.Text = list1[0].ToString();
                    txtPass1_1.Text = list1[1].ToString();
                    txtPass2_1.Text = list1[2].ToString();
                    txtPass3_1.Text = list1[3].ToString();
                    break;
            }

            switch (list2.Count)
            {
                case 5:
                    txtPass0_2.Text = list2[0].ToString();
                    break;
                case 6:
                    txtPass0_2.Text = list2[0].ToString();
                    txtPass1_2.Text = list2[1].ToString();
                    break;
                case 7:
                    txtPass0_2.Text = list2[0].ToString();
                    txtPass1_2.Text = list2[1].ToString();
                    txtPass2_2.Text = list2[2].ToString();
                    break;
                case 8:
                    txtPass0_2.Text = list2[0].ToString();
                    txtPass1_2.Text = list2[1].ToString();
                    txtPass2_2.Text = list2[2].ToString();
                    txtPass3_2.Text = list2[3].ToString();
                    break;
                default:
                    txtPass0_2.Text = list2[0].ToString();
                    txtPass1_2.Text = list2[1].ToString();
                    txtPass2_2.Text = list2[2].ToString();
                    txtPass3_2.Text = list2[3].ToString();
                    break;
            }
        }

        private void txtPass0_1_KeyDown(object sender, KeyEventArgs e)
        {
            txtPass1_1.Focus();
        }

        private void txtPass1_1_KeyDown(object sender, KeyEventArgs e)
        {
            txtPass2_1.Focus();
        }

        private void txtPass2_1_KeyDown(object sender, KeyEventArgs e)
        {
            txtPass3_1.Focus();
        }

        private void txtPass3_1_KeyDown(object sender, KeyEventArgs e)
        {
            txtPass0_2.Focus();
        }

        private void txtPass0_2_KeyDown(object sender, KeyEventArgs e)
        {
            txtPass1_2.Focus();
        }

        private void txtPass1_2_KeyDown(object sender, KeyEventArgs e)
        {
            txtPass2_2.Focus();
        }

        private void txtPass2_2_KeyDown(object sender, KeyEventArgs e)
        {
            txtPass3_2.Focus();
        }

        private void txtPass3_2_KeyDown(object sender, KeyEventArgs e)
        {
            btnSave.Focus();
        }

        private void btnClear1_Click(object sender, EventArgs e)
        {
            list1.Clear();
            list2.Clear();
            txtPass0_1.Text = "";
            txtPass1_1.Text = "";
            txtPass2_1.Text = "";
            txtPass3_1.Text = "";
            txtPass0_2.Text = "";
            txtPass1_2.Text = "";
            txtPass2_2.Text = "";
            txtPass3_2.Text = "";
            txtPass0_1.Focus();
        }

        private void btnClear2_Click(object sender, EventArgs e)
        {
            list2.Clear();
            txtPass0_2.Text = "";
            txtPass1_2.Text = "";
            txtPass2_2.Text = "";
            txtPass3_2.Text = "";
            txtPass0_2.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            client = new MyClient();

            if (txtPass0_1.Text.ToString() != String.Empty && txtPass1_1.Text.ToString() != String.Empty && txtPass2_1.Text.ToString() != String.Empty && txtPass3_1.Text.ToString() != String.Empty &&
                txtPass0_2.Text.ToString() != String.Empty && txtPass1_2.Text.ToString() != String.Empty && txtPass2_2.Text.ToString() != String.Empty && txtPass3_2.Text.ToString() != String.Empty)
            {
                pass1 = Convert.ToString(txtPass0_1.Text + txtPass1_1.Text + txtPass2_1.Text + txtPass3_1.Text);
                pass2 = Convert.ToString(txtPass0_2.Text + txtPass1_2.Text + txtPass2_2.Text + txtPass3_2.Text);
                if (pass1 == pass2)
                {
                    try
                    {
                        conn = new SqlConnection(connstr);
                        conn.Open();

                        cmd = new SqlCommand();
                        cmd = conn.CreateCommand();

                        cmd.CommandText = "Update Users Set PasswordHash=@PasswordHash Where Id =" + userid;

                        cmd.Parameters.AddRange(new SqlParameter[]
                                  {
                        new SqlParameter("@Id", userid),
                        new SqlParameter("@PasswordHash", client.PassHash(pass2))
              });

                        resultt = (int)cmd.ExecuteNonQuery();

                        if (resultt == 1)
                        {
                            Msg msg = new Msg("Parolunuz müvəffəqiyyətlə dəyişdi", 221);
                            msg.ShowDialog();
                            cmd.Dispose();
                            Application.Restart();
                        }
                        else
                        {
                            Msg msg = new Msg("Xəta baş verdi, dəyişdirilmədi", 237);
                            msg.ShowDialog();
                        }

                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        throw;
                    }
                    finally { }
                }
                else
                {
                    Msg msg = new Msg("Parol təkrarı ilə uyğun deyil\nXahiş edirik diqqətli olun", 237);
                    msg.ShowDialog();
                }
            }
            else
            {
                Msg msg = new Msg("Parameterlər boş ola bilməz", 237);
                msg.ShowDialog();
            }
        }


    }
}
