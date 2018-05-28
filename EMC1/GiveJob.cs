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
        public GiveJob()
        {
            InitializeComponent();
        }

        private void GiveJob_Load(object sender, EventArgs e)
        {
            this.unitTableAdapter1.Fill(this.dataSetEMC1.Unit);
            this.employeTableAdapter.Fill(this.dataSetEMC1.Employee);
            this.jobTypeTableAdapter.Fill(this.dataSetEMC1.JobType);
            this.materialTableAdapter.Fill(this.dataSetEMC1.Material);
            this.cmbMat.SelectedIndex = -1;
            this.cmbJobs.SelectedIndex = -1;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (CheckVal())
            {
                if (SaveData())
                    this.Close();
            }
        }

        private bool SaveData()
        {
            DataSetEMC1.JobRow NewRow= this.dataSetEMC1.Job.NewJobRow();
            NewRow["id_jobs"] = (int)cmbJobs.SelectedValue;
            NewRow["id_emp"] = (int)cmbEmpl.SelectedValue;
            NewRow["date"] = dtp.Value;
            NewRow["adm_emp"] = 0;
            NewRow["id_mat"] = (int)cmbMat.SelectedValue;
            NewRow["status"] = 1;
            NewRow["date_adm"] = DateTime.Now;

            dataSetEMC1.Job.AddJobRow(NewRow);
            try
            {
                this.jobTableAdapter1.Update(dataSetEMC1.Job);
                MessageBox.Show("Данные сохранены", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось сохранить данные", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        private bool CheckVal()
        {
            if (cmbJobs.SelectedIndex == -1)
                return false;
            if (cmbMat.SelectedIndex == -1)
                return false;
            if (cmbEmpl.SelectedIndex == -1)
                return false;

            if (!ChecMatOnStorage())
            {
                MessageBox.Show("Данный материал отсутсвует на складах", "Информация",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                return false;
            }
                


            return true;
        }

        private bool ChecMatOnStorage()
        {
            bool result = true;
            decimal count = 0;
            using(SqlConnection connection = new SqlConnection(User.connectionStr))
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "select sum(count) from storage_nal where id_mat = " + cmbMat.SelectedValue.ToString();
                command.Connection = connection;
                try
                {
                    connection.Open();
                    count = (decimal)command.ExecuteScalar();
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

           

            return result;
        }

        private string GetMatByJobs(object id)
        {
            
            string fillter = "";
            using (SqlConnection connection = new SqlConnection())
            {
                DataTable table = new DataTable();
                SqlDataAdapter adapter;
                SqlCommand command = new SqlCommand();
                command.CommandText = "select id_mat from jobs where id_jobs = " + id.ToString() + " group by id_mat";
                connection.ConnectionString = User.connectionStr;
                connection.Open();
                adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.SelectCommand.Connection = connection;
                try
                {
                    adapter.Fill(table);
                    foreach (DataRow rw in table.Rows)
                    {
                        fillter += "," + rw["id_mat"];
                    }
                    fillter = "id_mat in (" + fillter.Substring(1) + ")";
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка базы данных");
                }
                finally
                {
                    command.Dispose();
                    adapter.Dispose();
                }
            }

            return fillter;
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.employeTableAdapter.Fill(this.dataSetEMC1.Employee);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void cmbJobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbJobs.SelectedIndex == -1)
                return;

            DataRowView RowView = (DataRowView)cmbJobs.SelectedItem;
            DataView view = this.dataSetEMC1.Material.AsDataView();
            view.RowFilter = GetMatByJobs(RowView["id_jobs"]);
            cmbMat.DataSource = view;
        }
    }
}
