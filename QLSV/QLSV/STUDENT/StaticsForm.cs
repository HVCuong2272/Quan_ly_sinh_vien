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

namespace QLSV
{
    public partial class StaticsForm : Form
    {
        public StaticsForm()
        {
            InitializeComponent();
        }
        Color panTotalColor;
        Color panMaleCorlor;
        Color panFemaleColor;
        private void StaticsForm_Load(object sender, EventArgs e)
        {
            // Get panel coler
            panTotalColor = PanelTotal.BackColor;
            panMaleCorlor = PanelMale.BackColor;
            panFemaleColor = PanelFemale.BackColor;


            STUDENT student = new STUDENT();
            double TotalStudent = Convert.ToDouble(student.TotalStudent());
            double TotalMaleStudent = Convert.ToDouble(student.TotalMaleStudent());
            double TotalFemaleStudent = Convert.ToDouble(student.TotalFemaleStudent());


            double maleStudentPercentage = (TotalMaleStudent * (100 / TotalStudent));
            double femaleStudentPercentage = (TotalFemaleStudent * (100 / TotalStudent));
            LabelTotal.Text = ("Total Student: " + TotalStudent.ToString());
            LabelMale.Text = ("Male: " + (maleStudentPercentage.ToString("0.00") + "%"));
            LabelFemale.Text = ("Female: " + (femaleStudentPercentage.ToString("0.00") + "%"));


            chart1.Series["Phần trăm"].Points.AddXY("Totle", TotalStudent);
            chart1.Series["Phần trăm"].Points.AddXY("Female", TotalFemaleStudent);
            chart1.Series["Phần trăm"].Points.AddXY("Male", TotalMaleStudent);
            //chart title  
            chart1.Titles.Add("Proportion Chart");










            //SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=myDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            //SqlDataAdapter adapter = new SqlDataAdapter("SELECT ",con);
            //DataTable dt = new DataTable();
            //adapter.Fill(dt);
            //chart1.ChartAreas["ChartAreas1"].AxisX.Title = "Gender";
            //chart1.ChartAreas["ChartAreas1"].AxisY.Title = "So Luong";

            //chart1.Series["Series1"].XValueMember=""


        }

        private void PanelMale_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LabelTotal_Click(object sender, EventArgs e)
        {
            //LabelTotal.ForeColor = panTotalColor;
            //PanelMale.BackColor = Color.White;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void LabelTotal_MouseEnter(object sender, EventArgs e)
        {
            //PanelTotal.BackColor = Color.White;
            //LabelTotal.ForeColor = panTotalColor;
        }

        private void LabelTotal_MouseLeave(object sender, EventArgs e)
        {
            //PanelTotal.BackColor = panTotalColor;
            //LabelTotal.ForeColor = Color.White; 
        }

        private void LabelMale_MouseEnter(object sender, EventArgs e)
        {
            //PanelMale.BackColor = Color.White;
            //LabelFemale.ForeColor = panTotalColor;
        }

        private void LabelMale_MouseLeave(object sender, EventArgs e)
        {
            //PanelMale.BackColor = panTotalColor;
            //LabelMale.ForeColor = Color.White;
        }

        private void LabelFemale_MouseEnter(object sender, EventArgs e)
        {
            //PanelFemale.BackColor = Color.White;
            //LabelFemale.ForeColor = panTotalColor;
        }

        private void LabelFemale_MouseLeave(object sender, EventArgs e)
        {
            //PanelFemale.BackColor = panTotalColor;
            //LabelFemale.ForeColor = Color.White;
        }
    }
}
