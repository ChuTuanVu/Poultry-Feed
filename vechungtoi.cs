namespace btl
{
    public partial class vechungtoi : System.Windows.Forms.Form
    {
        public vechungtoi()
        {
            InitializeComponent();
        }

        private void Pbfb_Click(object sender, System.EventArgs e)
        {
            string fb = "https://www.facebook.com/100082459070147";
            System.Diagnostics.Process.Start(fb);
        }

        private void Pbemail_Click(object sender, System.EventArgs e)
        {
            string email = "chutuanvu020604@gmail.com";
            System.Diagnostics.ProcessStartInfo mo = new System.Diagnostics.ProcessStartInfo
            {
                FileName = "mailto:" + email,
                UseShellExecute = true
            };
            System.Diagnostics.Process.Start(mo);
        }
    }
}