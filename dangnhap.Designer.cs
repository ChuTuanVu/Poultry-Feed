namespace btl
{
    partial class dangnhap
    {
        private System.ComponentModel.IContainer components = null;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dangnhap));
            this.grbchucnang = new System.Windows.Forms.GroupBox();
            this.lbmk1 = new System.Windows.Forms.Label();
            this.lbtennguoidung1 = new System.Windows.Forms.Label();
            this.llbdangky = new System.Windows.Forms.LinkLabel();
            this.llbquenmk = new System.Windows.Forms.LinkLabel();
            this.pbanhdaidien = new System.Windows.Forms.PictureBox();
            this.pbhienmk = new System.Windows.Forms.PictureBox();
            this.btdangnhap = new System.Windows.Forms.Button();
            this.tbmk = new System.Windows.Forms.TextBox();
            this.tbtennguoidung = new System.Windows.Forms.TextBox();
            this.lbmk = new System.Windows.Forms.Label();
            this.lbtennguoidung = new System.Windows.Forms.Label();
            this.lbdangnhap = new System.Windows.Forms.Label();
            this.pbhinhnen = new System.Windows.Forms.PictureBox();
            this.grbchucnang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbanhdaidien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbhienmk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbhinhnen)).BeginInit();
            this.SuspendLayout();
            // 
            // grbchucnang
            // 
            this.grbchucnang.BackColor = System.Drawing.SystemColors.Window;
            this.grbchucnang.Controls.Add(this.lbmk1);
            this.grbchucnang.Controls.Add(this.lbtennguoidung1);
            this.grbchucnang.Controls.Add(this.llbdangky);
            this.grbchucnang.Controls.Add(this.llbquenmk);
            this.grbchucnang.Controls.Add(this.pbanhdaidien);
            this.grbchucnang.Controls.Add(this.pbhienmk);
            this.grbchucnang.Controls.Add(this.btdangnhap);
            this.grbchucnang.Controls.Add(this.tbmk);
            this.grbchucnang.Controls.Add(this.tbtennguoidung);
            this.grbchucnang.Controls.Add(this.lbmk);
            this.grbchucnang.Controls.Add(this.lbtennguoidung);
            this.grbchucnang.Controls.Add(this.lbdangnhap);
            resources.ApplyResources(this.grbchucnang, "grbchucnang");
            this.grbchucnang.Name = "grbchucnang";
            this.grbchucnang.TabStop = false;
            // 
            // lbmk1
            // 
            resources.ApplyResources(this.lbmk1, "lbmk1");
            this.lbmk1.BackColor = System.Drawing.Color.Transparent;
            this.lbmk1.Name = "lbmk1";
            this.lbmk1.Click += new System.EventHandler(this.Lbmk1_Click);
            // 
            // lbtennguoidung1
            // 
            resources.ApplyResources(this.lbtennguoidung1, "lbtennguoidung1");
            this.lbtennguoidung1.BackColor = System.Drawing.Color.Transparent;
            this.lbtennguoidung1.Name = "lbtennguoidung1";
            this.lbtennguoidung1.Click += new System.EventHandler(this.Lbtennguoidung1_Click);
            // 
            // llbdangky
            // 
            resources.ApplyResources(this.llbdangky, "llbdangky");
            this.llbdangky.Name = "llbdangky";
            this.llbdangky.TabStop = true;
            this.llbdangky.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Llbdangky_LinkClicked);
            // 
            // llbquenmk
            // 
            resources.ApplyResources(this.llbquenmk, "llbquenmk");
            this.llbquenmk.Name = "llbquenmk";
            this.llbquenmk.TabStop = true;
            this.llbquenmk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Llbquenmk_LinkClicked);
            // 
            // pbanhdaidien
            // 
            this.pbanhdaidien.BackColor = System.Drawing.SystemColors.Window;
            this.pbanhdaidien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbanhdaidien.Image = global::btl.Properties.Resources.dangnhapicon;
            resources.ApplyResources(this.pbanhdaidien, "pbanhdaidien");
            this.pbanhdaidien.Name = "pbanhdaidien";
            this.pbanhdaidien.TabStop = false;
            // 
            // pbhienmk
            // 
            this.pbhienmk.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pbhienmk, "pbhienmk");
            this.pbhienmk.Image = global::btl.Properties.Resources.matkhauan;
            this.pbhienmk.Name = "pbhienmk";
            this.pbhienmk.TabStop = false;
            this.pbhienmk.Click += new System.EventHandler(this.Pbhienmk_Click);
            // 
            // btdangnhap
            // 
            resources.ApplyResources(this.btdangnhap, "btdangnhap");
            this.btdangnhap.BackColor = System.Drawing.Color.Transparent;
            this.btdangnhap.FlatAppearance.BorderSize = 0;
            this.btdangnhap.ForeColor = System.Drawing.Color.Transparent;
            this.btdangnhap.Name = "btdangnhap";
            this.btdangnhap.UseVisualStyleBackColor = true;
            this.btdangnhap.Click += new System.EventHandler(this.Btdangnhap_Click);
            // 
            // tbmk
            // 
            resources.ApplyResources(this.tbmk, "tbmk");
            this.tbmk.Name = "tbmk";
            this.tbmk.UseSystemPasswordChar = true;
            this.tbmk.TextChanged += new System.EventHandler(this.Tbmk_TextChanged);
            this.tbmk.Enter += new System.EventHandler(this.Tbmk_Enter);
            this.tbmk.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tbmk_KeyDown);
            this.tbmk.Leave += new System.EventHandler(this.Tbmk_Leave);
            // 
            // tbtennguoidung
            // 
            this.tbtennguoidung.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.tbtennguoidung, "tbtennguoidung");
            this.tbtennguoidung.Name = "tbtennguoidung";
            this.tbtennguoidung.Enter += new System.EventHandler(this.Tbtennguoidung_Enter);
            this.tbtennguoidung.Leave += new System.EventHandler(this.Tbtennguoidung_Leave);
            // 
            // lbmk
            // 
            resources.ApplyResources(this.lbmk, "lbmk");
            this.lbmk.Name = "lbmk";
            // 
            // lbtennguoidung
            // 
            resources.ApplyResources(this.lbtennguoidung, "lbtennguoidung");
            this.lbtennguoidung.Name = "lbtennguoidung";
            // 
            // lbdangnhap
            // 
            resources.ApplyResources(this.lbdangnhap, "lbdangnhap");
            this.lbdangnhap.Name = "lbdangnhap";
            // 
            // pbhinhnen
            // 
            resources.ApplyResources(this.pbhinhnen, "pbhinhnen");
            this.pbhinhnen.Image = global::btl.Properties.Resources.hinhnen;
            this.pbhinhnen.Name = "pbhinhnen";
            this.pbhinhnen.TabStop = false;
            // 
            // dangnhap
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.pbhinhnen);
            this.Controls.Add(this.grbchucnang);
            this.Name = "dangnhap";
            this.grbchucnang.ResumeLayout(false);
            this.grbchucnang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbanhdaidien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbhienmk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbhinhnen)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grbchucnang;
        private System.Windows.Forms.Button btdangnhap;
        private System.Windows.Forms.PictureBox pbhinhnen;
        private System.Windows.Forms.LinkLabel llbdangky;
        private System.Windows.Forms.LinkLabel llbquenmk;
        private System.Windows.Forms.PictureBox pbanhdaidien;
        private System.Windows.Forms.PictureBox pbhienmk;
        private System.Windows.Forms.TextBox tbmk;
        private System.Windows.Forms.TextBox tbtennguoidung;
        private System.Windows.Forms.Label lbmk;
        private System.Windows.Forms.Label lbtennguoidung;
        private System.Windows.Forms.Label lbdangnhap;
        private System.Windows.Forms.Label lbmk1;
        private System.Windows.Forms.Label lbtennguoidung1;
    }
}

