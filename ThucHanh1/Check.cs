using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucHanh1
{
    internal class Check
    {
        public bool check_field(UCInfo ucInfo)
        {
            if (ucInfo.txtID.Text != "" && ucInfo.txtName.Text != "" && ucInfo.txtAddress.Text != "" && ucInfo.txtCMND.Text != ""
                 && ucInfo.txtGioiTinh.Text != "" && ucInfo.txtEmail.Text != "" && ucInfo.txtPhone.Text != "")
            {
                return true;
            }
            return false;
        }
        private bool check_date(DateTime dt)
        {
            DateTime current = DateTime.Now;
            DateTime birth = current.AddYears(-17);
            return dt <= birth;
        }
        public bool Check_phoneNumber(string phoneNumber)
        {
            return phoneNumber.Length == 10;
        }
        public bool Check_email(string email)
        {
            return false;
        }
    }
}
