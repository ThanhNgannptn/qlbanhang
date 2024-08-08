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
    public partial class FrmDanhmucSPKhach : Form
    {
        private SqlDataAdapter adapter;
        private DataTable dt;
        public FrmDanhmucSPKhach()
        {
            InitializeComponent();
        }
        ketnoiDMSP data = new ketnoiDMSP();
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
            DialogResult ch = MessageBox.Show("VỀ MÀN HÌNH CHÍNH KHÔNG (Y/N)?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void bttim_Click(object sender, EventArgs e)
        {
            if (rBMa.Checked)
            {
                string masp = tbtimma.Text;
                string select = "SELECT MASP, TENSP, GIABAN, TRANGTHAI, HSD, NSX, HINH FROM SANPHAM WHERE MASP = @MASP";
                SqlDataAdapter adapter = new SqlDataAdapter(select, data.getConnect());
                adapter.SelectCommand.Parameters.AddWithValue("@MASP", masp);
                dt.Clear();
                adapter.Fill(dt);
            }
            else if (rBTen.Checked)
            {
                string tensp = tbtimten.Text;
                string select = "SELECT MASP, TENSP, GIABAN, TRANGTHAI, HSD, NSX, HINH FROM SANPHAM WHERE TENSP LIKE'%'+@TENSP+'%'";
                SqlDataAdapter adapter = new SqlDataAdapter(select, data.getConnect());
                adapter.SelectCommand.Parameters.AddWithValue("@TENSP", tensp);
                dt.Clear();
                adapter.Fill(dt);
            }
            else
            {
                MessageBox.Show("Chọn một tiêu chí tìm kiếm");
                return;
            }
        }

        private void FrmDanhmucSPKhach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBHGS25DataSet4.LoaiKH' table. You can move, or remove it, as needed.
            this.loaiKHTableAdapter.Fill(this.qLBHGS25DataSet4.LoaiKH);
            // TODO: This line of code loads data into the 'qLBHGS25DataSet3.SanPham' table. You can move, or remove it, as needed.
            this.sanPhamTableAdapter.Fill(this.qLBHGS25DataSet3.SanPham);
            loadData();
        }
        private void loadData()
        {
            string str = "SELECT MASP, TENSP, GIABAN, TRANGTHAI, HSD, NSX, HINH FROM SANPHAM";
            adapter = new SqlDataAdapter(str, data.getConnect());
            dt = new DataTable();
            adapter.Fill(dt);
            dgvSP.DataSource = dt;
        }

        private void btreload_Click(object sender, EventArgs e)
        {
            loadData();
            rBMa.Checked = false;
            rBTen.Checked = false;
            tbtimma.Text = "";
            tbtimten.Text = "";
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (rBMa.Checked)
            {
                string masp = tbtimma.Text;
                string select = "SELECT MASP, TENSP, GIABAN, TRANGTHAI, HSD, NSX, HINH FROM SANPHAM WHERE MASP = @MASP";
                SqlDataAdapter adapter = new SqlDataAdapter(select, data.getConnect());
                adapter.SelectCommand.Parameters.AddWithValue("@MASP", masp);
                dt.Clear();
                adapter.Fill(dt);
            }
            else if (rBTen.Checked)
            {
                string tensp = tbtimten.Text;
                string select = "SELECT MASP, TENSP, GIABAN, TRANGTHAI, HSD, NSX, HINH FROM SANPHAM WHERE TENSP LIKE'%'+@TENSP+'%'";
                SqlDataAdapter adapter = new SqlDataAdapter(select, data.getConnect());
                adapter.SelectCommand.Parameters.AddWithValue("@TENSP", tensp);
                dt.Clear();
                adapter.Fill(dt);
            }
            else
            {
                MessageBox.Show("Chọn một tiêu chí tìm kiếm");
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmHoaDon a=new FrmHoaDon();
            a.ShowDialog();
        }
    }
}
