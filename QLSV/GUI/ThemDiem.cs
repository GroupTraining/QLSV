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
        }
    }
}
