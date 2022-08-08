using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Drawing.Imaging;
using System.Data.SqlClient;
using QLSV.SCORE;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace QLSV.RESULT
{
    public partial class ResultForm : Form
    {
        public ResultForm()
        {
            InitializeComponent();
        }
        STUDENT student = new STUDENT();
        Result result = new Result();
        Score score = new Score();
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void fillGrid(SqlCommand command)
        {
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.DataSource = student.getStudents(command);

            picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridView1.AllowUserToAddRows = false;


        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            DataView dv = score.LoadResultForm().DefaultView;
            dv.RowFilter = string.Format("fname like '%{0}%' OR Convert([id], System.String) like '%{0}%'", textBoxSearch.Text);
            dataGridView1.DataSource = dv.ToTable();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ResultForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = score.LoadResultForm();
            dataGridView1.Columns["Id1"].Visible = false;
            dataGridView1.Columns["AverageScore"].DefaultCellStyle.Format = "N2";

            //dataGridView1.Columns.Add("newColumnName", "C++");
            //dataGridView1.Columns.Add("newColumnName", "Python");
            //dataGridView1.Columns.Add("newColumnName", "Web");
            //dataGridView1.Columns.Add("newColumnName", "C#");
            //dataGridView1.Columns.Add("newColumnName", "Resut");

            dataGridView1.Columns["id1"].Visible = false;


        }

        private void labelReset_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = score.LoadResultForm();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txtStudentID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            TextBoxFname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TextBoxLname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\resultform_list.txt";

            using (var writer = new StreamWriter(path))
            {
                // check if the file exists
                if (!File.Exists(path))
                {
                    File.Create(path);
                }


                // rows
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    // columns
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                    }
                    // Make a new line 
                    writer.WriteLine("");
                    // Make a seperation
                    //writer.WriteLine("-------------------------------------------------------------");
                }

                writer.Close();
                MessageBox.Show("Data Exported");


            }
        }
            }
}
