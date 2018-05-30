using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using EMC1.DataSetEMC1TableAdapters;

namespace EMC1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            SetScreen();
            new StoredTableAdapter().Fill(this.dataSetEMC1.Stored);
            new OutMaterialTableAdapter().Fill(this.dataSetEMC1.OutMaterial);
            new StorageTableAdapter().Fill(this.dataSetEMC1.Storage);
            new JobTableAdapter().Fill(this.dataSetEMC1.Job);
            new UserTableAdapter().Fill(dataSetEMC1.User);
            new EmployeTableAdapter().Fill(dataSetEMC1.Employee);
            new MaterialTableAdapter().Fill(dataSetEMC1.Material);
            new UnitTableAdapter().Fill(dataSetEMC1.Unit);
            new ContrTableAdapter().Fill(dataSetEMC1.Contr);
            new JobTypeTableAdapter().Fill(dataSetEMC1.JobType);
            label4.Text = "Здравствуйте сегодня  " + DateTime.Now.ToShortDateString();
        }

        private void SetScreen()
        {
            switch (User.role)
            {
                case 1://
                    this.but_edit_spr.Visible = false;
                    this.but_give_job.Visible = false;
                    break;
                case 2:
                    this.but_in_mat.Visible = false;
                    this.but_out_mat.Visible = false;
                    break;
                case 3:
                    this.but_out_mat.Visible = false;
                    this.but_give_job.Visible = false;
                    break;
            }
        }

        private void btSPrClick(object sender, EventArgs e)
        {
            edit_spr edit_spr = new edit_spr(dataSetEMC1);
            edit_spr.ShowDialog();
            this.storageTableAdapter.Fill(this.dataSetEMC1.Storage);
        }

        private void btInMatClick(object sender, EventArgs e)
        {
            MatIn matin = new MatIn(this.dataSetEMC1);
            matin.ShowDialog();
            this.storageTableAdapter.Fill(this.dataSetEMC1.Storage);
        }

        private void btGiveJobClick(object sender, EventArgs e)
        {
            GiveJob givejob = new GiveJob(dataSetEMC1);
            givejob.ShowDialog();
        }

        private void but_out_mat_Click(object sender, EventArgs e)
        {
            MatOut mathout = new MatOut(this.dataSetEMC1);
            mathout.ShowDialog();
            this.storageTableAdapter.Fill(this.dataSetEMC1.Storage);
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            REP_NARYAD rn = new REP_NARYAD();
            rn.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutbox = new AboutBox1();
            aboutbox.ShowDialog();

        }
    }
}
