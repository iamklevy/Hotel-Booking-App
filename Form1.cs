using CrystalDecisions.Shared;
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
    public partial class Form1 : Form
    {
        CrystalReport1 report1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            report1 = new CrystalReport1();
            foreach (ParameterDiscreteValue v in report1.ParameterFields[0].DefaultValues)
            {
                comboBox1.Items.Add(v.Value);

            }

        }

        private void generatereport_btn_Click(object sender, EventArgs e)
        {
            report1.SetParameterValue(0, comboBox1.Text);
            crystalReportViewer1.ReportSource = report1;

        }
    }
}
