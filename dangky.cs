using System;
using System.Linq;
using System.Windows.Forms;

namespace btl
{
    public partial class Dangky : System.Windows.Forms.Form
    {
        public Dangky()
        {
            InitializeComponent();
        }

        private Database database = new Database();
        private Form form = new Form();

        private void Llbdangnhap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            form.Dangnhap();
            Hide();
        }

        private void Tbemail_TextChanged(object sender, EventArgs e)
        {
            string count = "select count (*) from taikhoan where email = '" + tbemail.Text + "'";
            int dem = database.Dem(count);
            if (dem == 0 && tbemail.Text.Contains("@"))
            {
                ttemail.SetToolTip(tbemail, "");
                btemail.Enabled = true;
                epemail.Clear();
            }
            else
            {
                btemail.Enabled = false;
                epemail.SetError(tbemail, "Email không hợp lệ hoặc đã được sử dụng");
                if (!tbemail.Text.Contains("@"))
                {
                    ttemail.SetToolTip(tbemail, $"Vui lòng bao gồm '@' trong địa chỉ email. '" + tbemail.Text + "' đang thiếu một '@'.");
                    btemail.Enabled = false;
                }
            }
        }

        private void Tbsdt_TextChanged(object sender, EventArgs e)
        {
            if (tbsdt.Text.Length != 10)
            {
                epsdt.SetError(tbsdt, "Số điện thoại phải có 10 chữ số");
                btsdt.Enabled = false;
            }
            else
            {
                btsdt.Enabled = true;
                epsdt.Clear();
            }

        }

        private void Tbmk_TextChanged(object sender, EventArgs e)
        {
            if (!(tbmk.Text.Length >= 8 && tbmk.Text.Any(char.IsLetter) && tbmk.Text.Any(cc => !char.IsLetter(cc))))
            {
                epmk.SetError(tbmk, "Mật khẩu phải dài ít nhất 8 ký tự\n" +
                                    "Mật khẩu phải chứa ít nhất 1 chữ cái và một ký tự không phải chữ cái");
                btmk.Enabled = false;
            }
            else
            {
                btmk.Enabled = true;
                epmk.Clear();
            }
        }

        private void Tbtennguoidung_TextChanged(object sender, EventArgs e)
        {
            string count = "select count(*) from taikhoan where tennguoidung = '" + tbtennguoidung.Text + "'";
            int dem = database.Dem(count);
            if (dem == 0 && tbtennguoidung.Text.Length > 3 && tbtennguoidung.Text.Length < 25)
            {
                eptennguoidung.Clear();
                bttennguoidung.Enabled = true;
            }
            else
            {
                eptennguoidung.SetError(tbtennguoidung, "Tên người dùng " + tbtennguoidung.Text + " không khả dụng.");
                bttennguoidung.Enabled = false;
            }
        }

        private void Btemail_Click(object sender, EventArgs e)
        {
            pbemail.Image = Properties.Resources.dangkytich;
            lbsdt.Visible = true;
            pbsdt.Visible = true;
            tbsdt.Visible = true;
            btsdt.Visible = true;
            btemail.Visible = false;
            tbsdt.Focus();
        }


