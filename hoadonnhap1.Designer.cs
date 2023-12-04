namespace btl
{
    partial class hoadonnhap1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hoadonnhap1));
            this.rpnhap = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.hoadonnhap2 = new btl.hoadonnhap();
            this.SuspendLayout();
            // 
            // rpnhap
            // 
            this.rpnhap.ActiveViewIndex = 0;
            this.rpnhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rpnhap.Cursor = System.Windows.Forms.Cursors.Default;
            this.rpnhap.DisplayStatusBar = false;
            this.rpnhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpnhap.Location = new System.Drawing.Point(0, 0);
            this.rpnhap.Name = "rpnhap";
            this.rpnhap.ReportSource = this.hoadonnhap2;
            this.rpnhap.Size = new System.Drawing.Size(880, 465);
            this.rpnhap.TabIndex = 0;
            // 
            // hoadonnhap1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(880, 465);
            this.Controls.Add(this.rpnhap);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "hoadonnhap1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cửa số hóa đơn nhập";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.hoadonnhap1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rpnhap;
        private hoadonnhap hoadonnhap2;
    }
}