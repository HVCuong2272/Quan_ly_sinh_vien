using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            Log_In_form flogin = new Log_In_form();
            if (flogin.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new progressBar());
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
