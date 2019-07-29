using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
namespace files
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();           
        }
       

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void test_Load(object sender, EventArgs e)
        {
            //ReportDocument reportDocument = new ReportDocument();           
            CrystalReport2 reportDocument = new CrystalReport2();
            reportDocument.FileName = "projectreport.xml";
            //reportDocument.Load(@"C:\Users\ghazi\Desktop\Task Manager\Task Manager\files\CrystalReport2.rpt");
            //TextObject t = (TextObject)reportDocument.ReportDefinition.Sections["Section3"].ReportObjects["Text1"];
            this.crystalReportViewer1.Refresh();
            this.crystalReportViewer1.ReportSource = reportDocument;
        }
    }
}
