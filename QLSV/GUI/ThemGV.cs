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
    public partial class ThemGV : Form
    {
        Bus bus = new Bus();
        public ThemGV()
        {
            InitializeComponent();
            dataGridViewX1.DataSource = bus.getData1();
        }
        
        private void dataGridViewX1_CellContentClick(object sender, DataGridViewCellEventArgs e)//hiển thị giáo viên vừa thêm
        {
            
        }

        private void buttonThem_Click(object sender, EventArgs e)//Thêm giáo viên
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
                bus.addTeacher(txtMaGV.Text, txtHoTen.Text, gt, dtpBirthday.Text, txtSDT.Text, txtMaMon.Text);
                dataGridViewX1.Refresh();
                dataGridViewX1.DataSource = bus.getData1();
                
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
