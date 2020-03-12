using Restaurant.AppCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant.Forms
{
    public partial class FirstAdmin : Form
    {
        MyClient client;
        SqlConnection conn;
        SqlCommand cmd;

        string connstr = null;
        int? resultt = null;
        bool rr = false;
        public FirstAdmin()
        {
            InitializeComponent();
            connstr = Properties.Settings.Default.ConnectionUrl;

            //this.Icon = IconExtractor.Extract("shell32.dll", 95, true);
            //btnSave.Image = IconExtractor.Extract("shell32.dll", 301, true).ToBitmap();
            //btnImgAdd.Image = IconExtractor.Extract("shell32.dll", 45, false).ToBitmap();
            //btnImgClear.Image = IconExtractor.Extract("shell32.dll", 31, false).ToBitmap();
        }
        private void FirstAdmin_Load(object sender, EventArgs e)
        {
            txtName.Focus();
            this.AcceptButton = btnSave;
        }
        private void btnImgClear_Click(object sender, EventArgs e)
        {
            imgBox.Image = null;
            btnImgClear.Enabled = false;
        }

        private void btnImgAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = Application.StartupPath;
            dialog.Title = "Select a image file";
            dialog.Filter = "Image Files (*.bmp, *.jpg, *.png, *.jpeg)|*.bmp;*.jpg;*.png*;*.jpeg";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string urlimg = dialog.FileName;
                imgBox.Image = resizeImage(Image.FromFile(dialog.FileName), new Size(50, 65));
                btnImgClear.Enabled = true;
            }

            else { return; }
        }

        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            client = new MyClient();
            Regexp(@"^([\w]+)@([\w]+)\.([\w]+)$", txtEmail);

            if (txtName.Text.ToString() != String.Empty && txtSurname.Text.ToString() != String.Empty && txtAddress.Text.ToString() != String.Empty && 
                txtPhone.Text.ToString() != String.Empty && txtEmail.Text.ToString() != String.Empty)
            {
                if (txtName.Text.ToString().Length >= 3 && txtSurname.Text.ToString().Length >= 3 && rr)
                {
                    try
                    {
                        conn = new SqlConnection(connstr);
                        conn.Open();

                        cmd = new SqlCommand(); 
                        cmd = conn.CreateCommand();

                        Image img = imgBox.Image;
                        byte[] arr;
                        ImageConverter converter = new ImageConverter();
                        arr = (byte[])converter.ConvertTo(img, typeof(byte[]));

                        cmd.CommandText = "Insert Into Users (Name,Surname,UserName,Address,PhoneNumber,Email,PasswordHash,Img)"
                                + "Values (@Name,@Surname,@UserName,@Address,@PhoneNumber,@Email,@PasswordHash,@Img)";

                        cmd.Parameters.AddRange(new SqlParameter[]
                 {
                           new SqlParameter("Name", txtName.Text),
                           new SqlParameter("Surname", txtSurname.Text),
                           new SqlParameter("UserName", txtUser.Text),
                           new SqlParameter("Address", txtAddress.Text),
                           new SqlParameter("PhoneNumber", txtPhone.Text),
                           new SqlParameter("Email", txtEmail.Text),
                           new SqlParameter("PasswordHash", client.PassHash("1234")),
                           new SqlParameter("Img", arr),
                    });


                        resultt = (int)cmd.ExecuteNonQuery();

                        if (resultt > 0)
                        {
                            Msg msg = new Msg("Məlumat uğurla daxil olundu", 221);
                            msg.ShowDialog();
                            cmd.Dispose();
                            Application.Restart();
                        }
                        else
                        {
                            Msg msg = new Msg("Xəta baş verdi, məlumat daxil edilmədi", 237);
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
                    if (txtName.Text.ToString().Length < 3)
                    {
                        errorProvider1.SetError(txtName, "a");
                    }
                    if (txtSurname.Text.ToString().Length < 3)
                    {
                        errorProvider1.SetError(txtSurname, "a");
                    }
                    if (!rr)
                    {
                        errorProvider1.SetError(txtEmail, "a");
                    }
                }
                
            }
            else
            {
                Msg msg = new Msg("Parameterlər boş ola bilməz", 237);
                msg.ShowDialog();
            }
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            if (txtSurname.Text.Length > 0 && txtName.Text.Length > 0)
            {
                string second = DateTime.Now.Second.ToString();
                txtUser.Text = txtName.Text + txtSurname.Text.Trim().Substring(0, 1) + second;
            }
        }

        private void Regexp (string re, TextBox tb)
        {
            Regex rgx = new Regex(re);
            if (rgx.IsMatch(tb.Text))
            {
                rr = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
