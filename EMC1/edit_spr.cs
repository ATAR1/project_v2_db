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
            this.unitTableAdapter.Fill(this.dataSetEMC11.Unit);
            this.employeeTableAdapter.Fill(this.dataSetEMC11.Employee);
            this.contrTableAdapter.Fill(this.dataSetEMC11.Contr);
            this.storageTableAdapter.Fill(this.dataSetEMC11.Storage);
            this.materialTableAdapter.Fill(this.dataSetEMC11.Material);
            this.jobTypeTableAdapter.Fill(this.dataSetEMC11.JobType);
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedTab.Name)
            {
                case "employess":
                    this.employeeTableAdapter.Update(this.dataSetEMC11.Employee);
                    break;
                case "kontr":
                    this.contrTableAdapter.Update(this.dataSetEMC11.Contr);
                    break;
                case "storage":
                    this.storageTableAdapter.Update(this.dataSetEMC11.Storage);
                    break;
                case "material":
                    this.materialTableAdapter.Update(this.dataSetEMC11.Material);
                    break;
                case "jobs":
                    this.jobTypeTableAdapter.Update(this.dataSetEMC11.JobType);
                    break;
                case "tpEdIzm":
                    this.unitTableAdapter.Update(this.dataSetEMC11.Unit);
                    break;
            }//switch
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
