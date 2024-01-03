using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace btl
{
    class DataBase
    {
        public string diachi = @"Data Source=LAPTOP\SQLEXPRESS;Initial Catalog=btl;Integrated Security=True";
        public SqlConnection kn;
        public SqlCommand cm;
        public SqlDataAdapter dtadt;
        public DataTable dttb;

        public DataBase()
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

        public void Chay(string lenh)
        {
            Ket();
            cm.CommandText = lenh;
            cm.ExecuteNonQuery();
            Ngat();
        }

        public void Tai(string lenh, Control control)
        {
            Ket();
            cm.CommandText = lenh;
            dtadt = new SqlDataAdapter(cm);
            dttb = new DataTable();
            dtadt.Fill(dttb);
            Ngat();
            if (control is DataGridView)
            {
                DataGridView dataGridView = control as DataGridView;
                dataGridView.DataSource = dttb;
            }
            else if (control is ComboBox)
            {
                ComboBox comboBox = control as ComboBox;
                foreach (DataRow dataRow in dttb.Rows)
                {
                    object giatri = dataRow[0].ToString();
                    if (!comboBox.Items.Contains(giatri))
                    {
                        comboBox.Items.Add(giatri);
                    }
                }
            }
        }

        public void TaiV2(string lenh, Control control)
        {
            Ket();
            cm.CommandText = lenh;
            dtadt = new SqlDataAdapter(cm);
            dttb = new DataTable();
            dtadt.Fill(dttb);
            Ngat();
            if (control is DataGridView)
            {
                DataGridView dataGridView = control as DataGridView;
                if (dttb.Columns.Contains("gia"))
                {
                    foreach (DataRow dataRow in dttb.Rows)
                    {
                        double giagoc = Convert.ToDouble((dataRow["gia"]));
                        double gialai = giagoc * 1.2;
                        dataRow["gia"] = gialai;
                    }
                    dataGridView.DataSource = dttb;
                }
            }
        }

        public object Lay(string lenh)
        {
            Chay(lenh);
            Ket();
            object giatri = cm.ExecuteScalar();
            Ngat();
            return giatri;
        }

        public void Hoa(string ten_proc, string ten_bien, string gia_tri_bien, ReportDocument reportDocument)
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

        public void Tu(string lenh, AutoCompleteStringCollection autoCompleteStringCollection, Control control)
        {
            Ket();
            cm.CommandText = lenh;
            dtadt = new SqlDataAdapter(cm);
            dttb = new DataTable();
            dtadt.Fill(dttb);
            Ngat();
            foreach (DataRow dataRow in dttb.Rows)
            {
                for (int i = 0; i < dttb.Columns.Count; i++)
                {
                    autoCompleteStringCollection.Add(dataRow[i].ToString());
                }
            }

            if (control is TextBox)
            {
                TextBox textBox = control as TextBox;
                textBox.AutoCompleteCustomSource = autoCompleteStringCollection;
            }
            else if (control is ComboBox)
            {
                ComboBox comboBox = control as ComboBox;
                comboBox.AutoCompleteCustomSource = autoCompleteStringCollection;
            }
        }
    }

    class Save
    {
        public static string tk;
    }
}