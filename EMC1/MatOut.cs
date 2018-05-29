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

        public MatOut(DataSetEMC1 dataSet)
        {
            
            InitializeComponent();          
            sharedBindingSource.DataSource = dataSet;
           
        }

        private void MatOut_Load(object sender, EventArgs e)
        {
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetEMC1.Stored". При необходимости она может быть перемещена или удалена.
            //this.storedTableAdapter.Fill(this.dataSetEMC1.Stored);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetEMC1.Storage". При необходимости она может быть перемещена или удалена.
            //this.storageTableAdapter.Fill(this.dataSetEMC1.Storage);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetEMC1.OutMaterial". При необходимости она может быть перемещена или удалена.
            //this.outMaterialTableAdapter.Fill(this.dataSetEMC1.OutMaterial);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetEMC1.Job". При необходимости она может быть перемещена или удалена.
            //this.jobTableAdapter.Fill(this.dataSetEMC1.Job);

            //jobBindingSource.ResetBindings(false);
            //storageBindingSource.ResetBindings(false);
        }




        private void btOut_Click(object sender, EventArgs e)
        {
            if (!CheckValue())
                return;
            DataSetEMC1.OutMaterialRow newRow =(DataSetEMC1.OutMaterialRow)((DataSetEMC1)sharedBindingSource.DataSource).OutMaterial.NewRow();
            newRow.Date = DateTime.Now;
            newRow.Count = Int32.Parse(txbCol.Text);
            newRow.JobId = (int)cmbJob.SelectedValue;
            newRow.MaterialId = (int)cmbMaterial.SelectedValue;
            newRow.StorageId = (int)cmbStorage.SelectedValue;
            newRow.StoremanId = 1;
            newRow.RecipientId = 1;
            ((DataSetEMC1.StoredRow)((DataRowView)storedBindingSource.Current).Row).Count -= Int32.Parse(txbCol.Text);
            ((DataSetEMC1)sharedBindingSource.DataSource).OutMaterial.AddOutMaterialRow(newRow);
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

            return true;
            if (Convert.ToInt32(txbCol.Text) <= ((DataSetEMC1.StoredRow)storedBindingSource.Current).Count)
                return true;
            else
            {
                MessageBox.Show("Недостаточно материалла на складе", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (((DataSetEMC1)sharedBindingSource.DataSource).HasChanges())
                if (MessageBox.Show("Есть несохранённые изменения! Отменить их?", "Внимание!", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.outMaterialTableAdapter.Update((DataSetEMC1)sharedBindingSource.DataSource);
            this.storedTableAdapter.Update((DataSetEMC1)sharedBindingSource.DataSource);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
