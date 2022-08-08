using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSV.HUMAN;
using System.Data.SqlClient;
using System.IO;
using QLSV.SCORE;

namespace QLSV.HUMAN
{
    public partial class Contacts_Full_List_Form : Form
    {
        public Contacts_Full_List_Form()
        {
            InitializeComponent();
        }
        public void getImageAndUsername()
        {
            MY_DB mydb = new MY_DB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM hr WHERE Id = @uid", mydb.getConnection);
            command.Parameters.Add("@uid", SqlDbType.Int).Value = Globals.GlobalUserId; // lấy id de up thong tin
            adapter.SelectCommand = command;

            adapter.Fill(table);

            if ((table.Rows.Count > 0))
            {
                byte[] pic = (byte[])table.Rows[0]["fig"];
                MemoryStream picture = new MemoryStream(pic);
                pictureBox_avt.Image = Image.FromStream(picture);

                lb_userName.Text = "Welcome back (" + table.Rows[0]["uname"].ToString().Trim() + ")";
            }
        }

      

    

      

  

        private void Contacts_Full_List_Form_Load(object sender, EventArgs e)
        {
            fillCombo();
            getImageAndUsername();
        }

    

      

        
       
        private void fillCombo()
        {
            GROUP group = new GROUP();
            comboBoxG1.DataSource = group.getGroups(Globals.GlobalUserId);
            comboBoxG1.DisplayMember = "name";
            comboBoxG1.ValueMember = "id";

            comboBoxG2.DataSource = group.getGroups(Globals.GlobalUserId);
            comboBoxG2.DisplayMember = "name";
            comboBoxG2.ValueMember = "id";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            addContactForm addCF = new addContactForm();
            addCF.Show();
        }

        private void buttonRemoveGroup_Click_1(object sender, EventArgs e)
        {
            try
            {
                int groupID = (int)comboBoxG2.SelectedValue;
                GROUP group = new GROUP();
                if (MessageBox.Show("Are You Sure You Want To Remove This Group", "Delete Group", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (group.deleteGroup(groupID))
                    {
                        MessageBox.Show("Group Deleted", " Remove Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fillCombo();
                    }
                    else
                    {
                        MessageBox.Show("Group not Deleted", "Remove Group", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Enter A Valid Numeric ID", "Remove Group", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show(ex.Message, "Remove Group", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonEditGroup_Click_1(object sender, EventArgs e)
        {
            GROUP group = new GROUP();
            try
            {
                // update the selected group
                string name = textBoxEditGroup.Text;
                int groupid = (int)comboBoxG1.SelectedValue;
                int userid = Globals.GlobalUserId;

                if (name.Trim() != "")
                {
                    // check if the course name already exists and it's not the current course using the id
                    if (group.groupExist(name, "edit", userid, groupid) == false)
                    {
                        MessageBox.Show("This Group Name Already Exists", "Edit Group ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (group.updateGroup(groupid, name))
                        {
                            MessageBox.Show("Group Updated", "Edit Group ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            fillCombo();
                        }
                        else
                        {
                            MessageBox.Show("Group Not Updated", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Enter The Group Name", "Edit Group ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("No Course Selected", "Edit Course ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRemoveContact_Click_1(object sender, EventArgs e)
        {
            try
            {
                int contactID = Convert.ToInt32(textBoxContactId.Text);
                CONTACT contact = new CONTACT();
                if (MessageBox.Show("Are You Sure You Want To Remove This Contact", "Delete Contact", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (contact.deleteContact(contactID))
                    {
                        MessageBox.Show("Contact Deleted", " Remove Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Contact not Deleted", "Remove Contact", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Enter A Valid Numeric ID", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonEditContact_Click_1(object sender, EventArgs e)
        {
            Edit_Contact_Form editCF = new Edit_Contact_Form();
            editCF.Show();
        }

        private void buttonSelectContact_Click_1(object sender, EventArgs e)
        {
            Select_Contact_Form SelectContactF = new Select_Contact_Form();
            SelectContactF.ShowDialog();
        }

        private void buttonShowFullList_Click_1(object sender, EventArgs e)
        {
            Contacts_Full ShowFullF = new Contacts_Full();
            ShowFullF.Show(); 
            Score score = new Score();
            score.deleteScoreTam();
        }

        private void buttonAddGroup_Click_1(object sender, EventArgs e)
        {
            if (textBoxGId.Text.Trim() == "" || textBoxGName.Text.Trim() == "")
            {
                MessageBox.Show("Empty Fields", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            GROUP group = new GROUP();
            int id = Convert.ToInt32(textBoxGId.Text);
            string fname = textBoxGName.Text;
            int userid = Globals.GlobalUserId;

            if (group.checkID(Convert.ToInt32(textBoxGId.Text)))
            {
                if (group.groupExist(fname, "add", userid))
                {
                    if (group.insertGroup(id, fname, userid))
                    {
                        MessageBox.Show("New Group Added", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fillCombo();
                    }
                    else
                    {
                        MessageBox.Show("Error", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("This Group Already Exists, Try Another One", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("This ID Already Exists, Try Another One", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
