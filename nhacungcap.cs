using System;
using System.Windows.Forms;

namespace btl
{
    public partial class nhacungcap : System.Windows.Forms.Form
    {
        private string manhacungcap;
        public nhacungcap()
        {
            InitializeComponent();
        }

        private DataBase dataBase = new DataBase();
        private Form form = new Form();

        private void Nhacungcap_Load(object sender, EventArgs e)
        {
            string lenh = "select manhacungcap, tennhacungcap from nhacungcap";
            AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
            dataBase.Tu(lenh, autoCompleteStringCollection, tbtim);
            string select = "select * from nhacungcap";
            dataBase.Tai(select,dtgvnhacungcap);
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
                DataGridViewRow dataGridViewRow = dtgvnhacungcap.Rows[e.RowIndex];
                tbmanhacc.Text = dataGridViewRow.Cells["Column1"].Value.ToString();
                manhacungcap = dataGridViewRow.Cells["Column1"].Value.ToString();
                tbtenncc.Text = dataGridViewRow.Cells["Column2"].Value.ToString();
                tbdiachi.Text = dataGridViewRow.Cells["Column3"].Value.ToString();
                tbsdt.Text = dataGridViewRow.Cells["Column4"].Value.ToString();
                tbngayky.Text = string.Format("{0:dd/MM/yyyy}", dataGridViewRow.Cells["Column5"].Value);
                tbngayhethan.Text = string.Format("{0:dd/MM/yyyy}", dataGridViewRow.Cells["Column6"].Value);
            }
        }

        private void Btthem_Click(object sender, EventArgs e)
        {
            string lenh = "select count (*) from nhacungcap where manhacungcap = '" + tbmanhacc.Text + "' or tennhacungcap = N'" + tbtenncc.Text + "'";
            if (Convert.ToInt32(dataBase.Lay(lenh)) == 0 )
            {
                string lenh1 = "insert into nhacungcap values ('" + tbmanhacc.Text + "',N'" + tbtenncc.Text + "',N'" + tbdiachi.Text + "','" + tbsdt.Text + "','" + dtpkngayky.Value.ToString("yyyy-MM-dd") + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "')";
                dataBase.Chay(lenh1);
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
                    string lenh = "update nhacungcap set manhacungcap = '" + manhacungcap + "', tennhacungcap = N'" + tbtenncc.Text + "',diachi = N'" + tbdiachi.Text + "', sodienthoai = '" + tbsdt.Text + "', ngayky = N'" + dtpkngayky.Value.ToString("yyyy-MM-dd") + "',ngayhethan = N'" + dtpkngayhet.Value.ToString("yyyy-MM-dd") + "' where manhacungcap = '" + manhacungcap + "'";
                    dataBase.Chay(lenh);
                    MessageBox.Show("Sửa sản phẩm thành công!", "Thành công");
                    string select = "select * from nhacungcap";
                    dataBase.Tai(select, dtgvnhacungcap);
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
                string lenh = "delete from nhacungcap where manhacungcap = '" + tbmanhacc.Text + "'";
                dataBase.Chay(lenh);
                MessageBox.Show("Xóa nhà cung cấp thành công", "Thành công");
                string select = "select * from nhacungcap";
                dataBase.Tai(select, dtgvnhacungcap);
            }
        }

        private void Btmoi_Click(object sender, EventArgs e)
        {
            manhacungcap = "";
            tbtim.Clear();
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

        private void Btthem_MouseMove(object sender, MouseEventArgs e)
        {
            lbngayky.Visible = false;
            tbngayky.Visible = false;
            dtpkngayky.Visible = false;
            tbngayhethan.Visible = false;
            dtpkngayhet.Visible = true;
        }

        private void Btsua_MouseMove(object sender, MouseEventArgs e)
        {
            lbngayky.Visible = false;
            tbngayky.Visible = false;
            dtpkngayky.Visible = false;
            tbngayhethan.Visible = false;
            dtpkngayhet.Visible = true;
        }

        private void Bttim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbtim.Text))
            {
                string select = "select * from nhacungcap";
                dataBase.Tai(select, dtgvnhacungcap);
            }
            else
            {
                string select = "select * from nhacungcap where manhacungcap  = N'" + tbtim.Text + "' or tennhacungcap = N'" + tbtim.Text + "'";
                dataBase.Tai(select, dtgvnhacungcap);
            }
        }

        private void Nhacungcap_FormClosing(object sender, FormClosingEventArgs e)
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