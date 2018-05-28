using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMC1
{
    public partial class REP_NARYAD : Form
    {
        public REP_NARYAD()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {

            switch (comboBox1.SelectedIndex)
            {
                case 0 :
                    gET_REP_NARYADTableAdapter.Fill(dataSetEMC1.GET_REP_NARYAD, 1);
                    break;

                case 1 :
                    gET_REP_NARYADTableAdapter.Fill(dataSetEMC1.GET_REP_NARYAD, 2);
                    break;

                default:
                    break;
            }
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = "Report2.rdlc";
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", gET_REP_NARYADBindingSource));
            reportViewer1.RefreshReport();
        }
    }
}
