namespace btl
{
    partial class Doithongtin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doithongtin));
            this.lbtaikhoan = new System.Windows.Forms.Label();
            this.tbtaikhoan = new System.Windows.Forms.TextBox();
            this.lbemail = new System.Windows.Forms.Label();
            this.lbmatkhau = new System.Windows.Forms.Label();
            this.lbsdt = new System.Windows.Forms.Label();
            this.lbngaysinh = new System.Windows.Forms.Label();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.tbmk = new System.Windows.Forms.TextBox();
            this.tbsdt = new System.Windows.Forms.TextBox();
            this.demnguoc = new System.Windows.Forms.Timer(this.components);
            this.btdoi = new System.Windows.Forms.Button();
            this.dtpkngaysinh = new System.Windows.Forms.DateTimePicker();
            this.pbtennguoidung = new System.Windows.Forms.PictureBox();
            this.pbemail = new System.Windows.Forms.PictureBox();
            this.pbmatkhau = new System.Windows.Forms.PictureBox();
            this.pbsdt = new System.Windows.Forms.PictureBox();
            this.pbngaysinh = new System.Windows.Forms.PictureBox();
            this.pbhienmk = new System.Windows.Forms.PictureBox();
            this.epemail = new System.Windows.Forms.ErrorProvider(this.components);
            this.epsdt = new System.Windows.Forms.ErrorProvider(this.components);
            this.epmk = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbtennguoidung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbemail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmatkhau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbsdt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbngaysinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbhienmk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epemail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epsdt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epmk)).BeginInit();
            this.SuspendLayout();
            // 
            // lbtaikhoan
            // 
            this.lbtaikhoan.AutoSize = true;
            this.lbtaikhoan.Location = new System.Drawing.Point(31, 20);
            this.lbtaikhoan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbtaikhoan.Name = "lbtaikhoan";
            this.lbtaikhoan.Size = new System.Drawing.Size(103, 19);
            this.lbtaikhoan.TabIndex = 9;
            this.lbtaikhoan.Text = "Tên người dùng";
            // 
            // tbtaikhoan
            // 
            this.tbtaikhoan.Location = new System.Drawing.Point(181, 13);
            this.tbtaikhoan.Margin = new System.Windows.Forms.Padding(4);
            this.tbtaikhoan.Name = "tbtaikhoan";
            this.tbtaikhoan.ReadOnly = true;
            this.tbtaikhoan.Size = new System.Drawing.Size(205, 26);
            this.tbtaikhoan.TabIndex = 10;
            this.tbtaikhoan.Click += new System.EventHandler(this.Tbtaikhoan_Click);
            // 
            // lbemail
            // 
            this.lbemail.AutoSize = true;
            this.lbemail.Location = new System.Drawing.Point(31, 70);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(45, 19);
            this.lbemail.TabIndex = 0;
            this.lbemail.Text = "Email:";
            // 
            // lbmatkhau
            // 
            this.lbmatkhau.AutoSize = true;
            this.lbmatkhau.Location = new System.Drawing.Point(31, 126);
            this.lbmatkhau.Name = "lbmatkhau";
            this.lbmatkhau.Size = new System.Drawing.Size(70, 19);
            this.lbmatkhau.TabIndex = 2;
            this.lbmatkhau.Text = "Mật khẩu:";
            // 
            // lbsdt
            // 
            this.lbsdt.AutoSize = true;
            this.lbsdt.Location = new System.Drawing.Point(31, 195);
            this.lbsdt.Name = "lbsdt";
            this.lbsdt.Size = new System.Drawing.Size(91, 19);
            this.lbsdt.TabIndex = 4;
            this.lbsdt.Text = "Số điện thoại:";
            // 
            // lbngaysinh
            // 
            this.lbngaysinh.AutoSize = true;
            this.lbngaysinh.Location = new System.Drawing.Point(31, 238);
            this.lbngaysinh.Name = "lbngaysinh";
            this.lbngaysinh.Size = new System.Drawing.Size(72, 19);
            this.lbngaysinh.TabIndex = 6;
            this.lbngaysinh.Text = "Ngày sinh:";
            // 
            // tbemail
            // 
            this.tbemail.Location = new System.Drawing.Point(181, 68);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(205, 26);
            this.tbemail.TabIndex = 1;
            this.tbemail.TextChanged += new System.EventHandler(this.Tbemail_TextChanged);
            // 
            // tbmk
            // 
            this.tbmk.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbmk.Location = new System.Drawing.Point(181, 124);
            this.tbmk.Name = "tbmk";
            this.tbmk.Size = new System.Drawing.Size(205, 26);
            this.tbmk.TabIndex = 3;
            this.tbmk.UseSystemPasswordChar = true;
            this.tbmk.TextChanged += new System.EventHandler(this.Tbmk_TextChanged);
            // 
            // tbsdt
            // 
            this.tbsdt.Location = new System.Drawing.Point(181, 193);
            this.tbsdt.Name = "tbsdt";
            this.tbsdt.Size = new System.Drawing.Size(205, 26);
            this.tbsdt.TabIndex = 5;
            this.tbsdt.TextChanged += new System.EventHandler(this.Tbsdt_TextChanged);
            this.tbsdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tbsdt_KeyPress);
            // 
            // demnguoc
            // 
            this.demnguoc.Interval = 1000;
            this.demnguoc.Tick += new System.EventHandler(this.Demnguoc_Tick);
            // 
            // btdoi
            // 
            this.btdoi.Image = global::btl.Properties.Resources.doi;
            this.btdoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btdoi.Location = new System.Drawing.Point(432, 124);
            this.btdoi.Name = "btdoi";
            this.btdoi.Size = new System.Drawing.Size(75, 30);
            this.btdoi.TabIndex = 8;
            this.btdoi.Text = "Đổi";
            this.btdoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btdoi.UseVisualStyleBackColor = true;
            this.btdoi.Click += new System.EventHandler(this.Btdoi_Click);
            // 
            // dtpkngaysinh
            // 
            this.dtpkngaysinh.Location = new System.Drawing.Point(181, 238);
            this.dtpkngaysinh.Name = "dtpkngaysinh";
            this.dtpkngaysinh.Size = new System.Drawing.Size(205, 26);
            this.dtpkngaysinh.TabIndex = 7;
            this.dtpkngaysinh.Value = new System.DateTime(2004, 6, 2, 0, 0, 0, 0);
            // 
            // pbtennguoidung
            // 
            this.pbtennguoidung.Image = global::btl.Properties.Resources.tennguoidung;
            this.pbtennguoidung.Location = new System.Drawing.Point(147, 13);
            this.pbtennguoidung.Name = "pbtennguoidung";
            this.pbtennguoidung.Size = new System.Drawing.Size(26, 26);
            this.pbtennguoidung.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbtennguoidung.TabIndex = 12;
            this.pbtennguoidung.TabStop = false;
            // 
            // pbemail
            // 
            this.pbemail.Image = global::btl.Properties.Resources.email;
            this.pbemail.Location = new System.Drawing.Point(147, 70);
            this.pbemail.Name = "pbemail";
            this.pbemail.Size = new System.Drawing.Size(26, 26);
            this.pbemail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbemail.TabIndex = 13;
            this.pbemail.TabStop = false;
            // 
            // pbmatkhau
            // 
            this.pbmatkhau.Image = global::btl.Properties.Resources.matkhau;
            this.pbmatkhau.Location = new System.Drawing.Point(147, 124);
            this.pbmatkhau.Name = "pbmatkhau";
            this.pbmatkhau.Size = new System.Drawing.Size(26, 26);
            this.pbmatkhau.TabIndex = 14;
            this.pbmatkhau.TabStop = false;
            // 
            // pbsdt
            // 
            this.pbsdt.Image = global::btl.Properties.Resources.lienlac;
            this.pbsdt.Location = new System.Drawing.Point(147, 193);
            this.pbsdt.Name = "pbsdt";
            this.pbsdt.Size = new System.Drawing.Size(26, 26);
            this.pbsdt.TabIndex = 15;
            this.pbsdt.TabStop = false;
            // 
            // pbngaysinh
            // 
            this.pbngaysinh.Image = global::btl.Properties.Resources.ngaysinh;
            this.pbngaysinh.Location = new System.Drawing.Point(147, 238);
            this.pbngaysinh.Name = "pbngaysinh";
            this.pbngaysinh.Size = new System.Drawing.Size(26, 26);
            this.pbngaysinh.TabIndex = 16;
            this.pbngaysinh.TabStop = false;
            // 
            // pbhienmk
            // 
            this.pbhienmk.BackColor = System.Drawing.SystemColors.Window;
            this.pbhienmk.Image = global::btl.Properties.Resources.matkhauan;
            this.pbhienmk.Location = new System.Drawing.Point(359, 128);
            this.pbhienmk.Name = "pbhienmk";
            this.pbhienmk.Size = new System.Drawing.Size(18, 17);
            this.pbhienmk.TabIndex = 19;
            this.pbhienmk.TabStop = false;
            this.pbhienmk.Click += new System.EventHandler(this.Pbhienmk_Click);
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
            // epmk
            // 
            this.epmk.BlinkRate = 1;
            this.epmk.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epmk.ContainerControl = this;
            // 
            // Doithongtin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(544, 276);
            this.Controls.Add(this.pbhienmk);
            this.Controls.Add(this.pbngaysinh);
            this.Controls.Add(this.pbsdt);
            this.Controls.Add(this.pbmatkhau);
            this.Controls.Add(this.pbemail);
            this.Controls.Add(this.pbtennguoidung);
            this.Controls.Add(this.dtpkngaysinh);
            this.Controls.Add(this.btdoi);
            this.Controls.Add(this.tbsdt);
            this.Controls.Add(this.tbmk);
            this.Controls.Add(this.tbemail);
            this.Controls.Add(this.lbngaysinh);
            this.Controls.Add(this.lbsdt);
            this.Controls.Add(this.lbmatkhau);
            this.Controls.Add(this.lbemail);
            this.Controls.Add(this.tbtaikhoan);
            this.Controls.Add(this.lbtaikhoan);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Doithongtin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi thông tin tài khoản";
            this.Load += new System.EventHandler(this.Doithongtin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbtennguoidung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbemail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmatkhau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbsdt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbngaysinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbhienmk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epemail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epsdt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epmk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbtaikhoan;
        private System.Windows.Forms.TextBox tbtaikhoan;
        private System.Windows.Forms.Label lbemail;
        private System.Windows.Forms.Label lbmatkhau;
        private System.Windows.Forms.Label lbsdt;
        private System.Windows.Forms.Label lbngaysinh;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.TextBox tbmk;
        private System.Windows.Forms.TextBox tbsdt;
        private System.Windows.Forms.Timer demnguoc;
        private System.Windows.Forms.Button btdoi;
        private System.Windows.Forms.DateTimePicker dtpkngaysinh;
        private System.Windows.Forms.PictureBox pbtennguoidung;
        private System.Windows.Forms.PictureBox pbemail;
        private System.Windows.Forms.PictureBox pbmatkhau;
        private System.Windows.Forms.PictureBox pbsdt;
        private System.Windows.Forms.PictureBox pbngaysinh;
        private System.Windows.Forms.PictureBox pbhienmk;
        private System.Windows.Forms.ErrorProvider epemail;
        private System.Windows.Forms.ErrorProvider epsdt;
        private System.Windows.Forms.ErrorProvider epmk;
    }
}