using QLSV.HUMAN;
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
using QLSV.HUMAN;
namespace QLSV
{
    public partial class Log_In_form : Form
    {
        public Log_In_form()
        {
            InitializeComponent();
        }

        private void bt_Login_Click(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            if(comboBox1.Text=="")
            {
                SqlCommand command = new SqlCommand("SELECT * FROM login WHERE username = @User AND password = @Pass ", db.getConnection);

                command.Parameters.Add("@User", SqlDbType.VarChar).Value = TextBoxUsername.Text;
                command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = TextBoxPassword.Text;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if ((table.Rows.Count > 0))
                {
                    //MessageBox.Show("Ok, next time will be go to Main Menu of App");

                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                SqlCommand command = new SqlCommand("SELECT * FROM login WHERE username = @User AND password = @Pass AND Power = @Power ", db.getConnection);

                command.Parameters.Add("@User", SqlDbType.VarChar).Value = TextBoxUsername.Text;
                command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = TextBoxPassword.Text;
                command.Parameters.Add("@Power", SqlDbType.VarChar).Value = comboBox1.Text;

                adapter.SelectCommand = command;
                adapter.Fill(table);
                if ((table.Rows.Count > 0))
                {
                    //MessageBox.Show("Ok, next time will be go to Main Menu of App");
                    Contacts_Full_List_Form contacts_Full_List_Form = new Contacts_Full_List_Form();
                    contacts_Full_List_Form.Show(this);


                }
                else
                {
                    MessageBox.Show("Invalid Username or Password OR ''Bạn Không có quyền truy cập''", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }







            
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("admin");
            comboBox1.Items.Add("user");
            comboBox1.Items.Add("");


        }

        private void labelAddAccout_Click(object sender, EventArgs e)
        {
            AddAccout addAccout = new AddAccout();
            addAccout.Show(this);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxPassword_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                TextBoxPassword.UseSystemPasswordChar = false;

            }
            else
            {
                TextBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void labelpermission_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

        private void radioButtonStudent_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
