using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBHGS25
{
    public partial class FrmMainQL : Form
    {
        public FrmMainQL()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FrmMainQL_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBHGS25DataSet33.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter1.Fill(this.qLBHGS25DataSet33.KhachHang);
            // TODO: This line of code loads data into the 'qLBHGS25DataSet32.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.qLBHGS25DataSet32.KhachHang);
            // TODO: This line of code loads data into the 'qLBHGS25DataSet28.HoaDon' table. You can move, or remove it, as needed.
            this.hoaDonTableAdapter.Fill(this.qLBHGS25DataSet28.HoaDon);
            // TODO: This line of code loads data into the 'qLBHGS25DataSet27.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.qLBHGS25DataSet27.NhanVien);
            // TODO: This line of code loads data into the 'qLBHGS25DataSet26.NCC' table. You can move, or remove it, as needed.
            this.nCCTableAdapter.Fill(this.qLBHGS25DataSet26.NCC);
            // TODO: This line of code loads data into the 'qLBHGS25DataSet25.SanPham' table. You can move, or remove it, as needed.
            this.sanPhamTableAdapter.Fill(this.qLBHGS25DataSet25.SanPham);

            date.Text = "Hôm nay: " + DateTime.Now.ToShortDateString();
            time.Text = System.DateTime.Now.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rBHD.Checked == true)
            {
                FrmHoaDon a = new FrmHoaDon();
                a.ShowDialog();
            }
            else if (rBSP.Checked == true)
            {
                FrmDanhmucSP sp = new FrmDanhmucSP();
                sp.ShowDialog();
            }
            else if (rBKH.Checked == true)
            {
                FrmKhachHang b = new FrmKhachHang();
                b.ShowDialog();
            }
            else if (rBNCC.Checked == true)
            {
                FrmDMNCC n = new FrmDMNCC();
                n.ShowDialog();
            }
            else if (rBNV.Checked == true)
            {
                FrmDMNV nv = new FrmDMNV();
                nv.ShowDialog();
            }
            else if (rbnh.Checked==true)
            {
                FrmQLNhap a = new FrmQLNhap();
                a.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn vai trò để tiếp tục!");
            }
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            FrmPhieuThanhToan a = new FrmPhieuThanhToan();
            a.ShowDialog();
        }
    }
}
