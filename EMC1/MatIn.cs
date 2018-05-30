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
    public partial class MatIn : Form
    {
        public MatIn(DataSetEMC1 dataSet)
        {
            InitializeComponent();
            sharedDataSource.DataSource = dataSet;
        }
        

        private void btSave_Click(object sender, EventArgs e)
        {
            if (CheckValue())
            {
                if(SaveData())
                    this.Close();
            }
            else
                MessageBox.Show("Проверьте введенные данные", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool CheckValue()
        {
            if (cmbMat.SelectedIndex == -1)
                return false;
            if (cmbStorage.SelectedIndex == -1)
                return false;
            if (txbCol.Text.Trim().Length == 0)
                return false;

            int Col = -1;
            if (int.TryParse(txbCol.Text, out Col))
            {
                if (Col <= 0)
                    return false;
            }
            else
            {
                return false;
            }


            return true;
        }

        private bool SaveData()
        {
            var count = Int32.Parse(txbCol.Text);
            var dataSet = ((DataSetEMC1)this.sharedDataSource.DataSource);
            var newRow = (DataSetEMC1.InMaterialRow)dataSet.InMaterial.NewRow();
            newRow.ContractorId = ((DataSetEMC1.ContrRow)((DataRowView)this.contrBindingSource.Current).Row).Id;
            newRow.Date = DateTime.Now;
            newRow.Count = count;
            newRow.MaterialId = ((DataSetEMC1.MaterialRow)((DataRowView)this.materialBindingSource.Current).Row).Id;
            newRow.StoremanId = 1;
            newRow.StorageId = ((DataSetEMC1.StorageRow)((DataRowView)this.storageBindingSource.Current).Row).Id;
            dataSet.InMaterial.AddInMaterialRow(newRow);
            if (((DataSetEMC1.StorageRow)((DataRowView)this.storageBindingSource.Current).Row).GetStoredRows().Any(sr => sr.MaterialId == newRow.MaterialId))
            {
                ((DataSetEMC1.StorageRow)((DataRowView)this.storageBindingSource.Current).Row).GetStoredRows().Single(sr => sr.MaterialId == newRow.MaterialId)
                    .Count += count;
            }
            else
            {
                var newStoredRow = (DataSetEMC1.StoredRow)dataSet.Stored.NewRow();
                newStoredRow.StorageId = newRow.StorageId;
                newStoredRow.MaterialId = newRow.MaterialId;
                newStoredRow.Count = count;
                dataSet.Stored.AddStoredRow(newStoredRow);
            }
            var storedAdapter = new DataSetEMC1TableAdapters.StoredTableAdapter();
            var inMaterialAdapter = new DataSetEMC1TableAdapters.InMaterialTableAdapter();
            var connection = storedAdapter.Connection;
            inMaterialAdapter.Connection = connection;
            connection.Open();
            using (SqlTransaction transaction = connection.BeginTransaction())
            {
                storedAdapter.Transaction = transaction;
                inMaterialAdapter.Transaction = transaction;
                storedAdapter.Update(dataSet);
                inMaterialAdapter.Update(dataSet);
                transaction.Commit();
            }
            MessageBox.Show("Данные сохранены", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
