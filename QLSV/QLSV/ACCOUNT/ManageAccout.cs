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

namespace QLSV.ACCOUT
{
    public partial class ManageAccout : Form
    {
        public ManageAccout()
        {
            InitializeComponent();
        }
        Account account = new Account();
        private void ManageAccout_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDBDataSet.Login' table. You can move, or remove it, as needed.
            //this.loginTableAdapter.Fill(this.myDBDataSet.Login);
            dataGridView.DataSource = account.getAccount();
            comboBox1.Items.Add("admin");
            comboBox1.Items.Add("User");
            comboBox1.Items.Add("Staff");
            comboBox1.Items.Add("");

        }

        private void labelPass_Click(object sender, EventArgs e)
        {

        }

        private void labelUsername_Click(object sender, EventArgs e)
        {

        }

        private void labelID_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxID.Text);
                string username = textBoxUserName.Text;
                int pass = Convert.ToInt32(textBoxPass.Text);

                if (username.Trim() == "")
                {
                    MessageBox.Show("Add a User  Name", "Add User  ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (account.checkAccount(id, username, pass))
                {
                    if (account.insertAccount(id, username, pass))
                    {
                        MessageBox.Show("New User Insert", "Add User ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dataGridView.DataSource = account.getAccount();

                    }
                    else
                    {
                        MessageBox.Show("User Not Insert", "Add User ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("This User Name Already Exists", "Add User ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch
            {
                MessageBox.Show("something is wrong", "Add User ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void labelReset_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = account.getAccount();

        }

        private void buttonDEL_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = Convert.ToInt32(textBoxID.Text);
                if (MessageBox.Show("Are You Sure You to Delete This Account", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (account.deleteAccount(ID))
                    {
                        MessageBox.Show("Account Deleted", "Delete Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxID.Text = "";
                        textBoxUserName.Text = "";
                        textBoxPass.Text = ""; dataGridView.DataSource = account.getAccount();

                    }
                    //else
                    //{
                    //    MessageBox.Show("Student Not Deleted", "delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}
                }
                else
                {
                    MessageBox.Show("Account Not Deleted", "delete Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch
            {
                MessageBox.Show("Please Enter Avalid ID", "Delete Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView_Click(object sender, EventArgs e)
        {
            textBoxID.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
            textBoxUserName.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            textBoxPass.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            comboBox1.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
            
        }

        private void buttonUPDATE_Click(object sender, EventArgs e)
        {

            try
            {
                int Id = Convert.ToInt32(textBoxID.Text); ;
                string username = textBoxUserName.Text;
                string password = textBoxPass.Text;
                string Power = comboBox1.Text;

                if (account.updateAccount(Id, username, password, Power))
                {
                    MessageBox.Show("Account Information Updated", "Edit Account", MessageBoxButtons.OK, MessageBoxIcon.Information); dataGridView.DataSource = account.getAccount();
                }
                else
                {
                    MessageBox.Show("Error", "Edit Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Edit Account", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
}

        private void button1_Click(object sender, EventArgs e)
        {
            AddIDUser addIDUser = new AddIDUser();
            addIDUser.Show(this);
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonAddInfo_Click(object sender, EventArgs e)
        {
            AddInfoUser addInfo = new AddInfoUser();
            addInfo.Show(this);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


