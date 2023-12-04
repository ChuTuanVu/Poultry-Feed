namespace btl
{
    partial class Sanpham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sanpham));
            this.tplsmuahang = new System.Windows.Forms.TabPage();
            this.rpnguoidung = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.hoadonmua1 = new btl.hoadonmua();
            this.tpsanpham = new System.Windows.Forms.TabPage();
            this.dtgvsanpham = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbthongtin = new System.Windows.Forms.GroupBox();
            this.cbbloai = new System.Windows.Forms.ComboBox();
            this.tbnhacungcap = new System.Windows.Forms.TextBox();
            this.lbnhacungcap = new System.Windows.Forms.Label();
            this.lbsoluongmua = new System.Windows.Forms.Label();
            this.tbsoluongmua = new System.Windows.Forms.TextBox();
            this.lbmota = new System.Windows.Forms.Label();
            this.lbloai = new System.Windows.Forms.Label();
            this.lbtensp = new System.Windows.Forms.Label();
            this.lbgia = new System.Windows.Forms.Label();
            this.lbsoluong = new System.Windows.Forms.Label();
            this.lbmasanpham = new System.Windows.Forms.Label();
            this.tbmota = new System.Windows.Forms.TextBox();
            this.tbtensp = new System.Windows.Forms.TextBox();
            this.tbmasp = new System.Windows.Forms.TextBox();
            this.tbsoluong = new System.Windows.Forms.TextBox();
            this.tbgia = new System.Windows.Forms.TextBox();
            this.gbchucnang = new System.Windows.Forms.GroupBox();
            this.btmota = new System.Windows.Forms.Button();
            this.btmua = new System.Windows.Forms.Button();
            this.cbblocnhacungcap = new System.Windows.Forms.ComboBox();
            this.tbtim = new System.Windows.Forms.TextBox();
            this.btthem = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.bttim = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btmoi = new System.Windows.Forms.Button();
            this.cbblocloai = new System.Windows.Forms.ComboBox();
            this.btloc = new System.Windows.Forms.Button();
            this.tcsanpham = new System.Windows.Forms.TabControl();
            this.epsoluongmua = new System.Windows.Forms.ErrorProvider(this.components);
            this.tplsmuahang.SuspendLayout();
            this.tpsanpham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvsanpham)).BeginInit();
            this.gbthongtin.SuspendLayout();
            this.gbchucnang.SuspendLayout();
            this.tcsanpham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epsoluongmua)).BeginInit();
            this.SuspendLayout();
            // 
            // tplsmuahang
            // 
            this.tplsmuahang.Controls.Add(this.rpnguoidung);
            this.tplsmuahang.Location = new System.Drawing.Point(4, 24);
            this.tplsmuahang.Name = "tplsmuahang";
            this.tplsmuahang.Padding = new System.Windows.Forms.Padding(3);
            this.tplsmuahang.Size = new System.Drawing.Size(872, 437);
            this.tplsmuahang.TabIndex = 1;
            this.tplsmuahang.Text = "Lịch sử mua hàng";
            this.tplsmuahang.UseVisualStyleBackColor = true;
            // 
            // rpnguoidung
            // 
            this.rpnguoidung.ActiveViewIndex = 0;
            this.rpnguoidung.AutoSize = true;
            this.rpnguoidung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rpnguoidung.Cursor = System.Windows.Forms.Cursors.Default;
            this.rpnguoidung.DisplayStatusBar = false;
            this.rpnguoidung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpnguoidung.Location = new System.Drawing.Point(3, 3);
            this.rpnguoidung.Name = "rpnguoidung";
            this.rpnguoidung.ReportSource = this.hoadonmua1;
            this.rpnguoidung.Size = new System.Drawing.Size(866, 431);
            this.rpnguoidung.TabIndex = 0;
            this.rpnguoidung.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // tpsanpham
            // 
            this.tpsanpham.Controls.Add(this.dtgvsanpham);
            this.tpsanpham.Controls.Add(this.gbthongtin);
            this.tpsanpham.Controls.Add(this.gbchucnang);
            this.tpsanpham.Location = new System.Drawing.Point(4, 24);
            this.tpsanpham.Name = "tpsanpham";
            this.tpsanpham.Padding = new System.Windows.Forms.Padding(3);
            this.tpsanpham.Size = new System.Drawing.Size(872, 437);
            this.tpsanpham.TabIndex = 0;
            this.tpsanpham.Text = "Sản phẩm";
            this.tpsanpham.UseVisualStyleBackColor = true;
            // 
            // dtgvsanpham
            // 
            this.dtgvsanpham.AllowUserToAddRows = false;
            this.dtgvsanpham.AllowUserToDeleteRows = false;
            this.dtgvsanpham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvsanpham.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvsanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvsanpham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dtgvsanpham.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvsanpham.Location = new System.Drawing.Point(3, 286);
            this.dtgvsanpham.Name = "dtgvsanpham";
            this.dtgvsanpham.ReadOnly = true;
            this.dtgvsanpham.Size = new System.Drawing.Size(866, 148);
            this.dtgvsanpham.TabIndex = 1;
            this.dtgvsanpham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtgvsanpham_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "masanpham";
            this.Column1.HeaderText = "Mã sản phẩm";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tensanpham";
            this.Column2.HeaderText = "Tên sản phẩm";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "soluong";
            this.Column3.HeaderText = "Số lượng";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "gia";
            this.Column4.HeaderText = "Giá";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "loai";
            this.Column5.HeaderText = "Loại";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "nhacungcap";
            this.Column6.HeaderText = "Nhà cung cấp";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // gbthongtin
            // 
            this.gbthongtin.Controls.Add(this.cbbloai);
            this.gbthongtin.Controls.Add(this.tbnhacungcap);
            this.gbthongtin.Controls.Add(this.lbnhacungcap);
            this.gbthongtin.Controls.Add(this.lbsoluongmua);
            this.gbthongtin.Controls.Add(this.tbsoluongmua);
            this.gbthongtin.Controls.Add(this.lbmota);
            this.gbthongtin.Controls.Add(this.lbloai);
            this.gbthongtin.Controls.Add(this.lbtensp);
            this.gbthongtin.Controls.Add(this.lbgia);
            this.gbthongtin.Controls.Add(this.lbsoluong);
            this.gbthongtin.Controls.Add(this.lbmasanpham);
            this.gbthongtin.Controls.Add(this.tbmota);
            this.gbthongtin.Controls.Add(this.tbtensp);
            this.gbthongtin.Controls.Add(this.tbmasp);
            this.gbthongtin.Controls.Add(this.tbsoluong);
            this.gbthongtin.Controls.Add(this.tbgia);
            this.gbthongtin.Location = new System.Drawing.Point(3, 8);
            this.gbthongtin.Name = "gbthongtin";
            this.gbthongtin.Size = new System.Drawing.Size(880, 148);
            this.gbthongtin.TabIndex = 3;
            this.gbthongtin.TabStop = false;
            this.gbthongtin.Text = "Thông tin";
            // 
            // cbbloai
            // 
            this.cbbloai.Enabled = false;
            this.cbbloai.FormattingEnabled = true;
            this.cbbloai.Items.AddRange(new object[] {
            "Gà",
            "Vịt",
            "Thuốc"});
            this.cbbloai.Location = new System.Drawing.Point(361, 121);
            this.cbbloai.Name = "cbbloai";
            this.cbbloai.Size = new System.Drawing.Size(138, 23);
            this.cbbloai.TabIndex = 16;
            // 
            // tbnhacungcap
            // 
            this.tbnhacungcap.Location = new System.Drawing.Point(632, 122);
            this.tbnhacungcap.Name = "tbnhacungcap";
            this.tbnhacungcap.Size = new System.Drawing.Size(215, 22);
            this.tbnhacungcap.TabIndex = 15;
            // 
            // lbnhacungcap
            // 
            this.lbnhacungcap.AutoSize = true;
            this.lbnhacungcap.Location = new System.Drawing.Point(541, 122);
            this.lbnhacungcap.Name = "lbnhacungcap";
            this.lbnhacungcap.Size = new System.Drawing.Size(81, 15);
            this.lbnhacungcap.TabIndex = 14;
            this.lbnhacungcap.Text = "Nhà cung cấp";
            // 
            // lbsoluongmua
            // 
            this.lbsoluongmua.AutoSize = true;
            this.lbsoluongmua.Location = new System.Drawing.Point(28, 122);
            this.lbsoluongmua.Name = "lbsoluongmua";
            this.lbsoluongmua.Size = new System.Drawing.Size(80, 15);
            this.lbsoluongmua.TabIndex = 13;
            this.lbsoluongmua.Text = "Số lượng mua";
            // 
            // tbsoluongmua
            // 
            this.tbsoluongmua.Location = new System.Drawing.Point(118, 122);
            this.tbsoluongmua.Name = "tbsoluongmua";
            this.tbsoluongmua.Size = new System.Drawing.Size(61, 22);
            this.tbsoluongmua.TabIndex = 12;
            this.tbsoluongmua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tbsoluongmua_KeyPress);
            // 
            // lbmota
            // 
            this.lbmota.AutoSize = true;
            this.lbmota.Location = new System.Drawing.Point(565, 25);
            this.lbmota.Name = "lbmota";
            this.lbmota.Size = new System.Drawing.Size(39, 15);
            this.lbmota.TabIndex = 10;
            this.lbmota.Text = "Mô tả";
            // 
            // lbloai
            // 
            this.lbloai.AutoSize = true;
            this.lbloai.Location = new System.Drawing.Point(273, 122);
            this.lbloai.Name = "lbloai";
            this.lbloai.Size = new System.Drawing.Size(30, 15);
            this.lbloai.TabIndex = 4;
            this.lbloai.Text = "Loại";
            // 
            // lbtensp
            // 
            this.lbtensp.AutoSize = true;
            this.lbtensp.Location = new System.Drawing.Point(273, 25);
            this.lbtensp.Name = "lbtensp";
            this.lbtensp.Size = new System.Drawing.Size(82, 15);
            this.lbtensp.TabIndex = 2;
            this.lbtensp.Text = "Tên sản phẩm";
            // 
            // lbgia
            // 
            this.lbgia.AutoSize = true;
            this.lbgia.Location = new System.Drawing.Point(273, 95);
            this.lbgia.Name = "lbgia";
            this.lbgia.Size = new System.Drawing.Size(24, 15);
            this.lbgia.TabIndex = 8;
            this.lbgia.Text = "Giá";
            // 
            // lbsoluong
            // 
            this.lbsoluong.AutoSize = true;
            this.lbsoluong.Location = new System.Drawing.Point(28, 82);
            this.lbsoluong.Name = "lbsoluong";
            this.lbsoluong.Size = new System.Drawing.Size(55, 15);
            this.lbsoluong.TabIndex = 6;
            this.lbsoluong.Text = "Số lượng";
            // 
            // lbmasanpham
            // 
            this.lbmasanpham.AutoSize = true;
            this.lbmasanpham.Location = new System.Drawing.Point(28, 29);
            this.lbmasanpham.Name = "lbmasanpham";
            this.lbmasanpham.Size = new System.Drawing.Size(79, 15);
            this.lbmasanpham.TabIndex = 0;
            this.lbmasanpham.Text = "Mã sản phẩm";
            // 
            // tbmota
            // 
            this.tbmota.Location = new System.Drawing.Point(632, 25);
            this.tbmota.Multiline = true;
            this.tbmota.Name = "tbmota";
            this.tbmota.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbmota.Size = new System.Drawing.Size(215, 72);
            this.tbmota.TabIndex = 11;
            // 
            // tbtensp
            // 
            this.tbtensp.Location = new System.Drawing.Point(361, 25);
            this.tbtensp.Multiline = true;
            this.tbtensp.Name = "tbtensp";
            this.tbtensp.Size = new System.Drawing.Size(138, 55);
            this.tbtensp.TabIndex = 3;
            // 
            // tbmasp
            // 
            this.tbmasp.Location = new System.Drawing.Point(118, 25);
            this.tbmasp.Name = "tbmasp";
            this.tbmasp.Size = new System.Drawing.Size(116, 22);
            this.tbmasp.TabIndex = 1;
            // 
            // tbsoluong
            // 
            this.tbsoluong.Enabled = false;
            this.tbsoluong.Location = new System.Drawing.Point(118, 78);
            this.tbsoluong.Name = "tbsoluong";
            this.tbsoluong.Size = new System.Drawing.Size(61, 22);
            this.tbsoluong.TabIndex = 7;
            // 
            // tbgia
            // 
            this.tbgia.Enabled = false;
            this.tbgia.Location = new System.Drawing.Point(361, 91);
            this.tbgia.Name = "tbgia";
            this.tbgia.Size = new System.Drawing.Size(138, 22);
            this.tbgia.TabIndex = 9;
            // 
            // gbchucnang
            // 
            this.gbchucnang.Controls.Add(this.btmota);
            this.gbchucnang.Controls.Add(this.btmua);
            this.gbchucnang.Controls.Add(this.cbblocnhacungcap);
            this.gbchucnang.Controls.Add(this.tbtim);
            this.gbchucnang.Controls.Add(this.btthem);
            this.gbchucnang.Controls.Add(this.btxoa);
            this.gbchucnang.Controls.Add(this.bttim);
            this.gbchucnang.Controls.Add(this.btsua);
            this.gbchucnang.Controls.Add(this.btmoi);
            this.gbchucnang.Controls.Add(this.cbblocloai);
            this.gbchucnang.Controls.Add(this.btloc);
            this.gbchucnang.Location = new System.Drawing.Point(0, 157);
            this.gbchucnang.Name = "gbchucnang";
            this.gbchucnang.Size = new System.Drawing.Size(880, 148);
            this.gbchucnang.TabIndex = 4;
            this.gbchucnang.TabStop = false;
            this.gbchucnang.Text = "Hệ thống";
            // 
            // btmota
            // 
            this.btmota.Image = global::btl.Properties.Resources.mota;
            this.btmota.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmota.Location = new System.Drawing.Point(237, 53);
            this.btmota.Name = "btmota";
            this.btmota.Size = new System.Drawing.Size(80, 40);
            this.btmota.TabIndex = 10;
            this.btmota.Text = "    MÔ TẢ";
            this.btmota.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btmota.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btmota.UseVisualStyleBackColor = true;
            this.btmota.Click += new System.EventHandler(this.Btmota_Click);
            // 
            // btmua
            // 
            this.btmua.Image = global::btl.Properties.Resources.mua;
            this.btmua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmua.Location = new System.Drawing.Point(422, 53);
            this.btmua.Name = "btmua";
            this.btmua.Size = new System.Drawing.Size(80, 40);
            this.btmua.TabIndex = 9;
            this.btmua.Text = "MUA HÀNG";
            this.btmua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btmua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btmua.UseVisualStyleBackColor = true;
            this.btmua.Click += new System.EventHandler(this.Btmua_Click);
            // 
            // cbblocnhacungcap
            // 
            this.cbblocnhacungcap.FormattingEnabled = true;
            this.cbblocnhacungcap.Items.AddRange(new object[] {
            "Công ty cổ phần Tập đoàn DABACO Việt Nam",
            "Công ty CP chăn nuôi C.P. Việt Nam",
            "Công ty TNHH Cargill Việt Nam",
            "De Heus Việt Nam",
            "TT phân phối thuốc trang trại FARMVET"});
            this.cbblocnhacungcap.Location = new System.Drawing.Point(710, 53);
            this.cbblocnhacungcap.Name = "cbblocnhacungcap";
            this.cbblocnhacungcap.Size = new System.Drawing.Size(140, 23);
            this.cbblocnhacungcap.TabIndex = 8;
            // 
            // tbtim
            // 
            this.tbtim.Location = new System.Drawing.Point(710, 85);
            this.tbtim.Multiline = true;
            this.tbtim.Name = "tbtim";
            this.tbtim.Size = new System.Drawing.Size(140, 42);
            this.tbtim.TabIndex = 7;
            // 
            // btthem
            // 
            this.btthem.Image = global::btl.Properties.Resources.them;
            this.btthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btthem.Location = new System.Drawing.Point(121, 53);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(80, 40);
            this.btthem.TabIndex = 1;
            this.btthem.Text = "THÊM";
            this.btthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btthem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.Btthem_Click);
            // 
            // btxoa
            // 
            this.btxoa.Image = global::btl.Properties.Resources.xoa;
            this.btxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btxoa.Location = new System.Drawing.Point(494, 53);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(80, 40);
            this.btxoa.TabIndex = 3;
            this.btxoa.Text = "XÓA";
            this.btxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btxoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.Btxoa_Click);
            // 
            // bttim
            // 
            this.bttim.Image = global::btl.Properties.Resources.tim;
            this.bttim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttim.Location = new System.Drawing.Point(603, 87);
            this.bttim.Name = "bttim";
            this.bttim.Size = new System.Drawing.Size(80, 40);
            this.bttim.TabIndex = 6;
            this.bttim.Text = " TÌM KIẾM";
            this.bttim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttim.UseVisualStyleBackColor = true;
            this.bttim.Click += new System.EventHandler(this.Bttim_Click);
            // 
            // btsua
            // 
            this.btsua.Image = global::btl.Properties.Resources.sua;
            this.btsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btsua.Location = new System.Drawing.Point(351, 53);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(80, 40);
            this.btsua.TabIndex = 2;
            this.btsua.Text = "SỬA";
            this.btsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btsua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.Btsua_Click);
            // 
            // btmoi
            // 
            this.btmoi.Image = global::btl.Properties.Resources.moi;
            this.btmoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmoi.Location = new System.Drawing.Point(3, 53);
            this.btmoi.Name = "btmoi";
            this.btmoi.Size = new System.Drawing.Size(80, 40);
            this.btmoi.TabIndex = 0;
            this.btmoi.Text = "MỚI";
            this.btmoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btmoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btmoi.UseVisualStyleBackColor = true;
            this.btmoi.Click += new System.EventHandler(this.Btmoi_Click);
            // 
            // cbblocloai
            // 
            this.cbblocloai.FormattingEnabled = true;
            this.cbblocloai.Items.AddRange(new object[] {
            "Gà",
            "Vịt",
            "Thuốc"});
            this.cbblocloai.Location = new System.Drawing.Point(710, 17);
            this.cbblocloai.Name = "cbblocloai";
            this.cbblocloai.Size = new System.Drawing.Size(140, 23);
            this.cbblocloai.TabIndex = 5;
            // 
            // btloc
            // 
            this.btloc.Image = global::btl.Properties.Resources.loc;
            this.btloc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btloc.Location = new System.Drawing.Point(603, 26);
            this.btloc.Name = "btloc";
            this.btloc.Size = new System.Drawing.Size(80, 40);
            this.btloc.TabIndex = 4;
            this.btloc.Text = "LỌC";
            this.btloc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btloc.UseVisualStyleBackColor = true;
            this.btloc.Click += new System.EventHandler(this.Btloc_Click);
            // 
            // tcsanpham
            // 
            this.tcsanpham.Controls.Add(this.tpsanpham);
            this.tcsanpham.Controls.Add(this.tplsmuahang);
            this.tcsanpham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcsanpham.Location = new System.Drawing.Point(0, 0);
            this.tcsanpham.Name = "tcsanpham";
            this.tcsanpham.SelectedIndex = 0;
            this.tcsanpham.Size = new System.Drawing.Size(880, 465);
            this.tcsanpham.TabIndex = 0;
            // 
            // epsoluongmua
            // 
            this.epsoluongmua.BlinkRate = 1;
            this.epsoluongmua.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epsoluongmua.ContainerControl = this;
            // 
            // Sanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 465);
            this.Controls.Add(this.tcsanpham);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sanpham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cửa sổ sản phẩm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Sanpham_FormClosing);
            this.Load += new System.EventHandler(this.Sanpham_Load);
            this.tplsmuahang.ResumeLayout(false);
            this.tplsmuahang.PerformLayout();
            this.tpsanpham.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvsanpham)).EndInit();
            this.gbthongtin.ResumeLayout(false);
            this.gbthongtin.PerformLayout();
            this.gbchucnang.ResumeLayout(false);
            this.gbchucnang.PerformLayout();
            this.tcsanpham.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.epsoluongmua)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tplsmuahang;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer rpnguoidung;
        private System.Windows.Forms.TabPage tpsanpham;
        private System.Windows.Forms.DataGridView dtgvsanpham;
        private System.Windows.Forms.GroupBox gbthongtin;
        private System.Windows.Forms.Label lbsoluongmua;
        private System.Windows.Forms.TextBox tbsoluongmua;
        private System.Windows.Forms.Label lbmota;
        private System.Windows.Forms.Label lbloai;
        private System.Windows.Forms.Label lbtensp;
        private System.Windows.Forms.Label lbgia;
        private System.Windows.Forms.Label lbsoluong;
        private System.Windows.Forms.Label lbmasanpham;
        private System.Windows.Forms.TextBox tbmota;
        private System.Windows.Forms.TextBox tbtensp;
        private System.Windows.Forms.TextBox tbmasp;
        private System.Windows.Forms.TextBox tbsoluong;
        private System.Windows.Forms.TextBox tbgia;
        private System.Windows.Forms.GroupBox gbchucnang;
        private System.Windows.Forms.Button btmota;
        private System.Windows.Forms.Button btmua;
        private System.Windows.Forms.ComboBox cbblocnhacungcap;
        private System.Windows.Forms.TextBox tbtim;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button bttim;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btmoi;
        private System.Windows.Forms.ComboBox cbblocloai;
        private System.Windows.Forms.Button btloc;
        private System.Windows.Forms.TabControl tcsanpham;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TextBox tbnhacungcap;
        private System.Windows.Forms.Label lbnhacungcap;
        private System.Windows.Forms.ComboBox cbbloai;
        private hoadonmua hoadonmua1;
        private System.Windows.Forms.ErrorProvider epsoluongmua;
    }
}