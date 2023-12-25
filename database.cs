using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace btl
{
    class Database
    {
        //kiểu phi kết nối
        public string diachi = @"Data Source=LAPTOP\SQLEXPRESS;Initial Catalog=btl;Integrated Security=True";
        public SqlConnection kn;
        public SqlCommand cm;
        public SqlDataAdapter dtadt;
        public DataTable dttb;

        public Database()
        {
            kn = new SqlConnection(diachi);
            cm = new SqlCommand
            {
                Connection = kn
            };
        }

        public void Ket()
        {
            if (kn.State == ConnectionState.Closed)
            {
                kn.Open();
            }
        }

        public void Ngat()
        {
            if (kn.State == ConnectionState.Open)
            {
                kn.Close();
            }
        }

        public void Chay(string batki)
        {
            Ket();
            cm.CommandText = batki;
            cm.ExecuteNonQuery();
            Ngat();
        }

        public void Taiad(string select, DataGridView dtgv)
        {
            Ket();
            cm.CommandText = select;
            dtadt = new SqlDataAdapter(cm);
            dttb = new DataTable();
            dtadt.Fill(dttb);
            dtgv.DataSource = dttb;
            Ngat();
        }

        public void Tai(string lenh, DataGridView dataGridView)
        {
            Ket();
            cm.CommandText = lenh;
            dtadt = new SqlDataAdapter(cm);
            dttb = new DataTable();
            dtadt.Fill(dttb);
            if (dttb.Columns.Contains("gia"))
            {
                foreach (DataRow dataRow in dttb.Rows)
                {
                    int giagoc = int.Parse(dataRow["gia"].ToString());
                    int gialai = (int)(giagoc * 1.2);
                    dataRow["gia"] = gialai;
                }
            }
            dataGridView.DataSource = dttb;
            Ngat();
        }

        public int Dem(string lenh)
        {
            Chay(lenh);
            Ket();
            int dem = (int)cm.ExecuteScalar();
            Ngat();
            return dem;
        }

        public void Hoa(string ten_proc,string ten_bien,string gia_tri_bien, ReportDocument reportDocument)
        {
            Ket();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = ten_proc;
            cm.Parameters.AddWithValue(ten_bien, gia_tri_bien);
            dtadt = new SqlDataAdapter(cm);
            dttb = new DataTable();
            dtadt.Fill(dttb);
            reportDocument.SetDataSource(dttb);
            cm.Parameters.Clear();
            cm.CommandType = CommandType.Text;
            Ngat();
        }

        public void Tu(string lenh, AutoCompleteStringCollection autoCompleteStringCollection, string ten_cot, Control control)
        {
            Ket();
            cm.CommandText = lenh;
            dtadt = new SqlDataAdapter(cm);
            dttb = new DataTable();
            dtadt.Fill(dttb);
            foreach (DataRow dataRow in dttb.Rows)
            {
                autoCompleteStringCollection.Add(dataRow[ten_cot].ToString());
            }
            if (control is TextBox)
            {
                TextBox textBox = control as TextBox;
                textBox.AutoCompleteCustomSource = autoCompleteStringCollection;
            }
            else if(control is ComboBox)
            {
                ComboBox comboBox = control as ComboBox;
                comboBox.AutoCompleteCustomSource = autoCompleteStringCollection;
            }
            Ngat();
        }
    }

    class Luu
    {
        public static string tk;
    }
}