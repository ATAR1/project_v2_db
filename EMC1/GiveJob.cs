using EMC1.DataSetEMC1TableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMC1
{
    public partial class GiveJob : Form
    {
        private DataSetEMC1 dataSetEMC1;

        public GiveJob(DataSetEMC1 dataSet)
        {
            InitializeComponent();
            sharedDataSource.DataSource = dataSet;
            dataSetEMC1 = dataSet;
        }
        

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private bool SaveData()
        {
            DataSetEMC1.JobRow NewRow= this.dataSetEMC1.Job.NewJobRow();
            NewRow.JobTypeId = (int)cmbJobs.SelectedValue;
            NewRow.ExecutorId = (int)cmbEmpl.SelectedValue;
            NewRow.Date = dtp.Value;
            NewRow.ChiefId = 0;
            NewRow.Status= 1;

            dataSetEMC1.Job.AddJobRow(NewRow);
            try
            {
                new JobTableAdapter().Update(dataSetEMC1.Job);
                MessageBox.Show("Данные сохранены", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось сохранить данные", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
        
    }
}
