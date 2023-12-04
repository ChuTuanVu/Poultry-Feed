using System;
using System.Drawing;
using System.Windows.Forms;


namespace btl
{
    public partial class dangnhap : System.Windows.Forms.Form
    {
        public dangnhap()
        {
            InitializeComponent();
        }

        private Database database = new Database();
        private Form form = new Form();

        private void Lbtennguoidung1_Click(object sender, EventArgs e)
        {
            lbtennguoidung1.Visible = false;
            lbtennguoidung.Visible = true;
            tbtennguoidung.Focus();
        }


        private void Lbmk1_Click(object sender, EventArgs e)
        {
            lbmk1.Visible = false;
            lbmk.Visible = true;
            tbmk.Focus();
        }

        private void Pbhienmk_Click(object sender, EventArgs e)
        {
            if (tbmk.UseSystemPasswordChar)
            {
                tbmk.UseSystemPasswordChar = false;
                pbhienmk.Image = Properties.Resources.matkhauhien;
            }
            else
            {
                tbmk.UseSystemPasswordChar = true;
                pbhienmk.Image = Properties.Resources.matkhauan;
            }
        }


        private void Btdangnhap_Click(object sender, EventArgs e)
        {
            string count = "select count (*) from taikhoan where tennguoidung = '" + tbtennguoidung.Text + "' and matkhau = '" + tbmk.Text + "'";
            int dem = database.Dem(count);
            if (dem > 0)
            {
                Luu.tk = tbtennguoidung.Text;
                form.Cacchucnang();
                Hide();
            }
            else
            {
                MessageBox.Show("Thông tin xác thực đăng nhập của bạn không khớp với tài khoản trong hệ thống.","Kiểm tra lại thông tin");
                tbmk.Clear();
                tbmk.Focus();
            }
        }

        private void Llbdangky_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            form.Dangky();
            Hide();
        }

        private void Llbquenmk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            form.Quenmatkhau();
            Hide();
        }

        private void Tbmk_Enter(object sender, EventArgs e)
        {
            lbmk1.Visible = false;
            lbmk.Visible = true;
        }

        private void Tbmk_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbmk.Text))
            {
                lbmk1.Visible = true;
                lbmk.Visible = false;
            }
        }

        private void Tbtennguoidung_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbtennguoidung.Text))
            {
                lbtennguoidung1.Visible = true;
                lbtennguoidung.Visible = false;
            }
        }

        private void Tbtennguoidung_Enter(object sender, EventArgs e)
        {
            lbtennguoidung1.Visible = false;
            lbtennguoidung.Visible = true;
        }

        private void Tbmk_KeyDown(object sender, KeyEventArgs e)
        {
            if (btdangnhap.Enabled)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Btdangnhap_Click(this, EventArgs.Empty);
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void Tbmk_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbmk.Text))
            {
                btdangnhap.Enabled = true;
                btdangnhap.BackColor = Color.LimeGreen;
            }
            else
            {
                btdangnhap.Enabled = false;
                btdangnhap.BackColor = Color.Transparent;
            }
        }
    }
}