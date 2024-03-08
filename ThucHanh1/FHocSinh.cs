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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace ThucHanh1
{
    public partial class FHocSinh : Form
    {
        StudentDao studentDao = new StudentDao();
        public FHocSinh()
        {
            InitializeComponent();
            ucInfo.btnAdd.Click += btnAdd_Click;
            ucInfo.btnEdit.Click += btnEdit_Click;
            ucInfo.btnRemove.Click += btnRemove_Click;
        }

        private void FHocSinh_Load(object sender, EventArgs e)
        {
            ucInfo.gvList.DataSource = DBConnection.Load("HocSinh");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Check.check_all(ucInfo))
            {
                Student student = new Student(ucInfo.txtID.Text, ucInfo.txtName.Text, ucInfo.txtAddress.Text, ucInfo.txtCMND.Text, ucInfo.dateTimePicker1.Value, ucInfo.txtPhone.Text, ucInfo.txtGender.Text, ucInfo.txtEmail.Text);
                studentDao.Add(student, "HocSinh");
                FHocSinh_Load(sender, e);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (Check.check_all(ucInfo))
            {
                Student student = new Student(ucInfo.txtID.Text, ucInfo.txtName.Text, ucInfo.txtAddress.Text, ucInfo.txtCMND.Text, ucInfo.dateTimePicker1.Value, ucInfo.txtPhone.Text, ucInfo.txtGender.Text, ucInfo.txtEmail.Text);
                studentDao.Update(student, "HocSinh");
                FHocSinh_Load(sender, e);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Student student = new Student(ucInfo.txtID.Text);
            studentDao.Delete(student, "HocSinh");
            FHocSinh_Load(sender, e);
        }

        private void btnGiaoVien_Click(object sender, EventArgs e)
        {
            this.Hide();
            FGiaoVien form2 = new FGiaoVien();
            form2.ShowDialog();
            this.Show();
        }
    }
}
