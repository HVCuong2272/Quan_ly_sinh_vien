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


namespace QLSV.HUMAN
{
    public partial class Select_Contact_Form : Form
    {
        public Select_Contact_Form()
        {
            InitializeComponent();
        }
        private void Select_Contact_Form_Load(object sender, EventArgs e)
        {
            CONTACT contact = new CONTACT();
            SqlCommand command = new SqlCommand("SELECT id ,  fname  as 'first name',  lname  as 'last name',  group_id  as'group id' FROM  mycontact  WHERE  userid  = @uid");
            command.Parameters.Add("@uid", SqlDbType.Int).Value = Globals.GlobalUserId;
            dataGridView1.DataSource = contact.SelectContactList(command);
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Select_Contact_Form_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DoubleClick_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
