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
    public partial class ThemHS : Form
    {
        Bus bus = new Bus();
        public ThemHS()
        {
            InitializeComponent();
            dataGridView2.DataSource = bus.getData2();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            string gt = "";
            if (radioNam.Checked == true)
            {
                gt = "Nam";
            }
            if (radioNu.Checked == true)
            {
                gt = "Nữ";
            }
            try
            {
                bus.addStudent(textMasv.Text, textTensv.Text, gt, dateBirth.Text, textMalop.Text);
                dataGridView2.Refresh();
                dataGridView2.DataSource = bus.getData2();

                MessageBox.Show("Đã thêm thành công");
            }
            catch (Exception ex)
            {
                Console.Write(ex);
                MessageBox.Show("Nhập liệu sai!!!");
            }
        }
    }
}
