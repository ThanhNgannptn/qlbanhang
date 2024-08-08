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
    public partial class FrmQLNhap : Form
    {
        public FrmQLNhap()
        {
            InitializeComponent();
        }
        private SqlDataAdapter adapter;
        private BindingSource bdsource = new BindingSource();
        private DataTable dt = new DataTable();
        ketnoiqlnhap data = new ketnoiqlnhap();

        private void FrmQLNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBHGS25DataSet38.qlnhaphang' table. You can move, or remove it, as needed.
            this.qlnhaphangTableAdapter.Fill(this.qLBHGS25DataSet38.qlnhaphang);
            LoadDataToDataGridView();
            // Gọi hàm để nạp dữ liệu vào BindingSource
            LoadDataToBindingSource();

            // Gán BindingSource vào DataGridView
            //  dgvncc.DataSource = bdsource;
            loadData();
        }
        private void loadData()
        {
            string str = "SELECT * FROM qlnhaphang";
            adapter = new SqlDataAdapter(str, data.getConnect());
            dt = new DataTable();
            adapter.Fill(dt);
            dgvnh.DataSource = dt;
        }
        private void LoadDataToBindingSource()
        {
            bdsource.DataSource = data.qlnhaphang();
        }
        private void LoadDataToDataGridView()
        {
            string query = "SELECT* FROM qlnhaphang";
            DataTable dataTable = data.ExcuteQuery(query);
            dgvnh.DataSource = dataTable;
        }
        private void bttim_Click(object sender, EventArgs e)
        {
            if (rBPN.Checked)
            {

                string mapn = tbpn.Text;
                string select = "SELECT * FROM qlnhaphang WHERE mapn = @mapn";
                SqlDataAdapter adapter = new SqlDataAdapter(select, data.getConnect());
                adapter.SelectCommand.Parameters.AddWithValue("@mapn", mapn);
                dt.Clear();
                adapter.Fill(dt);

            }
            else if (rBNV.Checked)
            {

                string manv = tbnv.Text;
                string select = "SELECT * FROM qlnhaphang WHERE manv = @manv";
                SqlDataAdapter adapter = new SqlDataAdapter(select, data.getConnect());
                adapter.SelectCommand.Parameters.AddWithValue("@manv", manv);
                dt.Clear();
                adapter.Fill(dt);

            }
            else if (rBNCC.Checked)
            {

                string mancc = tbncc.Text;
                string select = "SELECT * FROM qlnhaphang WHERE mancc = @mancc";
                SqlDataAdapter adapter = new SqlDataAdapter(select, data.getConnect());
                adapter.SelectCommand.Parameters.AddWithValue("@mancc", mancc);
                dt.Clear();
                adapter.Fill(dt);

            }
            else if (rBSP.Checked)
            {

                string masp = tbsp.Text;
                string select = "SELECT * FROM qlnhaphang WHERE masp = @masp";
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
                FrmDMNCC ncc = new FrmDMNCC();
                ncc.ShowDialog();
            }
        }

        private void btreload_Click(object sender, EventArgs e)
        {
            loadData();
            tbsp.Clear();
            tbnv.Clear();
            tbncc.Clear();
            tbpn.Clear();
            rBPN.Checked = false;
            rBNV.Checked = false;
            rBNCC.Checked = false;
            rBSP.Checked = false;
        }
    }
}
