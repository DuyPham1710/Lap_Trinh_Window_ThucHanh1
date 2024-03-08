using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace ThucHanh1
{
    public partial class FGiaoVien : Form
    {
        TeacherDao teacherDao = new TeacherDao();
        public FGiaoVien()
        {
            InitializeComponent();
            ucInfo.btnAdd.Click += btnAdd_Click;
            ucInfo.btnEdit.Click += btnEdit_Click;
            ucInfo.btnRemove.Click += btnRemove_Click;
        }

        private void FGiaoVien_Load(object sender, EventArgs e)
        {
            ucInfo.gvList.DataSource = DBConnection.Load("GiaoVien");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Check.check_all(ucInfo))
            {             
                Teacher teacher = new Teacher(ucInfo.txtID.Text, ucInfo.txtName.Text, ucInfo.txtAddress.Text, ucInfo.txtCMND.Text, ucInfo.dateTimePicker1.Value, ucInfo.txtPhone.Text, ucInfo.txtGender.Text, ucInfo.txtEmail.Text);
                teacherDao.Add(teacher, "GiaoVien");
                FGiaoVien_Load(sender, e);
            }        
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (Check.check_all(ucInfo))
            {
                Teacher teacher = new Teacher(ucInfo.txtID.Text, ucInfo.txtName.Text, ucInfo.txtAddress.Text, ucInfo.txtCMND.Text, ucInfo.dateTimePicker1.Value, ucInfo.txtPhone.Text, ucInfo.txtGender.Text, ucInfo.txtEmail.Text);
                teacherDao.Update(teacher, "GiaoVien");
                FGiaoVien_Load(sender, e);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher(ucInfo.txtID.Text);
            teacherDao.Delete(teacher, "GiaoVien");
            FGiaoVien_Load(sender, e);
        }
    }
}
