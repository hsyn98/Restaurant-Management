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
    public partial class UserInfo : Form
    {
        MyClient client = new MyClient();
        DataSet ds = new DataSet();
        SqlConnection conn;
        SqlCommand cmd;
        string connStr = null;
        int id;
        int? resultt = null;
        string closed;
        
        public UserInfo(int rowid)
        {
            InitializeComponent();
            connStr = Properties.Settings.Default.ConnectionUrl;
            id = rowid;
        }
        private void UserInfo_Load(object sender, EventArgs e)
        {
            if (id != 0 )
            {
                FillData(id);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.OK;
        }

        private void FillData(int id)
        {
            client = new MyClient();
            ds = new DataSet();

            ds = client.GetDataSet("Select a.Id,a.SurName,a.Name,a.UserName,a.Address,a.PhoneNumber,b.Name As OfficeName,a.Email,a.Img,a.ClosedDate,b.Id As OfficeId"
                + " From Users As a INNER JOIN Office As b  ON a.OfficeId = b.Id Where a.Id =" + id + ";Select Id,Name From Office");

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
                cboOfficeName.SelectedValue = (int)dr["OfficeId"];
                txtDate.Text = (dr["ClosedDate"].ToString());
            }
            if (txtDate.Text.ToString() == "")
            {
                btnActive.Enabled = false;
                btnDeactive.Enabled = true;
                btnPassZero.Enabled = true;
            }
            else
            {
                btnActive.Enabled = true;
                btnDeactive.Enabled = false;
                btnPassZero.Enabled = false;
            }

            ds.Dispose();
        }

        private void btnPassZero_Click(object sender, EventArgs e)
        {
            DialogResult dr_result = MessageBox.Show("Siz bu istifadəçinin parolunun sıfırlanmasına qərar vermisiniz?", "Təsdiq mesajı", MessageBoxButtons.YesNo);
            if (dr_result == DialogResult.Yes)
            {
                try
                {
                    conn = new SqlConnection(connStr);
                    conn.Open();

                    cmd = new SqlCommand();
                    cmd = conn.CreateCommand();

                    cmd = new SqlCommand();
                    cmd = conn.CreateCommand();

                    cmd.CommandText = "Update  Users Set PasswordHash=@PasswordHash Where Id=@Id";

                    cmd.Parameters.AddRange(new SqlParameter[]
                                  {
                        new SqlParameter("@Id", id),
                        new SqlParameter("@PasswordHash", client.PassHash("1234"))
                    });

                    resultt = (int)cmd.ExecuteNonQuery();

                    if (resultt == 1)
                    {
                        Msg msg = new Msg(txtUser.Text.ToString() + " istifadəçinin şifrəsi sıfırlandı", 221);
                        msg.ShowDialog();
                        cmd.Dispose();
                    }
                    else
                    {
                        Msg msg = new Msg("Xəta baş verdi, şifrə sıfırlanmadı", 237);
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
            else if (dr_result == DialogResult.Yes)
            {
                return;
            }
        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            DialogResult dr_result = MessageBox.Show("Siz bu istifadəçini sistemədə aktiv etməyinizə əminsinizmi ?", "Təsdiq mesajı", MessageBoxButtons.YesNo);
            if (dr_result == DialogResult.Yes)
            {
                try
                {
                    conn = new SqlConnection(connStr);
                    conn.Open();

                    cmd = new SqlCommand();
                    cmd = conn.CreateCommand();

                    cmd.CommandText = "Update  Users Set ClosedDate=@ClosedDate Where Id=@Id";

                    cmd.Parameters.AddRange(new SqlParameter[]
                    {
                          new SqlParameter("ClosedDate", DBNull.Value),
                          new SqlParameter("Id", id)
                      });

                    resultt = (int)cmd.ExecuteNonQuery();

                    if (resultt == 1)
                    {
                        Msg msg = new Msg("Məlumat uğurla tamamlandı.", 221);
                        msg.ShowDialog();
                        cmd.Dispose();

                        conn.Close();
                        btnActive.Enabled = false;
                        btnDeactive.Enabled = true;
                        btnPassZero.Enabled = true;
                    }
                    else
                    {
                        Msg msg = new Msg("Xəta baş verdi, məlumat daxil edilmədi", 237);
                        msg.ShowDialog();
                    }
                }
                catch { }
            }
            else if (dr_result == DialogResult.No)
            {
                return;
            }
        }

        private void btnDeactive_Click(object sender, EventArgs e)
        {
            DialogResult dr_result = MessageBox.Show("Siz bu istifadəçini sistemə girişinin bağlanmasına qərar vermisiz?", "Təsdiq mesajı", MessageBoxButtons.YesNo);
            if (dr_result == DialogResult.Yes)
            {
                try
                {
                    conn = new SqlConnection(connStr);
                    conn.Open();

                    cmd = new SqlCommand();
                    cmd = conn.CreateCommand();

                    cmd.CommandText = "Update  Users Set ClosedDate=@ClosedDate Where Id=@Id";


                    cmd.Parameters.AddRange(new SqlParameter[]
                {
              new SqlParameter("ClosedDate",DateTime.Now.ToString("yyyy.MM.dd hh:mm:ss")),
              new SqlParameter("Id", id)
                });

                    resultt = (int)cmd.ExecuteNonQuery();

                    if (resultt == 1)
                    {
                        Msg msg = new Msg("Məlumat uğurla tamamlandı.", 221);
                        msg.ShowDialog();

                        cmd.Dispose();
                      
                        conn.Close();
                        btnDeactive.Enabled = false;
                        btnActive.Enabled = true;
                        btnPassZero.Enabled = false;
                    }
                    else
                    {
                        Msg msg = new Msg("Xəta baş verdi, məlumat daxil edilmədi", 237);
                        msg.ShowDialog();
                    }
                }
                catch { }
            }
            else if (dr_result == DialogResult.No)
            {
                return;
            }
        }
    }
}
