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
            this.storageTableAdapter.Fill(this.dataSetEMC1.storage);
            new OUT_MATERIALTableAdapter().Fill(this.dataSetEMC1.OUT_MATERIAL);
            new DataTable1TableAdapter().Fill(this.dataSetEMC1.DataTable1);
            new storageTableAdapter().Fill(this.dataSetEMC1.storage);
            new planjobTableAdapter().Fill(this.dataSetEMC1.planjob);
            new usersTableAdapter().Fill(dataSetEMC1.users);
            new employessTableAdapter().Fill(dataSetEMC1.employess);
            new materialTableAdapter().Fill(dataSetEMC1.material);
            new ED_IZMTableAdapter().Fill(dataSetEMC1.ED_IZM);
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
            edit_spr edit_spr = new edit_spr();
            edit_spr.ShowDialog();
            this.storageTableAdapter.Fill(this.dataSetEMC1.storage);
        }

        private void btInMatClick(object sender, EventArgs e)
        {
            MatIn matin = new MatIn();
            matin.ShowDialog();
            this.storageTableAdapter.Fill(this.dataSetEMC1.storage);
        }

        private void btGiveJobClick(object sender, EventArgs e)
        {
            GiveJob givejob = new GiveJob();
            givejob.ShowDialog();
        }

        private void but_out_mat_Click(object sender, EventArgs e)
        {
            MatOut mathout = new MatOut(this.dataSetEMC1);
            mathout.ShowDialog();
            this.storageTableAdapter.Fill(this.dataSetEMC1.storage);
        }
        

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow == null)
                return;
            DataRowView rw = (DataRowView)dataGridView2.CurrentRow.DataBoundItem;
            FillOstStorage((int)rw["id_storage"]);
        }

        private void FillOstStorage(int id)
        {
            //this.balanceTableAdapter.Fill(this.dataSetEMC1.Balance, id);  
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
