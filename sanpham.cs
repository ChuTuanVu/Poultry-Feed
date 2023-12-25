using System;
using System.Windows.Forms;

namespace btl
{
    public partial class Sanpham : System.Windows.Forms.Form
    {
        public string masanpham;
        public Sanpham()
        {
            InitializeComponent();
        }

        private Form form = new Form();
        private Database database = new Database();

        void Taidulieu()
        {
            string select = "select masanpham, tensanpham, loai, soluong, gia, nhacungcap from sanpham";
            if (Luu.tk == "admin")
            {
                database.Taiad(select, dtgvsanpham);
            }
            else
            {
                database.Tai(select, dtgvsanpham);
            }

            string tenproc = "hoadonnguoidung";
            string ten = "@tennguoidung";
            string giatriten = Luu.tk;
            database.Hoa(tenproc, ten, giatriten, hoadonmua1);           
        }

        private void Sanpham_Load(object sender, EventArgs e)
        {
            string lenh = "select * from sanpham";
            AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
            string cot = "masanpham";
            string cot1 = "tensanpham";
            TextBox textBox = tbtim;
            database.Tu(lenh, autoCompleteStringCollection, cot, textBox );
            database.Tu(lenh, autoCompleteStringCollection, cot1, textBox);

            AutoCompleteStringCollection autoCompleteStringCollection1 = new AutoCompleteStringCollection();
            string cot2 = "loai";
            ComboBox comboBox = cbblocloai;
            database.Tu(lenh, autoCompleteStringCollection1, cot2, comboBox);

            AutoCompleteStringCollection autoCompleteStringCollection2 = new AutoCompleteStringCollection();
            string cot3 = "nhacungcap";
            ComboBox comboBox1 = cbblocnhacungcap;
            database.Tu(lenh, autoCompleteStringCollection2, cot3, comboBox1);

            AutoCompleteStringCollection autoCompleteStringCollection3 = new AutoCompleteStringCollection();
            ComboBox comboBox2 = cbbloai;
            database.Tu(lenh, autoCompleteStringCollection3, cot2, cbbloai);

            Taidulieu();
            if (Luu.tk == "admin")
            {
                btmua.Visible = false;
                lbsoluongmua.Visible = false;
                tbsoluongmua.Visible = false;
                cbbloai.Enabled = true;
                tbsoluong.Enabled = true;
                tbgia.Enabled = true;
            }
            else
            {
                btthem.Visible = false;
                btsua.Visible = false;
                btxoa.Visible = false;
            }
        }

        private void Btmoi_Click(object sender, EventArgs e)
        {
            tbmasp.Clear();
            tbtensp.Clear();
            tbsoluong.Clear();
            tbsoluongmua.Clear();
            tbgia.Clear();
            cbbloai.Text = "";
            tbmota.Clear();
            tbnhacungcap.Clear();
            cbblocloai.Text = "";
            cbblocnhacungcap.Text = "";
            Taidulieu();
            tbtim.Clear();
        }

        private void Btthem_Click(object sender, EventArgs e)
        {
            string count = "select count (*) from sanpham where masanpham = '" + tbmasp.Text + "'";
            int dem = database.Dem(count);
            if (dem == 0)
            {
                if (!string.IsNullOrEmpty(tbmasp.Text) &&
                    !string.IsNullOrEmpty(tbtensp.Text) &&
                    !string.IsNullOrEmpty(tbsoluong.Text) &&
                    !string.IsNullOrEmpty(tbgia.Text) &&
                    !string.IsNullOrEmpty(cbbloai.Text) &&
                    !string.IsNullOrEmpty(tbnhacungcap.Text))
                {
                    string insert = "insert into sanpham values ('" + tbmasp.Text + "', N'" + tbtensp.Text + "','" + tbsoluong.Text + "', '" + tbgia.Text + "', N'" + cbbloai.Text + "', N'" + tbmota.Text + "', N'" + tbnhacungcap.Text + "')";
                    database.Chay(insert);
                    Taidulieu();
                    MessageBox.Show("Thêm sản phẩm thành công","Thành công");
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu cho sản phẩm","Thiếu thông tin");
                }
            }
            else
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại", "Thất bại");
            }
        }

