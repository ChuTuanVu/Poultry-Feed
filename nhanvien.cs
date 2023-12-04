using System;
using System.Windows.Forms;

namespace btl
{
    public partial class nhanvien : System.Windows.Forms.Form
    {
        public nhanvien()
        {
            InitializeComponent();
        }

        private Database database = new Database();
        private Form form = new Form();

        private void Btxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string delete = "delete from nhanvien where manv ='" + tbmanv.Text + "'";
                database.Chay(delete);
                MessageBox.Show("Xóa nhân viên thành công","Thành công");
                Nhanvien_Load(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhân viên có mã " + tbmanv.Text + "","Thất bại");
            }
        }

        private void Nhanvien_Load(object sender, EventArgs e)
        {
            string select = "select * from nhanvien";
            database.Tai(select,dtgvnv);
            database.Tai(select, dtgvxoanv);
        }

        private void Dtgvxoanv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow chon = dtgvxoanv.Rows[e.RowIndex];
                tbmanv.Text = chon.Cells[0].Value.ToString(); ;
            }
        }

        private void Btthem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbma.Text) &&
                !string.IsNullOrEmpty(tbten.Text) &&
                !string.IsNullOrEmpty(tbsdt.Text) &&
                !string.IsNullOrEmpty(cbbgioitinh.Text) &&
                !string.IsNullOrEmpty(tbemail.Text))
            {
                string insert = "insert into nhanvien values('" + tbma.Text + "',N'" + tbten.Text + "','" + tbsdt.Text + "',N'" + cbbgioitinh.Text + "','" + tbemail.Text + "')";
                database.Chay(insert);
                MessageBox.Show("Đăng ký thành công","Thành công");
                Nhanvien_Load(this, EventArgs.Empty);
                tbma.Clear();
                tbten.Clear();
                tbsdt.Clear();
                cbbgioitinh.Text = "";
                tbemail.Clear();
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!","Thất bại");
            }
        }

        private void nhanvien_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.Cacchucnang();
            Hide();
        }
    }
}