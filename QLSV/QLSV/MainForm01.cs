using QLSV.Coures;
using QLSV.SCORE;
using QLSV.RESULT;
using QLSV.ACCOUT;
using QLSV.HUMAN;
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
    public partial class MainForm01 : Form
    {
        public MainForm01()
        {
            InitializeComponent();
        }

        private void MainForm01_Load(object sender, EventArgs e)
        {

        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudentForm addStdF = new AddStudentForm();
            addStdF.Show(this);
        }

        private void studentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studentsListForm stLF = new studentsListForm();
            stLF.Show(this);
        }

        private void staticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticsForm stcF = new StaticsForm();
            stcF.Show(this);
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintStdForm prStdF = new PrintStdForm();
            prStdF.Show(this);
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageStudentForm ManageStdF = new ManageStudentForm();
            ManageStdF.Show();

        }

        private void editRemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDeleteStudentForm updateStdF = new UpdateDeleteStudentForm();
            updateStdF.Show();
        }

        private void AddCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCourseForm addCourse = new AddCourseForm();
            addCourse.Show(this);
        }

        private void RemoveCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveCourseForm RmCourse = new RemoveCourseForm();
            RmCourse.Show();
        }

        private void EditCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCourseForm editCourse = new EditCourseForm();
            editCourse.Show(this);
        }

        private void ManageCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCourseForm manageCourse = new ManageCourseForm();
            manageCourse.Show(this);
        }

        private void PrintCourseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PrintCourseForm printCourse = new PrintCourseForm();
            printCourse.Show(this);
        }

        private void agvScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            avgScoreByCourseForm avgScore = new avgScoreByCourseForm();
            avgScore.Show(this);
        }

        private void addScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddScoreForm addScore = new AddScoreForm();
            addScore.Show(this);
        }

        private void removeScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveScoreForm rmScrF = new RemoveScoreForm();
            rmScrF.Show(this);
        }

        private void manageScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageScoreForm manageScore = new ManageScoreForm();
            manageScore.Show(this);
        }

        private void printToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PrintScoreForm printScore = new PrintScoreForm();
            printScore.Show(this);
        }

        private void addAccoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void addAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAccout addAccout = new AddAccout();
            addAccout.Show(this);
        }

        private void resultScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResultForm resultForm = new ResultForm();
            resultForm.Show(this);
        }

        private void staticResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticResult staticResult = new StaticResult();
            staticResult.Show(this);
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You to Exit This App", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            { 
                Application.Exit();
            } 
           
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Own own = new Own();
            own.Show(this);
        }

        private void showAccoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You must be logged in as an administrator to continue ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LoginAdmin loginAdmin = new LoginAdmin();
                loginAdmin.Show();
            }
        }

     

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
                Application.Exit();
           

        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LoginAdmin2 loginAdmin2 = new LoginAdmin2();
            loginAdmin2.Show(this);


            Score score = new Score();
            score.deleteScoreTam();
        }

        private void linkLabelHUMAN_Click(object sender, EventArgs e)
        {
            Contacts_Full_List_Form contacts_Full_List_Form = new Contacts_Full_List_Form();
            contacts_Full_List_Form.Show(this);
        }

        private void humanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contacts_Full_List_Form contacts_Full_List_Form = new Contacts_Full_List_Form();
            contacts_Full_List_Form.Show(this);
        }
    }
}
