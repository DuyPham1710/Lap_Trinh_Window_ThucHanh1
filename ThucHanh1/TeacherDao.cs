using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ThucHanh1
{
    internal class TeacherDao
    {
        static SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);

        public static void Add(Teacher teacher)
        {
            string sqlStr = string.Format("INSERT INTO GiaoVien(ID, Ten , Diachi, Cmnd, ngaySinh, GioiTinh, Email, PhoneNumber) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')",
                teacher.ID, teacher.Name, teacher.Address, teacher.Cmnd, teacher.BornYear.ToString(), teacher.GioiTinh, teacher.Email, teacher.PhoneNumber);
            DBConnection.Execute(sqlStr);
        }

        public static void Update(Teacher teacher)
        {
            string SQL = string.Format("UPDATE GiaoVien SET Ten = '{0}', Diachi = '{1}', Cmnd = '{2}', ngaySinh = '{3}', GioiTinh = '{4}', Email = '{5}', PhoneNumber = '{6}' WHERE ID = '{7}'",
                teacher.Name, teacher.Address, teacher.Cmnd, teacher.BornYear.ToString(), teacher.GioiTinh, teacher.Email, teacher.PhoneNumber, teacher.ID);
            DBConnection.Execute(SQL);
        }

        public static void Delete(Teacher teacher)
        {
            string SQL = string.Format("DELETE FROM GiaoVien WHERE id = '{0}'", teacher.ID);
            DBConnection.Execute(SQL);
        }  
    }
}