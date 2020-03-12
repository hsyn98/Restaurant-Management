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
    public partial class Tables : Form
    {
        MyClient client;
        DataSet ds = new DataSet();
        SqlConnection conn;
        SqlCommand cmd;
        string connStr = null;
        DataGridViewRow selectedRow;
        private int id;
        int? resultt = null;
        bool type = true;

        public Tables()
        {
            InitializeComponent();
            connStr = Properties.Settings.Default.ConnectionUrl;
        }

        private void Tables_Load(object sender, EventArgs e)
        {
            ShowTable();
        }

        private void ShowTable()
        {
            client = new MyClient();
            ds = new DataSet();

            ds = client.GetDataSet("Select a.Id,b.Name As GroupName,a.Name,a.Number,IIf(a.Type=0, 'Mebleg','Faiz') As Type,a.Amount,a.Status" +
                " From Tables As a INNER JOIN TableGroup As b ON a.GroupId  = b.Id Order by a.Status DESC");

            dgvTables.DataSource = ds.Tables[0].DefaultView;
        }

        private void tsbtnNew_Click(object sender, EventArgs e)
        {
            var newuser = new NewTable(0);
            var result = newuser.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    conn = new SqlConnection(connStr);
                    conn.Open();

                    cmd = new SqlCommand();
                    cmd = conn.CreateCommand();

                    cmd.CommandText = "Insert Into Tables (Name,GroupId,Number,Amount,Type,Status) Values (@Name,@GroupId,@Number,@Amount,@Type,@Status)";

                    cmd.Parameters.AddRange(new SqlParameter[]
                    {
                        new SqlParameter("Name", newuser.name),
                        new SqlParameter("GroupId", newuser.groupid),
                        new SqlParameter("Number", newuser.number),
                        new SqlParameter("Amount", newuser.amount),
                        new SqlParameter("Type", newuser.amounttype),
                        new SqlParameter("Status", newuser.status)
                    });

                    resultt = (int)cmd.ExecuteNonQuery();

                    if (resultt > 0)
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
            var newuser = new NewTable(id);
            var result = newuser.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    conn = new SqlConnection(connStr);
                    conn.Open();

                    cmd = new SqlCommand();
                    cmd = conn.CreateCommand();

                    cmd.CommandText = "Update  Tables Set Name=@Name,GroupId=@GroupId,Number=@Number,Amount=@Amount,Type=@Type,Status=@Status Where Id=@Id";

                    cmd.Parameters.AddRange(new SqlParameter[]
                    {
                        new SqlParameter("@Id", id),
                        new SqlParameter("@Name", newuser.name),
                        new SqlParameter("@GroupId", newuser.groupid),
                        new SqlParameter("@Number", newuser.number),
                        new SqlParameter("@Amount", newuser.amount),
                        new SqlParameter("@Type", newuser.amounttype),
                        new SqlParameter("@Status", newuser.status)
                    });

                    resultt = (int)cmd.ExecuteNonQuery();

                    if (resultt == 1)
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

                    cmd.CommandText = "Update  Tables Set Status=0 Where Id=@Id";


                    cmd.Parameters.AddRange(new SqlParameter[]
                {
              new SqlParameter("Id", id)
                });

                    resultt = (int)cmd.ExecuteNonQuery();

                    if (resultt == 1)
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

                    cmd.CommandText = "Update  Tables Set Status=1 Where Id=@Id";


                    cmd.Parameters.AddRange(new SqlParameter[]
                {
              new SqlParameter("Id", id)
                });

                    resultt = (int)cmd.ExecuteNonQuery();

                    if (resultt == 1)
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

        private void dgvTables_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (((DataGridView)sender).RowHeadersVisible)
            {
                string strRowNumber = (e.RowIndex + 1).ToString();
                SizeF size = e.Graphics.MeasureString(strRowNumber, ((DataGridView)sender).Font);
                Brush b = SystemBrushes.ControlText;
                e.Graphics.DrawString(strRowNumber, ((DataGridView)sender).Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
            }
        }

        private void dgvTables_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTables.SelectedRows.Count > 0)
            {
                int index = dgvTables.SelectedCells[0].RowIndex;
                selectedRow = dgvTables.Rows[index];

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

        private void dgvTables_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvTables.Columns[e.ColumnIndex].Name == "Status")
            {
                if (e.Value.ToString() == "False")
                {
                    dgvTables.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
