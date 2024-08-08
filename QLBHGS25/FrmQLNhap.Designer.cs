namespace QLBHGS25
{
    partial class FrmQLNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQLNhap));
            this.btreload = new System.Windows.Forms.Button();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbsp = new System.Windows.Forms.TextBox();
            this.tbncc = new System.Windows.Forms.TextBox();
            this.rBSP = new System.Windows.Forms.RadioButton();
            this.rBNCC = new System.Windows.Forms.RadioButton();
            this.tbnv = new System.Windows.Forms.TextBox();
            this.tbpn = new System.Windows.Forms.TextBox();
            this.rBNV = new System.Windows.Forms.RadioButton();
            this.rBPN = new System.Windows.Forms.RadioButton();
            this.bthome = new System.Windows.Forms.Button();
            this.btthoat = new System.Windows.Forms.Button();
            this.bttim = new System.Windows.Forms.Button();
            this.dgvnh = new System.Windows.Forms.DataGridView();
            this.qLBHGS25DataSet38 = new QLBHGS25.QLBHGS25DataSet38();
            this.qlnhaphangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qlnhaphangTableAdapter = new QLBHGS25.QLBHGS25DataSet38TableAdapters.qlnhaphangTableAdapter();
            this.mapnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manccDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maspDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenspDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaynhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gianhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thànhTiềnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHGS25DataSet38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlnhaphangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btreload
            // 
            this.btreload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btreload.BackgroundImage")));
            this.btreload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btreload.Location = new System.Drawing.Point(1417, 12);
            this.btreload.Name = "btreload";
            this.btreload.Size = new System.Drawing.Size(52, 39);
            this.btreload.TabIndex = 72;
            this.btreload.UseVisualStyleBackColor = true;
            this.btreload.Click += new System.EventHandler(this.btreload_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.qlnhaphangBindingSource;
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
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 531);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1567, 31);
            this.bindingNavigator1.TabIndex = 71;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.tbsp);
            this.groupBox1.Controls.Add(this.tbncc);
            this.groupBox1.Controls.Add(this.rBSP);
            this.groupBox1.Controls.Add(this.rBNCC);
            this.groupBox1.Controls.Add(this.tbnv);
            this.groupBox1.Controls.Add(this.tbpn);
            this.groupBox1.Controls.Add(this.rBNV);
            this.groupBox1.Controls.Add(this.rBPN);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(280, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(815, 131);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tiêu chí tìm kiếm";
            // 
            // tbsp
            // 
            this.tbsp.Location = new System.Drawing.Point(547, 79);
            this.tbsp.Name = "tbsp";
            this.tbsp.Size = new System.Drawing.Size(215, 28);
            this.tbsp.TabIndex = 62;
            // 
            // tbncc
            // 
            this.tbncc.Location = new System.Drawing.Point(547, 26);
            this.tbncc.Name = "tbncc";
            this.tbncc.Size = new System.Drawing.Size(215, 28);
            this.tbncc.TabIndex = 61;
            // 
            // rBSP
            // 
            this.rBSP.AutoSize = true;
            this.rBSP.Location = new System.Drawing.Point(435, 83);
            this.rBSP.Name = "rBSP";
            this.rBSP.Size = new System.Drawing.Size(79, 26);
            this.rBSP.TabIndex = 60;
            this.rBSP.TabStop = true;
            this.rBSP.Text = "MaSP";
            this.rBSP.UseVisualStyleBackColor = true;
            // 
            // rBNCC
            // 
            this.rBNCC.AutoSize = true;
            this.rBNCC.Location = new System.Drawing.Point(435, 27);
            this.rBNCC.Name = "rBNCC";
            this.rBNCC.Size = new System.Drawing.Size(94, 26);
            this.rBNCC.TabIndex = 59;
            this.rBNCC.TabStop = true;
            this.rBNCC.Text = "MaNCC";
            this.rBNCC.UseVisualStyleBackColor = true;
            // 
            // tbnv
            // 
            this.tbnv.Location = new System.Drawing.Point(179, 81);
            this.tbnv.Name = "tbnv";
            this.tbnv.Size = new System.Drawing.Size(215, 28);
            this.tbnv.TabIndex = 54;
            // 
            // tbpn
            // 
            this.tbpn.Location = new System.Drawing.Point(179, 23);
            this.tbpn.Name = "tbpn";
            this.tbpn.Size = new System.Drawing.Size(215, 28);
            this.tbpn.TabIndex = 53;
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
            // 
            // rBPN
            // 
            this.rBPN.AutoSize = true;
            this.rBPN.Location = new System.Drawing.Point(71, 27);
            this.rBPN.Name = "rBPN";
            this.rBPN.Size = new System.Drawing.Size(85, 26);
            this.rBPN.TabIndex = 51;
            this.rBPN.TabStop = true;
            this.rBPN.Text = "Mã PN";
            this.rBPN.UseVisualStyleBackColor = true;
            // 
            // bthome
            // 
            this.bthome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bthome.BackgroundImage")));
            this.bthome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bthome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bthome.Location = new System.Drawing.Point(1408, 137);
            this.bthome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bthome.Name = "bthome";
            this.bthome.Size = new System.Drawing.Size(61, 47);
            this.bthome.TabIndex = 69;
            this.bthome.UseVisualStyleBackColor = true;
            this.bthome.Click += new System.EventHandler(this.bthome_Click);
            // 
            // btthoat
            // 
            this.btthoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btthoat.BackgroundImage")));
            this.btthoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthoat.Location = new System.Drawing.Point(1319, 138);
            this.btthoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(55, 46);
            this.btthoat.TabIndex = 68;
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // bttim
            // 
            this.bttim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttim.BackgroundImage")));
            this.bttim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttim.Location = new System.Drawing.Point(1131, 76);
            this.bttim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttim.Name = "bttim";
            this.bttim.Size = new System.Drawing.Size(55, 41);
            this.bttim.TabIndex = 67;
            this.bttim.UseVisualStyleBackColor = true;
            this.bttim.Click += new System.EventHandler(this.bttim_Click);
            // 
            // dgvnh
            // 
            this.dgvnh.AutoGenerateColumns = false;
            this.dgvnh.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvnh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mapnDataGridViewTextBoxColumn,
            this.manvDataGridViewTextBoxColumn,
            this.manccDataGridViewTextBoxColumn,
            this.maspDataGridViewTextBoxColumn,
            this.tenspDataGridViewTextBoxColumn,
            this.soluongDataGridViewTextBoxColumn,
            this.ngaynhapDataGridViewTextBoxColumn,
            this.gianhapDataGridViewTextBoxColumn,
            this.thànhTiềnDataGridViewTextBoxColumn});
            this.dgvnh.DataSource = this.qlnhaphangBindingSource;
            this.dgvnh.Location = new System.Drawing.Point(12, 189);
            this.dgvnh.Name = "dgvnh";
            this.dgvnh.RowHeadersWidth = 51;
            this.dgvnh.RowTemplate.Height = 24;
            this.dgvnh.Size = new System.Drawing.Size(1523, 326);
            this.dgvnh.TabIndex = 66;
            // 
            // qLBHGS25DataSet38
            // 
            this.qLBHGS25DataSet38.DataSetName = "QLBHGS25DataSet38";
            this.qLBHGS25DataSet38.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qlnhaphangBindingSource
            // 
            this.qlnhaphangBindingSource.DataMember = "qlnhaphang";
            this.qlnhaphangBindingSource.DataSource = this.qLBHGS25DataSet38;
            // 
            // qlnhaphangTableAdapter
            // 
            this.qlnhaphangTableAdapter.ClearBeforeFill = true;
            // 
            // mapnDataGridViewTextBoxColumn
            // 
            this.mapnDataGridViewTextBoxColumn.DataPropertyName = "mapn";
            this.mapnDataGridViewTextBoxColumn.HeaderText = "Mã PN";
            this.mapnDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mapnDataGridViewTextBoxColumn.Name = "mapnDataGridViewTextBoxColumn";
            this.mapnDataGridViewTextBoxColumn.Width = 125;
            // 
            // manvDataGridViewTextBoxColumn
            // 
            this.manvDataGridViewTextBoxColumn.DataPropertyName = "manv";
            this.manvDataGridViewTextBoxColumn.HeaderText = "Mã NV";
            this.manvDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.manvDataGridViewTextBoxColumn.Name = "manvDataGridViewTextBoxColumn";
            this.manvDataGridViewTextBoxColumn.Width = 125;
            // 
            // manccDataGridViewTextBoxColumn
            // 
            this.manccDataGridViewTextBoxColumn.DataPropertyName = "mancc";
            this.manccDataGridViewTextBoxColumn.HeaderText = "Mã NCC";
            this.manccDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.manccDataGridViewTextBoxColumn.Name = "manccDataGridViewTextBoxColumn";
            this.manccDataGridViewTextBoxColumn.Width = 125;
            // 
            // maspDataGridViewTextBoxColumn
            // 
            this.maspDataGridViewTextBoxColumn.DataPropertyName = "masp";
            this.maspDataGridViewTextBoxColumn.HeaderText = "Mã SP";
            this.maspDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maspDataGridViewTextBoxColumn.Name = "maspDataGridViewTextBoxColumn";
            this.maspDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenspDataGridViewTextBoxColumn
            // 
            this.tenspDataGridViewTextBoxColumn.DataPropertyName = "tensp";
            this.tenspDataGridViewTextBoxColumn.HeaderText = "Tên SP";
            this.tenspDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenspDataGridViewTextBoxColumn.Name = "tenspDataGridViewTextBoxColumn";
            this.tenspDataGridViewTextBoxColumn.Width = 125;
            // 
            // soluongDataGridViewTextBoxColumn
            // 
            this.soluongDataGridViewTextBoxColumn.DataPropertyName = "soluong";
            this.soluongDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.soluongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soluongDataGridViewTextBoxColumn.Name = "soluongDataGridViewTextBoxColumn";
            this.soluongDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngaynhapDataGridViewTextBoxColumn
            // 
            this.ngaynhapDataGridViewTextBoxColumn.DataPropertyName = "ngaynhap";
            this.ngaynhapDataGridViewTextBoxColumn.HeaderText = "Ngày nhập";
            this.ngaynhapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngaynhapDataGridViewTextBoxColumn.Name = "ngaynhapDataGridViewTextBoxColumn";
            this.ngaynhapDataGridViewTextBoxColumn.Width = 125;
            // 
            // gianhapDataGridViewTextBoxColumn
            // 
            this.gianhapDataGridViewTextBoxColumn.DataPropertyName = "gianhap";
            this.gianhapDataGridViewTextBoxColumn.HeaderText = "Giá nhập";
            this.gianhapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gianhapDataGridViewTextBoxColumn.Name = "gianhapDataGridViewTextBoxColumn";
            this.gianhapDataGridViewTextBoxColumn.Width = 125;
            // 
            // thànhTiềnDataGridViewTextBoxColumn
            // 
            this.thànhTiềnDataGridViewTextBoxColumn.DataPropertyName = "Thành tiền";
            this.thànhTiềnDataGridViewTextBoxColumn.HeaderText = "Thành tiền";
            this.thànhTiềnDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.thànhTiềnDataGridViewTextBoxColumn.Name = "thànhTiềnDataGridViewTextBoxColumn";
            this.thànhTiềnDataGridViewTextBoxColumn.ReadOnly = true;
            this.thànhTiềnDataGridViewTextBoxColumn.Width = 125;
            // 
            // FrmQLNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1567, 562);
            this.Controls.Add(this.btreload);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bthome);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.bttim);
            this.Controls.Add(this.dgvnh);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmQLNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhập hàng";
            this.Load += new System.EventHandler(this.FrmQLNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHGS25DataSet38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlnhaphangBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btreload;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbsp;
        private System.Windows.Forms.TextBox tbncc;
        private System.Windows.Forms.RadioButton rBSP;
        private System.Windows.Forms.RadioButton rBNCC;
        private System.Windows.Forms.TextBox tbnv;
        private System.Windows.Forms.TextBox tbpn;
        private System.Windows.Forms.RadioButton rBNV;
        private System.Windows.Forms.RadioButton rBPN;
        private System.Windows.Forms.Button bthome;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.Button bttim;
        private System.Windows.Forms.DataGridView dgvnh;
        private QLBHGS25DataSet38 qLBHGS25DataSet38;
        private System.Windows.Forms.BindingSource qlnhaphangBindingSource;
        private QLBHGS25DataSet38TableAdapters.qlnhaphangTableAdapter qlnhaphangTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mapnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manccDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maspDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenspDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaynhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gianhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thànhTiềnDataGridViewTextBoxColumn;
    }
}