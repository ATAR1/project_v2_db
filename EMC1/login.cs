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

namespace EMC1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btEnter_Click(object sender, EventArgs e)
        {
            CheckAcces();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.No;
            this.Close();
        }


        private void CheckAcces()
        {
            if (String.IsNullOrWhiteSpace(txbLogin.Text))
                return;

            if (String.IsNullOrWhiteSpace(txbPWD.Text))
                return;

            using (SqlConnection connection = new SqlConnection())
            {
                int id_user = 0;
                
                

                //connection.ConnectionString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\DB\\emcDB.mdf;Integrated Security=True;Connect Timeout=30";


                connection.ConnectionString = Properties.Settings.Default.DB_EMC1ConnectionString;

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "select id from [User] where login = '" + txbLogin.Text + "' and pwd = " + txbPWD.Text;
                
                try
                {
                    connection.Open();
                    Int32.TryParse(command.ExecuteScalar().ToString(), out id_user);
                    command.CommandText = "select UserRoleId from [User] where id = " + id_user.ToString();
                    User.role = (int)command.ExecuteScalar();
                    User.connectionStr = connection.ConnectionString;
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нет доступа к системе");
                    this.DialogResult = System.Windows.Forms.DialogResult.No;
                    this.Close();
                }
                finally
                {
                    command.Dispose();
                }


            }
        }

    }
}
