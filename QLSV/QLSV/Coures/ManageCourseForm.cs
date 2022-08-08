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
    public partial class ManageCourseForm : Form
    {
        public ManageCourseForm()
        {
            InitializeComponent();
        }
        Course course = new Course();
        int pos;
        private void ManageCourseForm_Load(object sender, EventArgs e)
        {
            reloadListBoxData();
        }
        public void reloadListBoxData()
        {
            listBoxCourse.DataSource = course.getAllCourse();
            listBoxCourse.DisplayMember = "Name_Course";
            listBoxCourse.ValueMember = "ID";
            listBoxCourse.SelectedItem = null;

            labelTotal.Text = "Total Course : " + course.TotalCourse();


        }

        void showData(int index)
        {
            DataRow dr = course.getAllCourse().Rows[index];

            listBoxCourse.SelectedIndex = index;
            textBoxID.Text = dr.ItemArray[0].ToString();
            textBoxNameCourse.Text = dr.ItemArray[1].ToString();
            numericUpDown1.Value = int.Parse(dr.ItemArray[2].ToString());
            textBoxDescription.Text = dr.ItemArray[3].ToString();
            comboBox.Text = dr.ItemArray[4].ToString();
          


        }













        private void numericUpDownHours_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                int courseID = Convert.ToInt32(textBoxID.Text);
                Course course = new Course();
                if (MessageBox.Show("Are You Sure You Want To Remove This Course", "Delete Course", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
                {
                    if (course.deleteCourse(courseID))
                    {
                        MessageBox.Show("Course Deleted", " Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reloadListBoxData();


                        textBoxID.Text = "";
                        numericUpDown1.Value = 10;
                        textBoxNameCourse.Text = "";
                        textBoxDescription.Text = "";
                    }
                    //else
                    //{
                    //    MessageBox.Show("Course not Deleted", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //}
                }
                else
                {
                    MessageBox.Show("Course not Deleted", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                //else
                //{
                //    MessageBox.Show("Course not Deleted", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //}

            }
            catch
            {
                MessageBox.Show("Enter A valid Number ID ", " Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            pos = 0;
        }

        private void buttonEditCourse_Click(object sender, EventArgs e)
        {
            //try
            //{
                int id = Convert.ToInt32(textBoxID.Text);
                string name = textBoxNameCourse.Text;
                int hrs = (int)numericUpDown1.Value;
                string descr = textBoxDescription.Text;
                int se = Convert.ToInt32(comboBox.Text);


                if (name.Trim() != "")
                {
                    //if (!course.checkCourseName(name, id))
                    //{
                    //    MessageBox.Show("This Course Name Already Exists", "Edit Course ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    //}
                    //else
                    if (course.updateCours(id, name, hrs, descr,se))
                    {
                        MessageBox.Show("Course Update", "Edit Course ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reloadListBoxData();
                    }
                    else
                    {
                        MessageBox.Show("Course Not Update", "Edit Course ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("Enter The Course Name", "Edit Course ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            //}
            //catch
            //{
            //    MessageBox.Show("No Course Selected", "Edit Course ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            pos = 0;
        }



        //private void listBoxCourse_Click(object sender, EventArgs e)
        //{
        //    pos = listBoxCourse.SelectedIndex;
        //    showData(pos);
        //}

        private void listBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                pos = listBoxCourse.SelectedIndex;
                showData(pos);
            }
            catch
            {

            }

        }

        private void buttonLL_Click(object sender, EventArgs e)
        {
            pos = 0;
            showData(0);
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            if(pos<(course.getAllCourse().Rows.Count-1))
            {
                pos = pos + 1;
                showData(pos);
            }
           
        }

        private void buttonL_Click(object sender, EventArgs e)
        {
            if(pos>0)
            {
                pos = pos - 1;
                showData(pos);
            }
            
        }

        private void buttonRR_Click(object sender, EventArgs e)
        {
            pos = course.getAllCourse().Rows.Count - 1;
            showData(pos);
        }

        private void buttonADDCourse_Click(object sender, EventArgs e)
        {

            try
            {
                int id = Convert.ToInt32(textBoxID.Text);
                string nameCourse = textBoxNameCourse.Text;
                int hourse = (int)numericUpDown1.Value;
                string description = textBoxDescription.Text;
                int se = Convert.ToInt32(comboBox.Text);
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
                        reloadListBoxData();


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
    }
}
