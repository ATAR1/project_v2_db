using EMC1.DataSetEMC1TableAdapters;
using Microsoft.Reporting.WinForms;
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
    public partial class MatOut : Form
    {
        private DataSetEMC1 dataSetEMC1;

        public MatOut(DataSetEMC1 dataSet)
        {
            this.dataSetEMC1 = dataSet;
            InitializeComponent();          
            
        }

        private void MatOut_Load(object sender, EventArgs e)
        {            
                    
        }

        
        

        private void btOut_Click(object sender, EventArgs e)
        {
            if (!CheckValue())
                return;

            var planjobRow = dataSetEMC1.planjob.Single(pj => pj.id == (int)cmbJob.SelectedValue);
            var materialRow = dataSetEMC1.material.Single(m => m.id_mat == (int)cmbMaterial.SelectedValue);
            var usersRow = dataSetEMC1.users.First();
            var employessRow = dataSetEMC1.employess.First();
            dataSetEMC1.OUT_MATERIAL.AddOUT_MATERIALRow(
                planjobRow,
                (int)cmbStorage.SelectedValue,
                materialRow,
                DateTime.Now,
                int.Parse(txbCol.Text),
                usersRow,
                employessRow,
                materialRow.name,
                materialRow.ED_IZMRow.full_name
                );
        }


        private bool CheckValue()
        {
            if (cmbJob.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите номер наряда", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
                
            if (cmbStorage.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите склад", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txbCol.Text.Trim().Length == 0)
            {
                MessageBox.Show("Введите количество", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
                

            int count = 0;
            if (!int.TryParse(txbCol.Text, out count))                
            {
                MessageBox.Show("Проверьте введенные данные", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (Convert.ToInt32(txbCol.Text) <= (int)((DataRowView)storageDataTable1BindingSource.Current).Row["count"])
                return true;
            else
            {
                MessageBox.Show("Недостаточно материалла на складе", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }              

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataSetEMC1.HasChanges())
                if (MessageBox.Show("Есть несохранённые изменения! Отменить их?", "Внимание!", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.oUT_MATERIALTableAdapter.Update(dataSetEMC1);
        }
    }
}
