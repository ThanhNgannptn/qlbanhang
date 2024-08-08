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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace QLBHGS25
{
    public partial class FrmHoaDon : Form
    {
       
        public FrmHoaDon()
        {
            InitializeComponent();
        }
        private SqlDataAdapter adapter;
        private BindingSource bdsource = new BindingSource();
        private DataTable dt = new DataTable();
        ketnoihd data = new ketnoihd();
        private void loadData()
        {
            string str = "SELECT * FROM HOADON";
            adapter = new SqlDataAdapter(str, data.getConnect());
            dt = new DataTable();
            adapter.Fill(dt);
            dgvhd.DataSource = dt;
        }
        private void LoadDataToBindingSource()
        {
            bdsource.DataSource = data.hd();
        }
        private void LoadDataToDataGridView()
        {
            string query = "SELECT* FROM HOADON";
            DataTable dataTable = data.ExcuteQuery(query);
            dgvhd.DataSource = dataTable;
        }
        private void bttao_Click(object sender, EventArgs e)
        {
           
                string mahd = tbmahd.Text;
                string manv = cbBmanv.Text;
                string makh = cbBmakh.Text;
                DateTime ngaylap = datenl.Value;
                string ghichu= tbghichu.Text;
                string query = $"INSERT INTO HOADON (MaHD,  MaKH,MaNV, NgayLap, GhiChu) VALUES ('{mahd}',  '{makh}', '{manv}','{ngaylap}','{ghichu}')";
                // Thực thi câu truy vấn
                int rowsAffected = data.ExecutenonQuery(query);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Tạo hóa đơn thành công!");
                    LoadDataToDataGridView();
                }
                else
                {
                    MessageBox.Show("Tạo hóa đơn thất bại!");
                }
            
           
        }

        private void FrmHoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBHGS25DataSet31.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.qLBHGS25DataSet31.NhanVien);
            // TODO: This line of code loads data into the 'qLBHGS25DataSet30.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter1.Fill(this.qLBHGS25DataSet30.KhachHang);
            // TODO: This line of code loads data into the 'qLBHGS25DataSet17.HoaDon' table. You can move, or remove it, as needed.
            //this.hoaDonTableAdapter1.Fill(this.qLBHGS25DataSet17.HoaDon);
            // TODO: This line of code loads data into the 'qLBHGS25DataSet29.HoaDon' table. You can move, or remove it, as needed.
            //  this.hoaDonTableAdapter1.Fill(this.qLBHGS25DataSet29.HoaDon);
            // TODO: This line of code loads data into the 'qLBHGS25DataSet17.NhanVien' table. You can move, or remove it, as needed.
            //    this.nhanVienTableAdapter.Fill(this.qLBHGS25DataSet17.NhanVien);
            // TODO: This line of code loads data into the 'qLBHGS25DataSet10.KhachHang' table. You can move, or remove it, as needed.
            //this.khachHangTableAdapter.Fill(this.qLBHGS25DataSet10.KhachHang);
            // TODO: This line of code loads data into the 'qLBHGS25DataSet9.HoaDon' table. You can move, or remove it, as needed.
            //this.hoaDonTableAdapter.Fill(this.qLBHGS25DataSet9.HoaDon);
            // TODO: This line of code loads data into the 'qLBHGS25DataSet14.CTHD' table. You can move, or remove it, as needed.
            // this.cTHDTableAdapter1.Fill(this.qLBHGS25DataSet14.CTHD);
            // TODO: This line of code loads data into the 'qLBHGS25DataSet10.CTHD' table. You can move, or remove it, as needed.
            // this.cTHDTableAdapter.Fill(this.qLBHGS25DataSet10.CTHD);
            // TODO: This line of code loads data into the 'qLBHGS25DataSet9.HoaDon' table. You can move, or remove it, as needed.
            //  this.hoaDonTableAdapter.Fill(this.qLBHGS25DataSet9.HoaDon);
            loadData();
            
        }
    
        private void btkh_Click(object sender, EventArgs e)
        {
            FrmKhachHang a = new FrmKhachHang();
            a.ShowDialog();
        }

        private void dgvhd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dgvhd.Rows[e.RowIndex];
                tbmahd.Text = row.Cells["MAHD"].Value.ToString();
                datenl.Text = row.Cells["NGAYLAP"].Value.ToString();
                cbBmakh.Text = row.Cells["MAKH"].Value.ToString();
                cbBmanv.Text = row.Cells["MANV"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCTHD a=new FrmCTHD();
            a.ShowDialog();
        }

        private void cbBmanv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            string mahd = tbmahd.Text;
            string manv = cbBmanv.Text;
            string makh = cbBmakh.Text;
            DateTime ngaylap = datenl.Value;
            string ghichu = tbghichu.Text;
            string query = $"INSERT INTO HOADON (MaHD,  MaKH,MaNV, NgayLap, GhiChu) VALUES ('{mahd}',  '{makh}', '{manv}','{ngaylap}','{ghichu}')";
            // Thực thi câu truy vấn
            int rowsAffected = data.ExecutenonQuery(query);
            if (rowsAffected > 0)
            {
                MessageBox.Show("Tạo hóa đơn thành công!");
                LoadDataToDataGridView();
            }
            else
            {
                MessageBox.Show("Tạo hóa đơn thất bại!");
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
