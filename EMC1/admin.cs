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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetEMC1.Employee". При необходимости она может быть перемещена или удалена.
            this.employeTableAdapter.Fill(this.dataSetEMC1.Employee);
            this.userTableAdapter.FillAll(this.dataSetEMC1.User);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetEMC1.Role". При необходимости она может быть перемещена или удалена.
            this.roleTableAdapter.Fill(this.dataSetEMC1.Role);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetEMC1.UserRole". При необходимости она может быть перемещена или удалена.
            this.userRoleTableAdapter.Fill(this.dataSetEMC1.UserRole);

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userTableAdapter.Update(dataSetEMC1);
            userRoleTableAdapter.Update(dataSetEMC1.UserRole);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            foreach (var dgRow in dgUser.SelectedRows)
            {
                var userRow = ((DataSetEMC1.UserRow)((DataRowView)((DataGridViewRow)dgRow).DataBoundItem).Row);
                int userId = userRow.Id;
                userRow.Delete();                
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            var addUserForm = new AddUser();
            addUserForm.employeeBindingSource.DataSource = dataSetEMC1;
            if(addUserForm.ShowDialog()==DialogResult.OK)
            {
                var employeeId = (int)addUserForm.cbEmployee.SelectedValue;
                var login = addUserForm.txbLogin.Text;
                var pwd = addUserForm.txbPWD.Text;
                userTableAdapter.AddUser(login, pwd, employeeId);
                userTableAdapter.FillAll(dataSetEMC1.User);
            }
        }
    }
}
