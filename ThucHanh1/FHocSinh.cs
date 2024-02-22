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
        Check check = new Check();
        public FHocSinh()
        {
            InitializeComponent();
            ucInfo.btnAdd.Click += btnAdd_Click;
            ucInfo.btnEdit.Click += btnEdit_Click;
            ucInfo.btnRemove.Click += btnRemove_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ucInfo.gvHsinh.DataSource = DBConnection.Load("HocSinh"); /// gvHsinh = name cua data gridview
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (check.check_field(ucInfo))
            {
              //  if (check_date(ucInfo.dateTimePicker1.Value))
                if (check.Check_phoneNumber(ucInfo.txtPhone.Text))
                {
                    Student student = new Student(ucInfo.txtID.Text, ucInfo.txtName.Text, ucInfo.txtAddress.Text, ucInfo.txtCMND.Text, ucInfo.dateTimePicker1.Value, ucInfo.txtPhone.Text, ucInfo.txtGioiTinh.Text, ucInfo.txtEmail.Text);
                    StudentDao.Add(student);
                    Form1_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Số điện thoại không hợp lệ");
                }
            }
            else
            {
                MessageBox.Show("Tất cả các field không được rỗng");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Student student = new Student(ucInfo.txtID.Text, ucInfo.txtName.Text, ucInfo.txtAddress.Text, ucInfo.txtCMND.Text, ucInfo.dateTimePicker1.Value, ucInfo.txtPhone.Text, ucInfo.txtGioiTinh.Text, ucInfo.txtEmail.Text);
            StudentDao.Update(student);
            Form1_Load(sender, e);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Student student = new Student(ucInfo.txtID.Text);
            StudentDao.Delete(student);
            Form1_Load(sender, e);
        }

        private void btnGiaoVien_Click(object sender, EventArgs e)
        {
            this.Hide();
            FGiaoVien form2 = new FGiaoVien();
            form2.ShowDialog();
            this.Show();
        }

        //private void gvHsinh_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    try
        //    {
        //        string value1 = ucinfo.gvHsinh.Rows[e.RowIndex].Cells[0].Value.ToString();
        //        string value2 = ucinfo.gvHsinh.Rows[e.RowIndex].Cells[1].Value.ToString();
        //        string value3 = ucinfo.gvHsinh.Rows[e.RowIndex].Cells[2].Value.ToString();
        //        string value4 = ucinfo.gvHsinh.Rows[e.RowIndex].Cells[3].Value.ToString();
        //        DateTime value5 = DateTime.Parse(ucinfo.gvHsinh.Rows[e.RowIndex].Cells[4].Value.ToString());

        //        ucinfo.txtID.Text = value1;
        //        ucinfo.txtName.Text = value2;
        //        ucinfo.txtAddress.Text = value3;
        //        ucinfo.txtCMND.Text = value4;
        //        ucinfo.dateTimePicker1.Value = value5;
        //    }
        //    catch (Exception ex) { }
        //}
    }
}
