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
using QLSV.HUMAN;

namespace QLSV.SCORE
{
    public partial class ManageScoreForm : Form
    {
        public ManageScoreForm()
        {
            InitializeComponent();
        }
        Score score = new Score();
        STUDENT student = new STUDENT();
        Course coures = new Course();
        string data = "score";

        private void labelSelectCourse_Click(object sender, EventArgs e)
        {

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    

        private void buttonRemoveScore_Click(object sender, EventArgs e)
        {
            try
            {
                int student_Id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                int course_Id = int.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());

                if (MessageBox.Show("Do You Want Delete This Score", "Delete Course", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
                {
                    if (score.deleteScore(student_Id, course_Id))
                    {
                        MessageBox.Show("Score Deleted", " Remove Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.DataSource = score.getStudentScore();
                    }
                    else
                    {
                        MessageBox.Show("Score not Deleted", "Remove Score", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Hãy nhập dử liệu  ", "Remove Score", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        
            
        }

        private void buttonAvgScore_Click(object sender, EventArgs e)
        {
            avgScoreByCourseForm avgScore = new avgScoreByCourseForm();
            avgScore.Show(this);
        }

        private void ManageScoreForm_Load(object sender, EventArgs e)
        {

            comboBoxCourse.DataSource = coures.getAllCourse();
            comboBoxCourse.DisplayMember = "Name_Course";
            comboBoxCourse.ValueMember = "Id";

            comboBoxCourse.Text = Contacts_Full.luu.ID;

            dataGridView1.DataSource = score.getStudentScore();
            




            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                int a = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());

                string b = dataGridView1.Rows[i].Cells[1].Value.ToString();
                string c = dataGridView1.Rows[i].Cells[2].Value.ToString();
                int d = int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                string k = dataGridView1.Rows[i].Cells[4].Value.ToString();

                float v;
                try 
                {
                     v = Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value.ToString());

                }
                catch
                {
                      v = 0; 
                }
                
                

                score.getStudentScore2(a, b, c, d, k, v);


            };
            if(comboBoxCourse.Text =="")
            {
                dataGridView1.DataSource = score.getStudentScore(); 
                dataGridView2.DataSource = score.deleteScoreTam();
            }
            else
            {
                dataGridView1.DataSource = score.getNameCourse(comboBoxCourse.Text);

            }



            //

            //if (comboBoxCourse.Text == "")
            //{
            //    dataGridView1.DataSource = score.getStudentScore();

            //}
            //else
            //{



            //}





        }

        private void buttonShowStd_Click(object sender, EventArgs e)
        {
            data = "std2";
            SqlCommand command = new SqlCommand("SELECT ID, fname, lname, bdate FROM std2");
            dataGridView1.DataSource = student.getStudents(command); dataGridView2.DataSource = score.deleteScoreTam();

        }

        private void buttonShowScore_Click(object sender, EventArgs e)
        {
            data = "score";
            dataGridView1.DataSource = score.getStudentScore(); dataGridView2.DataSource = score.deleteScoreTam();


        }
        public void getDataFromDatagridview()
        {
            if(data == "std2")
            {
                textBoxIDStudent.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            }
            else if (data=="score")
            {
                textBoxIDStudent.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                comboBoxCourse.SelectedValue = dataGridView1.CurrentRow.Cells[3].Value;

            }

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            getDataFromDatagridview();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox7.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            int Id = Convert.ToInt32(textBox7.Text);
            int IDstd = Convert.ToInt32(textBoxIDStudent.Text);
            float scorestd = Convert.ToInt32(textBoxScore.Text);
            if (score.updateScore(IDstd, Id,  scorestd ))
            {
                MessageBox.Show("Diểm Đã Cập Nhật", "Edit Score", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                dataGridView1.DataSource = score.getStudentScore();
            }
            else
            {
                MessageBox.Show("Error", "Edit Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
