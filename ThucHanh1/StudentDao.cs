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
    internal class StudentDao
    {
        static SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);

        public static void Add(Student student)
        {
            string sqlStr = string.Format("INSERT INTO HocSinh(ID, Ten , Diachi, Cmnd, ngaySinh, GioiTinh, Email, PhoneNumber) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')",
                student.ID, student.Name, student.Address, student.Cmnd, student.BornYear.ToString(), student.GioiTinh, student.Email, student.PhoneNumber);   
            DBConnection.Execute(sqlStr);
        }

        public static void Update(Student student)
        {
            string SQL = string.Format("UPDATE HocSinh SET Ten = '{0}', Diachi ='{1}', Cmnd = '{2}', ngaySinh = '{3}', GioiTinh = '{4}', Email = '{5}', PhoneNumber = '{6}' WHERE ID = '{7}'", 
                student.Name, student.Address, student.Cmnd, student.BornYear.ToString(), student.GioiTinh, student.Email, student.PhoneNumber, student.ID);
            DBConnection.Execute(SQL);
        }

        public static void Delete(Student student)
        {
            string SQL = string.Format("DELETE FROM HocSinh WHERE id = '{0}'", student.ID);
            DBConnection.Execute(SQL);  
        }
    }
}