using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class progressBar : Form
    {
        public progressBar()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);

        }

        private void Process_Click(object sender, EventArgs e)
        {
            MainForm01 abc = new MainForm01();
            abc.Show();
            this.Hide();

        }

        private void progressBar1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
