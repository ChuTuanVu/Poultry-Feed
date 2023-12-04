namespace btl
{
    partial class Dangky
    {
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

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dangky));
            this.lbemail = new System.Windows.Forms.Label();
            this.lbtennguoidung = new System.Windows.Forms.Label();
            this.lbmk = new System.Windows.Forms.Label();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.tbtennguoidung = new System.Windows.Forms.TextBox();
            this.tbmk = new System.Windows.Forms.TextBox();
            this.dtpkngaysinh = new System.Windows.Forms.DateTimePicker();
            this.epemail = new System.Windows.Forms.ErrorProvider(this.components);
            this.epsdt = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbsdt = new System.Windows.Forms.TextBox();
            this.epmk = new System.Windows.Forms.ErrorProvider(this.components);
            this.eptennguoidung = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbsdt = new System.Windows.Forms.Label();
            this.pbhienmk = new System.Windows.Forms.PictureBox();
            this.gbdangky = new System.Windows.Forms.GroupBox();
            this.btdangky = new System.Windows.Forms.Button();
            this.lbnamsinh = new System.Windows.Forms.Label();
            this.bttennguoidung = new System.Windows.Forms.Button();
            this.pbtennguoidung = new System.Windows.Forms.PictureBox();
            this.pbmk = new System.Windows.Forms.PictureBox();
            this.pbsdt = new System.Windows.Forms.PictureBox();
            this.pbemail = new System.Windows.Forms.PictureBox();
            this.btmk = new System.Windows.Forms.Button();
            this.btsdt = new System.Windows.Forms.Button();
            this.btemail = new System.Windows.Forms.Button();
            this.llbdangnhap = new System.Windows.Forms.LinkLabel();
            this.lbdacotk = new System.Windows.Forms.Label();
            this.ttemail = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epemail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epsdt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epmk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eptennguoidung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbhienmk)).BeginInit();
            this.gbdangky.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbtennguoidung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbsdt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbemail)).BeginInit();
            this.SuspendLayout();
            // 
            // lbemail
            // 
            this.lbemail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbemail.AutoSize = true;
            this.lbemail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbemail.Location = new System.Drawing.Point(109, 56);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(129, 19);
            this.lbemail.TabIndex = 4;
            this.lbemail.Text = "Nhập email của bạn";
            // 
            // lbtennguoidung
            // 
            this.lbtennguoidung.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbtennguoidung.AutoSize = true;
            this.lbtennguoidung.BackColor = System.Drawing.Color.Transparent;
            this.lbtennguoidung.Location = new System.Drawing.Point(109, 276);
            this.lbtennguoidung.Name = "lbtennguoidung";
            this.lbtennguoidung.Size = new System.Drawing.Size(136, 19);
            this.lbtennguoidung.TabIndex = 12;
            this.lbtennguoidung.Text = "Nhập tên người dùng";
            this.lbtennguoidung.Visible = false;
            // 
            // lbmk
            // 
            this.lbmk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbmk.AutoSize = true;
            this.lbmk.BackColor = System.Drawing.Color.Transparent;
            this.lbmk.Location = new System.Drawing.Point(109, 208);
            this.lbmk.Name = "lbmk";
            this.lbmk.Size = new System.Drawing.Size(92, 19);
            this.lbmk.TabIndex = 11;
            this.lbmk.Text = "Tạo mật khẩu";
            this.lbmk.Visible = false;
            // 
            // tbemail
            // 
            this.tbemail.Location = new System.Drawing.Point(109, 78);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(240, 26);
            this.tbemail.TabIndex = 0;
            this.tbemail.TextChanged += new System.EventHandler(this.Tbemail_TextChanged);
            this.tbemail.Enter += new System.EventHandler(this.Tbemail_Enter);
            this.tbemail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tbemail_KeyDown);
            this.tbemail.Leave += new System.EventHandler(this.Tbemail_Leave);
            // 
            // tbtennguoidung
            // 
            this.tbtennguoidung.Location = new System.Drawing.Point(109, 298);
            this.tbtennguoidung.Name = "tbtennguoidung";
            this.tbtennguoidung.Size = new System.Drawing.Size(240, 26);
            this.tbtennguoidung.TabIndex = 6;
            this.tbtennguoidung.Visible = false;
            this.tbtennguoidung.TextChanged += new System.EventHandler(this.Tbtennguoidung_TextChanged);
            this.tbtennguoidung.Enter += new System.EventHandler(this.Tbtennguoidung_Enter);
            this.tbtennguoidung.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tbtennguoidung_KeyDown);
            this.tbtennguoidung.Leave += new System.EventHandler(this.Tbtennguoidung_Leave);
            // 
            // tbmk
            // 
            this.tbmk.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbmk.Location = new System.Drawing.Point(109, 229);
            this.tbmk.Name = "tbmk";
            this.tbmk.Size = new System.Drawing.Size(240, 26);
            this.tbmk.TabIndex = 4;
            this.tbmk.UseSystemPasswordChar = true;
            this.tbmk.Visible = false;
            this.tbmk.TextChanged += new System.EventHandler(this.Tbmk_TextChanged);
            this.tbmk.Enter += new System.EventHandler(this.Tbmk_Enter);
            this.tbmk.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tbmk_KeyDown);
            this.tbmk.Leave += new System.EventHandler(this.Tbmk_Leave);
            // 
            // dtpkngaysinh
            // 
            this.dtpkngaysinh.CalendarForeColor = System.Drawing.Color.Transparent;
            this.dtpkngaysinh.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dtpkngaysinh.CalendarTitleBackColor = System.Drawing.Color.Transparent;
            this.dtpkngaysinh.CalendarTitleForeColor = System.Drawing.Color.Transparent;
            this.dtpkngaysinh.CalendarTrailingForeColor = System.Drawing.Color.Transparent;
            this.dtpkngaysinh.Location = new System.Drawing.Point(109, 365);
            this.dtpkngaysinh.Name = "dtpkngaysinh";
            this.dtpkngaysinh.Size = new System.Drawing.Size(240, 26);
            this.dtpkngaysinh.TabIndex = 8;
            this.dtpkngaysinh.Value = new System.DateTime(2004, 6, 2, 0, 0, 0, 0);
            this.dtpkngaysinh.Visible = false;
            // 
            // epemail
            // 
            this.epemail.BlinkRate = 1;
            this.epemail.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epemail.ContainerControl = this;
            // 
            // epsdt
            // 
            this.epsdt.BlinkRate = 1;
            this.epsdt.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epsdt.ContainerControl = this;
            // 
            // tbsdt
            // 
            this.tbsdt.Location = new System.Drawing.Point(109, 153);
            this.tbsdt.Name = "tbsdt";
            this.tbsdt.Size = new System.Drawing.Size(240, 26);
            this.tbsdt.TabIndex = 2;
            this.tbsdt.Visible = false;
            this.tbsdt.TextChanged += new System.EventHandler(this.Tbsdt_TextChanged);
            this.tbsdt.Enter += new System.EventHandler(this.Tbsdt_Enter);
            this.tbsdt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tbsdt_KeyDown);
            this.tbsdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tbsdt_KeyPress);
            this.tbsdt.Leave += new System.EventHandler(this.Tbsdt_Leave);
            // 
            // epmk
            // 
            this.epmk.BlinkRate = 1;
            this.epmk.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epmk.ContainerControl = this;
            // 
            // eptennguoidung
            // 
            this.eptennguoidung.BlinkRate = 1;
            this.eptennguoidung.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.eptennguoidung.ContainerControl = this;
            // 
            // lbsdt
            // 
            this.lbsdt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbsdt.AutoSize = true;
            this.lbsdt.BackColor = System.Drawing.Color.Transparent;
            this.lbsdt.Location = new System.Drawing.Point(109, 134);
            this.lbsdt.Name = "lbsdt";
            this.lbsdt.Size = new System.Drawing.Size(123, 19);
            this.lbsdt.TabIndex = 10;
            this.lbsdt.Text = "Nhập số điện thoại";
            this.lbsdt.Visible = false;
            // 
            // pbhienmk
            // 
            this.pbhienmk.BackColor = System.Drawing.SystemColors.Window;
            this.pbhienmk.Image = global::btl.Properties.Resources.matkhauan;
            this.pbhienmk.Location = new System.Drawing.Point(322, 233);
            this.pbhienmk.Name = "pbhienmk";
            this.pbhienmk.Size = new System.Drawing.Size(18, 18);
            this.pbhienmk.TabIndex = 20;
            this.pbhienmk.TabStop = false;
            this.pbhienmk.Visible = false;
            this.pbhienmk.Click += new System.EventHandler(this.Pbhienmk_Click);
            // 
            // gbdangky
            // 
            this.gbdangky.BackColor = System.Drawing.Color.PowderBlue;
            this.gbdangky.Controls.Add(this.btdangky);
            this.gbdangky.Controls.Add(this.lbnamsinh);
            this.gbdangky.Controls.Add(this.bttennguoidung);
            this.gbdangky.Controls.Add(this.pbhienmk);
            this.gbdangky.Controls.Add(this.pbtennguoidung);
            this.gbdangky.Controls.Add(this.pbmk);
            this.gbdangky.Controls.Add(this.pbsdt);
            this.gbdangky.Controls.Add(this.pbemail);
            this.gbdangky.Controls.Add(this.tbsdt);
            this.gbdangky.Controls.Add(this.btmk);
            this.gbdangky.Controls.Add(this.btsdt);
            this.gbdangky.Controls.Add(this.btemail);
            this.gbdangky.Controls.Add(this.lbemail);
            this.gbdangky.Controls.Add(this.tbemail);
            this.gbdangky.Controls.Add(this.lbsdt);
            this.gbdangky.Controls.Add(this.lbmk);
            this.gbdangky.Controls.Add(this.tbmk);
            this.gbdangky.Controls.Add(this.lbtennguoidung);
            this.gbdangky.Controls.Add(this.tbtennguoidung);
            this.gbdangky.Controls.Add(this.dtpkngaysinh);
            this.gbdangky.Location = new System.Drawing.Point(123, 47);
            this.gbdangky.Name = "gbdangky";
            this.gbdangky.Size = new System.Drawing.Size(476, 480);
            this.gbdangky.TabIndex = 0;
            this.gbdangky.TabStop = false;
            this.gbdangky.Text = "Chào mừng đến với chúng tôi";
            // 
            // btdangky
            // 
            this.btdangky.Location = new System.Drawing.Point(124, 420);
            this.btdangky.Name = "btdangky";
            this.btdangky.Size = new System.Drawing.Size(225, 30);
            this.btdangky.TabIndex = 9;
            this.btdangky.Text = "Tạo tài khoản";
            this.btdangky.UseVisualStyleBackColor = true;
            this.btdangky.Visible = false;
            this.btdangky.Click += new System.EventHandler(this.Btdangky_Click);
            // 
            // lbnamsinh
            // 
            this.lbnamsinh.AutoSize = true;
            this.lbnamsinh.Location = new System.Drawing.Point(109, 343);
            this.lbnamsinh.Name = "lbnamsinh";
            this.lbnamsinh.Size = new System.Drawing.Size(66, 19);
            this.lbnamsinh.TabIndex = 13;
            this.lbnamsinh.Text = "Năm sinh";
            this.lbnamsinh.Visible = false;
            // 
            // bttennguoidung
            // 
            this.bttennguoidung.AutoSize = true;
            this.bttennguoidung.Enabled = false;
            this.bttennguoidung.Location = new System.Drawing.Point(357, 297);
            this.bttennguoidung.Name = "bttennguoidung";
            this.bttennguoidung.Size = new System.Drawing.Size(86, 29);
            this.bttennguoidung.TabIndex = 7;
            this.bttennguoidung.Text = "Tiếp tục";
            this.bttennguoidung.UseVisualStyleBackColor = true;
            this.bttennguoidung.Visible = false;
            this.bttennguoidung.Click += new System.EventHandler(this.Bttennguoidung_Click);
            // 
            // pbtennguoidung
            // 
            this.pbtennguoidung.Image = global::btl.Properties.Resources.dangkymuiten;
            this.pbtennguoidung.Location = new System.Drawing.Point(73, 299);
            this.pbtennguoidung.Name = "pbtennguoidung";
            this.pbtennguoidung.Size = new System.Drawing.Size(25, 25);
            this.pbtennguoidung.TabIndex = 28;
            this.pbtennguoidung.TabStop = false;
            this.pbtennguoidung.Visible = false;
            // 
            // pbmk
            // 
            this.pbmk.Image = global::btl.Properties.Resources.dangkymuiten;
            this.pbmk.Location = new System.Drawing.Point(73, 230);
            this.pbmk.Name = "pbmk";
            this.pbmk.Size = new System.Drawing.Size(25, 25);
            this.pbmk.TabIndex = 27;
            this.pbmk.TabStop = false;
            this.pbmk.Visible = false;
            // 
            // pbsdt
            // 
            this.pbsdt.Image = global::btl.Properties.Resources.dangkymuiten;
            this.pbsdt.Location = new System.Drawing.Point(73, 154);
            this.pbsdt.Name = "pbsdt";
            this.pbsdt.Size = new System.Drawing.Size(25, 25);
            this.pbsdt.TabIndex = 26;
            this.pbsdt.TabStop = false;
            this.pbsdt.Visible = false;
            // 
            // pbemail
            // 
            this.pbemail.Image = global::btl.Properties.Resources.dangkymuiten;
            this.pbemail.Location = new System.Drawing.Point(73, 79);
            this.pbemail.Name = "pbemail";
            this.pbemail.Size = new System.Drawing.Size(25, 25);
            this.pbemail.TabIndex = 25;
            this.pbemail.TabStop = false;
            // 
            // btmk
            // 
            this.btmk.AutoSize = true;
            this.btmk.Enabled = false;
            this.btmk.Location = new System.Drawing.Point(357, 228);
            this.btmk.Name = "btmk";
            this.btmk.Size = new System.Drawing.Size(86, 29);
            this.btmk.TabIndex = 5;
            this.btmk.Text = "Tiếp tục";
            this.btmk.UseVisualStyleBackColor = true;
            this.btmk.Visible = false;
            this.btmk.Click += new System.EventHandler(this.Btmk_Click);
            // 
            // btsdt
            // 
            this.btsdt.AutoSize = true;
            this.btsdt.Enabled = false;
            this.btsdt.Location = new System.Drawing.Point(357, 152);
            this.btsdt.Name = "btsdt";
            this.btsdt.Size = new System.Drawing.Size(86, 29);
            this.btsdt.TabIndex = 3;
            this.btsdt.Text = "Tiếp tục";
            this.btsdt.UseVisualStyleBackColor = true;
            this.btsdt.Visible = false;
            this.btsdt.Click += new System.EventHandler(this.Btsdt_Click);
            // 
            // btemail
            // 
            this.btemail.AutoSize = true;
            this.btemail.Enabled = false;
            this.btemail.Location = new System.Drawing.Point(357, 77);
            this.btemail.Name = "btemail";
            this.btemail.Size = new System.Drawing.Size(86, 29);
            this.btemail.TabIndex = 1;
            this.btemail.Text = "Tiếp tục";
            this.btemail.UseVisualStyleBackColor = true;
            this.btemail.Click += new System.EventHandler(this.Btemail_Click);
            // 
            // llbdangnhap
            // 
            this.llbdangnhap.AutoSize = true;
            this.llbdangnhap.BackColor = System.Drawing.Color.Transparent;
            this.llbdangnhap.Location = new System.Drawing.Point(612, 13);
            this.llbdangnhap.Name = "llbdangnhap";
            this.llbdangnhap.Size = new System.Drawing.Size(93, 19);
            this.llbdangnhap.TabIndex = 1;
            this.llbdangnhap.TabStop = true;
            this.llbdangnhap.Text = "Đăng nhập ->";
            this.llbdangnhap.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Llbdangnhap_LinkClicked);
            // 
            // lbdacotk
            // 
            this.lbdacotk.AutoSize = true;
            this.lbdacotk.BackColor = System.Drawing.Color.Transparent;
            this.lbdacotk.Location = new System.Drawing.Point(494, 13);
            this.lbdacotk.Name = "lbdacotk";
            this.lbdacotk.Size = new System.Drawing.Size(112, 19);
            this.lbdacotk.TabIndex = 2;
            this.lbdacotk.Text = "Đã có tài khoản?";
            // 
            // ttemail
            // 
            this.ttemail.AutoPopDelay = 5000;
            this.ttemail.InitialDelay = 100;
            this.ttemail.ReshowDelay = 100;
            // 
            // Dangky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::btl.Properties.Resources.dangkynen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 527);
            this.Controls.Add(this.lbdacotk);
            this.Controls.Add(this.llbdangnhap);
            this.Controls.Add(this.gbdangky);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dangky";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cửa sổ đăng ký tài khoản";
            ((System.ComponentModel.ISupportInitialize)(this.epemail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epsdt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epmk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eptennguoidung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbhienmk)).EndInit();
            this.gbdangky.ResumeLayout(false);
            this.gbdangky.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbtennguoidung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbsdt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbemail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbemail;
        private System.Windows.Forms.Label lbtennguoidung;
        private System.Windows.Forms.Label lbmk;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.TextBox tbtennguoidung;
        private System.Windows.Forms.TextBox tbmk;
        private System.Windows.Forms.DateTimePicker dtpkngaysinh;
        private System.Windows.Forms.ErrorProvider epemail;
        private System.Windows.Forms.ErrorProvider epsdt;
        private System.Windows.Forms.ErrorProvider epmk;
        private System.Windows.Forms.ErrorProvider eptennguoidung;
        private System.Windows.Forms.Label lbsdt;
        private System.Windows.Forms.PictureBox pbhienmk;
        private System.Windows.Forms.GroupBox gbdangky;
        private System.Windows.Forms.Button bttennguoidung;
        private System.Windows.Forms.PictureBox pbtennguoidung;
        private System.Windows.Forms.PictureBox pbmk;
        private System.Windows.Forms.PictureBox pbsdt;
        private System.Windows.Forms.PictureBox pbemail;
        private System.Windows.Forms.TextBox tbsdt;
        private System.Windows.Forms.Button btmk;
        private System.Windows.Forms.Button btsdt;
        private System.Windows.Forms.Button btemail;
        private System.Windows.Forms.Label lbnamsinh;
        private System.Windows.Forms.LinkLabel llbdangnhap;
        private System.Windows.Forms.Label lbdacotk;
        private System.Windows.Forms.Button btdangky;
        private System.Windows.Forms.ToolTip ttemail;
    }
}