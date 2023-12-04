using System;
using System.Windows.Forms;

namespace btl
{
    public partial class Sanpham : System.Windows.Forms.Form
    {
        public Sanpham()
        {
            InitializeComponent();
        }

        private Form form = new Form();
        private Database database = new Database();

        void Taidulieu()
        {
            string tenproc = "hoadonnguoidung";
            string ten = "@tennguoidung";
            string giatriten = Luu.tk;
            database.Hoa(tenproc, ten, giatriten, hoadonmua1);
            string select = "select masanpham, tensanpham, loai, soluong, gia, nhacungcap from sanpham";
            database.Tai(select, dtgvsanpham);
        }

        private void Sanpham_Load(object sender, EventArgs e)
        {
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
                    string update = "update sanpham set masanpham = '" + tbmasp.Text + "', tensanpham = N'" + tbtensp.Text + "',soluong = '" + tbsoluong.Text + "', gia = '" + tbgia.Text + "', loai = N'" + cbbloai.Text + "',mota = N'" + tbnhacungcap.Text + "' where masanpham = '" + tbmasp.Text + "'";
                    database.Chay(update);
                    Taidulieu();
                    MessageBox.Show("Sửa sản phẩm thành công", "Thành công");
                }
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
            if (string.IsNullOrEmpty(tbsoluongmua.Text))
            {
                throw new Exception("reterter");
            }
            else
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
                    }
                    else
                    {
                        MessageBox.Show("Số lượng trong kho không đủ", "Thất bại");
                    }
                }
            }
        }

        private void Dtgvsanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow chon = dtgvsanpham.Rows[e.RowIndex];
                tbmasp.Text = chon.Cells["Column1"].Value.ToString();
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
                database.Ketnoi();
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
    }
}