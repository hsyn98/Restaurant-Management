using Restaurant.AppCode;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace Restaurant.Forms
{
    public partial class Users : Form
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
        Image myImage = IconExtractor.Extract("shell32.dll", 281, true).ToBitmap();
        public Users()
        {
            InitializeComponent();
            this.Icon = IconExtractor.Extract("shell32.dll", 86, true);
            connStr = Properties.Settings.Default.ConnectionUrl;
            label1.Image = IconExtractor.Extract("shell32.dll", 209, false).ToBitmap();
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            ShowData();
        }
        private void ShowData()
        {
            client = new MyClient();
            ds = new DataSet();

            ds.Tables.Add(client.GetTable("Select a.Id,a.SurName,a.Name,a.UserName,a.Address,a.PhoneNumber,b.Name As OfficeName,a.Email,a.PasswordHash,a.RoleStr,a.Img,a.CreatedDate,IIf(a.ClosedDate Is Null, 'Aktiv','Deaktiv') As ClosedDate,b.Id As OfficeId"
                + " From Users As a INNER JOIN Office As b  ON a.OfficeId = b.Id"));
            ds.Tables.Add(client.GetTable("Select Id,Name From Office"));

            dgvUsers.DataSource = null;
            dgvUsers.Columns.Clear();

            dgvUsers.DataSource = ds.Tables[0].DefaultView;
            cmbShow.SelectedIndex = 0;
            cmbShow_SelectedIndexChanged(null, null);

            dgvUsers.Columns[0].HeaderText = "Kodu";
            dgvUsers.Columns[1].HeaderText = "Soyadı";
            dgvUsers.Columns[2].HeaderText = "Adı";
            dgvUsers.Columns[3].HeaderText = "Giriş adı";
            dgvUsers.Columns[4].HeaderText = "Ünvanı";
            dgvUsers.Columns[5].HeaderText = "Telefonu";
            dgvUsers.Columns[6].HeaderText = "Ofis";
            dgvUsers.Columns[7].HeaderText = "E-poçt";
            dgvUsers.Columns[8].HeaderText = "Şifrə";
            dgvUsers.Columns[9].HeaderText = "Yetkisi";
            dgvUsers.Columns[10].HeaderText = "Foto";
            dgvUsers.Columns[11].HeaderText = "Daxil olma tarixi";
            dgvUsers.Columns[12].HeaderText = "Status";


            DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            col.HeaderText = "Ümumi";
            col.Name = "column14";
            col.Width = 40;
            col.Text = "...";
            col.DefaultCellStyle.Font = new System.Drawing.Font("Palatino Linotype", 7.5F, FontStyle.Bold);
            col.FlatStyle = FlatStyle.System;
            col.UseColumnTextForButtonValue = true;
            dgvUsers.Columns.Insert(14, col);
            dgvUsers.Columns[14].Width = 40;
            dgvUsers.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvUsers.Columns[12].Width = 60;

            for (int i = 0; i < dgvUsers.Columns.Count; i++)
                if (dgvUsers.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)dgvUsers.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                    break;
                }

            dgvUsers.Columns[10].Width = 60;
            dgvUsers.Columns[8].Width = 50;
            dgvUsers.Columns[0].Width = 40;
            dgvUsers.Columns[13].Visible = false;

            label2.Image = IconExtractor.Extract("shell32.dll", 209, true).ToBitmap();
            
        }

        private void tsbtnNew_Click(object sender, EventArgs e)
        {
            var newuser = new NewUser(0);
            var result = newuser.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    conn = new SqlConnection(connStr);
                    conn.Open();

                    cmd = new SqlCommand();
                    cmd = conn.CreateCommand();

                    cmd.CommandText = "Insert Into Users (Name,Surname,UserName,Address,PhoneNumber,Email,PasswordHash,Img,CreatedDate,OfficeId)"
                            + "Values (@Name,@Surname,@UserName,@Address,@PhoneNumber,@Email,@PasswordHash,@Img,@CreatedDate,@OfficeId)";

                    cmd.Parameters.AddRange(new SqlParameter[]
             {
                        new SqlParameter("Name", newuser.FirstName),
                        new SqlParameter("Surname", newuser.LastName),
                        new SqlParameter("UserName", newuser.UserName),
                        new SqlParameter("Address", newuser.Address),
                        new SqlParameter("PhoneNumber", newuser.Phone),
                        new SqlParameter("Email", newuser.Email),
                        new SqlParameter("PasswordHash", client.PassHash("1234")),
                        new SqlParameter("Img", newuser.arr),
                        new SqlParameter("CreatedDate",DateTime.Now.ToString("yyyy.MM.dd hh:mm:ss")),
                        new SqlParameter("OfficeId", newuser.Officeid)
                });



                        resultt = (int)cmd.ExecuteNonQuery();

                    if (resultt > 0)
                    {
                        Msg msg = new Msg("Məlumat uğurla daxil olundu", 221);
                        msg.ShowDialog();
                        cmd.Dispose();
                        ShowData();
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
        }

        private void tsbtnEdit_Click(object sender, EventArgs e)
        {
            var newuser = new NewUser(id);
            var result = newuser.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    conn = new SqlConnection(connStr);
                    conn.Open();

                    cmd = new SqlCommand();
                    cmd = conn.CreateCommand();

                    cmd.CommandText = "Update  Users Set Name=@Name,Surname=@Surname,UserName=@UserName,Address=@Address,PhoneNumber=@PhoneNumber,Email=@Email,Img=@Img,OfficeId=@OfficeId Where Id=@Id";

                    cmd.Parameters.AddRange(new SqlParameter[]
                                  {
                        new SqlParameter("@Id", id),
                        new SqlParameter("@Name", newuser.FirstName),
                        new SqlParameter("@Surname", newuser.LastName),
                        new SqlParameter("@UserName", newuser.UserName),
                        new SqlParameter("@Address", newuser.Address),
                        new SqlParameter("@PhoneNumber", newuser.Phone),
                        new SqlParameter("@Email", newuser.Email),
                        new SqlParameter("@Img", newuser.arr),
                        new SqlParameter("@OfficeId", newuser.Officeid)
              });

                    resultt = (int)cmd.ExecuteNonQuery();

                    if (resultt == 1)
                    {
                        Msg msg = new Msg(newuser.UserName + " istifadəçinin məlumatı uğurla dəyişdirildi", 221);
                        msg.ShowDialog();
                        cmd.Dispose();
                        ShowData();
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
        }





        private void dgvUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                int index = dgvUsers.SelectedCells[0].RowIndex;
                selectedRow = dgvUsers.Rows[index];

                id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                closed = Convert.ToString(selectedRow.Cells["ClosedDate"].Value);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length > 0)
            {
                if (IsNumeric(txtSearch.Text.ToString()))
                {
                    ds.Tables[0].DefaultView.RowFilter = string.Format("Id = '{0}'", txtSearch.Text);
                }
                else if (IsAlpha(txtSearch.Text.ToString()))
                {
                    ds.Tables[0].DefaultView.RowFilter = string.Format("Name LIKE '%{0}%'", txtSearch.Text.Trim());
                }
            }
            else
            {
                ds.Tables[0].DefaultView.RowFilter = "";
            }

            lblCnt.Text = "Cəmi  sətir sayı : " + dgvUsers.Rows.Count.ToString();
        }

        public bool IsAlpha(string input)
        {
            return Regex.IsMatch(input, @"(?i)^[a-z]+");
        }

        public bool IsNumeric(string input)
        {
            return Regex.IsMatch(input, "[0-9]");
        }

        

        private void tsbtnRole_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Role"] == null)
            {
                client = new MyClient();

                using (var formrole = new Role(id))
                {
                    var dr_result = formrole.ShowDialog();
                    if (dr_result == DialogResult.OK)
                    {
                        string userRole = formrole.role;
                        string userRoleStr = formrole.rolestr;

                        try
                        {
                            conn = new SqlConnection(connStr);
                            conn.Open();

                            cmd = new SqlCommand();
                            cmd = conn.CreateCommand();

                            cmd.CommandText = "Update  Users Set Role=@Role,RoleStr=@RoleStr Where Id=@Id";

                            cmd.Parameters.AddRange(new SqlParameter[]
                 {
              new SqlParameter("Role", userRole),
              new SqlParameter("RoleStr", userRoleStr),
              new SqlParameter("Id", id)
                 });



                            resultt = (int)cmd.ExecuteNonQuery();

                            if (resultt == 1)
                            {
                                Msg msg = new Msg("Məlumat uğurla dəyişdirildi.", 221);
                                msg.ShowDialog();

                                cmd.Dispose();

                                ShowData();
                                conn.Close();
                            }
                            else
                            {
                                Msg msg = new Msg("Xəta baş verdi, məlumat daxil edilmədi", 237);
                                msg.ShowDialog();
                            }
                        }
                        catch { }
                    }
                }
            }

            else
                return;
        }

        private void dgvUsers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvUsers.Columns[e.ColumnIndex].Name == "ClosedDate")
            {
                if (e.Value.ToString() == "Deaktiv")
                {
                    dgvUsers.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
                }
            }
        }

        private void dgvUsers_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (((DataGridView)sender).RowHeadersVisible)
            {
                string strRowNumber = (e.RowIndex + 1).ToString();
                SizeF size = e.Graphics.MeasureString(strRowNumber, ((DataGridView)sender).Font);
                Brush b = SystemBrushes.ControlText;
                e.Graphics.DrawString(strRowNumber, ((DataGridView)sender).Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
            }
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var usrinfo = new UserInfo(Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["Id"].Value));
                var result = usrinfo.ShowDialog();

                if (result == DialogResult.OK)
                {
                    ShowData();
                }
                else
                {
                    ShowData();
                }
            }
        }

        private void cmbShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbShow.SelectedIndex == 0)
            {
                ds.Tables[0].DefaultView.RowFilter = string.Format("Convert(ClosedDate, System.String) = '{0}'", "Aktiv");
            }
            else if (cmbShow.SelectedIndex == 1)
            {
                ds.Tables[0].DefaultView.RowFilter = string.Format("Convert(ClosedDate, System.String) = '{0}'", "Deaktiv");
            }
            else if (cmbShow.SelectedIndex == 2)
            {
                ds.Tables[0].DefaultView.RowFilter = string.Empty;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
