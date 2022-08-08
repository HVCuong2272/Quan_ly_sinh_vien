using System;
using QLSV.SCORE;
using QLSV.Coures;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLSV.SCORE
{
    public partial class AddScoreForm : Form
    {
        public AddScoreForm()
        {
            InitializeComponent();
        }
        Score score = new Score();
        Course course = new Course();
        STUDENT student = new STUDENT();


        private void labelIDCourse_Click(object sender, EventArgs e)
        {

        }

        private void AddScoreForm_Load(object sender, EventArgs e)
        {
            comboBoxCourse.DataSource = course.getAllCourse();
            comboBoxCourse.DisplayMember = "Name_Course";
            comboBoxCourse.ValueMember = "ID";

            SqlCommand command = new SqlCommand("SELECT id,fname,lname FROM std2");
            dataGridView1.DataSource = student.getStudents(command);



        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBoxIDStudent.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void buttonAddScore_Click(object sender, EventArgs e)
        {
            try
            {
                int student_Id = Convert.ToInt32(textBoxIDStudent.Text);
                int course_Id = Convert.ToInt32(comboBoxCourse.SelectedValue);
                float student_score = Convert.ToInt32(textBoxScore.Text);
                string description = textBoxDescription.Text;

                if (!score.studentScoreExists(student_Id, course_Id))
                {
                    if (score.inserScore(student_Id, course_Id, student_score, description))
                    {
                        MessageBox.Show("Student Score Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Student  Score not Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("The Score For This Course Are Already Set", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
        }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

}
        
    }
}
