using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Net.Mail;
using System.Security.Cryptography;

namespace ThucHanh1
{
    internal class Check
    {
        public static bool check_all(UCInfo ucInfo)
        {
            if (check_field(ucInfo))
            {
                if (!Check_phoneNumber(ucInfo.txtPhone.Text))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ");
                }
                if (!check_date(ucInfo.dateTimePicker1.Value))
                {
                    MessageBox.Show("Ngày sinh phải lớn hơn hoặc bằng 17 tuổi");
                }
                if (!Check_email(ucInfo.txtEmail.Text))
                {
                    MessageBox.Show("Email không hợp lệ");
                    return false;
                }
                if (Check_phoneNumber(ucInfo.txtPhone.Text) && check_date(ucInfo.dateTimePicker1.Value) && Check_email(ucInfo.txtEmail.Text))
                {
                    return true;
                }
            }
            else
            {
                MessageBox.Show("Tất cả các field không được rỗng");
            }
            return false;
        }

        public static bool check_field(UCInfo ucInfo)
        {
            return (ucInfo.txtID.Text != "" && ucInfo.txtName.Text != "" && ucInfo.txtAddress.Text != "" && ucInfo.txtCMND.Text != ""
                 && ucInfo.txtGender.Text != "" && ucInfo.txtEmail.Text != "" && ucInfo.txtPhone.Text != "");
        }

        public static bool check_date(DateTime dt)
        {
            DateTime current = DateTime.Now;
            DateTime birth = current.AddYears(-17);
            return dt <= birth;
        }

        public static bool Check_phoneNumber(string phoneNumber)
        {
            for (int i=0; i<phoneNumber.Length; i++)
            {
                if (i != 3 && i != 8)
                {
                    if (phoneNumber[i] < '0' || phoneNumber[i] > '9')
                        return false;
                }
            }
            return phoneNumber.Length == 12 && phoneNumber[3] == '-' && phoneNumber[8] == '-';
        }

        public static bool Check_email(string email)
        {
            if (!email.Contains("@") || !email.Contains(".") || email.EndsWith("."))
                return false;

            for (int i=0; i<email.Length; i++)
            {
                if (email[i] == '.' || email[i] == '@')
                {
                    for (int j=i+1; j<email.Length; j++)
                    {
                        if (email[j] == '@')
                            return false;
                    }
                }
                if (email[i] == '.' && email[i+1] == '.')
                    return false;

                if (email[i] == '@' && email[i+1] ==  '.')
                    return false;
            }
            return true;
        }
    }
}
