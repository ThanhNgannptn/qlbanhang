namespace QLBHGS25
{
    partial class FrmPhieuThanhToan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPhieuThanhToan));
            this.dgvtt = new System.Windows.Forms.DataGridView();
            this.mAHDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mANVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mASPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOLUONGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gIABANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tHÀNHTIỀNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phieuThanhToanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBHGS25DataSet37 = new QLBHGS25.QLBHGS25DataSet37();
            this.phieuThanhToanTableAdapter = new QLBHGS25.QLBHGS25DataSet37TableAdapters.PhieuThanhToanTableAdapter();
            this.tbnv = new System.Windows.Forms.TextBox();
            this.tbhd = new System.Windows.Forms.TextBox();
            this.rBNV = new System.Windows.Forms.RadioButton();
            this.rBHD = new System.Windows.Forms.RadioButton();
            this.bttim = new System.Windows.Forms.Button();
            this.bthome = new System.Windows.Forms.Button();
            this.btthoat = new System.Windows.Forms.Button();
            this.khachHangTableAdapter1 = new QLBHGS25.QLBHGS25DataSet10TableAdapters.KhachHangTableAdapter();
            this.rBKH = new System.Windows.Forms.RadioButton();
            this.rBSP = new System.Windows.Forms.RadioButton();
            this.tbkh = new System.Windows.Forms.TextBox();
            this.tbsp = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btreload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuThanhToanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHGS25DataSet37)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvtt
            // 
            this.dgvtt.AutoGenerateColumns = false;
            this.dgvtt.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvtt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mAHDDataGridViewTextBoxColumn,
            this.mANVDataGridViewTextBoxColumn,
            this.mAKHDataGridViewTextBoxColumn,
            this.mASPDataGridViewTextBoxColumn,
            this.tENSPDataGridViewTextBoxColumn,
            this.sOLUONGDataGridViewTextBoxColumn,
            this.gIABANDataGridViewTextBoxColumn,
            this.tHÀNHTIỀNDataGridViewTextBoxColumn});
            this.dgvtt.DataSource = this.phieuThanhToanBindingSource;
            this.dgvtt.Location = new System.Drawing.Point(10, 166);
            this.dgvtt.Name = "dgvtt";
            this.dgvtt.RowHeadersWidth = 51;
            this.dgvtt.RowTemplate.Height = 24;
            this.dgvtt.Size = new System.Drawing.Size(1474, 329);
            this.dgvtt.TabIndex = 0;
            this.dgvtt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtt_CellContentClick);
            // 
            // mAHDDataGridViewTextBoxColumn
            // 
            this.mAHDDataGridViewTextBoxColumn.DataPropertyName = "MAHD";
            this.mAHDDataGridViewTextBoxColumn.HeaderText = "MÃ HD";
            this.mAHDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mAHDDataGridViewTextBoxColumn.Name = "mAHDDataGridViewTextBoxColumn";
            this.mAHDDataGridViewTextBoxColumn.Width = 125;
            // 
            // mANVDataGridViewTextBoxColumn
            // 
            this.mANVDataGridViewTextBoxColumn.DataPropertyName = "MANV";
            this.mANVDataGridViewTextBoxColumn.HeaderText = "MÃ NV";
            this.mANVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mANVDataGridViewTextBoxColumn.Name = "mANVDataGridViewTextBoxColumn";
            this.mANVDataGridViewTextBoxColumn.Width = 125;
            // 
            // mAKHDataGridViewTextBoxColumn
            // 
            this.mAKHDataGridViewTextBoxColumn.DataPropertyName = "MAKH";
            this.mAKHDataGridViewTextBoxColumn.HeaderText = "MÃ KH";
            this.mAKHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mAKHDataGridViewTextBoxColumn.Name = "mAKHDataGridViewTextBoxColumn";
            this.mAKHDataGridViewTextBoxColumn.Width = 125;
            // 
            // mASPDataGridViewTextBoxColumn
            // 
            this.mASPDataGridViewTextBoxColumn.DataPropertyName = "MASP";
            this.mASPDataGridViewTextBoxColumn.HeaderText = "MÃ SP";
            this.mASPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mASPDataGridViewTextBoxColumn.Name = "mASPDataGridViewTextBoxColumn";
            this.mASPDataGridViewTextBoxColumn.Width = 125;
            // 
            // tENSPDataGridViewTextBoxColumn
            // 
            this.tENSPDataGridViewTextBoxColumn.DataPropertyName = "TENSP";
            this.tENSPDataGridViewTextBoxColumn.HeaderText = "TÊN SP";
            this.tENSPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tENSPDataGridViewTextBoxColumn.Name = "tENSPDataGridViewTextBoxColumn";
            this.tENSPDataGridViewTextBoxColumn.Width = 125;
            // 
            // sOLUONGDataGridViewTextBoxColumn
            // 
            this.sOLUONGDataGridViewTextBoxColumn.DataPropertyName = "SOLUONG";
            this.sOLUONGDataGridViewTextBoxColumn.HeaderText = "SỐ LƯỢNG";
            this.sOLUONGDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sOLUONGDataGridViewTextBoxColumn.Name = "sOLUONGDataGridViewTextBoxColumn";
            this.sOLUONGDataGridViewTextBoxColumn.Width = 125;
            // 
            // gIABANDataGridViewTextBoxColumn
            // 
            this.gIABANDataGridViewTextBoxColumn.DataPropertyName = "GIABAN";
            this.gIABANDataGridViewTextBoxColumn.HeaderText = "GIÁC BÁN";
            this.gIABANDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gIABANDataGridViewTextBoxColumn.Name = "gIABANDataGridViewTextBoxColumn";
            this.gIABANDataGridViewTextBoxColumn.Width = 125;
            // 
            // tHÀNHTIỀNDataGridViewTextBoxColumn
            // 
            this.tHÀNHTIỀNDataGridViewTextBoxColumn.DataPropertyName = "THÀNH TIỀN";
            this.tHÀNHTIỀNDataGridViewTextBoxColumn.HeaderText = "THÀNH TIỀN";
            this.tHÀNHTIỀNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tHÀNHTIỀNDataGridViewTextBoxColumn.Name = "tHÀNHTIỀNDataGridViewTextBoxColumn";
            this.tHÀNHTIỀNDataGridViewTextBoxColumn.ReadOnly = true;
            this.tHÀNHTIỀNDataGridViewTextBoxColumn.Width = 125;
            // 
            // phieuThanhToanBindingSource
            // 
            this.phieuThanhToanBindingSource.DataMember = "PhieuThanhToan";
            this.phieuThanhToanBindingSource.DataSource = this.qLBHGS25DataSet37;
            // 
            // qLBHGS25DataSet37
            // 
            this.qLBHGS25DataSet37.DataSetName = "QLBHGS25DataSet37";
            this.qLBHGS25DataSet37.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phieuThanhToanTableAdapter
            // 
            this.phieuThanhToanTableAdapter.ClearBeforeFill = true;
            // 
            // tbnv
            // 
            this.tbnv.Location = new System.Drawing.Point(179, 81);
            this.tbnv.Name = "tbnv";
            this.tbnv.Size = new System.Drawing.Size(215, 28);
            this.tbnv.TabIndex = 54;
            this.tbnv.TextChanged += new System.EventHandler(this.tbtimten_TextChanged);
            // 
            // tbhd
            // 
            this.tbhd.Location = new System.Drawing.Point(179, 23);
            this.tbhd.Name = "tbhd";
            this.tbhd.Size = new System.Drawing.Size(215, 28);
            this.tbhd.TabIndex = 53;
            this.tbhd.TextChanged += new System.EventHandler(this.tbtimma_TextChanged);
            // 
            // rBNV
            // 
            this.rBNV.AutoSize = true;
            this.rBNV.Location = new System.Drawing.Point(71, 81);
            this.rBNV.Name = "rBNV";
            this.rBNV.Size = new System.Drawing.Size(80, 26);
            this.rBNV.TabIndex = 52;
            this.rBNV.TabStop = true;
            this.rBNV.Text = "MaNV";
            this.rBNV.UseVisualStyleBackColor = true;
            this.rBNV.CheckedChanged += new System.EventHandler(this.rBten_CheckedChanged);
            // 
            // rBHD
            // 
            this.rBHD.AutoSize = true;
            this.rBHD.Location = new System.Drawing.Point(71, 27);
            this.rBHD.Name = "rBHD";
            this.rBHD.Size = new System.Drawing.Size(86, 26);
            this.rBHD.TabIndex = 51;
            this.rBHD.TabStop = true;
            this.rBHD.Text = "Mã HD";
            this.rBHD.UseVisualStyleBackColor = true;
            this.rBHD.CheckedChanged += new System.EventHandler(this.rBma_CheckedChanged);
            // 
            // bttim
            // 
            this.bttim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttim.BackgroundImage")));
            this.bttim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttim.Location = new System.Drawing.Point(1165, 63);
            this.bttim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttim.Name = "bttim";
            this.bttim.Size = new System.Drawing.Size(55, 41);
            this.bttim.TabIndex = 50;
            this.bttim.UseVisualStyleBackColor = true;
            this.bttim.Click += new System.EventHandler(this.bttim_Click);
            // 
            // bthome
            // 
            this.bthome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bthome.BackgroundImage")));
            this.bthome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bthome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bthome.Location = new System.Drawing.Point(1423, 114);
            this.bthome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bthome.Name = "bthome";
            this.bthome.Size = new System.Drawing.Size(61, 47);
            this.bthome.TabIndex = 56;
            this.bthome.UseVisualStyleBackColor = true;
            this.bthome.Click += new System.EventHandler(this.bthome_Click_1);
            // 
            // btthoat
            // 
            this.btthoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btthoat.BackgroundImage")));
            this.btthoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthoat.Location = new System.Drawing.Point(1333, 113);
            this.btthoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(55, 46);
            this.btthoat.TabIndex = 55;
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // khachHangTableAdapter1
            // 
            this.khachHangTableAdapter1.ClearBeforeFill = true;
            // 
            // rBKH
            // 
            this.rBKH.AutoSize = true;
            this.rBKH.Location = new System.Drawing.Point(459, 25);
            this.rBKH.Name = "rBKH";
            this.rBKH.Size = new System.Drawing.Size(80, 26);
            this.rBKH.TabIndex = 59;
            this.rBKH.TabStop = true;
            this.rBKH.Text = "MaKH";
            this.rBKH.UseVisualStyleBackColor = true;
            // 
            // rBSP
            // 
            this.rBSP.AutoSize = true;
            this.rBSP.Location = new System.Drawing.Point(459, 81);
            this.rBSP.Name = "rBSP";
            this.rBSP.Size = new System.Drawing.Size(79, 26);
            this.rBSP.TabIndex = 60;
            this.rBSP.TabStop = true;
            this.rBSP.Text = "MaSP";
            this.rBSP.UseVisualStyleBackColor = true;
            // 
            // tbkh
            // 
            this.tbkh.Location = new System.Drawing.Point(547, 21);
            this.tbkh.Name = "tbkh";
            this.tbkh.Size = new System.Drawing.Size(215, 28);
            this.tbkh.TabIndex = 61;
            // 
            // tbsp
            // 
            this.tbsp.Location = new System.Drawing.Point(547, 79);
            this.tbsp.Name = "tbsp";
            this.tbsp.Size = new System.Drawing.Size(215, 28);
            this.tbsp.TabIndex = 62;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbsp);
            this.groupBox1.Controls.Add(this.tbkh);
            this.groupBox1.Controls.Add(this.rBSP);
            this.groupBox1.Controls.Add(this.rBKH);
            this.groupBox1.Controls.Add(this.tbnv);
            this.groupBox1.Controls.Add(this.tbhd);
            this.groupBox1.Controls.Add(this.rBNV);
            this.groupBox1.Controls.Add(this.rBHD);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(288, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(815, 127);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tiêu chí tìm kiếm";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.phieuThanhToanBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 506);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1495, 27);
            this.bindingNavigator1.TabIndex = 64;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // btreload
            // 
            this.btreload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btreload.BackgroundImage")));
            this.btreload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btreload.Location = new System.Drawing.Point(1423, 18);
            this.btreload.Name = "btreload";
            this.btreload.Size = new System.Drawing.Size(52, 39);
            this.btreload.TabIndex = 65;
            this.btreload.UseVisualStyleBackColor = true;
            this.btreload.Click += new System.EventHandler(this.btreload_Click);
            // 
            // FrmPhieuThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1495, 533);
            this.Controls.Add(this.btreload);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bthome);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.bttim);
            this.Controls.Add(this.dgvtt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPhieuThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu thanh toán";
            this.Load += new System.EventHandler(this.FrmPhieuThanhToan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuThanhToanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHGS25DataSet37)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvtt;
        private QLBHGS25DataSet37 qLBHGS25DataSet37;
        private System.Windows.Forms.BindingSource phieuThanhToanBindingSource;
        private QLBHGS25DataSet37TableAdapters.PhieuThanhToanTableAdapter phieuThanhToanTableAdapter;
        private System.Windows.Forms.TextBox tbnv;
        private System.Windows.Forms.TextBox tbhd;
        private System.Windows.Forms.RadioButton rBNV;
        private System.Windows.Forms.RadioButton rBHD;
        private System.Windows.Forms.Button bttim;
        private System.Windows.Forms.Button bthome;
        private System.Windows.Forms.Button btthoat;
        private QLBHGS25DataSet10TableAdapters.KhachHangTableAdapter khachHangTableAdapter1;
        private System.Windows.Forms.RadioButton rBKH;
        private System.Windows.Forms.RadioButton rBSP;
        private System.Windows.Forms.TextBox tbkh;
        private System.Windows.Forms.TextBox tbsp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Button btreload;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAHDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mANVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mASPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOLUONGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gIABANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tHÀNHTIỀNDataGridViewTextBoxColumn;
    }
}