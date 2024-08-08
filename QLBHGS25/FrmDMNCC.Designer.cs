namespace QLBHGS25
{
    partial class FrmDMNCC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDMNCC));
            this.dgvncc = new System.Windows.Forms.DataGridView();
            this.nCCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBHGS25DataSet5 = new QLBHGS25.QLBHGS25DataSet5();
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
            this.gBNCC = new System.Windows.Forms.GroupBox();
            this.tbtimten = new System.Windows.Forms.TextBox();
            this.tbtimma = new System.Windows.Forms.TextBox();
            this.btreload = new System.Windows.Forms.Button();
            this.rBten = new System.Windows.Forms.RadioButton();
            this.rBma = new System.Windows.Forms.RadioButton();
            this.bttim = new System.Windows.Forms.Button();
            this.bthome = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.tbghichu = new System.Windows.Forms.TextBox();
            this.btthoat = new System.Windows.Forms.Button();
            this.tbsdt = new System.Windows.Forms.TextBox();
            this.tbtenncc = new System.Windows.Forms.TextBox();
            this.tbdiachi = new System.Windows.Forms.TextBox();
            this.tbmancc = new System.Windows.Forms.TextBox();
            this.btluu = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btsua = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lbtensp = new System.Windows.Forms.Label();
            this.lbmasp = new System.Windows.Forms.Label();
            this.btthem = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.nCCTableAdapter = new QLBHGS25.QLBHGS25DataSet5TableAdapters.NCCTableAdapter();
            this.maNCCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNCCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvncc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHGS25DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.gBNCC.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvncc
            // 
            this.dgvncc.AutoGenerateColumns = false;
            this.dgvncc.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvncc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvncc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNCCDataGridViewTextBoxColumn,
            this.tenNCCDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.sDTDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.ghiChuDataGridViewTextBoxColumn});
            this.dgvncc.DataSource = this.nCCBindingSource;
            this.dgvncc.Location = new System.Drawing.Point(12, 307);
            this.dgvncc.Name = "dgvncc";
            this.dgvncc.RowHeadersWidth = 51;
            this.dgvncc.RowTemplate.Height = 24;
            this.dgvncc.Size = new System.Drawing.Size(1082, 281);
            this.dgvncc.TabIndex = 34;
            // 
            // nCCBindingSource
            // 
            this.nCCBindingSource.DataMember = "NCC";
            this.nCCBindingSource.DataSource = this.qLBHGS25DataSet5;
            // 
            // qLBHGS25DataSet5
            // 
            this.qLBHGS25DataSet5.DataSetName = "QLBHGS25DataSet5";
            this.qLBHGS25DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.nCCBindingSource;
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
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 584);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1098, 31);
            this.bindingNavigator1.TabIndex = 33;
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
            // gBNCC
            // 
            this.gBNCC.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gBNCC.Controls.Add(this.tbtimten);
            this.gBNCC.Controls.Add(this.tbtimma);
            this.gBNCC.Controls.Add(this.btreload);
            this.gBNCC.Controls.Add(this.rBten);
            this.gBNCC.Controls.Add(this.rBma);
            this.gBNCC.Controls.Add(this.bttim);
            this.gBNCC.Controls.Add(this.bthome);
            this.gBNCC.Controls.Add(this.label13);
            this.gBNCC.Controls.Add(this.tbemail);
            this.gBNCC.Controls.Add(this.tbghichu);
            this.gBNCC.Controls.Add(this.btthoat);
            this.gBNCC.Controls.Add(this.tbsdt);
            this.gBNCC.Controls.Add(this.tbtenncc);
            this.gBNCC.Controls.Add(this.tbdiachi);
            this.gBNCC.Controls.Add(this.tbmancc);
            this.gBNCC.Controls.Add(this.btluu);
            this.gBNCC.Controls.Add(this.label11);
            this.gBNCC.Controls.Add(this.label8);
            this.gBNCC.Controls.Add(this.btsua);
            this.gBNCC.Controls.Add(this.label7);
            this.gBNCC.Controls.Add(this.lbtensp);
            this.gBNCC.Controls.Add(this.lbmasp);
            this.gBNCC.Controls.Add(this.btthem);
            this.gBNCC.Controls.Add(this.btxoa);
            this.gBNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBNCC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gBNCC.Location = new System.Drawing.Point(12, 2);
            this.gBNCC.Name = "gBNCC";
            this.gBNCC.Size = new System.Drawing.Size(1083, 305);
            this.gBNCC.TabIndex = 32;
            this.gBNCC.TabStop = false;
            this.gBNCC.Text = "Chi tiết thông tin nhà cung cấp";
            this.gBNCC.UseCompatibleTextRendering = true;
            // 
            // tbtimten
            // 
            this.tbtimten.Location = new System.Drawing.Point(456, 252);
            this.tbtimten.Name = "tbtimten";
            this.tbtimten.Size = new System.Drawing.Size(215, 28);
            this.tbtimten.TabIndex = 49;
            // 
            // tbtimma
            // 
            this.tbtimma.Location = new System.Drawing.Point(456, 206);
            this.tbtimma.Name = "tbtimma";
            this.tbtimma.Size = new System.Drawing.Size(215, 28);
            this.tbtimma.TabIndex = 48;
            // 
            // btreload
            // 
            this.btreload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btreload.BackgroundImage")));
            this.btreload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btreload.Location = new System.Drawing.Point(1031, 0);
            this.btreload.Name = "btreload";
            this.btreload.Size = new System.Drawing.Size(52, 39);
            this.btreload.TabIndex = 47;
            this.btreload.UseVisualStyleBackColor = true;
            this.btreload.Click += new System.EventHandler(this.btreload_Click);
            // 
            // rBten
            // 
            this.rBten.AutoSize = true;
            this.rBten.Location = new System.Drawing.Point(316, 256);
            this.rBten.Name = "rBten";
            this.rBten.Size = new System.Drawing.Size(114, 26);
            this.rBten.TabIndex = 41;
            this.rBten.TabStop = true;
            this.rBten.Text = "Tên NCC";
            this.rBten.UseVisualStyleBackColor = true;
            // 
            // rBma
            // 
            this.rBma.AutoSize = true;
            this.rBma.Location = new System.Drawing.Point(316, 206);
            this.rBma.Name = "rBma";
            this.rBma.Size = new System.Drawing.Size(105, 26);
            this.rBma.TabIndex = 40;
            this.rBma.TabStop = true;
            this.rBma.Text = "Mã NCC";
            this.rBma.UseVisualStyleBackColor = true;
            // 
            // bttim
            // 
            this.bttim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttim.BackgroundImage")));
            this.bttim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttim.Location = new System.Drawing.Point(744, 219);
            this.bttim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttim.Name = "bttim";
            this.bttim.Size = new System.Drawing.Size(53, 43);
            this.bttim.TabIndex = 31;
            this.bttim.UseVisualStyleBackColor = true;
            this.bttim.Click += new System.EventHandler(this.bttim_Click);
            // 
            // bthome
            // 
            this.bthome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bthome.BackgroundImage")));
            this.bthome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bthome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bthome.Location = new System.Drawing.Point(1019, 252);
            this.bthome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bthome.Name = "bthome";
            this.bthome.Size = new System.Drawing.Size(64, 48);
            this.bthome.TabIndex = 28;
            this.bthome.UseVisualStyleBackColor = true;
            this.bthome.Click += new System.EventHandler(this.bthome_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(803, 42);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 22);
            this.label13.TabIndex = 36;
            this.label13.Text = "Ghi Chú";
            // 
            // tbemail
            // 
            this.tbemail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nCCBindingSource, "Email", true));
            this.tbemail.Location = new System.Drawing.Point(810, 90);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(240, 28);
            this.tbemail.TabIndex = 20;
            // 
            // tbghichu
            // 
            this.tbghichu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nCCBindingSource, "Email", true));
            this.tbghichu.Location = new System.Drawing.Point(890, 39);
            this.tbghichu.Name = "tbghichu";
            this.tbghichu.Size = new System.Drawing.Size(136, 28);
            this.tbghichu.TabIndex = 16;
            // 
            // btthoat
            // 
            this.btthoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btthoat.BackgroundImage")));
            this.btthoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthoat.Location = new System.Drawing.Point(771, 139);
            this.btthoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(54, 40);
            this.btthoat.TabIndex = 29;
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // tbsdt
            // 
            this.tbsdt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nCCBindingSource, "SDT", true));
            this.tbsdt.Location = new System.Drawing.Point(482, 87);
            this.tbsdt.Name = "tbsdt";
            this.tbsdt.Size = new System.Drawing.Size(179, 28);
            this.tbsdt.TabIndex = 15;
            // 
            // tbtenncc
            // 
            this.tbtenncc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nCCBindingSource, "TenNCC", true));
            this.tbtenncc.Location = new System.Drawing.Point(138, 84);
            this.tbtenncc.Name = "tbtenncc";
            this.tbtenncc.Size = new System.Drawing.Size(271, 28);
            this.tbtenncc.TabIndex = 14;
            // 
            // tbdiachi
            // 
            this.tbdiachi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nCCBindingSource, "DiaChi", true));
            this.tbdiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbdiachi.Location = new System.Drawing.Point(458, 36);
            this.tbdiachi.Name = "tbdiachi";
            this.tbdiachi.Size = new System.Drawing.Size(339, 28);
            this.tbdiachi.TabIndex = 13;
            // 
            // tbmancc
            // 
            this.tbmancc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nCCBindingSource, "MaNCC", true));
            this.tbmancc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbmancc.Location = new System.Drawing.Point(138, 33);
            this.tbmancc.Name = "tbmancc";
            this.tbmancc.Size = new System.Drawing.Size(219, 28);
            this.tbmancc.TabIndex = 12;
            // 
            // btluu
            // 
            this.btluu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btluu.BackgroundImage")));
            this.btluu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btluu.Location = new System.Drawing.Point(663, 141);
            this.btluu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btluu.Name = "btluu";
            this.btluu.Size = new System.Drawing.Size(56, 38);
            this.btluu.TabIndex = 30;
            this.btluu.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(731, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 22);
            this.label11.TabIndex = 9;
            this.label11.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(429, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 22);
            this.label8.TabIndex = 6;
            this.label8.Text = "SĐT";
            // 
            // btsua
            // 
            this.btsua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btsua.BackgroundImage")));
            this.btsua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsua.Location = new System.Drawing.Point(524, 140);
            this.btsua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(59, 39);
            this.btsua.TabIndex = 25;
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(383, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 22);
            this.label7.TabIndex = 5;
            this.label7.Text = "Địa Chỉ";
            // 
            // lbtensp
            // 
            this.lbtensp.AutoSize = true;
            this.lbtensp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtensp.Location = new System.Drawing.Point(36, 90);
            this.lbtensp.Name = "lbtensp";
            this.lbtensp.Size = new System.Drawing.Size(86, 22);
            this.lbtensp.TabIndex = 2;
            this.lbtensp.Text = "Tên NCC";
            // 
            // lbmasp
            // 
            this.lbmasp.AutoSize = true;
            this.lbmasp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmasp.Location = new System.Drawing.Point(44, 39);
            this.lbmasp.Name = "lbmasp";
            this.lbmasp.Size = new System.Drawing.Size(78, 22);
            this.lbmasp.TabIndex = 1;
            this.lbmasp.Text = "Mã NCC";
            // 
            // btthem
            // 
            this.btthem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btthem.BackgroundImage")));
            this.btthem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthem.Location = new System.Drawing.Point(257, 139);
            this.btthem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(54, 39);
            this.btthem.TabIndex = 24;
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // btxoa
            // 
            this.btxoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btxoa.BackgroundImage")));
            this.btxoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxoa.Location = new System.Drawing.Point(387, 140);
            this.btxoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(62, 38);
            this.btxoa.TabIndex = 26;
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // nCCTableAdapter
            // 
            this.nCCTableAdapter.ClearBeforeFill = true;
            // 
            // maNCCDataGridViewTextBoxColumn
            // 
            this.maNCCDataGridViewTextBoxColumn.DataPropertyName = "MaNCC";
            this.maNCCDataGridViewTextBoxColumn.HeaderText = "Mã NCC";
            this.maNCCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maNCCDataGridViewTextBoxColumn.Name = "maNCCDataGridViewTextBoxColumn";
            this.maNCCDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenNCCDataGridViewTextBoxColumn
            // 
            this.tenNCCDataGridViewTextBoxColumn.DataPropertyName = "TenNCC";
            this.tenNCCDataGridViewTextBoxColumn.HeaderText = "Tên NCC";
            this.tenNCCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenNCCDataGridViewTextBoxColumn.Name = "tenNCCDataGridViewTextBoxColumn";
            this.tenNCCDataGridViewTextBoxColumn.Width = 125;
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "Địa Chỉ";
            this.diaChiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            this.diaChiDataGridViewTextBoxColumn.Width = 125;
            // 
            // sDTDataGridViewTextBoxColumn
            // 
            this.sDTDataGridViewTextBoxColumn.DataPropertyName = "SDT";
            this.sDTDataGridViewTextBoxColumn.HeaderText = "SDT";
            this.sDTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sDTDataGridViewTextBoxColumn.Name = "sDTDataGridViewTextBoxColumn";
            this.sDTDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // ghiChuDataGridViewTextBoxColumn
            // 
            this.ghiChuDataGridViewTextBoxColumn.DataPropertyName = "GhiChu";
            this.ghiChuDataGridViewTextBoxColumn.HeaderText = "Ghi Chú";
            this.ghiChuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ghiChuDataGridViewTextBoxColumn.Name = "ghiChuDataGridViewTextBoxColumn";
            this.ghiChuDataGridViewTextBoxColumn.Width = 125;
            // 
            // FrmDMNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1098, 615);
            this.Controls.Add(this.dgvncc);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.gBNCC);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDMNCC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục nhà cung cấp";
            this.Load += new System.EventHandler(this.FrmDMNCC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvncc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHGS25DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.gBNCC.ResumeLayout(false);
            this.gBNCC.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvncc;
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
        private System.Windows.Forms.GroupBox gBNCC;
        private System.Windows.Forms.TextBox tbtimten;
        private System.Windows.Forms.TextBox tbtimma;
        private System.Windows.Forms.Button btreload;
        private System.Windows.Forms.RadioButton rBten;
        private System.Windows.Forms.RadioButton rBma;
        private System.Windows.Forms.Button bttim;
        private System.Windows.Forms.Button bthome;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.TextBox tbghichu;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.TextBox tbsdt;
        private System.Windows.Forms.TextBox tbtenncc;
        private System.Windows.Forms.TextBox tbdiachi;
        private System.Windows.Forms.TextBox tbmancc;
        private System.Windows.Forms.Button btluu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbtensp;
        private System.Windows.Forms.Label lbmasp;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Button btxoa;
        private QLBHGS25DataSet5 qLBHGS25DataSet5;
        private System.Windows.Forms.BindingSource nCCBindingSource;
        private QLBHGS25DataSet5TableAdapters.NCCTableAdapter nCCTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNCCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNCCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChuDataGridViewTextBoxColumn;
    }
}