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
    public partial class edit_spr : Form
    {
        public edit_spr(DataSetEMC1 dataSet)
        {
            InitializeComponent();
            sharedDataSource.DataSource = dataSet;
        }
        


        private void button1_Click_1(object sender, EventArgs e)
        {
            var dataSetEMC11 = ((DataSetEMC1)sharedDataSource.DataSource);
            this.employeeTableAdapter.Update(dataSetEMC11.Employee);
            this.contrTableAdapter.Update(dataSetEMC11.Contr);
            this.storageTableAdapter.Update(dataSetEMC11.Storage);
            this.materialTableAdapter.Update(dataSetEMC11.Material);
            this.jobTypeTableAdapter.Update(dataSetEMC11.JobType);
            this.unitTableAdapter.Update(dataSetEMC11.Unit);
        }

        private void edit_spr_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (((DataSetEMC1)sharedDataSource.DataSource).HasChanges())
                if (MessageBox.Show("Есть несохранённые изменения! Отменить их?", "Внимание!", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
                else
                {
                    ((DataSetEMC1)sharedDataSource.DataSource).RejectChanges();
                }
        }
    }
}
