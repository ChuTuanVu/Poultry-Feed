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

        public void Ketnoi()
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
            Ketnoi();
            cm.CommandText = batki;
            cm.ExecuteNonQuery();
            Ngat();
        }

        //public void Tai(string select, DataGridView dtgv)
        //{
        //    Ketnoi();
        //    cm.CommandText = select;
        //    dtadt = new SqlDataAdapter(cm);
        //    dttb = new DataTable();
        //    dtadt.Fill(dttb);
        //    dtgv.DataSource = dttb;
        //}

        public void Tai(string select, DataGridView dtgv)
        {
            Ketnoi();
            cm.CommandText = select;
            dtadt = new SqlDataAdapter(cm);
            dttb = new DataTable();
            dtadt.Fill(dttb);
            if (dttb.Columns.Contains("gia"))
            {
                foreach (DataRow row in dttb.Rows)
                {
                    int giagoc = int.Parse(row["gia"].ToString());
                    int gialai = (int)(giagoc * 1.2);
                    row["gia"] = gialai;
                }
            }
            dtgv.DataSource = dttb;
        }

        public int Dem(string count)
        {
            Chay(count);
            Ketnoi();
            int dem = (int)cm.ExecuteScalar();
            Ngat();
            return dem;
        }

        public void Hoa(string tenproc,string ten,string giatriten, ReportDocument rpdcm)
        {
            Ketnoi();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = tenproc;
            cm.Parameters.AddWithValue(ten, giatriten);
            dtadt = new SqlDataAdapter(cm);
            dttb = new DataTable();
            dtadt.Fill(dttb);
            rpdcm.SetDataSource(dttb);
            cm.Parameters.Clear();
            cm.CommandType = CommandType.Text;
            Ngat();
        }
    }
    class Luu
    {
        public static string tk;
    }
}