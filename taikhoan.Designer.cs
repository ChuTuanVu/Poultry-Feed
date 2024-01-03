namespace btl
{
    partial class Taikhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Taikhoan));
            this.dtgvtaikhoan = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbhethong = new System.Windows.Forms.GroupBox();
            this.tbtim = new System.Windows.Forms.TextBox();
            this.btmoi = new System.Windows.Forms.Button();
            this.bttim = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.gbthongtin = new System.Windows.Forms.GroupBox();
            this.tbngaysinh = new System.Windows.Forms.TextBox();
            this.dtpkngaysinh = new System.Windows.Forms.DateTimePicker();
            this.lbngaydangky = new System.Windows.Forms.Label();
            this.lbngaysinh = new System.Windows.Forms.Label();
            this.lbsdt = new System.Windows.Forms.Label();
            this.lbemail = new System.Windows.Forms.Label();
            this.lbmk = new System.Windows.Forms.Label();
            this.lbtennguoidung = new System.Windows.Forms.Label();
            this.tbngaydangky = new System.Windows.Forms.TextBox();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.tbsdt = new System.Windows.Forms.TextBox();
            this.tbmk = new System.Windows.Forms.TextBox();
            this.tbtennguoidung = new System.Windows.Forms.TextBox();
            this.tbtieude = new System.Windows.Forms.TextBox();
            this.epemail = new System.Windows.Forms.ErrorProvider(this.components);
            this.epmk = new System.Windows.Forms.ErrorProvider(this.components);
            this.epsdt = new System.Windows.Forms.ErrorProvider(this.components);
            this.eptennguoidung = new System.Windows.Forms.ErrorProvider(this.components);
            this.ttemail = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvtaikhoan)).BeginInit();
            this.gbhethong.SuspendLayout();
            this.gbthongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epemail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epmk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epsdt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eptennguoidung)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvtaikhoan
            // 
            this.dtgvtaikhoan.AllowUserToAddRows = false;
            this.dtgvtaikhoan.AllowUserToDeleteRows = false;
            this.dtgvtaikhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvtaikhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dtgvtaikhoan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvtaikhoan.Location = new System.Drawing.Point(0, 290);
            this.dtgvtaikhoan.Name = "dtgvtaikhoan";
            this.dtgvtaikhoan.ReadOnly = true;
            this.dtgvtaikhoan.Size = new System.Drawing.Size(880, 175);
            this.dtgvtaikhoan.TabIndex = 1;
            this.dtgvtaikhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtgvtaikhoan_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "tennguoidung";
            this.Column1.HeaderText = "Tên người dùng";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "matkhau";
            this.Column2.HeaderText = "Mật khẩu";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "email";
            this.Column3.HeaderText = "Email";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "sodienthoai";
            this.Column4.HeaderText = "Số điện thoại";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ngaysinh";
            this.Column5.HeaderText = "Ngày sinh";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "ngaydangky";
            this.Column6.HeaderText = "Ngày đăng ký";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // gbhethong
            // 
            this.gbhethong.Controls.Add(this.tbtim);
            this.gbhethong.Controls.Add(this.btmoi);
            this.gbhethong.Controls.Add(this.bttim);
            this.gbhethong.Controls.Add(this.btxoa);
            this.gbhethong.Controls.Add(this.btsua);
            this.gbhethong.Controls.Add(this.btthem);
            this.gbhethong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbhethong.Location = new System.Drawing.Point(0, 182);
            this.gbhethong.Name = "gbhethong";
            this.gbhethong.Size = new System.Drawing.Size(880, 108);
            this.gbhethong.TabIndex = 2;
            this.gbhethong.TabStop = false;
            this.gbhethong.Text = "Hệ thống";
            // 
            // tbtim
            // 
            this.tbtim.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbtim.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbtim.Location = new System.Drawing.Point(708, 42);
            this.tbtim.Name = "tbtim";
            this.tbtim.Size = new System.Drawing.Size(160, 22);
            this.tbtim.TabIndex = 5;
            this.tbtim.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tbtim_KeyDown);
            // 
            // btmoi
            // 
            this.btmoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btmoi.AutoSize = true;
            this.btmoi.Image = global::btl.Properties.Resources.moi;
            this.btmoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmoi.Location = new System.Drawing.Point(25, 30);
            this.btmoi.Name = "btmoi";
            this.btmoi.Size = new System.Drawing.Size(80, 45);
            this.btmoi.TabIndex = 4;
            this.btmoi.Text = "MỚI";
            this.btmoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btmoi.UseVisualStyleBackColor = true;
            this.btmoi.Click += new System.EventHandler(this.Btmoi_Click);
            // 
            // bttim
            // 
            this.bttim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttim.AutoSize = true;
            this.bttim.Image = global::btl.Properties.Resources.tim;
            this.bttim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttim.Location = new System.Drawing.Point(622, 30);
            this.bttim.Name = "bttim";
            this.bttim.Size = new System.Drawing.Size(80, 45);
            this.bttim.TabIndex = 3;
            this.bttim.Text = "TÌM";
            this.bttim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttim.UseVisualStyleBackColor = true;
            this.bttim.Click += new System.EventHandler(this.Bttim_Click);
            // 
            // btxoa
            // 
            this.btxoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btxoa.AutoSize = true;
            this.btxoa.Image = global::btl.Properties.Resources.xoa;
            this.btxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btxoa.Location = new System.Drawing.Point(464, 30);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(80, 45);
            this.btxoa.TabIndex = 2;
            this.btxoa.Text = "XÓA";
            this.btxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btxoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.Btxoa_Click);
            // 
            // btsua
            // 
            this.btsua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btsua.AutoSize = true;
            this.btsua.Image = global::btl.Properties.Resources.sua;
            this.btsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btsua.Location = new System.Drawing.Point(335, 30);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(80, 45);
            this.btsua.TabIndex = 1;
            this.btsua.Text = "SỬA";
            this.btsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btsua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.Btsua_Click);
            this.btsua.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Btsua_MouseMove);
            // 
            // btthem
            // 
            this.btthem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btthem.AutoSize = true;
            this.btthem.Image = global::btl.Properties.Resources.them;
            this.btthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btthem.Location = new System.Drawing.Point(174, 30);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(80, 45);
            this.btthem.TabIndex = 0;
            this.btthem.Text = "THÊM";
            this.btthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.Btthem_Click);
            this.btthem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Btthem_MouseMove);
            // 
            // gbthongtin
            // 
            this.gbthongtin.Controls.Add(this.tbngaysinh);
            this.gbthongtin.Controls.Add(this.dtpkngaysinh);
            this.gbthongtin.Controls.Add(this.lbngaydangky);
            this.gbthongtin.Controls.Add(this.lbngaysinh);
            this.gbthongtin.Controls.Add(this.lbsdt);
            this.gbthongtin.Controls.Add(this.lbemail);
            this.gbthongtin.Controls.Add(this.lbmk);
            this.gbthongtin.Controls.Add(this.lbtennguoidung);
            this.gbthongtin.Controls.Add(this.tbngaydangky);
            this.gbthongtin.Controls.Add(this.tbemail);
            this.gbthongtin.Controls.Add(this.tbsdt);
            this.gbthongtin.Controls.Add(this.tbmk);
            this.gbthongtin.Controls.Add(this.tbtennguoidung);
            this.gbthongtin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbthongtin.Location = new System.Drawing.Point(0, 54);
            this.gbthongtin.Name = "gbthongtin";
            this.gbthongtin.Size = new System.Drawing.Size(880, 128);
            this.gbthongtin.TabIndex = 3;
            this.gbthongtin.TabStop = false;
            this.gbthongtin.Text = "Thông tin";
            // 
            // tbngaysinh
            // 
            this.tbngaysinh.Location = new System.Drawing.Point(382, 82);
            this.tbngaysinh.Name = "tbngaysinh";
            this.tbngaysinh.Size = new System.Drawing.Size(100, 22);
            this.tbngaysinh.TabIndex = 13;
            // 
            // dtpkngaysinh
            // 
            this.dtpkngaysinh.Location = new System.Drawing.Point(382, 83);
            this.dtpkngaysinh.Name = "dtpkngaysinh";
            this.dtpkngaysinh.Size = new System.Drawing.Size(173, 22);
            this.dtpkngaysinh.TabIndex = 12;
            this.dtpkngaysinh.Value = new System.DateTime(2004, 6, 2, 0, 0, 0, 0);
            this.dtpkngaysinh.Visible = false;
            // 
            // lbngaydangky
            // 
            this.lbngaydangky.AutoSize = true;
            this.lbngaydangky.Location = new System.Drawing.Point(561, 87);
            this.lbngaydangky.Name = "lbngaydangky";
            this.lbngaydangky.Size = new System.Drawing.Size(82, 15);
            this.lbngaydangky.TabIndex = 11;
            this.lbngaydangky.Text = "Ngày đăng ký";
            this.lbngaydangky.Visible = false;
            // 
            // lbngaysinh
            // 
            this.lbngaysinh.AutoSize = true;
            this.lbngaysinh.Location = new System.Drawing.Point(313, 87);
            this.lbngaysinh.Name = "lbngaysinh";
            this.lbngaysinh.Size = new System.Drawing.Size(62, 15);
            this.lbngaysinh.TabIndex = 10;
            this.lbngaysinh.Text = "Ngày sinh";
            // 
            // lbsdt
            // 
            this.lbsdt.AutoSize = true;
            this.lbsdt.Location = new System.Drawing.Point(12, 87);
            this.lbsdt.Name = "lbsdt";
            this.lbsdt.Size = new System.Drawing.Size(77, 15);
            this.lbsdt.TabIndex = 9;
            this.lbsdt.Text = "Số điện thoại";
            // 
            // lbemail
            // 
            this.lbemail.AutoSize = true;
            this.lbemail.Location = new System.Drawing.Point(561, 21);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(35, 15);
            this.lbemail.TabIndex = 8;
            this.lbemail.Text = "Email";
            // 
            // lbmk
            // 
            this.lbmk.AutoSize = true;
            this.lbmk.Location = new System.Drawing.Point(313, 21);
            this.lbmk.Name = "lbmk";
            this.lbmk.Size = new System.Drawing.Size(58, 15);
            this.lbmk.TabIndex = 7;
            this.lbmk.Text = "Mật khẩu";
            // 
            // lbtennguoidung
            // 
            this.lbtennguoidung.AutoSize = true;
            this.lbtennguoidung.Location = new System.Drawing.Point(12, 21);
            this.lbtennguoidung.Name = "lbtennguoidung";
            this.lbtennguoidung.Size = new System.Drawing.Size(93, 15);
            this.lbtennguoidung.TabIndex = 6;
            this.lbtennguoidung.Text = "Tên nguòi dùng";
            // 
            // tbngaydangky
            // 
            this.tbngaydangky.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbngaydangky.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbngaydangky.Enabled = false;
            this.tbngaydangky.Location = new System.Drawing.Point(649, 83);
            this.tbngaydangky.Name = "tbngaydangky";
            this.tbngaydangky.Size = new System.Drawing.Size(120, 22);
            this.tbngaydangky.TabIndex = 5;
            this.tbngaydangky.Visible = false;
            // 
            // tbemail
            // 
            this.tbemail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbemail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbemail.Location = new System.Drawing.Point(617, 21);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(219, 22);
            this.tbemail.TabIndex = 4;
            this.tbemail.TextChanged += new System.EventHandler(this.Tbemail_TextChanged);
            // 
            // tbsdt
            // 
            this.tbsdt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbsdt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbsdt.Location = new System.Drawing.Point(111, 83);
            this.tbsdt.Name = "tbsdt";
            this.tbsdt.Size = new System.Drawing.Size(117, 22);
            this.tbsdt.TabIndex = 2;
            this.tbsdt.TextChanged += new System.EventHandler(this.Tbsdt_TextChanged);
            this.tbsdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tbsdt_KeyPress);
            // 
            // tbmk
            // 
            this.tbmk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbmk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbmk.Location = new System.Drawing.Point(381, 21);
            this.tbmk.Name = "tbmk";
            this.tbmk.Size = new System.Drawing.Size(100, 22);
            this.tbmk.TabIndex = 1;
            this.tbmk.TextChanged += new System.EventHandler(this.Tbmk_TextChanged);
            // 
            // tbtennguoidung
            // 
            this.tbtennguoidung.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbtennguoidung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbtennguoidung.Location = new System.Drawing.Point(111, 21);
            this.tbtennguoidung.Name = "tbtennguoidung";
            this.tbtennguoidung.Size = new System.Drawing.Size(117, 22);
            this.tbtennguoidung.TabIndex = 0;
            this.tbtennguoidung.TextChanged += new System.EventHandler(this.Tbtennguoidung_TextChanged);
            // 
            // tbtieude
            // 
            this.tbtieude.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbtieude.Enabled = false;
            this.tbtieude.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtieude.Location = new System.Drawing.Point(0, 0);
            this.tbtieude.Name = "tbtieude";
            this.tbtieude.Size = new System.Drawing.Size(880, 35);
            this.tbtieude.TabIndex = 4;
            this.tbtieude.Text = "CỬA SỔ CÁC TÀI KHOẢN ĐÃ ĐĂNG KÝ";
            this.tbtieude.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // epemail
            // 
            this.epemail.BlinkRate = 1;
            this.epemail.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epemail.ContainerControl = this;
            // 
            // epmk
            // 
            this.epmk.BlinkRate = 1;
            this.epmk.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epmk.ContainerControl = this;
            // 
            // epsdt
            // 
            this.epsdt.BlinkRate = 1;
            this.epsdt.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epsdt.ContainerControl = this;
            // 
            // eptennguoidung
            // 
            this.eptennguoidung.BlinkRate = 1;
            this.eptennguoidung.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.eptennguoidung.ContainerControl = this;
            // 
            // ttemail
            // 
            this.ttemail.AutoPopDelay = 5000;
            this.ttemail.InitialDelay = 100;
            this.ttemail.ReshowDelay = 100;
            // 
            // Taikhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(880, 465);
            this.Controls.Add(this.tbtieude);
            this.Controls.Add(this.gbthongtin);
            this.Controls.Add(this.gbhethong);
            this.Controls.Add(this.dtgvtaikhoan);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Taikhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cửa sổ tài khoản";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Taikhoan_FormClosing);
            this.Load += new System.EventHandler(this.Taikhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvtaikhoan)).EndInit();
            this.gbhethong.ResumeLayout(false);
            this.gbhethong.PerformLayout();
            this.gbthongtin.ResumeLayout(false);
            this.gbthongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epemail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epmk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epsdt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eptennguoidung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgvtaikhoan;
        private System.Windows.Forms.GroupBox gbhethong;
        private System.Windows.Forms.GroupBox gbthongtin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button bttim;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Label lbngaydangky;
        private System.Windows.Forms.Label lbngaysinh;
        private System.Windows.Forms.Label lbsdt;
        private System.Windows.Forms.Label lbemail;
        private System.Windows.Forms.Label lbmk;
        private System.Windows.Forms.Label lbtennguoidung;
        private System.Windows.Forms.TextBox tbngaydangky;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.TextBox tbsdt;
        private System.Windows.Forms.TextBox tbmk;
        private System.Windows.Forms.TextBox tbtennguoidung;
        private System.Windows.Forms.TextBox tbtieude;
        private System.Windows.Forms.ErrorProvider epemail;
        private System.Windows.Forms.ErrorProvider epmk;
        private System.Windows.Forms.ErrorProvider epsdt;
        private System.Windows.Forms.ErrorProvider eptennguoidung;
        private System.Windows.Forms.DateTimePicker dtpkngaysinh;
        private System.Windows.Forms.TextBox tbngaysinh;
        private System.Windows.Forms.Button btmoi;
        private System.Windows.Forms.TextBox tbtim;
        private System.Windows.Forms.ToolTip ttemail;
    }
}