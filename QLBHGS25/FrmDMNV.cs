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
    public partial class FrmDMNV : Form
    {
        private SqlDataAdapter adapter;
        private BindingSource bdsource = new BindingSource();
        private DataTable dt = new DataTable();
        public FrmDMNV()
        {
            InitializeComponent();
        }
        ketnoinv data = new ketnoinv();
        private void FrmDMNV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBHGS25DataSet36.ChucVu' table. You can move, or remove it, as needed.
            this.chucVuTableAdapter.Fill(this.qLBHGS25DataSet36.ChucVu);
            // TODO: This line of code loads data into the 'qLBHGS25DataSet35.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.qLBHGS25DataSet35.NhanVien);
            // TODO: This line of code loads data into the 'qLBHGS25DataSet34.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.qLBHGS25DataSet35.NhanVien);
            // TODO: This line of code loads data into the 'qLBHGS25DataSet7.ChucVu' table. You can move, or remove it, as needed.
            this.chucVuTableAdapter.Fill(this.qLBHGS25DataSet36.ChucVu);
            // TODO: This line of code loads data into the 'qLBHGS25DataSet6.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.qLBHGS25DataSet35.NhanVien);
            LoadDataToDataGridView();
            // Gọi hàm để nạp dữ liệu vào BindingSource
            LoadDataToBindingSource();

            // Gán BindingSource vào DataGridView
            //  dgvncc.DataSource = bdsource;
            loadData();
        }
        private void loadData()
        {
            string str = "SELECT * FROM NHANVIEN";
            adapter = new SqlDataAdapter(str, data.getConnect());
            dt = new DataTable();
            adapter.Fill(dt);
            dgvnv.DataSource = dt;
        }
        private void bthome_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("VỀ MÀN HÌNH CHÍNH KHÔNG (Y/N)?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                FrmDMNCC ncc = new FrmDMNCC();
                ncc.ShowDialog();
            }
        }
        private void LoadDataToBindingSource()
        {
            bdsource.DataSource = data.NHANVIEN();
        }
        private void LoadDataToDataGridView()
        {
            string query = "SELECT* FROM NHANVIEN";
            DataTable dataTable = data.ExcuteQuery(query);
            dgvnv.DataSource = dataTable;
        }
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dgvnv.Rows[e.RowIndex];
                tbmanv.Text = row.Cells["MANV"].Value.ToString();
                tbtennv.Text = row.Cells["TENNV"].Value.ToString();
                datens.Text = row.Cells["NGAYSINH"].Value.ToString();
                tbgioitinh.Text = row.Cells["GIOITINH"].Value.ToString();
                datengaylam.Text = row.Cells["NGAYVAOLAM"].Value.ToString();
                tbdc.Text = row.Cells["DIACHI"].Value.ToString();
                tbsdt.Text = row.Cells["SDT"].Value.ToString();
                tbghichu.Text = row.Cells["GHICHU"].Value.ToString();

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

        private void btthem_Click(object sender, EventArgs e)
        {
            string manv = tbmanv.Text;
            string tennv = tbtennv.Text;
            string sdt = tbsdt.Text;
            string diachi = tbdc.Text;
            string ghichu = tbghichu.Text;
            string gioitinh = tbgioitinh.Text;
            DateTime ngaylam = datengaylam.Value;
            DateTime ngaysinh = datens.Value;
            string macv = cbBCV.Text;

            string query = $"INSERT INTO NHANVIEN (manv, tennv, macv, ngaysinh, gioitinh, ngayvaolam, diachi, sdt, ghichu) VALUES ('{manv}', '{tennv}', '{macv}', '{ngaysinh}', '{gioitinh}', '{ngaylam}', '{diachi}', '{sdt}', '{ghichu}')";
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

        private void btsua_Click(object sender, EventArgs e)
        {
            string manv = tbmanv.Text;
            string tennv = tbtennv.Text;
            string sdt = tbsdt.Text;
            string diachi = tbdc.Text;
            string ghichu = tbghichu.Text;
            string gioitinh = tbgioitinh.Text;
            DateTime ngaylam = datengaylam.Value;
            DateTime ngaysinh = datens.Value;
            string macv = cbBCV.Text;
            string query = $"UPDATE NHANVIEN SET manv = '{manv}', tennv='{tennv}', macv='{macv}', ngaysinh='{ngaysinh}', gioitinh='{gioitinh}',ngayvaolam='{ngaylam}', DIACHI = '{diachi}', SDT = '{sdt}', Ghichu = '{ghichu}' WHERE manv = '{manv}'";
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

        private void btxoa_Click(object sender, EventArgs e)
        {
            string manv = tbmanv.Text;
            string query = $"DELETE FROM NHANVIEN WHERE manv = '{manv}'";
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

       

        private void btreload_Click(object sender, EventArgs e)
        {
            loadData();
            tbtimma.Clear();
            tbtimten.Clear();
            rBma.Checked = false;
            rBten.Checked = false;
        }

        private void bttim_Click(object sender, EventArgs e)
        {
            if (rBma.Checked)
            {

                string manv = tbtimma.Text;
                string select = "SELECT * FROM NHANVIEN WHERE manv = @manv";
                SqlDataAdapter adapter = new SqlDataAdapter(select, data.getConnect());
                adapter.SelectCommand.Parameters.AddWithValue("@manv", manv);
                dt.Clear();
                adapter.Fill(dt);

            }
            else if (rBten.Checked)
            {

                string tennv = tbtimten.Text;
                string select = "SELECT * FROM NHANVIEN WHERE tennv LIKE'%'+@tennv+'%'";
                SqlDataAdapter adapter = new SqlDataAdapter(select, data.getConnect());
                adapter.SelectCommand.Parameters.AddWithValue("@tennv", tennv);
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
                (manv, tennv, macv, ngaysinh, gioitinh, ngayvaolam, diachi, sdt, ghichu)
                values
                ('" + tbmanv.Text + "','" + tbtennv.Text + "',N'" + cbBCV.Text + "','" + datens.Value + "','" + tbgioitinh.Text + "','" + datengaylam.Value + "','" + tbdc.Text + "','" + "',N'" + tbsdt.Text + "',N'" + tbghichu.Text + "'); ";
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
