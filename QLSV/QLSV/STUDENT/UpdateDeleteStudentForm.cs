using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSV.Coures;

namespace QLSV
{
    public partial class UpdateDeleteStudentForm : Form
    {
        public UpdateDeleteStudentForm()
        {
            InitializeComponent();
        }
        STUDENT student = new STUDENT();
        private void TextBoxID_TextChanged(object sender, EventArgs e)
        {
            
        }
        Course course = new Course();
        private void buttonFind_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TextBoxID.Text);
            SqlCommand command = new SqlCommand("SELECT id, fname, lname, bdate, gender, phone, address, picture FROM std2 WHERE Id = " + id);
            DataTable table = student.getStudents(command);
            if (table.Rows.Count > 0)
            {
                TextBoxFname.Text = table.Rows[0]["fname"].ToString();
                TextBoxLname.Text = table.Rows[0]["lname"].ToString();
                DateTimePicker1.Value = (DateTime)table.Rows[0]["bdate"];


                // gender
                if (table.Rows[0]["gender"].ToString() == "Male")
                {
                    RadioButtonMale.Checked = true;
                }
                else
                {
                    RadioButtonFemale.Checked = true;
                }

                TextBoxPhone.Text = table.Rows[0]["phone"].ToString();
                TextBoxAddress.Text = table.Rows[0]["address"].ToString();

                byte[] pic = (byte[])table.Rows[0]["picture"];
                MemoryStream picture = new MemoryStream(pic);
                PictureBoxStudentImage.Image = Image.FromStream(picture);
            }
            else
            {
                MessageBox.Show("not found", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public void fill()
        {
          

        }














        private void TextBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        bool verif()
        {
            if ((TextBoxFname.Text.Trim() == "")
                || (TextBoxLname.Text.Trim() == "")
                || (TextBoxAddress.Text.Trim() == "")
                || (TextBoxPhone.Text.Trim() == "")
                || (PictureBoxStudentImage.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                PictureBoxStudentImage.Image = Image.FromFile(opf.FileName);
            }
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int studentID = Convert.ToInt32(TextBoxID.Text);
                if ((MessageBox.Show("Are You Sure You to Delete This Student", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)) ;
                {
                    if (student.deleteStudents(studentID))
                    {
                        MessageBox.Show("Student Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TextBoxID.Text = "";
                        TextBoxFname.Text = "";
                        TextBoxLname.Text = "";
                        TextBoxAddress.Text = "";
                        TextBoxPhone.Text = "";
                        DateTimePicker1.Value = DateTime.Now;
                        PictureBoxStudentImage.Image = null;
                    }
                    else
                    {
                        MessageBox.Show("Student Not Deleted", "delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please Enter Avalid ID", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonEditStudent_Click(object sender, EventArgs e)
        {
            int id;
            string fname = TextBoxFname.Text;
            string lname = TextBoxLname.Text;
            DateTime bdate = DateTimePicker1.Value;
            string phone = TextBoxPhone.Text;
            string adrs = TextBoxAddress.Text;
            string gender = "Male";
            if (RadioButtonFemale.Checked)
            {
                gender = "Female";
            }
            MemoryStream pic = new MemoryStream();
            int born_year = DateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;
            if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
            {
                MessageBox.Show("The Student Age Must Be Between 10 and 100 year", "Birth Date Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (verif())
            {
                try
                {
                    id = Convert.ToInt32(TextBoxID.Text);
                    PictureBoxStudentImage.Image.Save(pic, PictureBoxStudentImage.Image.RawFormat);
                    if (student.updateStudents(id, fname, lname, bdate,gender, phone, adrs,pic))
                    {
                        MessageBox.Show("Student Information Updated", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void UpdateDeleteStudentForm_Load(object sender, EventArgs e)
        {

        }

        private void RadioButtonFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RadioButtonMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void buttonAddCourse_Click(object sender, EventArgs e)
        {
            AddCourse course = new AddCourse();
            //course.Show(this);
            luu.ID = TextBoxID.Text;
            AddCourse AC = new AddCourse();
            AC.Show();

            Hide();
        }


        public class luu
        {
            static public string ID;
        }
    }
}
