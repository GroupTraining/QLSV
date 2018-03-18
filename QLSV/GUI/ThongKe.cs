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
    public partial class ThongKe : Form
    {
        Bus bus = new Bus();
        DataDiagramDataContext data = new DataDiagramDataContext();
        public ThongKe()
        {
            InitializeComponent();
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            var mhs = from mon in data.MonHocs
                     select mon;
            comboBox_môn.Items.Add("[Chọn môn]");
            comboBox_môn.SelectedIndex = 0;
            foreach(var mh in mhs)
            {
                comboBox_môn.Items.Add(mh.TenMon);
            }
            var lops = from lop in data.Lops
                       select lop;
            comboBox_lop.Items.Add("[Chọn lớp]");
            comboBox_lop.SelectedIndex = 0;
            foreach (var lop in lops)
            {
                comboBox_lop.Items.Add(lop.TenLop);
            }

        }

        private void btn_timkiemdiemtheomon_Click(object sender, EventArgs e)
        {
            dataGridViewX1.DataSource = bus.ThongKeDiemTheoMon(comboBox_môn.GetItemText(comboBox_môn.SelectedItem));

            this.dataGridViewX1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewX1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewX1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewX1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void btn_timkiemdiemtheolop_Click(object sender, EventArgs e)
        {
            dataGridViewX2.DataSource = bus.ThongKeDiemTheoLop(comboBox_lop.GetItemText(comboBox_lop.SelectedItem));

            this.dataGridViewX2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewX2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewX2.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewX2.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
