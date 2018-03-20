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
    public partial class ThemDiem : Form
    {
        Bus bus = new Bus();
        public ThemDiem()
        {
            InitializeComponent();
            dataGridView3.DataSource = bus.getData3();
            this.dataGridView3.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView3.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridView3.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView3.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                bus.addMark(textMSV.Text, textMamon.Text, textDiem.Text);
                dataGridView3.DataSource = bus.getData3();
                dataGridView3.Refresh();
            }
            catch (Exception ex)
            {
                Console.Write(ex);
                MessageBox.Show("Nhập liệu sai!!!");
            }
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dataGridView3.DataSource = bus.getData2();
            this.dataGridView3.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView3.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridView3.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView3.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView3.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dataGridView3.DataSource = bus.getData3();
            this.dataGridView3.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView3.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridView3.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView3.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
