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
    public partial class AddIDUser : Form
    {
        public AddIDUser()
        {
            InitializeComponent();
        }
        Account account = new Account();
        private void buttonUPDATE_Click(object sender, EventArgs e)
        {
           
            try
            {

                int Id = Convert.ToInt32(textBoxID.Text); 
                string username = textBoxUserName.Text;

                if (account.checkAccount(username,Id))

                {
                    if (account.updateIDAccount(Id, username))
                    {
                        MessageBox.Show("Account Information Updated", "Edit Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Khong the Update ID ", "Edit Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("ID đã tồn tại ", "Edit Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Edit Account", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void AddIDUser_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = account.getAccount();
        }

        private void dataGridView_Click(object sender, EventArgs e)
        {
            textBoxID.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
            textBoxUserName.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
           
        }
    }
}
