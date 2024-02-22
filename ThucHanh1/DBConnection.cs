using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucHanh1
{
    internal class DBConnection
    {
        static SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public static DataTable Load(string selectForm)
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT *FROM " + selectForm);

                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dtSinhVien = new DataTable();
                adapter.Fill(dtSinhVien);
                return dtSinhVien; /// gvHsinh = name cua data gridview
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
            return null;
        }
        public static void Execute(string SQL)
        {
            try
            {
                // Ket noi
                conn.Open();
                SqlCommand cmd = new SqlCommand(SQL, conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                     MessageBox.Show("Thuc thi thanh cong");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thuc thi that bai\n" + ex);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
