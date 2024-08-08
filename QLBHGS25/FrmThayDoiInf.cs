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
    public partial class FrmThayDoiInf : Form
    {
        public FrmThayDoiInf()
        {
            InitializeComponent();
        }
        SqlConnection sqlconn = new SqlConnection(@"Data Source=LAPTOP-OEH13DGC;Initial Catalog=QLBHGS25;Integrated Security=True");
        private void btsua_Click(object sender, EventArgs e)
        {
            try
            {
                sqlconn.Open();
                string UpdateString = @"
                update USERS
                set MATKHAU=
                N'" + tbmk.Text +  "'where MAID'" + tbmaid.Text +"'MANV'"+tbmanv.Text+"'MAQUYEN'"+tbquyen.Text+"';";
                //Thể hiển Command mới với query và kết nối
                SqlCommand cmd = new SqlCommand(UpdateString, sqlconn);
                //Thực thi ExcuteNonQuery
                cmd.ExecuteNonQuery();
            }
            finally
            {
                //Close the connection
                if (sqlconn != null)
                {
                    sqlconn.Close();
                }
            }
        }

        private void btluu_Click(object sender, EventArgs e, SqlConnection sqlConnection)
        {
            try
            {
                sqlConnection.Open();
                //Câu lệnh
                string insertString = @"
                insert into Users
                ( maid, manv, matkhau, maquyen)
                values
                ('" + tbmaid.Text + "','" + tbmanv.Text + "',N'" + tbmk.Text + "','" + tbquyen.Text + "'); ";
                //Thể hiển Command mới với query và kết nối
                SqlCommand cmd = new SqlCommand(insertString, sqlConnection);
                //Thực thi ExcuteNonQuery
                cmd.ExecuteNonQuery();
            }
            finally
            {
                //Close the connection
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }
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
                this.Close();
            }
        }
    }
}
