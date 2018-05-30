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
            this.userRoleTableAdapter.Fill(this.dataSetEMC1.UserRole);
            //this.usersTableAdapter.Fill(this.dataSetEMC1.User);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedTab.Name)
            {
                case "user":
                    //this.usersTableAdapter.Update(this.dataSetEMC1.User);
                    break;
                case "role":
                    this.userRoleTableAdapter.Update(this.dataSetEMC1.UserRole);
                    break;

            }//switch
        }

    }
}
