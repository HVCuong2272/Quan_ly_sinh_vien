using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSV.ACCOUNT;

namespace QLSV.ACCOUNT
{
    public partial class AddInfoUser : Form
    {
        public AddInfoUser()
        {
            InitializeComponent();
        }
       
        private void AddInfoUser_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = account.getInfo();
        }

        private void buttonCannal_Click(object sender, EventArgs e)
        {
            Close();
        }
        Account account = new Account();
        private void buttonADD_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxID.Text);
            string fname = textBoxFname.Text;
            string lname = textBoxLname.Text;
            int phone = Convert.ToInt32(textBoxPhone.Text);
            string adrs = textBoxAddress.Text;
            string gender = "Male";

            if (RadioButtonFemale.Checked)
            {
                gender = "Female";
            }
            string nationality = textBoxNationality.Text;

            if (account.insertInfor(id, fname, lname, gender, phone, adrs, nationality))
            {
                MessageBox.Show("Xác nhận thêm thông tin ", "Add Infor ", MessageBoxButtons.OK, MessageBoxIcon.Information); dataGridView1.DataSource = account.getInfo();


            }
            else
            {
                MessageBox.Show("Error", "Add Infor ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void textBoxGender_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
           

            textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxFname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString(); textBoxLname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString(); 
       
          
            textBoxPhone.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBoxAddress.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[3].Value.ToString() == "Female")
            {
                RadioButtonFemale.Checked = true;

            }
            else
            {
                RadioButtonMale.Checked = true;
            }

            textBoxNationality.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();


        }
    }
}
