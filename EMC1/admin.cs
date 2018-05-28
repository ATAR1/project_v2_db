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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void admin_Load(object sender, EventArgs e)
        {
            this.user_roleTableAdapter.Fill(this.dataSetEMC1.user_role);
            this.usersTableAdapter.Fill(this.dataSetEMC1.users);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedTab.Name)
            {
                case "user":
                    this.usersTableAdapter.Update(this.dataSetEMC1.users);
                    break;
                case "role":
                    this.user_roleTableAdapter.Update(this.dataSetEMC1.user_role);
                    break;

            }//switch
        }

    }
}
