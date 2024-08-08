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
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-OEH13DGC;Initial Catalog=QLBHGS25;Integrated Security=True");

        private void btdangnhap_Click(object sender, EventArgs e)
        {
           conn.Open();
            string tk = tbtendn.Text;
            string mk = tbmk.Text;

            try
            {
                if (rBQL.Checked == true)
                {
                    string maq = "100001";
                    string sql = "select * from Users where id= '" + tk + "' and matkhau='" + mk + "' and maquyen='" + maq + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader dta = cmd.ExecuteReader();
                    if (dta.Read() == true)
                    {
                        MessageBox.Show("Đăng nhập thành công");
                        FrmMainQL a = new FrmMainQL();
                        a.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thất bại");
                    }
                }

                else if (rBNV.Checked == true)
                {
                    string maqu = "100002";
                    string sql = "select * from Users where id='" + tk + "' and matkhau='" + mk + "' and maquyen='" + maqu + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader dta = cmd.ExecuteReader();
                    if (dta.Read() == true)
                    {
                        MessageBox.Show("Đăng nhập thành công");
                        FrmMainNV b = new FrmMainNV();
                        b.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn vai trò");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đăng nhập");
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
    }
}
