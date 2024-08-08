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
    public partial class FrmCTHD : Form
    {
        public FrmCTHD()
        {
            InitializeComponent();
        }
        private SqlDataAdapter adapter;
        private BindingSource bdsource = new BindingSource();
        private DataTable dt = new DataTable();
        ketnoicthd data = new ketnoicthd();
        private void loadData()
        {
            string str = "SELECT * FROM CTHD";
            adapter = new SqlDataAdapter(str, data.getConnect());
            dt = new DataTable();
            adapter.Fill(dt);
            dgvcthd.DataSource = dt;
        }
        private void LoadDataToBindingSource()
        {
            bdsource.DataSource = data.cthd();
        }
        private void LoadDataToDataGridView()
        {
            string query = "SELECT* FROM CTHD";
            DataTable dataTable = data.ExcuteQuery(query);
            dgvcthd.DataSource = dataTable;
        }
        private void FrmCTHD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBHGS25DataSet21.HoaDon' table. You can move, or remove it, as needed.
            this.hoaDonTableAdapter.Fill(this.qLBHGS25DataSet21.HoaDon);
            // TODO: This line of code loads data into the 'qLBHGS25DataSet20.SanPham' table. You can move, or remove it, as needed.
            this.sanPhamTableAdapter.Fill(this.qLBHGS25DataSet20.SanPham);
            // TODO: This line of code loads data into the 'qLBHGS25DataSet18.CTHD' table. You can move, or remove it, as needed.
            this.cTHDTableAdapter.Fill(this.qLBHGS25DataSet18.CTHD);

        }

        private void bttao_Click(object sender, EventArgs e)
        {
            string mahd = cbBmahd.Text;
            string masp = cbBmasp.Text;
            string soluong = nrsl.Text;
            string query = $"INSERT INTO CTHD (mahd, masp, soluong) VALUES ('{mahd}', '{masp}', '{soluong}')";
            // Thực thi câu truy vấn
            int rowsAffected = data.ExecutenonQuery(query);
            if (rowsAffected > 0)
            {
                MessageBox.Show("Tạo chi tiết hóa đơn thành công!");
                LoadDataToDataGridView();
            }
            else
            {
                MessageBox.Show("Tạo chi tiết hóa đơn thất bại!");
            }

        }

        private void dgvcthd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dgvcthd.Rows[e.RowIndex];
                cbBmasp.Text = row.Cells["MASP"].Value.ToString();
                cbBmahd.Text = row.Cells["MAHD"].Value.ToString();
                nrsl.Text = row.Cells["SOLUONG"].Value.ToString();
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
                FrmGiaoDien b=new FrmGiaoDien();
                b.ShowDialog();

            }
        }
    }
}
