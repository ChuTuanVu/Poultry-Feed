using System;
using System.Linq;
using System.Windows.Forms;

namespace btl
{
    public partial class quenmatkhau : System.Windows.Forms.Form
    {
        public quenmatkhau()
        {
            InitializeComponent();
        }

        private Database sql = new Database();
        private Form form = new Form();

        private void Quenmatkhau_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.Dangnhap();
            Hide();
        }

        private void Btkt_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbtennguoidung.Text) &&
                !string.IsNullOrEmpty(tbemailhoacsdt.Text))
            {
                string count = "select count (*) from taikhoan where tennguoidung = '" + tbtennguoidung.Text + "' and sodienthoai = '" +
                tbemailhoacsdt.Text + "' or email = '" + tbemailhoacsdt.Text + "' and tennguoidung <> 'admin'";
                int dem = sql.Dem(count);
                if (dem > 0)
                {
                    lbmk.Visible = true;
                    pbmk.Visible = true;
                    tbmk.Visible = true;
                    lbxnmk.Visible = true;
                    pbxnmk.Visible = true;
                    tbxnmk.Visible = true;
                    btdoimk.Visible = true;
                    pbhienmk.Visible = true;
                    pbhienxnmk.Visible = true;
                }
                else
                {
                    MessageBox.Show("Thông tin không chính xác hoặc tài khoản không tồn tại. Vui lòng thử lại!","Không tìm thấy");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông tin thiếu");
            }
        }

        private void Tbmk_TextChanged(object sender, EventArgs e)
        {
            if (!(tbmk.Text.Length >= 8 && tbmk.Text.Any(char.IsLetter) && tbmk.Text.Any(cc => !char.IsLetter(cc))))
            {
                epmk.SetError(tbmk, "Mật khẩu phải dài ít nhất 8 ký tự\n" +
                                    "Mật khẩu phải chứa ít nhất 1 chữ cái và một ký tự không phải chữ cái");
            }
            else
            {
                epmk.Clear();
            }
        }

        private void Tbxnmk_TextChanged(object sender, EventArgs e)
        {
            if (tbmk.Text != tbxnmk.Text)
            {
                epxnmk.SetError(tbxnmk, "Không khớp với trường mật khẩu");
            }
            else
            {
                btdoimk.Enabled = true;
                epxnmk.Clear();
            }
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
        private void Pbhienxnmk_Click(object sender, EventArgs e)
        {
            if (tbxnmk.UseSystemPasswordChar)
            {
                tbxnmk.UseSystemPasswordChar = false;
                pbhienxnmk.Image = Properties.Resources.matkhauhien;
            }
            else
            {
                tbxnmk.UseSystemPasswordChar = true;
                pbhienxnmk.Image = Properties.Resources.matkhauan;
            }
        }

        private void Btdoimk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(epmk.GetError(tbmk)) &&
                string.IsNullOrEmpty(epxnmk.GetError(tbxnmk)))
            {
                string update = "update taikhoan set matkhau = '" + tbmk.Text + "' where tennguoidung = '" + tbtennguoidung.Text + "'";
                sql.Chay(update);
                MessageBox.Show("Mật khẩu đã được đặt lại", "Thành công");
            }
            else
            {
                MessageBox.Show("Kiểm tra lại thông tin", "Thất bại");
            }
        }
    }
}