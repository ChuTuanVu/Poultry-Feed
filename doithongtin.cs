using System;
using System.Linq;
using System.Windows.Forms;

namespace btl
{
    public partial class Doithongtin : System.Windows.Forms.Form
    {
        public Doithongtin()
        {
            InitializeComponent();
        }

        private Database database = new Database();
        private Form form = new Form();

        private void Doithongtin_Load(object sender, EventArgs e)
        {
            tbtaikhoan.Text = Luu.tk;
        }

        private void Tbtaikhoan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn chỉ có thể liên hệ với admin để có thể đổi tên người dùng","Thao tác bị từ chối");
        }

        private void Btdoi_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbemail.Text) &&
                !string.IsNullOrEmpty(tbsdt.Text) &&
                !string.IsNullOrEmpty(tbmk.Text))
            {
                if (string.IsNullOrEmpty(epemail.GetError(tbemail)) &&
                    string.IsNullOrEmpty(epsdt.GetError(tbsdt)) &&
                    string.IsNullOrEmpty(epmk.GetError(tbmk)))
                {
                    if (MessageBox.Show("Bạn có chắc muốn đổi thông tin không", "Xác nhận", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string update = "update taikhoan set email = '" + tbemail.Text + "', matkhau = '" + tbmk.Text + "', sodienthoai = '" + tbsdt.Text + "', ngaysinh = '" + dtpkngaysinh.Value.ToString("yyyy-MM-dd") + "' where tennguoidung = '" + tbtaikhoan.Text + "'";
                        database.Chay(update);
                        MessageBox.Show("Đổi thông tin tài khoản thành công\nBạn sẽ đăng nhập lại sau 3 giây!", "Thành công");
                        demnguoc.Start();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng kiểm tra lại thông tin", "Thất bại");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thất bại");
            }
        }

        public int tictactictac = 3;
        private void Demnguoc_Tick(object sender, EventArgs e)
        {
            tictactictac--;
            if (tictactictac <= 0)
            {
                demnguoc.Stop();
                form.Dangnhap();
                Hide();
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

        private void Tbemail_TextChanged(object sender, EventArgs e)
        {
            string count = "select count (*) from taikhoan where email = '" + tbemail.Text + "'";
            int dem = database.Dem(count);
            if (dem == 0)
            {
                if (!tbemail.Text.Contains("@"))
                {
                    epemail.SetError(tbemail, $"Vui lòng bao gồm '@' trong địa chỉ email. '" + tbemail.Text + "' đang thiếu một '@'");
                }
                else
                {
                    epemail.Clear();
                }
            }
            else
            {
                epemail.SetError(tbemail, "Email không hợp lệ hoặc đã được đăng ký");
            }
        }

        private void Tbsdt_TextChanged(object sender, EventArgs e)
        {
            if (tbsdt.Text.Length != 10)
            {
                epsdt.SetError(tbsdt, "Số điện thoại phải có 10 chữ số");
            }
            else
            {
                epsdt.Clear();
            }

        }
        private void Tbsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                epsdt.SetError(tbsdt, "Chỉ được nhập chữ số");
                e.Handled = true;
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
    }
}
