using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oraclee_sql_app
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void dashboard2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dashboard2 db2 = new Dashboard2();
            db2.ShowDialog();
        }

        private void dashboard1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dashboard db1 = new Dashboard();
            db1.ShowDialog();
        }

        private void crystalReport1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void crystalReport2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
