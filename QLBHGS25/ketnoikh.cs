using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBHGS25
{
    internal class ketnoikh
    {
        private string connectstring = @"Data Source=LAPTOP-OEH13DGC;Initial Catalog=QLBHGS25;Integrated Security=True";
        public SqlConnection getConnect()
        {
            SqlConnection conn = new SqlConnection(connectstring);
            conn.Open();
            return conn;
        }

        public DataTable KhachHang()
        {
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM KHACHHANG", getConnect());
            adapter.Fill(data);
            return data;
        }
        public int ExecutenonQuery(string query)
        {
            int data = 0;
            using (SqlConnection Ketnoi = new SqlConnection(connectstring))
            {
                Ketnoi.Open();
                SqlCommand thucthi = new SqlCommand(query, Ketnoi);
                data = thucthi.ExecuteNonQuery();
                Ketnoi.Close();
            }
            return data;
        }

        public DataTable ExcuteQuery(string query)
        {
            DataTable dt = new DataTable();
            using (SqlConnection Ketnoi = new SqlConnection(connectstring))
            {
                Ketnoi.Open();
                SqlCommand thucthi = new SqlCommand(query, Ketnoi);
                SqlDataAdapter laydulieu = new SqlDataAdapter(thucthi);
                laydulieu.Fill(dt);
                Ketnoi.Close();
            }
            return dt;
        }
    }
}