        private void Btsua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbmasp.Text) &&
                !string.IsNullOrEmpty(tbtensp.Text) &&
                !string.IsNullOrEmpty(tbsoluong.Text) &&
                !string.IsNullOrEmpty(tbgia.Text) &&
                !string.IsNullOrEmpty(cbbloai.Text) &&
                !string.IsNullOrEmpty(tbnhacungcap.Text))
            {
                if (MessageBox.Show("Bạn có muốn sửa sản phẩm này không?", "Thông báo", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string lenh = "select soluong from sanpham where masanpham = '" + tbmasp.Text +"'";
                    int ss = database.Dem(lenh);
                    if (ss == Convert.ToInt16(tbsoluong.Text))
                    {
                        string update = "update sanpham set masanpham = '" + masanpham + "', tensanpham = N'" + tbtensp.Text + "', gia = '" + tbgia.Text + "', loai = N'" + cbbloai.Text + "' where masanpham = '" + tbmasp.Text + "'";
                        database.Chay(update);
                    }
                    else
                    {
                        string update = "update sanpham set masanpham = '" + masanpham + "', tensanpham = N'" + tbtensp.Text + "',soluong = '" + tbsoluong.Text + "', gia = '" + tbgia.Text + "', loai = N'" + cbbloai.Text + "' where masanpham = '" + tbmasp.Text + "'";
                        database.Chay(update);
                    }
                    Taidulieu();
                    MessageBox.Show("Sửa sản phẩm thành công", "Thành công");
                }
            }
            else
            {

            }
        }

        private void Btxoa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbmasp.Text) &&
                !string.IsNullOrEmpty(tbtensp.Text) &&
                !string.IsNullOrEmpty(tbsoluong.Text) &&
                !string.IsNullOrEmpty(tbgia.Text) &&
                !string.IsNullOrEmpty(cbbloai.Text) &&
                !string.IsNullOrEmpty(tbnhacungcap.Text))
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này không?", "Thông báo", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string delete = "delete from sanpham where masanpham = '" + tbmasp.Text + "'";
                    database.Chay(delete);
                    Taidulieu();
                    MessageBox.Show("Xóa sản phẩm thành công", "Thành công");
                }
            }
        }

        private void Btmua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbsoluong.Text) &&
                !string.IsNullOrWhiteSpace(tbsoluongmua.Text) &&
                !string.IsNullOrWhiteSpace(tbgia.Text) &&
                !string.IsNullOrWhiteSpace(tbmasp.Text) &&
                !string.IsNullOrWhiteSpace(tbtensp.Text) &&
                !string.IsNullOrWhiteSpace(cbbloai.Text) &&
                !string.IsNullOrWhiteSpace(tbnhacungcap.Text))
            {
                if (MessageBox.Show("Bạn có chắc muốn mua sản phẩm này không?\nBạn sẽ phải trả " + int.Parse(tbsoluongmua.Text) * int.Parse(tbgia.Text) + " đồng" + "", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (int.Parse(tbsoluongmua.Text) <= int.Parse(tbsoluong.Text))
                    {
                        int tongtien = int.Parse(tbsoluongmua.Text) * int.Parse(tbgia.Text);
                        string update = "update sanpham set soluong = '" + tbsoluong.Text + "' - " + tbsoluongmua.Text + " where masanpham = '" + tbmasp.Text + "'";
                        database.Chay(update);
                        Taidulieu();
                        string insert = "insert into hoadon values (N'" + Luu.tk + "', N'" + tbtensp.Text + "', N'" + tbsoluongmua.Text + "','" + tongtien.ToString() + "', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm") + "')";
                        database.Chay(insert);
                        string tenproc = "hoadonnguoidung";
                        string ten = "@tennguoidung";
                        string giatriten = Luu.tk;
                        database.Hoa(tenproc, ten, giatriten, hoadonmua1);
                        rpnguoidung.RefreshReport();
                        MessageBox.Show("Mua hàng thành công", "Thành công");
                    }
                    else
                    {
                        MessageBox.Show("Số lượng trong kho không đủ!", "Thất bại!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Thông tin sản phẩm còn thiếu!", "Thất bại!");
            }
        }

        private void Dtgvsanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow chon = dtgvsanpham.Rows[e.RowIndex];
                tbmasp.Text = chon.Cells["Column1"].Value.ToString();
                masanpham = chon.Cells["Column1"].Value.ToString();
                tbtensp.Text = chon.Cells["Column2"].Value.ToString();
                tbsoluong.Text = chon.Cells["Column3"].Value.ToString();
                tbgia.Text = chon.Cells["Column4"].Value.ToString();
                cbbloai.Text = chon.Cells["Column5"].Value.ToString();
                tbnhacungcap.Text = chon.Cells["Column6"].Value.ToString();
                tbmota.Clear();
                tbsoluongmua.Clear();
            }
        }

        private void Btloc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbblocloai.Text) && string.IsNullOrEmpty(cbblocnhacungcap.Text))
            {
                Taidulieu();
            }
            else if(string.IsNullOrEmpty(cbblocloai.Text))
            {
                string select = "select masanpham, tensanpham, soluong, gia, loai, nhacungcap from sanpham where nhacungcap = N'" + cbblocnhacungcap.Text + "'";
                database.Tai(select, dtgvsanpham);
            }
            else if (string.IsNullOrEmpty(cbblocnhacungcap.Text))
            {
                string select = "select masanpham, tensanpham, soluong, gia, loai, nhacungcap from sanpham where loai = N'" + cbblocloai.Text + "'";
                database.Tai(select, dtgvsanpham);
            }
            else
            {
                string select = "select masanpham, tensanpham, soluong, gia, loai, nhacungcap from sanpham where loai = N'" + cbblocloai.Text + "' and nhacungcap = N'" + cbblocnhacungcap.Text + "'";
                database.Tai(select, dtgvsanpham);
            }
            cbblocloai.Text = "";
            cbblocnhacungcap.Text = "";
        }

        private void Bttim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbtim.Text))
            {
                Taidulieu();
            }
            else
            {
                string select1 = "select masanpham, tensanpham, loai, soluong, gia, nhacungcap from sanpham where masanpham = '" + tbtim.Text + "' or tensanpham = N'" + tbtim.Text + "'";
                database.Tai(select1, dtgvsanpham);
            }
        }

        private void Btmota_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbmasp.Text) &&
                !string.IsNullOrEmpty(tbtensp.Text) &&
                !string.IsNullOrEmpty(tbsoluong.Text) &&
                !string.IsNullOrEmpty(tbgia.Text) &&
                !string.IsNullOrEmpty(cbbloai.Text) &&
                !string.IsNullOrEmpty(tbnhacungcap.Text))
            {
                string select = "select mota from sanpham where masanpham = '" + tbmasp.Text + "'";
                database.Chay(select);
                database.Ket();
                tbmota.Text = database.cm.ExecuteScalar().ToString();
                database.Ngat();
            }
        }

        private void Tbsoluongmua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                epsoluongmua.SetError(tbsoluongmua, "Chỉ được nhập chữ số");
                e.Handled = true;
            }
            else
            {
                epsoluongmua.Clear();
            }
        }

        private void Sanpham_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.Cacchucnang();
            Hide();
        }

        private void tbtim_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Bttim_Click(this, EventArgs.Empty);
            }
        }

        private void cbblocloai_MouseMove(object sender, MouseEventArgs e)
        {
            if (string.IsNullOrEmpty(cbblocloai.Text))
            {
                ttlocloai.SetToolTip(cbblocloai, $"Lọc theo loại mặt hàng");
            }
            else
            {
                ttlocloai.SetToolTip(cbblocloai, $"");
            }
        }

        private void cbblocnhacungcap_MouseMove(object sender, MouseEventArgs e)
        {
            if (string.IsNullOrEmpty(cbblocloai.Text))
            {
                ttlocnhacungcap.SetToolTip(cbblocnhacungcap, $"Lọc theo nhà cung cấp");
            }
            else
            {
                ttlocnhacungcap.SetToolTip(cbblocnhacungcap, $"");
            }
        }

        private void tbsoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                epsoluong.SetError(tbsoluongmua, "Chỉ được nhập chữ số");
                e.Handled = true;
            }
            else
            {
                epsoluong.Clear();
            }
        }

        private void tbgia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                epgia.SetError(tbsoluongmua, "Chỉ được nhập chữ số");
                e.Handled = true;
            }
            else
            {
                epgia.Clear();
            }
        }

        private void tbsoluongmua_Leave(object sender, EventArgs e)
        {
            epsoluongmua.Clear();
        }
    }
}