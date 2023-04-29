using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace oraclee_sql_app
{
    public partial class Form2 : Form
    {
        CrystalReport2 CrystalReport2;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CrystalReport2 = new CrystalReport2();
        }

        private void generatereport_btn_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = CrystalReport2;
        }
    }
}
