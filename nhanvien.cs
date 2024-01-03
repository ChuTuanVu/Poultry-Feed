using System;
using System.Windows.Forms;

namespace btl
{
    public partial class Nhanvien : System.Windows.Forms.Form
    {
        public Nhanvien()
        {
            InitializeComponent();
        }

        private DataBase dataBase = new DataBase();
        private Form form = new Form();

        private void Btxoa_Click(object sender, EventArgs e)
        {
            string lenh = "select count (*) from nhanvien where manhanvien = '" + tbxoa.Text + "'";
            if (Convert.ToInt32(dataBase.Lay(lenh)) != 0)
            {
<<<<<<< HEAD
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string lenh1 = "delete from nhanvien where manhanvien ='" + tbxoa.Text + "'";
                    dataBase.Chay(lenh1);
                    MessageBox.Show("Xóa nhân viên thành công", "Thành công");
                    Nhanvien_Load(this, EventArgs.Empty);
                }
            }
            else
            {
                if (string.IsNullOrEmpty(tbxoa.Text))
                {
                    MessageBox.Show("Mã nhân viên đang để trống!", "Thất bại!");

                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên có mã " + tbxoa.Text + "", "Thất bại!");
                }
=======
                string delete = "delete from nhanvien where manv ='" + tbxoamanv.Text + "'";
                database.Chay(delete);
                MessageBox.Show("Xóa nhân viên thành công","Thành công");
                Nhanvien_Load(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhân viên có mã " + tbxoamanv.Text + "","Thất bại");
>>>>>>> 88ce484a094424691e36687680fa448091bdf8e4
            }

        }

        private void Nhanvien_Load(object sender, EventArgs e)
        {
            string select = "select * from nhanvien";
<<<<<<< HEAD
            dataBase.Tai(select,dtgvnv);
            dataBase.Tai(select, dtgvxoanv);
            string lenh = "select manhanvien from nhanvien";
            AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
            dataBase.Tu(lenh,autoCompleteStringCollection, tbxoa);
=======
            database.Tai(select,dtgvnv);
            database.Tai(select, dtgvxoanv);
            string lenh = "select * from nhanvien";
            AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
            string cot = "manhanvien";
            TextBox textBox = tbxoamanv;
            database.Tu(lenh,autoCompleteStringCollection,cot, textBox);
>>>>>>> 88ce484a094424691e36687680fa448091bdf8e4
        }

        private void Dtgvxoanv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow chon = dtgvxoanv.Rows[e.RowIndex];
<<<<<<< HEAD
                tbxoa.Text = chon.Cells[0].Value.ToString(); ;
=======
                tbxoamanv.Text = chon.Cells[0].Value.ToString(); ;
>>>>>>> 88ce484a094424691e36687680fa448091bdf8e4
            }
        }

        private void Btthem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbmanv.Text) &&
                !string.IsNullOrEmpty(tbten.Text) &&
                !string.IsNullOrEmpty(tbsdt.Text) &&
                !string.IsNullOrEmpty(cbbgioitinh.Text) &&
                !string.IsNullOrEmpty(tbemail.Text))
            {
                string insert = "insert into nhanvien values('" + tbmanv.Text + "',N'" + tbten.Text + "','" + tbsdt.Text + "',N'" + cbbgioitinh.Text + "','" + tbemail.Text + "')";
<<<<<<< HEAD
                dataBase.Chay(insert);
=======
                database.Chay(insert);
>>>>>>> 88ce484a094424691e36687680fa448091bdf8e4
                MessageBox.Show("Đăng ký thành công","Thành công");
                Nhanvien_Load(this, EventArgs.Empty);
                tbmanv.Clear();
                tbten.Clear();
                tbsdt.Clear();
                cbbgioitinh.Text = "";
                tbemail.Clear();
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!","Thất bại!");
            }
        }

        private void Nhanvien_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.Cacchucnang();
            Hide();
        }
    }
}