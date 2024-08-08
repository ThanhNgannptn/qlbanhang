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
    public partial class FrmMainNV : Form
    {
        public FrmMainNV()
        {
            InitializeComponent();
        }

        private void FrmMainNV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBHGS25DataSet24.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.qLBHGS25DataSet24.KhachHang);
            // TODO: This line of code loads data into the 'qLBHGS25DataSet23.SanPham' table. You can move, or remove it, as needed.
            this.sanPhamTableAdapter.Fill(this.qLBHGS25DataSet23.SanPham);
            // TODO: This line of code loads data into the 'qLBHGS25DataSet22.HoaDon' table. You can move, or remove it, as needed.
            this.hoaDonTableAdapter.Fill(this.qLBHGS25DataSet22.HoaDon);

            date.Text = "Hôm nay: " + DateTime.Now.ToShortDateString();
            time.Text = System.DateTime.Now.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rBHD.Checked == true)
            {
                FrmHoaDon a=new FrmHoaDon();
                a.ShowDialog();
            }
            else if (rBSP.Checked == true)
            {
                FrmDanhmucSP sp = new FrmDanhmucSP();
                sp.ShowDialog();
            }
            else if (rBKH.Checked==true)
            {
                FrmKhachHang b=new FrmKhachHang();
                b.ShowDialog();
            }
            else if (rBINF.Checked==true)
            {
                FrmThayDoiInf inf = new FrmThayDoiInf();
                inf.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn vai trò để tiếp tục!");
            }
        }

        private void danhMụcNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmThayDoiInf inf = new FrmThayDoiInf();
            inf.ShowDialog();
        }

        private void quảnLýHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHoaDon a = new FrmHoaDon();
            a.ShowDialog();
        }

        private void quảnLýSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDanhmucSP sp = new FrmDanhmucSP();
            sp.ShowDialog();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKhachHang b = new FrmKhachHang();
            b.ShowDialog();
        }

        private void toolSthoat_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("THOÁT (Y/N)?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void toolSdanhmucsp_Click(object sender, EventArgs e)
        {
            FrmDanhmucSP sp = new FrmDanhmucSP();
            sp.ShowDialog();
        }

        private void lậpHóaĐơnInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHoaDon a = new FrmHoaDon();
            a.ShowDialog();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDangNhap dn=new FrmDangNhap();
            dn.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("THOÁT (Y/N)?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void toolSDX_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("THOÁT (Y/N)?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void saoLưuDựPhòngDữLiệuBackUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void phụcHồiDữLiệuRestoreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thoátKhỏiChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("THOÁT (Y/N)?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
