using System;
using System.Windows.Forms;

namespace btl
{
    public partial class nhacungcap : System.Windows.Forms.Form
    {
        public nhacungcap()
        {
            InitializeComponent();
        }

        private Database database = new Database();
        private Form form = new Form();

        private void Nhacungcap_Load(object sender, EventArgs e)
        {
            string select = "select * from nhacungcap";
            database.Tai(select,dtgvnhacungcap);
        }

        private void Dtgvnhacungcap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                lbngayky.Visible = true;
                tbngayhethan.Visible = true;
                tbngayky.Visible = true;
                dtpkngayhet.Visible = false;
                dtpkngayky.Visible = false;
                DataGridViewRow chon = dtgvnhacungcap.Rows[e.RowIndex];
                tbmanhacc.Text = chon.Cells["Column1"].Value.ToString();
                tbtenncc.Text = chon.Cells["Column2"].Value.ToString();
                tbdiachi.Text = chon.Cells["Column3"].Value.ToString();
                tbsdt.Text = chon.Cells["Column4"].Value.ToString();
                tbngayky.Text = string.Format("{0:dd/MM/yyyy}", chon.Cells["Column5"].Value);
                tbngayhethan.Text = string.Format("{0:dd/MM/yyyy}", chon.Cells["Column6"].Value);
            }
        }

        private void Btthem_Click(object sender, EventArgs e)
        {
            string count = "select count (*) from nhacungcap where manhacungcap = '" + tbmanhacc.Text + "' or tennhacungcap = N'" + tbtenncc.Text + "'";
            int dem = database.Dem(count);
            if (dem == 0 )
            {
                string insert = "insert into nhacungcap values ('" + tbmanhacc.Text + "',N'" + tbtenncc.Text + "',N'" + tbdiachi.Text + "','" + tbsdt.Text + "','" + dtpkngayky.Value.ToString("yyyy-MM-dd") + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "')";
                database.Chay(insert);
                MessageBox.Show("Thêm nhà cung cấp thành công","Thành công");
                Nhacungcap_Load(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Mã nhà cung cấp này hoặc tên nhà cung cấp đã tồn tại!", "Thất bại");
            }
        }

        private void Btsua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbmanhacc.Text))
            {
                if (MessageBox.Show("Bạn có muốn sửa nhà cung cấp này không?", "Sửa nhà cung cấp?", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string update = "update nhacungcap set manhacungcap = '" + tbmanhacc.Text + "', tennhacungcap = N'" + tbtenncc.Text + "',diachi = N'" + tbdiachi.Text + "', sodienthoai = '" + tbsdt.Text + "', ngayky = N'" + dtpkngayky.Value.ToString("yyyy-MM-dd") + "',ngayhethan = N'" + dtpkngayhet.Value.ToString("yyyy-MM-dd") + "' where manhacungcap = '" + tbmanhacc.Text + "'";
                    database.Chay(update);
                    MessageBox.Show("Sửa sản phẩm thành công!", "Thành công");
                    Nhacungcap_Load(this, EventArgs.Empty);
                }
            }
            else
            {
                MessageBox.Show("Mã nhà cung cấp không được để trống", "Thiếu dữ liệu");
            }
        }

        private void Btxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa nhà cung cấp này không", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string delete = "delete from nhacungcap where manhacungcap = '" + tbmanhacc.Text + "'";
                database.Chay(delete);
                MessageBox.Show("Xóa nhà cung cấp thành công", "Thành công");
                Nhacungcap_Load(this, EventArgs.Empty);
            }
        }

        private void btmoi_Click(object sender, EventArgs e)
        {
            tbmanhacc.Clear();
            tbdiachi.Clear();
            tbsdt.Clear();
            tbtenncc.Clear();
            lbngayky.Visible = false;
            tbngayky.Visible = false;
            dtpkngayky.Visible = false;
            tbngayhethan.Visible = false;
            dtpkngayhet.Visible = true;
        }

        private void btthem_MouseMove(object sender, MouseEventArgs e)
        {
            lbngayky.Visible = false;
            tbngayky.Visible = false;
            dtpkngayky.Visible = false;
            tbngayhethan.Visible = false;
            dtpkngayhet.Visible = true;
        }

        private void btsua_MouseMove(object sender, MouseEventArgs e)
        {
            lbngayky.Visible = false;
            tbngayky.Visible = false;
            dtpkngayky.Visible = false;
            tbngayhethan.Visible = false;
            dtpkngayhet.Visible = true;
        }

        private void bttim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbtim.Text))
            {
                Nhacungcap_Load(this, EventArgs.Empty);
            }
            else
            {
                string select = "select * from nhacungcap where manhacungcap = '" + tbtim.Text + "'";
                database.Tai(select, dtgvnhacungcap);
            }
        }

        private void nhacungcap_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.Cacchucnang();
            Hide();
        }
    }
}