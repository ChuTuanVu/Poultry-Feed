using System;
using System.Linq;
using System.Windows.Forms;

namespace btl
{
    public partial class Taikhoan : System.Windows.Forms.Form
    {
        public Taikhoan()
        {
            InitializeComponent();
        }

        private DataBase dataBase = new DataBase();
        private Form form = new Form();

        private void Taikhoan_Load(object sender, EventArgs e)
        {
            string lenh = "select tennguoidung from taikhoan";
            AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
            dataBase.Tu(lenh, autoCompleteStringCollection, tbtim);
            string select = "select * from taikhoan where tennguoidung <> 'admin' and tennguoidung <> 'user'";
            dataBase.Tai(select, dtgvtaikhoan);
        }

        private void Dtgvtaikhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                tbngaysinh.Visible = true;
                dtpkngaysinh.Visible = false;
                lbngaydangky.Visible = true;
                tbngaydangky.Visible = true;
                DataGridViewRow chon = dtgvtaikhoan.Rows[e.RowIndex];
                tbtennguoidung.Text = chon.Cells["Column1"].Value.ToString();
                tbmk.Text = chon.Cells["Column2"].Value.ToString();
                tbemail.Text = chon.Cells["Column3"].Value.ToString();
                tbsdt.Text = chon.Cells["Column4"].Value.ToString();
                tbngaysinh.Text = string.Format("{0:dd/MM/yyyy}", chon.Cells["Column5"].Value);
                tbngaydangky.Text = string.Format("{0:dd/MM/yyyy}", chon.Cells["Column6"].Value);
                eptennguoidung.Clear();
                epemail.Clear();
                epsdt.Clear();
                epmk.Clear();
            }
        }

        private void Btxoa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbtennguoidung.Text))
            {
                string lenh = "select count (*) from taikhoan where tennguoidung = '" + tbtennguoidung.Text + "'";
                if (Convert.ToInt32(dataBase.Lay(lenh)) > 0)
                {
                    if (MessageBox.Show("Xóa người dùng ngày sẽ xóa toàn bộ dữ liệu liên quan",
                            "Bạn có chắc chắn muốn xóa?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                        DialogResult.Yes)
                    {
                        string lenh1 = "delete from taikhoan where tennguoidung = '" + tbtennguoidung.Text + "'";
                        dataBase.Chay(lenh1);
                        MessageBox.Show("Xóa tài khoản thành công", "Thành công");
                        string lenh2 =
                            "select * from taikhoan where tennguoidung <> 'admin' and tennguoidung <> 'user'";
                        dataBase.Tai(lenh2, dtgvtaikhoan);
                    }
                }
                else
                {
                    MessageBox.Show("Tên " + tbtennguoidung.Text + " không có trong hệ thống", "Không tìm thấy!");
                }
            }
            else
            {
                MessageBox.Show("Chọn một tài khoản phía dưới hoặc nhập tên người dùng.", "Thiếu thông tin!");
            }
        }

        private void Btthem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbtennguoidung.Text))
            {
                string lenh = "select count (*) from taikhoan where tennguoidung = '" + tbtennguoidung.Text + "'";
                if (Convert.ToInt32(dataBase.Lay(lenh)) == 0)
                {
                    if (string.IsNullOrEmpty(epemail.GetError(tbemail)) &&
                        string.IsNullOrEmpty(epsdt.GetError(tbsdt)) &&
                        string.IsNullOrEmpty(epmk.GetError(tbmk)) &&
                        string.IsNullOrEmpty(eptennguoidung.GetError(tbtennguoidung)))
                    {
                        string insert = "insert into taikhoan values (N'" + tbtennguoidung.Text + "','" + tbmk.Text
                                        + "','" + tbemail.Text + "','" + tbsdt.Text + "','" +
                                        dtpkngaysinh.Value.ToString("yyyy-MM-dd") + "', '" +
                                        DateTime.Now.ToString("yyyy-MM-dd") + "')";
                        dataBase.Chay(insert);
                        Taikhoan_Load(this, EventArgs.Empty);
                        MessageBox.Show("Thêm tài khoản thành công", "Thành công");
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng kiểm tra lại thông tin!", "Thất bại!");
                    }
                }
                else
                {
                    MessageBox.Show("Tên người dùng " + tbtennguoidung.Text + " không khả dụng!", "Thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thất bại!");
            }
        }

        private void Btsua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(epemail.GetError(tbemail)) &&
                string.IsNullOrEmpty(epsdt.GetError(tbsdt)) &&
                string.IsNullOrEmpty(epmk.GetError(tbmk)) &&
                string.IsNullOrEmpty(eptennguoidung.GetError(tbtennguoidung)) &&
                string.IsNullOrEmpty(tbemail.Text) &&
                string.IsNullOrEmpty(tbsdt.Text) &&
                string.IsNullOrEmpty(tbmk.Text) &&
                string.IsNullOrEmpty(tbtennguoidung.Text))
            {
                if (MessageBox.Show("Bạn có muốn sửa thông tin tài khoản này không?", "Sửa?", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string lenh = "update taikhoan set tennguoidung = '" + tbtennguoidung.Text + "', matkhau = '" +
                                  tbmk.Text + "',email = '" + tbemail.Text + "', sodienthoai = '" + tbsdt.Text +
                                  "', ngaysinh = '" + dtpkngaysinh.Value.ToString("yyyy-MM-dd") +
                                  "' where tennguoidung = '" + tbtennguoidung.Text + "'";
                    dataBase.Chay(lenh);
                    MessageBox.Show("Sửa tài khoản thành công.", "Thành công");
                    string select = "select * from taikhoan where tennguoidung <> 'admin' and tennguoidung <> 'user'";
                    dataBase.Tai(select, dtgvtaikhoan);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin!", "Thất bại!");
            }
        }

        private void Bttim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbtim.Text))
            {
                string select = "select * from taikhoan where tennguoidung <> 'admin' and tennguoidung <> 'user'";
                dataBase.Tai(select, dtgvtaikhoan);
            }
            else
            {
                string select = "select * from taikhoan where tennguoidung = '" + tbtim.Text + "'";
                dataBase.Tai(select, dtgvtaikhoan);
            }
        }

        private void Btsua_MouseMove(object sender, MouseEventArgs e)
        {
            tbngaysinh.Visible = false;
            dtpkngaysinh.Visible = true;
        }

        private void Btthem_MouseMove(object sender, MouseEventArgs e)
        {
            tbngaysinh.Visible = false;
            dtpkngaysinh.Visible = true;
        }

        private void Btmoi_Click(object sender, EventArgs e)
        {
            tbtennguoidung.Clear();
            tbmk.Clear();
            tbemail.Clear();
            tbsdt.Clear();
            eptennguoidung.Clear();
            epemail.Clear();
            epsdt.Clear();
            epmk.Clear();
            tbngaysinh.Visible = false;
            dtpkngaysinh.Visible = true;
            lbngaydangky.Visible = false;
            tbngaydangky.Visible = false;
        }

        private void Tbtennguoidung_TextChanged(object sender, EventArgs e)
        {
            string lenh = "select count(*) from taikhoan where tennguoidung = '" + tbtennguoidung.Text + "'";
            if (Convert.ToInt32(dataBase.Lay(lenh)) == 0 && tbtennguoidung.Text.Length > 3 &&
                tbtennguoidung.Text.Length < 25)
            {
                eptennguoidung.Clear();
            }
            else
            {
                eptennguoidung.SetError(tbtennguoidung, "Tên người dùng " + tbtennguoidung.Text + " không khả dụng.");
            }
        }

        private void Tbemail_TextChanged(object sender, EventArgs e)
        {
            string lenh = "select count (*) from taikhoan where email = '" + tbemail.Text + "'";
            if (Convert.ToInt32(dataBase.Lay(lenh)) == 0 && tbemail.Text.Contains("@"))
            {
                ttemail.SetToolTip(tbemail, "");
                epemail.Clear();
            }
            else
            {
                epemail.SetError(tbemail, "Email không hợp lệ hoặc đã được sử dụng");
                if (!tbemail.Text.Contains("@"))
                {
                    ttemail.SetToolTip(tbemail,
                        $"Vui lòng bao gồm '@' trong địa chỉ email. '" + tbemail.Text + "' đang thiếu một '@'.");
                }
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

            if (e.KeyChar == (char)Keys.Enter)
            {
                dtpkngaysinh.Focus();
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

        private void Taikhoan_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.Cacchucnang();
            Hide();
        }

        private void Tbtim_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Bttim_Click(this, EventArgs.Empty);
            }
        }
    }
}