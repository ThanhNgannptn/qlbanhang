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
    public partial class FrmGiaoDien : Form
    {
        public FrmGiaoDien()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rBNV.Checked == true)
            {
                
                FrmDangNhap dn = new FrmDangNhap();
                dn.ShowDialog();
            }
            else if (rBKhach.Checked == true)
            {
                FrmDanhmucSPKhach spk = new FrmDanhmucSPKhach();
                spk.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn vai trò để tiếp tục!");
            }
        }

        private void FrmGiaoDien_Load(object sender, EventArgs e)
        {
            date.Text = "Hôm nay: " + DateTime.Now.ToShortDateString();
            time.Text = System.DateTime.Now.ToLongTimeString();
        }

        private void toolSDangnhap_Click(object sender, EventArgs e)
        {
            FrmDangNhap dn = new FrmDangNhap();
            dn.ShowDialog();
        }

        private void lậpPhiếuTínhTiềnBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDangNhap dn = new FrmDangNhap();
            dn.ShowDialog();
        }

        private void lậpHóaĐơnInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDangNhap dn = new FrmDangNhap();
            dn.ShowDialog();
        }

        private void thốngKêCácHóaĐơnTheoBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDangNhap dn = new FrmDangNhap();
            dn.ShowDialog();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDangNhap dn = new FrmDangNhap();
            dn.ShowDialog();
        }

        private void quảnLýTàiKhoảnNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDangNhap dn = new FrmDangNhap();
            dn.ShowDialog();
        }

        private void saoLưuDựPhòngDữLiệuBackUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDangNhap dn = new FrmDangNhap();
            dn.ShowDialog();
        }

        private void phụcHồiDữLiệuRestoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDangNhap dn = new FrmDangNhap();
            dn.ShowDialog();
        }

        private void thoátKhỏiChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("THOÁT (Y/N)?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void danhMụcLoạiSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDangNhap dn = new FrmDangNhap();
            dn.ShowDialog();
        }

        private void danhMụcNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDangNhap dn = new FrmDangNhap();
            dn.ShowDialog();
        }

        private void danhMụcNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDangNhap dn = new FrmDangNhap();
            dn.ShowDialog();
        }

        private void toolStinhtien_Click(object sender, EventArgs e)
        {
            FrmDangNhap dn = new FrmDangNhap();
            dn.ShowDialog();
        }

        private void toolSthoat_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("THOÁT (Y/N)?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        int x;
        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void rBNV_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x = lbtittle.Location.X;
            x--;
            lbtittle.Location = new Point(x, lbtittle.Location.Y);
            if (x == 0)
            {
                FrmGiaoDien fr = new FrmGiaoDien();
                x = fr.Size.Width;
            }
        }
    }
}
