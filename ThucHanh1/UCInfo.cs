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

namespace ThucHanh1
{
    public partial class UCInfo : UserControl
    {
        public UCInfo()
        {
            InitializeComponent();
        }

        //private void btnAdd_Click(object sender, EventArgs e)
        //{
        //    if (FormName == "HocSinh")
        //    {
        //        //     if ()
        //        Student student = new Student(txtID.Text, txtName.Text, txtAddress.Text, txtCMND.Text, dateTimePicker1.Value, txtPhone.Text, txtGioiTinh.Text, txtEmail.Text);
        //        StudentDao.Add(student);
        //    }
        //    else
        //    {
        //        Teacher teacher = new Teacher(txtID.Text, txtName.Text, txtAddress.Text, txtCMND.Text, dateTimePicker1.Value, txtPhone.Text, txtGioiTinh.Text, txtEmail.Text);
        //        TeacherDao.Add(teacher);
        //    }
        //    ucInfo_Load();
        //}

        //private void btnRemove_Click(object sender, EventArgs e)
        //{
        //    if (FormName == "HocSinh")
        //    {
        //        Student student = new Student(txtID.Text);
        //        StudentDao.Delete(student);

        //    }
        //    else
        //    {
        //        Teacher teacher = new Teacher(txtID.Text);
        //        TeacherDao.Delete(teacher);
        //    }
        //    ucInfo_Load();
        //}

        //private void btnEdit_Click(object sender, EventArgs e)
        //{
        //    if (FormName == "HocSinh")
        //    {
        //        Student student = new Student(txtID.Text, txtName.Text, txtAddress.Text, txtCMND.Text, dateTimePicker1.Value, txtPhone.Text, txtGioiTinh.Text, txtEmail.Text);
        //        StudentDao.Update(student);

        //    }
        //    else
        //    {
        //        Teacher teacher = new Teacher(txtID.Text, txtName.Text, txtAddress.Text, txtCMND.Text, dateTimePicker1.Value, txtPhone.Text, txtGioiTinh.Text, txtEmail.Text);
        //        TeacherDao.Update(teacher);
        //    }
        //    ucInfo_Load();
        //}

        private void gvHsinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string value1 = gvHsinh.Rows[e.RowIndex].Cells[0].Value.ToString();
                string value2 = gvHsinh.Rows[e.RowIndex].Cells[1].Value.ToString();
                string value3 = gvHsinh.Rows[e.RowIndex].Cells[2].Value.ToString();
                string value4 = gvHsinh.Rows[e.RowIndex].Cells[3].Value.ToString();
                string value5 = gvHsinh.Rows[e.RowIndex].Cells[5].Value.ToString();
                string value6 = gvHsinh.Rows[e.RowIndex].Cells[6].Value.ToString();
                string value7 = gvHsinh.Rows[e.RowIndex].Cells[7].Value.ToString();
                DateTime value8 = DateTime.Parse(gvHsinh.Rows[e.RowIndex].Cells[4].Value.ToString());

                txtID.Text = value1;
                txtName.Text = value2;
                txtAddress.Text = value3;
                txtCMND.Text = value4;
                txtGioiTinh.Text = value5;
                txtEmail.Text = value6;
                txtPhone.Text = value7;
                dateTimePicker1.Value = value8;
            }
            catch (Exception ex) { }
        }
    }
}
