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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSuaXoaSV suaxoanv = null;
            Check_Sua:
            if (suaxoanv == null || suaxoanv.IsDisposed)
            {
                suaxoanv = new frmSuaXoaSV();
            }
            if (suaxoanv.ShowDialog() == DialogResult.OK)
            {
                if ( db.editStudent(txtMasv.Text, txtTensv.Text, cbGt.Text, dtpNs.Text, txtMalop.Text) == 0)
                {
                    goto Check_Sua;
                }
            }
            db.editStudent(txtMasv.Text, txtTensv.Text, cbGt.Text, dtpNs.Text, txtMalop.Text);
            dataGridView1.DataSource = db.getData2();
        }
    }
}
