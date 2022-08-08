using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using QLSV.ACCOUNT;

using System.Windows.Forms;

namespace QLSV.ACCOUT
{
    public partial class LoginAdmin : Form
    {
        public LoginAdmin()
        {
            InitializeComponent();
        }

        private void bt_Login_Click(object sender, EventArgs e)
        {
            try
            {
                MY_DB db = new MY_DB();
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                Account account = new Account();
                string power = comboBox1.Text;
                int Id = Convert.ToInt32(textBoxID.Text); 
                SqlCommand command = new SqlCommand("SELECT * FROM login WHERE Id= @Id AND username = @User AND password = @Pass ", db.getConnection);

                command.Parameters.Add("@Id", SqlDbType.VarChar).Value = textBoxID.Text;
                command.Parameters.Add("@User", SqlDbType.VarChar).Value = TextBoxUsername.Text;
                command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = TextBoxPassword.Text;
                


                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (textBoxID.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập ID !");
                    return;
                }


                if (account.checkQUYEN(power,Id))
                {
                    if ((table.Rows.Count > 0))
                    {
                        //MessageBox.Show("Ok, next time will be go to Main Menu of App");
                        this.DialogResult = DialogResult.OK;
                        ManageAccout manageAccout = new ManageAccout();
                        manageAccout.Show(this);
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Bạn không có quyền truy cập", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } 

                
            }
            catch
            {
                MessageBox.Show("ID : Nhap khong dung cu phap", "Check Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }
            private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoginAdmin_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("admin");
            comboBox1.Items.Add("user");
            comboBox1.Items.Add("");
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
