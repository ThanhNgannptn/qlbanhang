using QLBHGS25.QLBHGS25DataSet15TableAdapters;
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
    public partial class FrmKhachHang : Form
    {
        private SqlDataAdapter adapter;
        private BindingSource bdsource = new BindingSource();
        private DataTable dt = new DataTable();
        ketnoikh data = new ketnoikh();

        public FrmKhachHang()
        {
            InitializeComponent();
        }

        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBHGS25DataSet16.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.qLBHGS25DataSet16.KhachHang);
            // TODO: This line of code loads data into the 'qLBHGS25DataSet19.LoaiKH' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'qLBHGS25DataSet18.KhachHang' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'qLBHGS25DataSet17.LoaiKH' table. You can move, or remove it, as needed.
            // this.loaiKHTableAdapter.Fill(this.qLBHGS25DataSet17.LoaiKH);
            // TODO: This line of code loads data into the 'qLBHGS25DataSet16.KhachHang' table. You can move, or remove it, as needed.
            //this.khachHangTableAdapter.Fill(this.qLBHGS25DataSet16.KhachHang);
            // TODO: This line of code loads data into the 'qLBHGS25DataSet15.KhachHang' table. You can move, or remove it, as needed.
            //  this.khachHangTableAdapter.Fill(this.qLBHGS25DataSet16.KhachHang);
        }

        private void loadData()
        {
            string str = "SELECT * FROM KHACHHANG";
            adapter = new SqlDataAdapter(str, data.getConnect());
            dt = new DataTable();
            adapter.Fill(dt);
            dgvkh.DataSource = dt;
        }
        private void LoadDataToBindingSource()
        {
            bdsource.DataSource = data.KhachHang();
        }
        private void LoadDataToDataGridView()
        {
            string query = "SELECT* FROM KHACHHANG";
            DataTable dataTable = data.ExcuteQuery(query);
            dgvkh.DataSource = dataTable;
        }
        private void btthem_Click(object sender, EventArgs e)
        {
            string makh = tbmakh.Text;
            string tenkh = tbtenkh.Text;
            string sdt = tbsdt.Text;
            string diachi = tbdc.Text;
            string ghichu = tbghichu.Text;
            string gioitinh = tbgioitinh.Text;
            DateTime ngaysinh = datens.Value;
            string loaikh=cbBKH.Text;

            string query = $"INSERT INTO KHACHHANG (makh, tenkh, maloaikh, ngaysinh, gioitinh,  diachi, sdt, ghichu) VALUES ('{makh}', '{tenkh}', '{loaikh}', '{ngaysinh}', '{gioitinh}',  '{diachi}', '{sdt}', '{ghichu}')";
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

        private void dgvkh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dgvkh.Rows[e.RowIndex];
                tbmakh.Text = row.Cells["MAKH"].Value.ToString();
                tbtenkh.Text = row.Cells["TENKH"].Value.ToString();
                datens.Text = row.Cells["NGAYSINH"].Value.ToString();
                tbgioitinh.Text = row.Cells["GIOITINH"].Value.ToString();
                tbdc.Text = row.Cells["DIACHI"].Value.ToString();
                tbsdt.Text = row.Cells["SDT"].Value.ToString();
                tbghichu.Text = row.Cells["GHICHU"].Value.ToString();
                
            }
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            string makh = tbmakh.Text;
            string tenkh = tbtenkh.Text;
            string sdt = tbsdt.Text;
            string diachi = tbdc.Text;
            string ghichu = tbghichu.Text;
            string gioitinh = tbgioitinh.Text;
            DateTime ngaysinh = datens.Value;
            string loaikh = cbBKH.Text;
            string query = $"UPDATE KHACHHANG SET makh = '{makh}', tenkh='{tenkh}', maloaikh='{loaikh}', ngaysinh='{ngaysinh}', gioitinh='{gioitinh}',DIACHI = '{diachi}', SDT = '{sdt}', Ghichu = '{ghichu}' WHERE makh = '{makh}'";
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
            string makh = tbmakh.Text;
            string query = $"DELETE FROM KHACHHANG WHERE makh = '{makh}'";
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

        private void btthoat_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("THOÁT (Y/N)?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void bthome_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("VỀ MÀN HÌNH CHÍNH CỦA NHÂN VIÊN (Y/N)", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.No)
            {
                FrmMainQL a = new FrmMainQL();
                a.ShowDialog();
            }
            else
            {
                FrmMainNV nv = new FrmMainNV();
                nv.ShowDialog();
            }
        }
    }
}
