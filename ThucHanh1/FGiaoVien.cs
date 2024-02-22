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

namespace ThucHanh1
{
    public partial class FGiaoVien : Form
    {
        public FGiaoVien()
        {
            InitializeComponent();
            ucInfo.btnAdd.Click += btnAdd_Click;
            ucInfo.btnEdit.Click += btnEdit_Click;
            ucInfo.btnRemove.Click += btnRemove_Click;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ucInfo.gvHsinh.DataSource = DBConnection.Load("GiaoVien"); /// gvHsinh = name cua data gridview
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher(ucInfo.txtID.Text, ucInfo.txtName.Text, ucInfo.txtAddress.Text, ucInfo.txtCMND.Text, ucInfo.dateTimePicker1.Value, ucInfo.txtPhone.Text, ucInfo.txtGioiTinh.Text, ucInfo.txtEmail.Text);
            TeacherDao.Add(teacher);
            Form2_Load(sender, e);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher(ucInfo.txtID.Text, ucInfo.txtName.Text, ucInfo.txtAddress.Text, ucInfo.txtCMND.Text, ucInfo.dateTimePicker1.Value, ucInfo.txtPhone.Text, ucInfo.txtGioiTinh.Text, ucInfo.txtEmail.Text);
            TeacherDao.Update(teacher);
            Form2_Load(sender, e);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher(ucInfo.txtID.Text);
            TeacherDao.Delete(teacher);
            Form2_Load(sender, e);
        }

        //private void gvGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    //try
        //    //{
        //    //    string value1 = gvGiaoVien.Rows[e.RowIndex].Cells[0].Value.ToString();
        //    //    string value2 = gvGiaoVien.Rows[e.RowIndex].Cells[1].Value.ToString();
        //    //    string value3 = gvGiaoVien.Rows[e.RowIndex].Cells[2].Value.ToString();
        //    //    string value4 = gvGiaoVien.Rows[e.RowIndex].Cells[3].Value.ToString();
        //    //    DateTime value5 = DateTime.Parse(gvGiaoVien.Rows[e.RowIndex].Cells[4].Value.ToString());

        //    //    txtID.Text = value1;
        //    //    txtName.Text = value2;
        //    //    txtAddress.Text = value3;
        //    //    txtCMND.Text = value4;
        //    //    dateTimePicker1.Value = value5;
        //    //}
        //    //catch (Exception ex) { }
        //}
    }
}