        private void Tbsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                epsdt.SetError(tbsdt,"Chỉ được nhập chữ số");
                e.Handled = true;
            }
        }

        private void Btsdt_Click(object sender, EventArgs e)
        {
            pbsdt.Image = Properties.Resources.dangkytich;
            lbmk.Visible = true;
            pbmk.Visible = true;
            tbmk.Visible = true;
            pbhienmk.Visible = true;
            btmk.Visible = true;
            btsdt.Visible = false;
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
        private void Btmk_Click(object sender, EventArgs e)
        {
            pbmk.Image = Properties.Resources.dangkytich;
            lbtennguoidung.Visible = true;
            pbtennguoidung.Visible = true;
            tbtennguoidung.Visible = true;
            bttennguoidung.Visible = true;
            btmk.Visible = false;
            tbtennguoidung.Focus();
        }



        private void Bttennguoidung_Click(object sender, EventArgs e)
        {
            pbtennguoidung.Image = Properties.Resources.dangkytich;
            lbnamsinh.Visible = true;
            dtpkngaysinh.Visible = true;
            btdangky.Visible = true;
            bttennguoidung.Visible = false;
            btdangky.Focus();
        }


        private void Btdangky_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(epemail.GetError(tbemail))&&
                string.IsNullOrEmpty(epsdt.GetError(tbsdt))&&
                string.IsNullOrEmpty(epmk.GetError(tbmk))&&
                string.IsNullOrEmpty(eptennguoidung.GetError(tbtennguoidung))&&
                string.IsNullOrEmpty(tbemail.Text)&&
                string.IsNullOrEmpty(tbsdt.Text)&&
                string.IsNullOrEmpty(tbmk.Text)&&
                string.IsNullOrEmpty(tbtennguoidung.Text))
            {
                string insert = "insert into taikhoan values (N'" + tbtennguoidung.Text + "',N'" + tbmk.Text
                + "',N'" + tbemail.Text + "','" + tbsdt.Text + "','" + dtpkngaysinh.Value.ToString("yyyy-MM-dd") + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "')";
                database.Chay(insert);
                MessageBox.Show("Đăng ký thành công","Thành công");
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin","Thất bại");
            }
        }

        private void Tbemail_Leave(object sender, EventArgs e)
        {
            if (btemail.Enabled == false)
            {
                epemail.Clear();
                pbemail.Image = Properties.Resources.dangkyx;
            }
            else
            {
                pbemail.Image = Properties.Resources.dangkytich;
            }
        }

        private void Tbsdt_Leave(object sender, EventArgs e)
        {
            if (btsdt.Enabled == false)
            {
                epsdt.Clear();
                pbsdt.Image = Properties.Resources.dangkyx;
            }
            else
            {
                pbsdt.Image = Properties.Resources.dangkytich;
            }
        }

        private void Tbmk_Leave(object sender, EventArgs e)
        {
            if (btmk.Enabled == false)
            {
                epmk.Clear();
                pbmk.Image = Properties.Resources.dangkyx;
            }
            else
            {
                pbmk.Image = Properties.Resources.dangkytich;
            }
        }

        private void Tbtennguoidung_Leave(object sender, EventArgs e)
        {
            if (bttennguoidung.Enabled == false)
            {
                eptennguoidung.Clear();
                pbtennguoidung.Image = Properties.Resources.dangkyx;
            }
            else
            {
                pbtennguoidung.Image = Properties.Resources.dangkytich;
            }
        }

        private void Tbemail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && btemail.Enabled)
            {
                Btemail_Click(this, EventArgs.Empty);
                e.SuppressKeyPress = true;
            }
        }

        private void Tbsdt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && btsdt.Enabled)
            {
                Btsdt_Click(this, EventArgs.Empty);
                e.SuppressKeyPress = true;
            }
        }

        private void Tbmk_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && btmk.Enabled)
            {
                Btmk_Click(this, EventArgs.Empty);
                e.SuppressKeyPress = true;
            }
        }

        private void Tbtennguoidung_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && bttennguoidung.Enabled)
            {
                Bttennguoidung_Click(this, EventArgs.Empty);
                e.SuppressKeyPress = true;
            }
        }

        private void Tbemail_Enter(object sender, EventArgs e)
        {
            btemail.Visible = true;
            btsdt.Visible = false;
            btmk.Visible = false;
            bttennguoidung.Visible = false;
            pbemail.Image = Properties.Resources.dangkymuiten;
        }

        private void Tbsdt_Enter(object sender, EventArgs e)
        {
            btemail.Visible = false;
            btsdt.Visible = true;
            btmk.Visible = false;
            bttennguoidung.Visible = false;
            pbsdt.Image = Properties.Resources.dangkymuiten;
        }


        private void Tbtennguoidung_Enter(object sender, EventArgs e)
        {
            btemail.Visible = false;
            btsdt.Visible = false;
            btmk.Visible = false;
            bttennguoidung.Visible = true;
            pbtennguoidung.Image = Properties.Resources.dangkymuiten;
        }

        private void Tbmk_Enter(object sender, EventArgs e)
        {
            btemail.Visible = false;
            btsdt.Visible = false;
            btmk.Visible = true;
            bttennguoidung.Visible = false;
            pbmk.Image = Properties.Resources.dangkymuiten;
        }
    }
}