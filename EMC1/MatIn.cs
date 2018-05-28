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
        public MatIn()
        {
            InitializeComponent();
        }

        private void MatIn_Load(object sender, EventArgs e)
        {
            this.eD_IZMTableAdapter1.Fill(this.dataSetEMC1.ED_IZM);
            this.kontrTableAdapter.Fill(this.dataSetEMC1.kontr);
            this.storageTableAdapter.Fill(this.dataSetEMC1.storage);
            this.materialTableAdapter.Fill(this.dataSetEMC1.material);
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
            decimal count = decimal.Parse(txbCol.Text);
            decimal count_old = 0;

            bool result = false;

            using(SqlConnection connection = new SqlConnection(User.connectionStr))
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "select count from storage_nal where id_storage = " 
                    + cmbStorage.SelectedValue.ToString() + " and id_mat = " + cmbMat.SelectedValue.ToString();
                connection.Open();
                try
                {
                    count_old = decimal.Parse(command.ExecuteScalar().ToString());
                }
                catch (Exception)
                {
                    count_old = 0;
                }
                finally
                {
                    command.Dispose();
                }
            }

            if(count_old == 0)
            {
                DataSetEMC1.storage_nalRow NewRow = dataSetEMC1.storage_nal.Newstorage_nalRow();
                NewRow.count = decimal.Parse(txbCol.Text);
                NewRow.id_storage = (int)cmbStorage.SelectedValue;
                NewRow.id_mat = (int)cmbMat.SelectedValue;
                dataSetEMC1.storage_nal.Rows.Add(NewRow);
                try
                {
                    this.storage_nalTableAdapter1.Update(this.dataSetEMC1.storage_nal);
                    
                    result = true;
                }
                catch (Exception)
                {
                    result = false;
                }
            }
            else
            {
                count += count_old;
                using (SqlConnection connection = new SqlConnection(User.connectionStr))
                {
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = "update storage_nal set count = " + count + " where id_storage = "
                        + cmbStorage.SelectedValue.ToString() + " and id_mat = " + cmbMat.SelectedValue.ToString();
                    connection.Open();
                    try
                    {
                        command.ExecuteNonQuery();
                        result = true;
                    }
                    catch (Exception)
                    {
                        result = false;
                    }
                    finally
                    {
                        command.Dispose();
                    }
                }
            }

            if(result)
                MessageBox.Show("Данные сохранены", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBox.Show("Не удалось сохранить данные", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.dataSetEMC1.storage_nal.Clear();
            }
                

            return result;
           


        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
