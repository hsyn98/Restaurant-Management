using Restaurant.AppCode;
using Restaurant.Properties;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Restaurant.Forms
{
    public partial class NewUser : Form
    {
        MyClient client;
        DataSet ds = new DataSet();

        private int id;
        Image myImage = Resources.man;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int Officeid { get; set; }
        public byte[] arr { get; set; }

        public NewUser(int rowid)
        {
            InitializeComponent();
            id = rowid;
            this.Icon = IconExtractor.Extract("shell32.dll", 95, true);
            //btnSave.Image = IconExtractor.Extract("shell32.dll", 301, true).ToBitmap();
            //btnImgAdd.Image = IconExtractor.Extract("shell32.dll", 45, false).ToBitmap();
            //btnImgClear.Image = IconExtractor.Extract("shell32.dll", 31, false).ToBitmap();
        }

        private void NewUser_Load(object sender, EventArgs e)
        {
            if (id != 0)
            {
                EditData(id);
                this.Text= "İstifadəçi";
            }
            else 
                FillCombo();
            this.AcceptButton = btnSave;
        }

        private void FillCombo()
        {
            client = new MyClient();
            ds = new DataSet();

            ds.Tables.Add(client.GetTable("Select Id,Name From Office"));

            cboOfficeName.DataSource = ds.Tables[0].DefaultView;
            cboOfficeName.ValueMember = "Id";
            cboOfficeName.DisplayMember = "Name";
            cboOfficeName.SelectedIndex = 0;
        }

        private void EditData(int id)
        {
            client = new MyClient();
            ds = new DataSet();

            ds=client.GetDataSet("Select a.Id,a.SurName,a.Name,a.UserName,a.Address,a.PhoneNumber,b.Name As OfficeName,a.Email,a.Img,b.Id As OfficeId"
                + " From Users As a INNER JOIN Office As b  ON a.OfficeId = b.Id Where a.Id =" + id+";Select Id,Name From Office");

            cboOfficeName.DataSource = ds.Tables[1].DefaultView;
            cboOfficeName.DisplayMember = "Name";
            cboOfficeName.ValueMember = "Id";

            
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                txtName.Text = (dr["Name"].ToString());
                txtSurname.Text = (dr["SurName"].ToString());
                txtUser.Text = (dr["UserName"].ToString());
                txtAddress.Text = (dr["Address"].ToString());
                txtEmail.Text = (dr["Email"].ToString());
                txtPhone.Text = (dr["PhoneNumber"].ToString());
                imgBox.Image = (dr["Img"] == DBNull.Value ? myImage : Image.FromStream(new MemoryStream((byte[])dr["Img"])));
                cboOfficeName.SelectedValue = (int)dr["OfficeId"];
            }
            
            ds.Dispose();
        }

        private void btnImgClear_Click(object sender, EventArgs e)
        {
            Image myImage = IconExtractor.Extract("shell32.dll", 281, true).ToBitmap();
            imgBox.Image = myImage;
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

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            if (txtSurname.Text.Length > 0 && txtName.Text.Length > 0)
            {
                string second = DateTime.Now.Second.ToString();
                txtUser.Text = txtName.Text + txtSurname.Text.Trim().Substring(0, 1) + second;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text.ToString() != String.Empty && txtSurname.Text.ToString() != String.Empty && txtAddress.Text.ToString() != String.Empty)
            {
                FirstName = txtName.Text;
                LastName = txtSurname.Text;
                UserName = txtUser.Text;
                Address = txtAddress.Text;
                Phone = txtPhone.Text;
                Email = txtEmail.Text;
                Officeid = (int)cboOfficeName.SelectedValue;

                Image img = imgBox.Image;
                ImageConverter converter = new ImageConverter();
                arr = (byte[])converter.ConvertTo(img, typeof(byte[]));

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                Msg msg = new Msg("Parametrlər boş ola bilməz", 237);
                msg.ShowDialog();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
