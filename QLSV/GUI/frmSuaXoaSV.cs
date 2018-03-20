using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace QLSV.GUI
{
    public partial class frmSuaXoaSV : Form
    {
        Bus db = new Bus();
        public frmSuaXoaSV()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa sinh viên?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.editStudent(txtMasv.Text, txtTensv.Text, cbGt.Text, dtpNs.Text, txtMalop.Text);
            }

            dataGridView1.DataSource = db.getData2();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa sinh viên?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.deleteStudent(txtMasv.Text);
                dataGridView1.DataSource = db.getData2();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMasv.Text = dataGridView1.CurrentRow.Cells["MaSV"].Value.ToString();
            if (dataGridView1.CurrentRow.Cells["TenSV"].Value == null)
            {
                txtTensv.Text = "";
            }
            else
            {
                txtTensv.Text = dataGridView1.CurrentRow.Cells["TenSV"].Value.ToString();
            }
            if (dataGridView1.CurrentRow.Cells["NgaySinh"].Value == null)
            {
                dtpNs.Text = "";
            }
            else
            {
                dtpNs.Text = dataGridView1.CurrentRow.Cells["NgaySinh"].Value.ToString();
            }
            if (dataGridView1.CurrentRow.Cells["GioiTinh"].Value == null)
            {
                cbGt.Text = "";
            }
            else if (dataGridView1.CurrentRow.Cells["GioiTinh"].Value.ToString() == "True")
            {
                cbGt.Text = "Nam";
            }
            else
            {
                cbGt.Text = "Nữ";
            }
            if (dataGridView1.CurrentRow.Cells["MaLop"].Value == null)
            {
                txtMalop.Text = "";
            }
            else
            {
                txtMalop.Text = dataGridView1.CurrentRow.Cells["MaLop"].Value.ToString();
            }
        }
    }
}
