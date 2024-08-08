using System;
using System.Windows.Forms;

namespace QLBHGS25
{
    public partial class FrmDanhmucSP : Form
    {

        public FrmDanhmucSP()
        {
            InitializeComponent();
        }
        string apppath = System.IO.Path.GetDirectoryName(System.IO.Path.GetDirectoryName(Application.StartupPath)) + "\\Images\\"; //BIẾN TOÀN CỤC LƯU ĐƯỜNG DẪN ĐẾ THƯ MỤC LƯU APP BÀI LÀM NÀY

        private void FrmDanhmucSP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBHGS25DataSet13.LoaiSP' table. You can move, or remove it, as needed.
            this.loaiSPTableAdapter.Fill(this.qLBHGS25DataSet13.LoaiSP);
            // TODO: This line of code loads data into the 'qLBHGS25DataSet12.NCC' table. You can move, or remove it, as needed.
            this.nCCTableAdapter.Fill(this.qLBHGS25DataSet12.NCC);
            // TODO: This line of code loads data into the 'qLBHGS25DataSet11.SanPham' table. You can move, or remove it, as needed.
            this.sanPhamTableAdapter.Fill(this.qLBHGS25DataSet11.SanPham);
            // TODO: This line of code loads data into the 'qLBHGS25DataSet2.LoaiSP' table. You can move, or remove it, as needed.
            //   this.loaiSPTableAdapter.Fill(this.qLBHGS25DataSet2.LoaiSP);
            // TODO: This line of code loads data into the 'qLBHGS25DataSet1.NCC' table. You can move, or remove it, as needed.
            // this.nCCTableAdapter.Fill(this.qLBHGS25DataSet1.NCC);
            // TODO: This line of code loads data into the 'qLBHGS25DataSet.SanPham' table. You can move, or remove it, as needed.
            //this.sanPhamTableAdapter.Fill(this.qLBHGS25DataSet.SanPham);
            // TODO: This line of code loads data into the 'qLBHGS25DataSet2.LoaiSP' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'qLBHGS25DataSet1.NCC' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'qLBHGS25DataSet.SanPham' table. You can move, or remove it, as needed.

        }


        private void btthem_Click(object sender, EventArgs e)
        {
            if (btth.Text == "Thêm")
            {
                pictureBox1.ImageLocation = apppath + "imagechoose.jpg";
                pictureBox1.Click += new EventHandler(pictureBox1_Click);

                tbmasp.Text = "";
                tbtensp.Text = " ";
                tbgiaban.Text = "";
                tbgianhap.Text = " ";
                tbtonkho.Text = " ";
                tbtrangthai.Text = " ";
                tbhsd.Text = "";
                tbghichu.Text = " ";
                btth.Text = "Lưu";
            }
            else
            {
                try
                {

                    sanPhamTableAdapter.Insert(tbmasp.Text, tbtensp.Text, cbBloaisp.SelectedValue.ToString(), cbBncc.SelectedValue.ToString(), double.Parse(tbgianhap.Text), double.Parse(tbgiaban.Text), datensx.Value, tbhsd.Text, int.Parse(tbtonkho.Text), tbtrangthai.Text, apppath + tbmasp.Text.Trim() + imagechoose, tbghichu.Text);
                    MessageBox.Show("THÊM XONG, XEM ĐI");
                }
                catch (System.Exception ex) { MessageBox.Show("Lỗi thêm SP mới : " + ex.Message); }

                try
                {
                    this.sanPhamTableAdapter.Fill(this.qLBHGS25DataSet11.SanPham);
                }
                catch (System.Exception) { }

                btth.Text = "Thêm";

            }
        }

        private void btsua_Click(object sender, EventArgs e)
        {


        }



        private void btxoa_Click(object sender, EventArgs e)
        {


        }




        private void btluu_Click(object sender, EventArgs e)
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


