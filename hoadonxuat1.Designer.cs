namespace btl
{
    partial class hoadonxuat1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hoadonxuat1));
            this.rpxuat = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.hoadonxuat2 = new btl.hoadonxuat();
            this.SuspendLayout();
            // 
            // rpxuat
            // 
            this.rpxuat.ActiveViewIndex = 0;
            this.rpxuat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rpxuat.Cursor = System.Windows.Forms.Cursors.Default;
            this.rpxuat.DisplayStatusBar = false;
            this.rpxuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpxuat.Location = new System.Drawing.Point(0, 0);
            this.rpxuat.Name = "rpxuat";
            this.rpxuat.ReportSource = this.hoadonxuat2;
            this.rpxuat.Size = new System.Drawing.Size(880, 465);
            this.rpxuat.TabIndex = 0;
            // 
            // hoadonxuat1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(880, 465);
            this.Controls.Add(this.rpxuat);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "hoadonxuat1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cửa sổ hóa đơn xuất";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.hoadonxuat1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rpxuat;
        private hoadonxuat hoadonxuat2;
    }
}