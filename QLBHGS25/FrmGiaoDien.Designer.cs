namespace QLBHGS25
{
    partial class FrmGiaoDien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiaoDien));
            this.rBKhach = new System.Windows.Forms.RadioButton();
            this.rBNV = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolSDangnhap = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolSdanhmucsp = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStinhtien = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolSthoat = new System.Windows.Forms.ToolStripDropDownButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.time = new System.Windows.Forms.ToolStripStatusLabel();
            this.date = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolShethong = new System.Windows.Forms.ToolStripDropDownButton();
            this.đăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýTàiKhoảnNgườiDùngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thiếtLậpThamSốHệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chọnChếĐộMànHìnhLàmViệcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saoLưuDựPhòngDữLiệuBackUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phụcHồiDữLiệuRestoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátKhỏiChươngTrìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSbanhang = new System.Windows.Forms.ToolStripDropDownButton();
            this.lậpPhiếuTínhTiềnBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lậpHóaĐơnInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêCácHóaĐơnTheoBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSdanhmuc = new System.Windows.Forms.ToolStripDropDownButton();
            this.danhMụcLoạiSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcNhàCungCấpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSgioithieu = new System.Windows.Forms.ToolStripDropDownButton();
            this.lbtittle = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rBKhach
            // 
            this.rBKhach.AutoSize = true;
            this.rBKhach.BackColor = System.Drawing.SystemColors.Control;
            this.rBKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBKhach.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rBKhach.Location = new System.Drawing.Point(448, 419);
            this.rBKhach.Name = "rBKhach";
            this.rBKhach.Size = new System.Drawing.Size(101, 33);
            this.rBKhach.TabIndex = 15;
            this.rBKhach.TabStop = true;
            this.rBKhach.Text = "Khách";
            this.rBKhach.UseVisualStyleBackColor = false;
            // 
            // rBNV
            // 
            this.rBNV.AutoSize = true;
            this.rBNV.BackColor = System.Drawing.SystemColors.Control;
            this.rBNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBNV.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rBNV.Location = new System.Drawing.Point(236, 419);
            this.rBNV.Name = "rBNV";
            this.rBNV.Size = new System.Drawing.Size(141, 33);
            this.rBNV.TabIndex = 14;
            this.rBNV.TabStop = true;
            this.rBNV.Text = "Nhân viên";
            this.rBNV.UseVisualStyleBackColor = false;
            this.rBNV.CheckedChanged += new System.EventHandler(this.rBNV_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(688, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 39);
            this.button1.TabIndex = 13;
            this.button1.Text = "Tiếp tục";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSDangnhap,
            this.toolSdanhmucsp,
            this.toolStinhtien,
            this.toolSthoat});
            this.toolStrip2.Location = new System.Drawing.Point(0, 32);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(961, 27);
            this.toolStrip2.TabIndex = 11;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolSDangnhap
            // 
            this.toolSDangnhap.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolSDangnhap.Image = ((System.Drawing.Image)(resources.GetObject("toolSDangnhap.Image")));
            this.toolSDangnhap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSDangnhap.Name = "toolSDangnhap";
            this.toolSDangnhap.Size = new System.Drawing.Size(129, 24);
            this.toolSDangnhap.Text = "ĐĂNG NHẬP";
            this.toolSDangnhap.Click += new System.EventHandler(this.toolSDangnhap_Click);
            // 
            // toolSdanhmucsp
            // 
            this.toolSdanhmucsp.Image = ((System.Drawing.Image)(resources.GetObject("toolSdanhmucsp.Image")));
            this.toolSdanhmucsp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSdanhmucsp.Name = "toolSdanhmucsp";
            this.toolSdanhmucsp.Size = new System.Drawing.Size(201, 24);
            this.toolSdanhmucsp.Text = "DANH MỤC SẢN PHẨM";
            // 
            // toolStinhtien
            // 
            this.toolStinhtien.Image = ((System.Drawing.Image)(resources.GetObject("toolStinhtien.Image")));
            this.toolStinhtien.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStinhtien.Name = "toolStinhtien";
            this.toolStinhtien.Size = new System.Drawing.Size(112, 24);
            this.toolStinhtien.Text = "TÍNH TIỀN";
            this.toolStinhtien.Click += new System.EventHandler(this.toolStinhtien_Click);
            // 
            // toolSthoat
            // 
            this.toolSthoat.Image = ((System.Drawing.Image)(resources.GetObject("toolSthoat.Image")));
            this.toolSthoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSthoat.Name = "toolSthoat";
            this.toolSthoat.Size = new System.Drawing.Size(90, 24);
            this.toolSthoat.Text = "THOÁT";
            this.toolSthoat.Click += new System.EventHandler(this.toolSthoat_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.time,
            this.date});
            this.statusStrip1.Location = new System.Drawing.Point(0, 465);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(961, 26);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // time
            // 
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(39, 20);
            this.time.Text = "time";
            // 
            // date
            // 
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(39, 20);
            this.date.Text = "date";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolShethong,
            this.toolSbanhang,
            this.toolSdanhmuc,
            this.toolSgioithieu});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(961, 32);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolShethong
            // 
            this.toolShethong.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolShethong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngNhậpToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem,
            this.quảnLýTàiKhoảnNgườiDùngToolStripMenuItem,
            this.thiếtLậpThamSốHệThốngToolStripMenuItem,
            this.chọnChếĐộMànHìnhLàmViệcToolStripMenuItem,
            this.saoLưuDựPhòngDữLiệuBackUpToolStripMenuItem,
            this.phụcHồiDữLiệuRestoreToolStripMenuItem,
            this.thoátKhỏiChươngTrìnhToolStripMenuItem});
            this.toolShethong.Image = ((System.Drawing.Image)(resources.GetObject("toolShethong.Image")));
            this.toolShethong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolShethong.Name = "toolShethong";
            this.toolShethong.Size = new System.Drawing.Size(114, 29);
            this.toolShethong.Text = "HỆ THỐNG";
            // 
            // đăngNhậpToolStripMenuItem
            // 
            this.đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            this.đăngNhậpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.đăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(440, 30);
            this.đăngNhậpToolStripMenuItem.Text = "Đăng nhập";
            this.đăngNhậpToolStripMenuItem.Click += new System.EventHandler(this.đăngNhậpToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(440, 30);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // quảnLýTàiKhoảnNgườiDùngToolStripMenuItem
            // 
            this.quảnLýTàiKhoảnNgườiDùngToolStripMenuItem.Name = "quảnLýTàiKhoảnNgườiDùngToolStripMenuItem";
            this.quảnLýTàiKhoảnNgườiDùngToolStripMenuItem.Size = new System.Drawing.Size(440, 30);
            this.quảnLýTàiKhoảnNgườiDùngToolStripMenuItem.Text = "Quản lý tài khoản người dùng";
            this.quảnLýTàiKhoảnNgườiDùngToolStripMenuItem.Click += new System.EventHandler(this.quảnLýTàiKhoảnNgườiDùngToolStripMenuItem_Click);
            // 
            // thiếtLậpThamSốHệThốngToolStripMenuItem
            // 
            this.thiếtLậpThamSốHệThốngToolStripMenuItem.Name = "thiếtLậpThamSốHệThốngToolStripMenuItem";
            this.thiếtLậpThamSốHệThốngToolStripMenuItem.Size = new System.Drawing.Size(440, 30);
            this.thiếtLậpThamSốHệThốngToolStripMenuItem.Text = "Thiết lập tham số hệ thống";
            // 
            // chọnChếĐộMànHìnhLàmViệcToolStripMenuItem
            // 
            this.chọnChếĐộMànHìnhLàmViệcToolStripMenuItem.Name = "chọnChếĐộMànHìnhLàmViệcToolStripMenuItem";
            this.chọnChếĐộMànHìnhLàmViệcToolStripMenuItem.Size = new System.Drawing.Size(440, 30);
            this.chọnChếĐộMànHìnhLàmViệcToolStripMenuItem.Text = "Chọn chế độ màn hình làm việc";
            // 
            // saoLưuDựPhòngDữLiệuBackUpToolStripMenuItem
            // 
            this.saoLưuDựPhòngDữLiệuBackUpToolStripMenuItem.Name = "saoLưuDựPhòngDữLiệuBackUpToolStripMenuItem";
            this.saoLưuDựPhòngDữLiệuBackUpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.saoLưuDựPhòngDữLiệuBackUpToolStripMenuItem.Size = new System.Drawing.Size(440, 30);
            this.saoLưuDựPhòngDữLiệuBackUpToolStripMenuItem.Text = "Sao lưu dự phòng dữ liệu (Back up)";
            this.saoLưuDựPhòngDữLiệuBackUpToolStripMenuItem.Click += new System.EventHandler(this.saoLưuDựPhòngDữLiệuBackUpToolStripMenuItem_Click);
            // 
            // phụcHồiDữLiệuRestoreToolStripMenuItem
            // 
            this.phụcHồiDữLiệuRestoreToolStripMenuItem.Name = "phụcHồiDữLiệuRestoreToolStripMenuItem";
            this.phụcHồiDữLiệuRestoreToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.phụcHồiDữLiệuRestoreToolStripMenuItem.Size = new System.Drawing.Size(440, 30);
            this.phụcHồiDữLiệuRestoreToolStripMenuItem.Text = "Phục hồi dữ liệu (Restore)";
            this.phụcHồiDữLiệuRestoreToolStripMenuItem.Click += new System.EventHandler(this.phụcHồiDữLiệuRestoreToolStripMenuItem_Click);
            // 
            // thoátKhỏiChươngTrìnhToolStripMenuItem
            // 
            this.thoátKhỏiChươngTrìnhToolStripMenuItem.Name = "thoátKhỏiChươngTrìnhToolStripMenuItem";
            this.thoátKhỏiChươngTrìnhToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.thoátKhỏiChươngTrìnhToolStripMenuItem.Size = new System.Drawing.Size(440, 30);
            this.thoátKhỏiChươngTrìnhToolStripMenuItem.Text = "Thoát khỏi chương trình";
            this.thoátKhỏiChươngTrìnhToolStripMenuItem.Click += new System.EventHandler(this.thoátKhỏiChươngTrìnhToolStripMenuItem_Click);
            // 
            // toolSbanhang
            // 
            this.toolSbanhang.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolSbanhang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lậpPhiếuTínhTiềnBillToolStripMenuItem,
            this.lậpHóaĐơnInvoiceToolStripMenuItem,
            this.thốngKêCácHóaĐơnTheoBillToolStripMenuItem});
            this.toolSbanhang.Image = ((System.Drawing.Image)(resources.GetObject("toolSbanhang.Image")));
            this.toolSbanhang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSbanhang.Name = "toolSbanhang";
            this.toolSbanhang.Size = new System.Drawing.Size(116, 29);
            this.toolSbanhang.Text = "BÁN HÀNG";
            // 
            // lậpPhiếuTínhTiềnBillToolStripMenuItem
            // 
            this.lậpPhiếuTínhTiềnBillToolStripMenuItem.Name = "lậpPhiếuTínhTiềnBillToolStripMenuItem";
            this.lậpPhiếuTínhTiềnBillToolStripMenuItem.Size = new System.Drawing.Size(342, 30);
            this.lậpPhiếuTínhTiềnBillToolStripMenuItem.Text = "Lập phiếu tính tiền (Bill)";
            this.lậpPhiếuTínhTiềnBillToolStripMenuItem.Click += new System.EventHandler(this.lậpPhiếuTínhTiềnBillToolStripMenuItem_Click);
            // 
            // lậpHóaĐơnInvoiceToolStripMenuItem
            // 
            this.lậpHóaĐơnInvoiceToolStripMenuItem.Name = "lậpHóaĐơnInvoiceToolStripMenuItem";
            this.lậpHóaĐơnInvoiceToolStripMenuItem.Size = new System.Drawing.Size(342, 30);
            this.lậpHóaĐơnInvoiceToolStripMenuItem.Text = "Lập hóa đơn (Invoice)";
            this.lậpHóaĐơnInvoiceToolStripMenuItem.Click += new System.EventHandler(this.lậpHóaĐơnInvoiceToolStripMenuItem_Click);
            // 
            // thốngKêCácHóaĐơnTheoBillToolStripMenuItem
            // 
            this.thốngKêCácHóaĐơnTheoBillToolStripMenuItem.Name = "thốngKêCácHóaĐơnTheoBillToolStripMenuItem";
            this.thốngKêCácHóaĐơnTheoBillToolStripMenuItem.Size = new System.Drawing.Size(342, 30);
            this.thốngKêCácHóaĐơnTheoBillToolStripMenuItem.Text = "Thống kê các hóa đơn theo Bill";
            this.thốngKêCácHóaĐơnTheoBillToolStripMenuItem.Click += new System.EventHandler(this.thốngKêCácHóaĐơnTheoBillToolStripMenuItem_Click);
            // 
            // toolSdanhmuc
            // 
            this.toolSdanhmuc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolSdanhmuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMụcLoạiSảnPhẩmToolStripMenuItem,
            this.danhMụcNhàCungCấpToolStripMenuItem,
            this.danhMụcNhânViênToolStripMenuItem});
            this.toolSdanhmuc.Image = ((System.Drawing.Image)(resources.GetObject("toolSdanhmuc.Image")));
            this.toolSdanhmuc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSdanhmuc.Name = "toolSdanhmuc";
            this.toolSdanhmuc.Size = new System.Drawing.Size(199, 29);
            this.toolSdanhmuc.Text = "QUẢN LÝ DANH MỤC";
            // 
            // danhMụcLoạiSảnPhẩmToolStripMenuItem
            // 
            this.danhMụcLoạiSảnPhẩmToolStripMenuItem.Name = "danhMụcLoạiSảnPhẩmToolStripMenuItem";
            this.danhMụcLoạiSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(295, 30);
            this.danhMụcLoạiSảnPhẩmToolStripMenuItem.Text = "Danh mục loại sản phẩm";
            this.danhMụcLoạiSảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.danhMụcLoạiSảnPhẩmToolStripMenuItem_Click);
            // 
            // danhMụcNhàCungCấpToolStripMenuItem
            // 
            this.danhMụcNhàCungCấpToolStripMenuItem.Name = "danhMụcNhàCungCấpToolStripMenuItem";
            this.danhMụcNhàCungCấpToolStripMenuItem.Size = new System.Drawing.Size(295, 30);
            this.danhMụcNhàCungCấpToolStripMenuItem.Text = "Danh mục nhà cung cấp";
            this.danhMụcNhàCungCấpToolStripMenuItem.Click += new System.EventHandler(this.danhMụcNhàCungCấpToolStripMenuItem_Click);
            // 
            // danhMụcNhânViênToolStripMenuItem
            // 
            this.danhMụcNhânViênToolStripMenuItem.Name = "danhMụcNhânViênToolStripMenuItem";
            this.danhMụcNhânViênToolStripMenuItem.Size = new System.Drawing.Size(295, 30);
            this.danhMụcNhânViênToolStripMenuItem.Text = "Danh mục nhân viên";
            this.danhMụcNhânViênToolStripMenuItem.Click += new System.EventHandler(this.danhMụcNhânViênToolStripMenuItem_Click);
            // 
            // toolSgioithieu
            // 
            this.toolSgioithieu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolSgioithieu.Image = ((System.Drawing.Image)(resources.GetObject("toolSgioithieu.Image")));
            this.toolSgioithieu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSgioithieu.Name = "toolSgioithieu";
            this.toolSgioithieu.Size = new System.Drawing.Size(115, 29);
            this.toolSgioithieu.Text = "GIỚI THIỆU";
            // 
            // lbtittle
            // 
            this.lbtittle.AutoSize = true;
            this.lbtittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtittle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbtittle.Location = new System.Drawing.Point(495, 73);
            this.lbtittle.Name = "lbtittle";
            this.lbtittle.Size = new System.Drawing.Size(720, 20);
            this.lbtittle.TabIndex = 16;
            this.lbtittle.Text = "Chào mừng bạn đến GS25!   Vui lòng chọn vai trò bên dưới để truy cập vào hệ thống" +
    "!";
            this.lbtittle.Click += new System.EventHandler(this.label2_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmGiaoDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(961, 491);
            this.Controls.Add(this.lbtittle);
            this.Controls.Add(this.rBKhach);
            this.Controls.Add(this.rBNV);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGiaoDien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GS25";
            this.Load += new System.EventHandler(this.FrmGiaoDien_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rBKhach;
        private System.Windows.Forms.RadioButton rBNV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripDropDownButton toolSDangnhap;
        private System.Windows.Forms.ToolStripDropDownButton toolSdanhmucsp;
        private System.Windows.Forms.ToolStripDropDownButton toolStinhtien;
        private System.Windows.Forms.ToolStripDropDownButton toolSthoat;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel time;
        private System.Windows.Forms.ToolStripStatusLabel date;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolShethong;
        private System.Windows.Forms.ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTàiKhoảnNgườiDùngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thiếtLậpThamSốHệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chọnChếĐộMànHìnhLàmViệcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saoLưuDựPhòngDữLiệuBackUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phụcHồiDữLiệuRestoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátKhỏiChươngTrìnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolSbanhang;
        private System.Windows.Forms.ToolStripMenuItem lậpPhiếuTínhTiềnBillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lậpHóaĐơnInvoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêCácHóaĐơnTheoBillToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolSdanhmuc;
        private System.Windows.Forms.ToolStripMenuItem danhMụcLoạiSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcNhàCungCấpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolSgioithieu;
        private System.Windows.Forms.Label lbtittle;
        private System.Windows.Forms.Timer timer1;
    }
}

