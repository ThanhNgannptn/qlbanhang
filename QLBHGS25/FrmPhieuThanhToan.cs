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
    public partial class FrmPhieuThanhToan : Form
    {
        private SqlDataAdapter adapter;
        private BindingSource bdsource = new BindingSource();
        private DataTable dt = new DataTable();
        public FrmPhieuThanhToan()
        {
            InitializeComponent();
        }
        ketnoitt data = new ketnoitt();
        private void FrmPhieuThanhToan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBHGS25DataSet37.PhieuThanhToan' table. You can move, or remove it, as needed.
            this.phieuThanhToanTableAdapter.Fill(this.qLBHGS25DataSet37.PhieuThanhToan);
            LoadDataToDataGridView();
            // Gọi hàm để nạp dữ liệu vào BindingSource
            LoadDataToBindingSource();

            // Gán BindingSource vào DataGridView
            //  dgvncc.DataSource = bdsource;
            loadData();
        }
        private void loadData()
        {
            string str = "SELECT * FROM phieuthanhtoan";
            adapter = new SqlDataAdapter(str, data.getConnect());
            dt = new DataTable();
            adapter.Fill(dt);
            dgvtt.DataSource = dt;
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
            bdsource.DataSource = data.Phieuthanhtoan();
        }
        private void LoadDataToDataGridView()
        {
            string query = "SELECT* FROM PhieuThanhToan";
            DataTable dataTable = data.ExcuteQuery(query);
            dgvtt.DataSource = dataTable;
        }
        private void rBma_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rBten_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tbtimma_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbtimten_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttim_Click(object sender, EventArgs e)
        {
            if (rBHD.Checked)
            {

                string mahd = tbhd.Text;
                string select = "SELECT * FROM PhieuThanhToan WHERE mahd = @mahd";
                SqlDataAdapter adapter = new SqlDataAdapter(select, data.getConnect());
                adapter.SelectCommand.Parameters.AddWithValue("@mahd", mahd);
                dt.Clear();
                adapter.Fill(dt);

            }
            else if (rBNV.Checked)
            {

                string manv = tbnv.Text;
                string select = "SELECT * FROM PhieuThanhToan WHERE manv = @manv";
                SqlDataAdapter adapter = new SqlDataAdapter(select, data.getConnect());
                adapter.SelectCommand.Parameters.AddWithValue("@manv", manv);
                dt.Clear();
                adapter.Fill(dt);

            }
            else if (rBKH.Checked)
            {

                string makh = tbkh.Text;
                string select = "SELECT * FROM PhieuThanhToan WHERE makh = @makh";
                SqlDataAdapter adapter = new SqlDataAdapter(select, data.getConnect());
                adapter.SelectCommand.Parameters.AddWithValue("@makh", makh);
                dt.Clear();
                adapter.Fill(dt);

            }
            else if (rBSP.Checked)
            {

                string masp = tbsp.Text;
                string select = "SELECT * FROM PhieuThanhToan WHERE masp = @masp";
                SqlDataAdapter adapter = new SqlDataAdapter(select, data.getConnect());
                adapter.SelectCommand.Parameters.AddWithValue("@masp", masp);
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

        }

        private void dgvtt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("THOÁT (Y/N)?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void bthome_Click_1(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("VỀ MÀN HÌNH CHÍNH KHÔNG (Y/N)?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                FrmDMNCC ncc = new FrmDMNCC();
                ncc.ShowDialog();
            }
        }

        private void btreload_Click(object sender, EventArgs e)
        {
            loadData();
            tbsp.Clear();
            tbnv.Clear();
            tbkh.Clear();
            tbhd.Clear();
            rBHD.Checked = false;
            rBNV.Checked = false;
            rBKH.Checked = false;
            rBSP.Checked = false;

        }
    }
}
