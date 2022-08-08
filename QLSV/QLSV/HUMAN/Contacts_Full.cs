using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSV.SCORE;
namespace QLSV.HUMAN
{
    public partial class Contacts_Full : Form
    {
        public Contacts_Full()
        {
            InitializeComponent();
        }

        private void labelShowAll_Click(object sender, EventArgs e)
        {
            Contacts_Full_Load(null, null);
        }

        private void Contacts_Full_Load(object sender, EventArgs e)
        {
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();

            dataGridView1.RowTemplate.Height = 80;

            int userid = Globals.GlobalUserId;
            CONTACT contact = new CONTACT();
            SqlCommand command = new SqlCommand("SELECT fname as 'First Name', lname as 'Last Name', mygroups.name as 'Group', phone, email, address, pic FROM mycontact INNER JOIN mygroups on mycontact.group_id = mygroups.id  WHERE mycontact.userid = @userid");
            command.Parameters.Add("@userid", SqlDbType.Int).Value = userid;
            dataGridView1.DataSource = contact.SelectContactList(command);

            picCol = (DataGridViewImageColumn)dataGridView1.Columns[6];

            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (IsOdd(i))
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                }
            }

            GROUP group = new GROUP();
            listBox1.DataSource = group.getGroups(Globals.GlobalUserId);
            listBox1.DisplayMember = "name";
            listBox1.ValueMember = "id";

            listBox1.SelectedItem = null;
            dataGridView1.ClearSelection();
        }
        public static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (IsOdd(i))
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                }
            }
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            try
            {
                CONTACT contact = new CONTACT();
                int groupid = (Int32)listBox1.SelectedValue;
                SqlCommand command = new SqlCommand("SELECT fname as 'First Name', lname as 'Last name', mygroups.name as 'Group', phone, email, address, pic " +
                    "FROM mycontact INNER JOIN mygroups on mycontact.group_id = mygroups.id WHERE " +
                    "mycontact.userid = @userid AND mycontact.group_id = @groupid");
                command.Parameters.Add("@groupid", SqlDbType.Int).Value = groupid;
                command.Parameters.Add("@userid", SqlDbType.Int).Value = Globals.GlobalUserId;
                dataGridView1.DataSource = contact.SelectContactList(command);

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (IsOdd(i))
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                    }
                }
            }
            catch (Exception)
            { }

            dataGridView1.ClearSelection();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxAddress.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            }
            catch (Exception)
            {

            }

        }

      

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ManageScoreForm manageSF = new ManageScoreForm();
            manageSF.Show();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

            textBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();







            ManageScoreForm manageSF = new ManageScoreForm();

            luu.ID = textBox1.Text;

            manageSF.Show();

            Hide();



            manageSF.Show();
            Hide();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        public class luu
        {
            static public string ID;
        }




    }

}
