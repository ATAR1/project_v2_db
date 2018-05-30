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

            if (Convert.ToInt32(txbCol.Text) <= ((DataSetEMC1.StoredRow)((DataRowView)storedBindingSource.Current).Row).Count)
                return true;
            else
            {
                MessageBox.Show("Недостаточно материалла на складе", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var connection = outMaterialTableAdapter.Connection;
            this.storedTableAdapter.Connection = connection;
            connection.Open();
            using (SqlTransaction transaction = connection.BeginTransaction())
            {
                this.outMaterialTableAdapter.Transaction=transaction;
                this.storedTableAdapter.Transaction= transaction;
                this.outMaterialTableAdapter.Update((DataSetEMC1)sharedBindingSource.DataSource);
                this.storedTableAdapter.Update((DataSetEMC1)sharedBindingSource.DataSource);
                transaction.Commit();
            }
            connection.Close();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            foreach (var selectedRow in outMateriasDataGridView.SelectedRows)
            {
                var outMaterialTableRow = (DataSetEMC1.OutMaterialRow)((DataRowView)((DataGridViewRow)selectedRow).DataBoundItem).Row;
                ((DataSetEMC1)sharedBindingSource.DataSource).Stored
                    .Single(sm => sm.StorageId == outMaterialTableRow.StorageId && sm.MaterialId == outMaterialTableRow.MaterialId)
                    .Count += outMaterialTableRow.Count;
                outMaterialTableRow.Delete();
            }
        }

        private void MatOut_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (((DataSetEMC1)sharedBindingSource.DataSource).HasChanges())
                if (MessageBox.Show("Есть несохранённые изменения! Отменить их?", "Внимание!", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
                else
                {
                    ((DataSetEMC1)sharedBindingSource.DataSource).RejectChanges();
                }
        }
    }
}
