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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            

        }

        private void btEnter_Click(object sender, EventArgs e)
        {
            if(txbPWD.Text!=tbPWD2.Text)
            {
                MessageBox.Show("Ошибка при повторном вводе пароля!", "Внимание");
                return;
            }
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
