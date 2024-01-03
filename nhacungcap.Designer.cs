namespace btl
{
    partial class nhacungcap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nhacungcap));
            this.dtgvnhacungcap = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbthongtin = new System.Windows.Forms.GroupBox();
            this.tbngayky = new System.Windows.Forms.TextBox();
            this.tbngayhethan = new System.Windows.Forms.TextBox();
            this.lbngayhethan = new System.Windows.Forms.Label();
            this.lbngayky = new System.Windows.Forms.Label();
            this.lbsdt = new System.Windows.Forms.Label();
            this.lbdiachi = new System.Windows.Forms.Label();
            this.lbtennhacc = new System.Windows.Forms.Label();
            this.lbmancc = new System.Windows.Forms.Label();
            this.tbsdt = new System.Windows.Forms.TextBox();
            this.tbdiachi = new System.Windows.Forms.TextBox();
            this.tbtenncc = new System.Windows.Forms.TextBox();
            this.tbmanhacc = new System.Windows.Forms.TextBox();
            this.dtpkngayhet = new System.Windows.Forms.DateTimePicker();
            this.dtpkngayky = new System.Windows.Forms.DateTimePicker();
            this.gbhethong = new System.Windows.Forms.GroupBox();
            this.tbtim = new System.Windows.Forms.TextBox();
            this.btmoi = new System.Windows.Forms.Button();
            this.bttim = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvnhacungcap)).BeginInit();
            this.gbthongtin.SuspendLayout();
            this.gbhethong.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvnhacungcap
            // 
            this.dtgvnhacungcap.AllowUserToAddRows = false;
            this.dtgvnhacungcap.AllowUserToDeleteRows = false;
            this.dtgvnhacungcap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvnhacungcap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvnhacungcap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dtgvnhacungcap.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvnhacungcap.Location = new System.Drawing.Point(0, 292);
            this.dtgvnhacungcap.Name = "dtgvnhacungcap";
            this.dtgvnhacungcap.ReadOnly = true;
            this.dtgvnhacungcap.Size = new System.Drawing.Size(880, 173);
            this.dtgvnhacungcap.TabIndex = 0;
            this.dtgvnhacungcap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtgvnhacungcap_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "manhacungcap";
            this.Column1.HeaderText = "Mã nhà cung cấp";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tennhacungcap";
            this.Column2.HeaderText = "Tên nhà cung cấp";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "diachi";
            this.Column3.HeaderText = "Địa chỉ";
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
            this.Column5.DataPropertyName = "ngayky";
            this.Column5.HeaderText = "Ngày ký";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "ngayhethan";
            this.Column6.HeaderText = "Ngày hết hạn";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // gbthongtin
            // 
            this.gbthongtin.Controls.Add(this.tbngayky);
            this.gbthongtin.Controls.Add(this.tbngayhethan);
            this.gbthongtin.Controls.Add(this.lbngayhethan);
            this.gbthongtin.Controls.Add(this.lbngayky);
            this.gbthongtin.Controls.Add(this.lbsdt);
            this.gbthongtin.Controls.Add(this.lbdiachi);
            this.gbthongtin.Controls.Add(this.lbtennhacc);
            this.gbthongtin.Controls.Add(this.lbmancc);
            this.gbthongtin.Controls.Add(this.tbsdt);
            this.gbthongtin.Controls.Add(this.tbdiachi);
            this.gbthongtin.Controls.Add(this.tbtenncc);
            this.gbthongtin.Controls.Add(this.tbmanhacc);
            this.gbthongtin.Controls.Add(this.dtpkngayhet);
            this.gbthongtin.Controls.Add(this.dtpkngayky);
            this.gbthongtin.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbthongtin.Location = new System.Drawing.Point(0, 0);
            this.gbthongtin.Name = "gbthongtin";
            this.gbthongtin.Size = new System.Drawing.Size(880, 152);
            this.gbthongtin.TabIndex = 1;
            this.gbthongtin.TabStop = false;
            this.gbthongtin.Text = "Thông tin";
            // 
            // tbngayky
            // 
            this.tbngayky.Location = new System.Drawing.Point(676, 30);
            this.tbngayky.Name = "tbngayky";
            this.tbngayky.Size = new System.Drawing.Size(133, 26);
            this.tbngayky.TabIndex = 13;
            // 
            // tbngayhethan
            // 
            this.tbngayhethan.Location = new System.Drawing.Point(676, 111);
            this.tbngayhethan.Name = "tbngayhethan";
            this.tbngayhethan.Size = new System.Drawing.Size(133, 26);
            this.tbngayhethan.TabIndex = 12;
            // 
            // lbngayhethan
            // 
            this.lbngayhethan.AutoSize = true;
            this.lbngayhethan.Location = new System.Drawing.Point(564, 115);
            this.lbngayhethan.Name = "lbngayhethan";
            this.lbngayhethan.Size = new System.Drawing.Size(89, 19);
            this.lbngayhethan.TabIndex = 11;
            this.lbngayhethan.Text = "Ngày hết hạn";
            // 
            // lbngayky
            // 
            this.lbngayky.AutoSize = true;
            this.lbngayky.Location = new System.Drawing.Point(592, 34);
            this.lbngayky.Name = "lbngayky";
            this.lbngayky.Size = new System.Drawing.Size(61, 19);
            this.lbngayky.TabIndex = 10;
            this.lbngayky.Text = "Ngày ký";
            // 
            // lbsdt
            // 
            this.lbsdt.AutoSize = true;
            this.lbsdt.Location = new System.Drawing.Point(6, 115);
            this.lbsdt.Name = "lbsdt";
            this.lbsdt.Size = new System.Drawing.Size(88, 19);
            this.lbsdt.TabIndex = 9;
            this.lbsdt.Text = "Số điện thoại";
            // 
            // lbdiachi
            // 
            this.lbdiachi.AutoSize = true;
            this.lbdiachi.Location = new System.Drawing.Point(256, 115);
            this.lbdiachi.Name = "lbdiachi";
            this.lbdiachi.Size = new System.Drawing.Size(51, 19);
            this.lbdiachi.TabIndex = 8;
            this.lbdiachi.Text = "Địa chỉ";
            // 
            // lbtennhacc
            // 
            this.lbtennhacc.AutoSize = true;
            this.lbtennhacc.Location = new System.Drawing.Point(256, 34);
            this.lbtennhacc.Name = "lbtennhacc";
            this.lbtennhacc.Size = new System.Drawing.Size(115, 19);
            this.lbtennhacc.TabIndex = 7;
            this.lbtennhacc.Text = "Tên nhà cung cấp";
            // 
            // lbmancc
            // 
            this.lbmancc.AutoSize = true;
            this.lbmancc.Location = new System.Drawing.Point(6, 34);
            this.lbmancc.Name = "lbmancc";
            this.lbmancc.Size = new System.Drawing.Size(113, 19);
            this.lbmancc.TabIndex = 6;
            this.lbmancc.Text = "Mã nhà cung cấp";
            // 
            // tbsdt
            // 
            this.tbsdt.Location = new System.Drawing.Point(120, 111);
            this.tbsdt.Name = "tbsdt";
            this.tbsdt.Size = new System.Drawing.Size(100, 26);
            this.tbsdt.TabIndex = 5;
            // 
            // tbdiachi
            // 
            this.tbdiachi.Location = new System.Drawing.Point(372, 111);
            this.tbdiachi.Multiline = true;
            this.tbdiachi.Name = "tbdiachi";
            this.tbdiachi.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbdiachi.Size = new System.Drawing.Size(186, 26);
            this.tbdiachi.TabIndex = 4;
            // 
            // tbtenncc
            // 
            this.tbtenncc.Location = new System.Drawing.Point(372, 30);
            this.tbtenncc.Multiline = true;
            this.tbtenncc.Name = "tbtenncc";
            this.tbtenncc.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbtenncc.Size = new System.Drawing.Size(186, 26);
            this.tbtenncc.TabIndex = 3;
            // 
            // tbmanhacc
            // 
            this.tbmanhacc.Location = new System.Drawing.Point(120, 30);
            this.tbmanhacc.Name = "tbmanhacc";
            this.tbmanhacc.Size = new System.Drawing.Size(77, 26);
            this.tbmanhacc.TabIndex = 2;
            // 
            // dtpkngayhet
            // 
            this.dtpkngayhet.CalendarFont = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkngayhet.Location = new System.Drawing.Point(676, 111);
            this.dtpkngayhet.Name = "dtpkngayhet";
            this.dtpkngayhet.Size = new System.Drawing.Size(198, 26);
            this.dtpkngayhet.TabIndex = 1;
            this.dtpkngayhet.Visible = false;
            // 
            // dtpkngayky
            // 
            this.dtpkngayky.CalendarFont = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkngayky.Location = new System.Drawing.Point(676, 30);
            this.dtpkngayky.Name = "dtpkngayky";
            this.dtpkngayky.Size = new System.Drawing.Size(198, 26);
            this.dtpkngayky.TabIndex = 0;
            this.dtpkngayky.Visible = false;
            // 
            // gbhethong
            // 
            this.gbhethong.Controls.Add(this.tbtim);
            this.gbhethong.Controls.Add(this.btmoi);
            this.gbhethong.Controls.Add(this.bttim);
            this.gbhethong.Controls.Add(this.btxoa);
            this.gbhethong.Controls.Add(this.btsua);
            this.gbhethong.Controls.Add(this.btthem);
            this.gbhethong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbhethong.Location = new System.Drawing.Point(0, 152);
            this.gbhethong.Name = "gbhethong";
            this.gbhethong.Size = new System.Drawing.Size(880, 140);
            this.gbhethong.TabIndex = 2;
            this.gbhethong.TabStop = false;
            this.gbhethong.Text = "Hệ thống";
            // 
            // tbtim
            // 
            this.tbtim.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbtim.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbtim.Location = new System.Drawing.Point(682, 60);
            this.tbtim.Name = "tbtim";
            this.tbtim.Size = new System.Drawing.Size(172, 26);
            this.tbtim.TabIndex = 10;
            this.tbtim.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tbtim_KeyDown);
            // 
            // btmoi
            // 
            this.btmoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btmoi.AutoSize = true;
            this.btmoi.Image = global::btl.Properties.Resources.moi;
            this.btmoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmoi.Location = new System.Drawing.Point(27, 50);
            this.btmoi.Name = "btmoi";
            this.btmoi.Size = new System.Drawing.Size(80, 45);
            this.btmoi.TabIndex = 9;
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
            this.bttim.Location = new System.Drawing.Point(596, 50);
            this.bttim.Name = "bttim";
            this.bttim.Size = new System.Drawing.Size(80, 45);
            this.bttim.TabIndex = 8;
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
            this.btxoa.Location = new System.Drawing.Point(455, 50);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(85, 45);
            this.btxoa.TabIndex = 7;
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
            this.btsua.Location = new System.Drawing.Point(322, 50);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(83, 45);
            this.btsua.TabIndex = 6;
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
            this.btthem.Location = new System.Drawing.Point(176, 50);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(80, 45);
            this.btthem.TabIndex = 5;
            this.btthem.Text = "THÊM";
            this.btthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.Btthem_Click);
            this.btthem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Btthem_MouseMove);
            // 
            // nhacungcap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(880, 465);
            this.Controls.Add(this.gbhethong);
            this.Controls.Add(this.gbthongtin);
            this.Controls.Add(this.dtgvnhacungcap);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "nhacungcap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cửa sổ nhà cung cấp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Nhacungcap_FormClosing);
            this.Load += new System.EventHandler(this.Nhacungcap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvnhacungcap)).EndInit();
            this.gbthongtin.ResumeLayout(false);
            this.gbthongtin.PerformLayout();
            this.gbhethong.ResumeLayout(false);
            this.gbhethong.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvnhacungcap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.GroupBox gbthongtin;
        private System.Windows.Forms.Label lbngayhethan;
        private System.Windows.Forms.Label lbngayky;
        private System.Windows.Forms.Label lbsdt;
        private System.Windows.Forms.Label lbdiachi;
        private System.Windows.Forms.Label lbtennhacc;
        private System.Windows.Forms.Label lbmancc;
        private System.Windows.Forms.TextBox tbsdt;
        private System.Windows.Forms.TextBox tbdiachi;
        private System.Windows.Forms.TextBox tbtenncc;
        private System.Windows.Forms.TextBox tbmanhacc;
        private System.Windows.Forms.DateTimePicker dtpkngayhet;
        private System.Windows.Forms.DateTimePicker dtpkngayky;
        private System.Windows.Forms.GroupBox gbhethong;
        private System.Windows.Forms.Button btmoi;
        private System.Windows.Forms.Button bttim;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.TextBox tbtim;
        private System.Windows.Forms.TextBox tbngayky;
        private System.Windows.Forms.TextBox tbngayhethan;
    }
}