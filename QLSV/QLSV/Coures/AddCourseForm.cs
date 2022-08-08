using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV.Coures
{
    public partial class AddCourseForm : Form
    {
        public AddCourseForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddCourseForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddCourse_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxIDCourse.Text);
                string nameCourse = textBoxNameCourse.Text;
                int hourse = (int)numericUpDownHours.Value;
                string description = textBoxDescription.Text;
                int se = Convert.ToInt32(comboBox.Text); ;

                Course course = new Course();

                if (nameCourse.Trim() == "")
                {
                    MessageBox.Show("Add a Course Name", "Add Course ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (course.checkCourseName(nameCourse))
                {
                    if (course.insertCourse(id, nameCourse, hourse, description, se))
                    {
                        MessageBox.Show("New Course Insert", "Add Course ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Course Not Insert", "Add Course ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("This Course Name Already Exists", "Add Course ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch
            {
                MessageBox.Show("ID is exited", "Add Course ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelHours_Click(object sender, EventArgs e)
        {

        }

        private void labelDescription_Click(object sender, EventArgs e)
        {

        }

        private void labelNameCourse_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDownHours_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBoxIDCourse_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNameCourse_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
