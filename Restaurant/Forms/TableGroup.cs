using Restaurant.AppCode;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Restaurant.Forms
{
    public partial class TableGroup : Form
    {
        MyClient client;
        DataTable dt;
        SqlConnection conn;
        SqlCommand cmd;
        string connStr = null;
        DataGridViewRow selectedRow;
        private int id;
        int? value = null;
       
        public TableGroup()
        {
            InitializeComponent();
            connStr = Properties.Settings.Default.ConnectionUrl;
        }

        private void TableGroup_Load(object sender, EventArgs e)
        {
            ShowTable();
        }

        private void ShowTable()
        {
            client = new MyClient();
            dt = new DataTable();

            dt = client.GetTable("Select * From TableGroup Order by Status DESC");
            dgvTableGroup.DataSource = dt.DefaultView;

            dgvTableGroup.Columns[0].Width = 50;
        }
        private void tsbtnNew_Click(object sender, EventArgs e)
        {
            var newuser = new NewTableGroup(0);
            var result = newuser.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    conn = new SqlConnection(connStr);
                    conn.Open();

                    cmd = new SqlCommand();
                    cmd = conn.CreateCommand();

                    cmd.CommandText = "Insert Into TableGroup (Name,Status) Values (@Name,@Status)";

                    cmd.Parameters.AddRange(new SqlParameter[]
                    {
                        new SqlParameter("Name", newuser.name),
                        new SqlParameter("Status", newuser.status)
                    });



                    value = (int)cmd.ExecuteNonQuery();

                    if (value > 0)
                    {
                        Msg msg = new Msg("Məlumat uğurla daxil olundu", 221);
                        msg.ShowDialog();
                        cmd.Dispose();
                        ShowTable();
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
            var newuser = new NewTableGroup(id);
            var result = newuser.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    conn = new SqlConnection(connStr);
                    conn.Open();

                    cmd = new SqlCommand();
                    cmd = conn.CreateCommand();

                    cmd.CommandText = "Update  TableGroup Set Name=@Name Where Id=@Id";

                    cmd.Parameters.AddRange(new SqlParameter[]
                    {
                        new SqlParameter("@Id", id),
                        new SqlParameter("@Name", newuser.name),
                    });

                    value = (int)cmd.ExecuteNonQuery();

                    if (value == 1)
                    {
                        Msg msg = new Msg("Məlumat uğurla dəyişdirildi", 221);
                        msg.ShowDialog();
                        cmd.Dispose();
                        ShowTable();
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

        private void dvgtablegroup_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (((DataGridView)sender).RowHeadersVisible)
            {
                string strRowNumber = (e.RowIndex + 1).ToString();
                SizeF size = e.Graphics.MeasureString(strRowNumber, ((DataGridView)sender).Font);
                Brush b = SystemBrushes.ControlText;
                e.Graphics.DrawString(strRowNumber, ((DataGridView)sender).Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
            }
        }

        private void dvgtablegroup_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTableGroup.SelectedRows.Count > 0)
            {
                int index = dgvTableGroup.SelectedCells[0].RowIndex;
                selectedRow = dgvTableGroup.Rows[index];

                id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                if (Convert.ToBoolean(selectedRow.Cells["Status"].Value) == true)
                {
                    tsbtnDeactive.Enabled = true;
                    tsbtnActive.Enabled = false;
                    tsbtnEdit.Enabled = true;
                }
                else
                {
                    tsbtnDeactive.Enabled = false;
                    tsbtnActive.Enabled = true;
                    tsbtnEdit.Enabled = false;
                }
            }
        }

        private void dgvtablegroup_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvTableGroup.Columns[e.ColumnIndex].Name == "Status")
            {
                if (e.Value.ToString() == "False")
                {
                    dgvTableGroup.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
                }
            }
        }

        private void tsbtnDeactive_Click(object sender, EventArgs e)
        {
            DialogResult dr_result = MessageBox.Show("Siz bu masanın bağlanmasına qərar vermisiz?", "Təsdiq mesajı", MessageBoxButtons.YesNo);
            if (dr_result == DialogResult.Yes)
            {
                try
                {
                    conn = new SqlConnection(connStr);
                    conn.Open();

                    cmd = new SqlCommand();
                    cmd = conn.CreateCommand();

                    cmd.CommandText = "Update  TableGroup Set Status=0 Where Id=@Id";


                    cmd.Parameters.AddRange(new SqlParameter[]
                {
              new SqlParameter("Id", id)
                });

                    value = (int)cmd.ExecuteNonQuery();

                    if (value == 1)
                    {
                        Msg msg = new Msg("Məlumat uğurla tamamlandı.", 221);
                        msg.ShowDialog();

                        cmd.Dispose();

                        ShowTable();
                        conn.Close();
                    }
                    else
                    {
                        Msg msg = new Msg("Xəta baş verdi", 237);
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

        private void tsbtnActive_Click(object sender, EventArgs e)
        {
            DialogResult dr_result = MessageBox.Show("Siz bu masanın açılmasına qərar vermisiz?", "Təsdiq mesajı", MessageBoxButtons.YesNo);
            if (dr_result == DialogResult.Yes)
            {
                try
                {
                    conn = new SqlConnection(connStr);
                    conn.Open();

                    cmd = new SqlCommand();
                    cmd = conn.CreateCommand();

                    cmd.CommandText = "Update  TableGroup Set Status=1 Where Id=@Id";


                    cmd.Parameters.AddRange(new SqlParameter[]
                {
              new SqlParameter("Id", id)
                });

                    value = (int)cmd.ExecuteNonQuery();

                    if (value == 1)
                    {
                        Msg msg = new Msg("Məlumat uğurla tamamlandı.", 221);
                        msg.ShowDialog();

                        cmd.Dispose();

                        ShowTable();
                        conn.Close();
                    }
                    else
                    {
                        Msg msg = new Msg("Xəta baş verdi", 237);
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
