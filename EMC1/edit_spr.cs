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
        public edit_spr()
        {
            InitializeComponent();
        }

        private void edit_spr_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetEMC11.ED_IZM". При необходимости она может быть перемещена или удалена.
            this.eD_IZMTableAdapter.Fill(this.dataSetEMC11.ED_IZM);
            this.employessTableAdapter.Fill(this.dataSetEMC11.employess);
            this.kontrTableAdapter.Fill(this.dataSetEMC11.kontr);
            this.storageTableAdapter.Fill(this.dataSetEMC11.storage);
            this.materialTableAdapter.Fill(this.dataSetEMC11.material);
            this.jobsTableAdapter.Fill(this.dataSetEMC11.jobs);
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedTab.Name)
            {
                case "employess":
                    this.employessTableAdapter.Update(this.dataSetEMC11.employess);
                    break;
                case "kontr":
                    this.kontrTableAdapter.Update(this.dataSetEMC11.kontr);
                    break;
                case "storage":
                    this.storageTableAdapter.Update(this.dataSetEMC11.storage);
                    break;
                case "material":
                    this.materialTableAdapter.Update(this.dataSetEMC11.material);
                    break;
                case "jobs":
                    this.jobsTableAdapter.Update(this.dataSetEMC11.jobs);
                    break;
                case "tpEdIzm":
                    this.eD_IZMTableAdapter.Update(this.dataSetEMC11.ED_IZM);
                    break;
            }//switch
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