        private void bthome_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("VỀ MÀN HÌNH CHÍNH CỦA NHÂN VIÊN (Y/N)", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.No)
            {
                FrmMainQL a = new FrmMainQL();
                a.ShowDialog();
            }
            else
            {
                FrmMainNV nv=new FrmMainNV();
                nv.ShowDialog();
            }

        }
        static string oldimage = "", imagechoose = "";
        private void btth_Click(object sender, EventArgs e)
        {

            if (btth.Text == "Thêm")
            {
                pictureBox1.ImageLocation = apppath + "imagechoose.jpg";
                pictureBox1.Click += new EventHandler(pictureBox1_Click);
                tbmasp.Text = "";
                tbtensp.Text = " ";
                tbgiaban.Text = "";
                tbgianhap.Text = " ";
                tbtonkho.Text = " ";
                tbtrangthai.Text = " ";
                tbhsd.Text = "";
                tbghichu.Text = " ";
                btth.Text = "Lưu";
            }
            else
            {
                try
                {

                    sanPhamTableAdapter.Insert(tbmasp.Text, tbtensp.Text, cbBloaisp.SelectedValue.ToString(), cbBncc.SelectedValue.ToString(), double.Parse(tbgianhap.Text), double.Parse(tbgiaban.Text), datensx.Value, tbhsd.Text, int.Parse(tbtonkho.Text), tbtrangthai.Text, apppath + tbmasp.Text.Trim() + imagechoose, tbghichu.Text);
                    MessageBox.Show("Đã thêm");
                }
                catch (System.Exception ex) { MessageBox.Show("Lỗi thêm SP mới : " + ex.Message); }

                try
                {
                    this.sanPhamTableAdapter.Fill(this.qLBHGS25DataSet11.SanPham);
                }
                catch (System.Exception) { }

                btth.Text = "Thêm";
            }

        }
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (btth.Text == "Thêm")
            {
                pictureBox1.ImageLocation = apppath + "imagechoose.jpg";
                pictureBox1.Click += new EventHandler(pictureBox1_Click);
                tbmasp.Text = "";
                tbtensp.Text = " ";
                tbgiaban.Text = "";
                tbgianhap.Text = " ";
                tbtonkho.Text = " ";
                tbtrangthai.Text = " ";
                tbhsd.Text = "";
                tbghichu.Text = " ";
                btth.Text = "Lưu";
            }
            else
            {
                try
                {

                    sanPhamTableAdapter.Insert(tbmasp.Text, tbtensp.Text, cbBloaisp.SelectedValue.ToString(), cbBncc.SelectedValue.ToString(), double.Parse(tbgianhap.Text), double.Parse(tbgiaban.Text), datensx.Value, tbhsd.Text, int.Parse(tbtonkho.Text), tbtrangthai.Text, apppath + tbmasp.Text.Trim() + imagechoose, tbghichu.Text);
                    MessageBox.Show("Đã thêm");
                }
                catch (System.Exception ex) { MessageBox.Show("Lỗi thêm sản phẩm mới : " + ex.Message); }

                try
                {
                    this.sanPhamTableAdapter.Fill(this.qLBHGS25DataSet11.SanPham);
                }
                catch (System.Exception) { }

                btth.Text = "Thêm";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult ch = openFileDialog1.ShowDialog();
            if (ch == DialogResult.OK)
            {
                imagechoose = System.IO.Path.GetFileName(openFileDialog1.FileName);
                try
                {
                    System.IO.File.Copy(openFileDialog1.FileName, apppath + tbmasp.Text.Trim() + imagechoose, true);
                }
                catch (System.Exception ex) { MessageBox.Show("Có lỗi sao chép hình vào thư mục của App" + ex.Message); }
            }
        }

        private void btx_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Xóa sản phẩm có mã " + tbmasp.Text.Trim() + " không(Y / N) ? ", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //B2: XÓA
            if (ch == DialogResult.Yes)
            {
                try
                {
                   sanPhamTableAdapter.Delete(tbmasp.Text.Trim());
                    MessageBox.Show("Đã xóa !");
                    DialogResult c = MessageBox.Show("Có xóa luôn hình không?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (c == DialogResult.No)
                    {
                        try
                        {
                            oldimage = System.IO.Path.GetFileName(pictureBox1.ImageLocation); //Lấy tên hình cũ 
                            System.IO.File.Copy(pictureBox1.ImageLocation, apppath + "z\\" + oldimage);
                            MessageBox.Show("Hình cũ copy vào thư mục D:\\QLBHGS25.0\\QLBHGS25\\Images\\ nha !");
                        }
                        catch (System.Exception ex) { MessageBox.Show("Lỗi Lưu hình cũ vào thư mục z: " + ex.Message); }
                    }
                    else
                    {
                        MessageBox.Show("Xóa hình cũ nha !");
                    }
                    System.IO.File.Delete(pictureBox1.ImageLocation);

                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Có lỗi xóa sản phẩm " + ex.Message);
                   
                }
            }
            try
            {
                this.sanPhamTableAdapter.Fill(this.qLBHGS25DataSet11.SanPham);
            }
            catch (System.Exception) { }
       
    }

        private void bts_Click(object sender, EventArgs e)
        {
            
            if (bts.Text == "Sửa")
            {
                oldimage = pictureBox1.ImageLocation;
              pictureBox1.ImageLocation = apppath + "imagechoose.jpg"; 
              pictureBox1.Click += new EventHandler(pictureBox1_Click);
                                                                               
                MessageBox.Show("Nhập các thông tin muốn sửa vào các ô textbox");
                bts.Text = "Lưu";
            }
            else
            {
                if (imagechoose == "") imagechoose = oldimage; 
             
                try
                { 
                   sanPhamTableAdapter.Update (tbtensp.Text, cbBloaisp.SelectedValue.ToString(), cbBncc.SelectedValue.ToString(), double.Parse(tbgianhap.Text), double.Parse(tbgiaban.Text), datensx.Text, tbhsd.Text, int.Parse(tbtonkho.Text), tbtrangthai.Text, imagechoose, tbghichu.Text, tbmasp.Text);

                    MessageBox.Show("Đã sửa!");
                  pictureBox1.ImageLocation = "";
                }
                catch (System.Exception ex) { MessageBox.Show("Có lỗi sửa chữa thông tin sản phẩm " + ex.Message); }
                bts.Text = "Sửa";
              
                try
                {
                    this.sanPhamTableAdapter.Fill(this.qLBHGS25DataSet11.SanPham);
                }
                catch (System.Exception) { } 
            }
        }
    }
}




