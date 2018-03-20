using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BUS;

namespace QLSV.GUI
{
    public partial class EditTeacher : Form
    {
        public EditTeacher()
        {
            InitializeComponent();
            dataGridView1.DataSource = tk.getData1();
        }


        Bus tk = new Bus();

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string gt = "";
            if (radioNam.Checked == true)
            {
                gt = "Nam";
            }
            else
            {
                gt = "Nữ";
            }
            tk.editTeacher(txtMaGV.Text, txtTenGV.Text, dateTimePicker1.Text, gt, txtSDT.Text, txtMonHoc.Text);
            dataGridView1.DataSource = tk.getData1();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            tk.DeleteTeacher(txtMaGV.Text);
            dataGridView1.DataSource = tk.getData1();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtMaGV.Text = dataGridView1.CurrentRow.Cells["MaGV"].Value.ToString();
            txtTenGV.Text = dataGridView1.CurrentRow.Cells["HoTen"].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells["NS"].Value.ToString();
            txtSDT.Text = dataGridView1.CurrentRow.Cells["SDT"].Value.ToString();
            txtMonHoc.Text = dataGridView1.CurrentRow.Cells["MaMon"].Value.ToString();

            string Gender = "";
            Gender = dataGridView1.CurrentRow.Cells["GT"].Value.ToString();
            if (Gender == "False")
            {
                radioNam.Checked = true;
            }
            else
            {
                radioNu.Checked = true;
            }
        }
    }
}
