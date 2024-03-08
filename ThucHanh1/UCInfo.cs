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

        private void gvHsinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string value1 = gvList.Rows[e.RowIndex].Cells[0].Value.ToString();
                string value2 = gvList.Rows[e.RowIndex].Cells[1].Value.ToString();
                string value3 = gvList.Rows[e.RowIndex].Cells[2].Value.ToString();
                string value4 = gvList.Rows[e.RowIndex].Cells[3].Value.ToString();
                string value5 = gvList.Rows[e.RowIndex].Cells[5].Value.ToString();
                string value6 = gvList.Rows[e.RowIndex].Cells[6].Value.ToString();
                string value7 = gvList.Rows[e.RowIndex].Cells[7].Value.ToString();
                DateTime value8 = DateTime.Parse(gvList.Rows[e.RowIndex].Cells[4].Value.ToString());

                txtID.Text = value1;
                txtName.Text = value2;
                txtAddress.Text = value3;
                txtCMND.Text = value4;
                txtGender.Text = value5;
                txtEmail.Text = value6;
                txtPhone.Text = value7;
                dateTimePicker1.Value = value8;
            }
            catch (Exception ex) { }
        }
    }
}
