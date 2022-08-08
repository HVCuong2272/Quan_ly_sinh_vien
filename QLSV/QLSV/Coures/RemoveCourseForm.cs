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



namespace QLSV.Coures
{
    public partial class RemoveCourseForm : Form
    {
        public RemoveCourseForm()
        {
            InitializeComponent();
        }

        private void RemoveCourseForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {

                int courseID = Convert.ToInt32(textBoxCourseID.Text);
                Course course = new Course();
                if (MessageBox.Show("Are You Sure You Want To Remove This Course", "Delete Course", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
                {
                    if (course.deleteCourse(courseID))
                    {
                        MessageBox.Show("Course Deleted", " Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Course not Deleted", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

            }
            catch
            {
                MessageBox.Show("Enter A valid Number ID ", " Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }




           

        }
    }
}
