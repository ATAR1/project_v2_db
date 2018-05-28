using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMC1
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            login Login = new login();
            Login.ShowDialog();
            if (Login.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                if (User.role != 4)
                    Application.Run(new Form1());
                else
                    Application.Run(new admin());
            }
                
            

                
        }
    }
}
