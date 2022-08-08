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
    public partial class EditCourseForm : Form
    {
        public EditCourseForm()
        {
            InitializeComponent();
        }
        Course course = new Course();
        private void EditCourseForm_Load(object sender, EventArgs e)
        {
            comboBoxCourse.DataSource = course.getAllCourse();
            comboBoxCourse.DisplayMember = "Name_Course";
            comboBoxCourse.ValueMember = "ID";

            comboBoxCourse.SelectedItem = null;

        }

        public void fillCombo(int index)
        {
            comboBoxCourse.DataSource = course.getAllCourse();
            comboBoxCourse.DisplayMember = "Name_Course";
            comboBoxCourse.ValueMember = "ID";

            comboBoxCourse.SelectedIndex = index;
        }




        private void comboBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(comboBoxCourse.SelectedValue);
                DataTable table = new DataTable();
                table = course.getCoursebyID(id);
                textBoxNameCourse.Text = table.Rows[0][1].ToString();
                numericUpDownHours.Value = int.Parse(table.Rows[0][2].ToString());
                textBoxDescription.Text = table.Rows[0][3].ToString();
            }
            catch
            {
               
            }
            
        }

        private void buttonEditCourse_Click(object sender, EventArgs e)
        {
            try
            {
                
                int id = (int)comboBoxCourse.SelectedValue;
                string name = textBoxNameCourse.Text;
                int hrs = (int)numericUpDownHours.Value;
                string descr = textBoxDescription.Text;
                int se = Convert.ToInt32(comboBox.Text);
                if (name.Trim() != "")
                {
                    if (!course.checkCourseName(name, id))
                    {
                        MessageBox.Show("This Course Name Already Exists", "Edit Course ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    if (course.updateCours(id, name, hrs, descr,se))
                    {
                        MessageBox.Show("Course Update", "Edit Course ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fillCombo(comboBoxCourse.SelectedIndex);
                    }
                    else
                    {
                        MessageBox.Show("Course Not Update", "Edit Course ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("Enter The Course Name", "Edit Course ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                };
            }
            catch
            {
                MessageBox.Show("No Course Selected", "Edit Course ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };


           
            


        }

        private void EditCourseForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
