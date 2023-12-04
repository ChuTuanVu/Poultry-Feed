namespace btl
{
    partial class Cacchucnang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cacchucnang));
            this.mnhethong = new System.Windows.Forms.ToolStripMenuItem();
            this.mndangxuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mndoitt = new System.Windows.Forms.ToolStripMenuItem();
            this.mnthoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mntrogiup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnvechungtoi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnquanly = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsanpham = new System.Windows.Forms.ToolStripMenuItem();
            this.mnnhanvien = new System.Windows.Forms.ToolStripMenuItem();
            this.mntaikhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnnhacungcap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnthongke = new System.Windows.Forms.ToolStripMenuItem();
            this.mnnhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnxuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mn = new System.Windows.Forms.MenuStrip();
            this.pbchaomung = new System.Windows.Forms.PictureBox();
            this.mn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbchaomung)).BeginInit();
            this.SuspendLayout();
            // 
            // mnhethong
            // 
            this.mnhethong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mndangxuat,
            this.mndoitt,
            this.mnthoat});
            this.mnhethong.Name = "mnhethong";
            this.mnhethong.Size = new System.Drawing.Size(69, 20);
            this.mnhethong.Text = "Hệ thống";
            // 
            // mndangxuat
            // 
            this.mndangxuat.Name = "mndangxuat";
            this.mndangxuat.Size = new System.Drawing.Size(196, 22);
            this.mndangxuat.Text = "Đăng xuất";
            this.mndangxuat.Click += new System.EventHandler(this.Mndangxuat_Click);
            // 
            // mndoitt
            // 
            this.mndoitt.Name = "mndoitt";
            this.mndoitt.Size = new System.Drawing.Size(196, 22);
            this.mndoitt.Text = "Đổi thông tin tài khoản";
            this.mndoitt.Click += new System.EventHandler(this.Mndoitt_Click);
            // 
            // mnthoat
            // 
            this.mnthoat.Name = "mnthoat";
            this.mnthoat.Size = new System.Drawing.Size(196, 22);
            this.mnthoat.Text = "Thoát";
            this.mnthoat.Click += new System.EventHandler(this.Mnthoat_Click);
            // 
            // mntrogiup
            // 
            this.mntrogiup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnvechungtoi});
            this.mntrogiup.Name = "mntrogiup";
            this.mntrogiup.Size = new System.Drawing.Size(62, 20);
            this.mntrogiup.Text = "Trợ giúp";
            // 
            // mnvechungtoi
            // 
            this.mnvechungtoi.Name = "mnvechungtoi";
            this.mnvechungtoi.Size = new System.Drawing.Size(141, 22);
            this.mnvechungtoi.Text = "Về chúng tôi";
            this.mnvechungtoi.Click += new System.EventHandler(this.Mnvechungtoi_Click);
            // 
            // mnquanly
            // 
            this.mnquanly.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsanpham,
            this.mnnhanvien,
            this.mntaikhoan,
            this.mnnhacungcap});
            this.mnquanly.Name = "mnquanly";
            this.mnquanly.Size = new System.Drawing.Size(60, 20);
            this.mnquanly.Text = "Quản lý";
            // 
            // mnsanpham
            // 
            this.mnsanpham.Name = "mnsanpham";
            this.mnsanpham.Size = new System.Drawing.Size(148, 22);
            this.mnsanpham.Text = "Sản phẩm";
            this.mnsanpham.Click += new System.EventHandler(this.Mnsanpham_Click);
            // 
            // mnnhanvien
            // 
            this.mnnhanvien.Name = "mnnhanvien";
            this.mnnhanvien.Size = new System.Drawing.Size(148, 22);
            this.mnnhanvien.Text = "Nhân viên";
            this.mnnhanvien.Click += new System.EventHandler(this.Mnnhanvien_Click);
            // 
            // mntaikhoan
            // 
            this.mntaikhoan.Name = "mntaikhoan";
            this.mntaikhoan.Size = new System.Drawing.Size(148, 22);
            this.mntaikhoan.Text = "Tài khoản";
            this.mntaikhoan.Click += new System.EventHandler(this.Mntaikhoan_Click);
            // 
            // mnnhacungcap
            // 
            this.mnnhacungcap.Name = "mnnhacungcap";
            this.mnnhacungcap.Size = new System.Drawing.Size(148, 22);
            this.mnnhacungcap.Text = "Nhà cung cấp";
            this.mnnhacungcap.Click += new System.EventHandler(this.Mnnhacungcap_Click);
            // 
            // mnthongke
            // 
            this.mnthongke.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnnhap,
            this.mnxuat});
            this.mnthongke.Name = "mnthongke";
            this.mnthongke.Size = new System.Drawing.Size(121, 20);
            this.mnthongke.Text = "Thống kê - Báo cáo";
            // 
            // mnnhap
            // 
            this.mnnhap.Name = "mnnhap";
            this.mnnhap.Size = new System.Drawing.Size(103, 22);
            this.mnnhap.Text = "Nhập";
            this.mnnhap.Click += new System.EventHandler(this.Mnnhap_Click);
            // 
            // mnxuat
            // 
            this.mnxuat.Name = "mnxuat";
            this.mnxuat.Size = new System.Drawing.Size(103, 22);
            this.mnxuat.Text = "Xuất";
            this.mnxuat.Click += new System.EventHandler(this.Mnxuat_Click);
            // 
            // mn
            // 
            this.mn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnhethong,
            this.mnquanly,
            this.mnthongke,
            this.mntrogiup});
            this.mn.Location = new System.Drawing.Point(0, 0);
            this.mn.Name = "mn";
            this.mn.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.mn.Size = new System.Drawing.Size(880, 24);
            this.mn.TabIndex = 0;
            this.mn.Text = "menuStrip1";
            // 
            // pbchaomung
            // 
            this.pbchaomung.BackColor = System.Drawing.Color.Transparent;
            this.pbchaomung.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbchaomung.Location = new System.Drawing.Point(0, 24);
            this.pbchaomung.Name = "pbchaomung";
            this.pbchaomung.Size = new System.Drawing.Size(880, 130);
            this.pbchaomung.TabIndex = 2;
            this.pbchaomung.TabStop = false;
            // 
            // Cacchucnang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(880, 465);
            this.Controls.Add(this.pbchaomung);
            this.Controls.Add(this.mn);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cacchucnang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cửa sổ các chức năng chính";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cacchucnang_FormClosing);
            this.Load += new System.EventHandler(this.Cacchucnang_Load);
            this.mn.ResumeLayout(false);
            this.mn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbchaomung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem mnhethong;
        private System.Windows.Forms.ToolStripMenuItem mndangxuat;
        private System.Windows.Forms.ToolStripMenuItem mnthoat;
        private System.Windows.Forms.ToolStripMenuItem mntrogiup;
        private System.Windows.Forms.ToolStripMenuItem mnvechungtoi;
        private System.Windows.Forms.ToolStripMenuItem mnquanly;
        private System.Windows.Forms.ToolStripMenuItem mnsanpham;
        private System.Windows.Forms.ToolStripMenuItem mnthongke;
        private System.Windows.Forms.MenuStrip mn;
        private System.Windows.Forms.ToolStripMenuItem mnnhanvien;
        private System.Windows.Forms.ToolStripMenuItem mntaikhoan;
        private System.Windows.Forms.ToolStripMenuItem mndoitt;
        private System.Windows.Forms.PictureBox pbchaomung;
        private System.Windows.Forms.ToolStripMenuItem mnnhap;
        private System.Windows.Forms.ToolStripMenuItem mnxuat;
        private System.Windows.Forms.ToolStripMenuItem mnnhacungcap;
    }
}