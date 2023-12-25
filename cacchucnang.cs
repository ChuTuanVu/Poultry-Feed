using System;
using System.Windows.Forms;

namespace btl
{
    public partial class Cacchucnang : System.Windows.Forms.Form
    {

        public Cacchucnang()
        {
            InitializeComponent();
        }

        Form form = new Form();

        private void Cacchucnang_Load(object sender, EventArgs e)
        {
            if (Luu.tk == "admin")
            {
                pbchaomung.Image = Properties.Resources.chaomungadmin;
                mndoitt.Visible = false;
            }
            else
            {
                pbchaomung.Image = Properties.Resources.chaomungnguoidung;
                mnnhacungcap.Visible = false;
                mnnhanvien.Visible = false;
                mntaikhoan.Visible = false;
                mnthongke.Visible = false;
            }
        }

        private void Mndangxuat_Click(object sender, EventArgs e)
        {
            form.Dangnhap();
            Hide();
        }

        private void Mndoitt_Click(object sender, EventArgs e)
        {
            form.Doithongtin();
        }

        private void Mnthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát khỏi ứng dụng không?", "Thoát?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Mnsanpham_Click(object sender, EventArgs e)
        {
            form.Sanpham();
            Hide();
        }

        private void Mnnhanvien_Click(object sender, EventArgs e)
        {
            form.Nhanvien();
            Hide();
        }

        private void Mntaikhoan_Click(object sender, EventArgs e)
        {
            form.Taikhoan();
            Hide();
        }

        private void Mnnhacungcap_Click(object sender, EventArgs e)
        {
            form.Nhacungcap();
            Hide();
        }

        private void Mnnhap_Click(object sender, EventArgs e)
        {
            form.Hoadonnhap();
        }

        private void Mnxuat_Click(object sender, EventArgs e)
        {
            form.Hoadonxuat();
        }

        private void Mnvechungtoi_Click(object sender, EventArgs e)
        {
            form.Vechungtoi();
        }

        private void Cacchucnang_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}