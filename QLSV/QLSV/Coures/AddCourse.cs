using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSV.Coures;
namespace QLSV.Coures
{
    public partial class AddCourse : Form
    {
        public AddCourse()
        {
            InitializeComponent();
        }
        Course course = new Course();
        private void AddCourse_Load(object sender, EventArgs e)
        {
            string IDstd = TextBoxID.Text;


            dataGridView1.DataSource = course.getAvailable();



            TextBoxID.Text = UpdateDeleteStudentForm.luu.ID;


        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            AddCourseForm addCourseForm = new AddCourseForm();
            addCourseForm.Show(this);
        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Nhấn YES Để Lưu   ", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                MessageBox.Show("Đã Lưu  ", "Thàng Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lỗi   ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }













        
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBox_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
           
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonREMOVE_Click(object sender, EventArgs e)
        {

            try
            {
                int IDstd = Convert.ToInt32(TextBoxID.Text);
                int ID = Convert.ToInt32(textBox_id.Text);
                string Se = textBox_Semester.Text;

                if (course.insertAC(IDstd, ID))
                {
                    MessageBox.Show("Xác nhận Thêm  ", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {
                    MessageBox.Show("Error", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                if (string.IsNullOrEmpty(textBox_id.Text) || string.IsNullOrEmpty(textBox_name.Text))
                    return;




                ListViewItem item = new ListViewItem(textBox_id.Text);



                item.SubItems.Add(textBox_name.Text);
                listView2.Items.Add(item);
                textBox_id.Clear();
                textBox_name.Clear();
                textBox_id.Focus();
            }
            catch
            {
                MessageBox.Show("Hãy Nhập ID SV ", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


           
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int se = Convert.ToInt32(comboBox.Text);
            dataGridView1.DataSource = course.getSeemester(se);




        }

        private void labelSemester_Click(object sender, EventArgs e)
        {

        }
    }
}
