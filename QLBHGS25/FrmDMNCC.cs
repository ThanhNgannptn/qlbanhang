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

namespace QLBHGS25
{
    public partial class FrmDMNCC : Form
    {
        private SqlDataAdapter adapter;
        private BindingSource bdsource = new BindingSource();
        private DataTable dt = new DataTable();
        public FrmDMNCC()
        {
            InitializeComponent();
        }
        ketnoincc data = new ketnoincc();
        private void bthome_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("VỀ MÀN HÌNH CHÍNH KHÔNG (Y/N)?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
               FrmDMNCC ncc = new FrmDMNCC();
                ncc.ShowDialog();
            }
        }
        private void loadData()
        {
            string str = "SELECT * FROM NCC";
            adapter = new SqlDataAdapter(str, data.getConnect());
            dt = new DataTable();
            adapter.Fill(dt);
            dgvncc.DataSource = dt;
        }
        private void btreload_Click(object sender, EventArgs e)
        {
            loadData();
            tbtimma.Clear();
            tbtimten.Clear();
            rBma.Checked = false;
            rBten.Checked = false;
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            string mancc = tbmancc.Text;
            string tenncc = tbtenncc.Text;
            string sdt = tbsdt.Text;
            string diachi = tbdiachi.Text;
            string email = tbemail.Text;
            string ghichu = tbghichu.Text;

            string query = $"INSERT INTO NCC (MANCC, TENNCC, DIACHI, SDT, EMAIL, GHICHU) VALUES ('{mancc}', '{tenncc}', '{diachi}', '{sdt}', '{email}', '{ghichu}')";
            // Thực thi câu truy vấn
            int rowsAffected = data.ExecutenonQuery(query);
            if (rowsAffected > 0)
            {
                MessageBox.Show("Thêm dữ liệu thành công!");
                LoadDataToDataGridView();
            }
            else
            {
                MessageBox.Show("Thêm dữ liệu thất bại!");
            }
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            string mancc = tbmancc.Text;
            string query = $"DELETE FROM ncc WHERE mancc = '{mancc}'";
            int rowsAffected = data.ExecutenonQuery(query);
            // Kiểm tra và thông báo kết quả
            if (rowsAffected > 0)
            {
                MessageBox.Show("Xóa dữ liệu thành công!");
                LoadDataToDataGridView();
            }
            else
            {
                MessageBox.Show("Xóa dữ liệu thất bại!");
            }
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            string mancc = tbmancc.Text;
            string tenncc = tbtenncc.Text;
            string sdt = tbsdt.Text;
            string diachi = tbdiachi.Text;
            string email = tbemail.Text;
            string ghichu = tbghichu.Text;
            string query = $"UPDATE ncc SET mancc = '{mancc}', TENNCC='{tenncc}', DIACHI = '{diachi}', SDT = '{sdt}', EMAIL = '{email}', Ghichu = '{ghichu}' WHERE mancc = '{mancc}'";
            int rowsAffected = data.ExecutenonQuery(query);
            if (rowsAffected > 0)
            {
                MessageBox.Show("Cập nhật dữ liệu thành công!");
                LoadDataToDataGridView();
            }
            else
            {
                MessageBox.Show("Cập nhật dữ liệu thất bại!");
            }
        }

     

        private void btthoat_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("THOÁT (Y/N)?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void FrmDMNCC_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBHGS25DataSet5.NCC' table. You can move, or remove it, as needed.
            this.nCCTableAdapter.Fill(this.qLBHGS25DataSet5.NCC);
            LoadDataToDataGridView();
            // Gọi hàm để nạp dữ liệu vào BindingSource
            LoadDataToBindingSource();

            // Gán BindingSource vào DataGridView
            //  dgvncc.DataSource = bdsource;
            loadData();
        }
        private void LoadDataToBindingSource()
        {
            bdsource.DataSource = data.ncc();
        }
        private void LoadDataToDataGridView()
        {
            string query = "SELECT* FROM ncc";
            DataTable dataTable = data.ExcuteQuery(query);
            dgvncc.DataSource = dataTable;
        }
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dgvncc.Rows[e.RowIndex];
                tbmancc.Text = row.Cells["MANCC"].Value.ToString();
                tbtenncc.Text = row.Cells["TENNCC"].Value.ToString();
                tbsdt.Text = row.Cells["SDT"].Value.ToString();
                tbdiachi.Text = row.Cells["DIACHI"].Value.ToString();
                tbemail.Text = row.Cells["EMAIL"].Value.ToString();
                tbghichu.Text = row.Cells["GHICHU"].Value.ToString();
            }
        }

        private void bttim_Click(object sender, EventArgs e)
        {
            if (rBma.Checked)
            {

                string mancc = tbtimma.Text;
                string select = "SELECT * FROM NCC WHERE MANCC = @MANCC";
                SqlDataAdapter adapter = new SqlDataAdapter(select, data.getConnect());
                adapter.SelectCommand.Parameters.AddWithValue("@MANCC", mancc);
                dt.Clear();
                adapter.Fill(dt);

            }
            else if (rBten.Checked)
            {

                string tenncc = tbtimten.Text;
                string select = "SELECT * FROM NCC WHERE TENNCC LIKE'%'+@TENNCC+'%'";
                SqlDataAdapter adapter = new SqlDataAdapter(select, data.getConnect());
                adapter.SelectCommand.Parameters.AddWithValue("@TENNCC", tenncc);
                dt.Clear();
                adapter.Fill(dt);

            }
            else
            {
                MessageBox.Show("Chọn một tiêu chí tìm kiếm");
                return;
            }
          
        }

        private void btluu_Click(object sender, EventArgs e, SqlConnection sqlConnection)
        {
            try
            {
                sqlConnection.Open();
                //Câu lệnh
                string insertString = @"
                insert into ncc
                (mancc,tenncc, diachi, sdt, email, ghichu)
                values
                ('" + tbmancc.Text + "','" + tbtenncc.Text + "',N'" + tbdiachi.Text + "','" + "',N'" + tbsdt.Text + "',N'" + tbemail.Text + "',N'" + tbghichu.Text + "'); ";
                //Thể hiển Command mới với query và kết nối
                SqlCommand cmd = new SqlCommand(insertString, sqlConnection);
                //Thực thi ExcuteNonQuery
                cmd.ExecuteNonQuery();
            }
            finally
            {
                //Close the connection
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }
            }
        }
    }
}
