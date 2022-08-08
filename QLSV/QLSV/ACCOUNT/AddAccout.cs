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


namespace QLSV
{
    public partial class AddAccout : Form
    {
        public AddAccout()
        {
            InitializeComponent();
        }
        Account account = new Account();
        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_Add_Click(object sender, EventArgs e)
        {

            string username = TextBoxUsername.Text;
            string pass = TextBoxPassword.Text;


            MY_DB mydb = new MY_DB();

            if (TextBoxUsername.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!");
                return;
            }
            if (TextBoxPassword.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
                return;
            }
            else if (TextBoxPassword.Text != textBoxConfirn.Text)
            {
                MessageBox.Show("Hai mật khẩu không khớp!");
            }

            try
            {
                if (mydb.insertAccout(username, pass))
                {
                    MessageBox.Show("New Accout Insert", "Add Accout ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Accout Not Insert", "Add Accout ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch
            {
                MessageBox.Show("Usename đã tồn tại !!!", "LỖi  Accout ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
             





                
           
        }

        private void labelID_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
