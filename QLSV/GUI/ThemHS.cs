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
            this.dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridView2.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView2.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView2.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //

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
                dataGridView2.DataSource = bus.getData2();
                this.dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView2.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView2.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView2.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView2.Refresh();
                

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
