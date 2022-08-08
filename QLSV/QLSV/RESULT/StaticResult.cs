using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSV.SCORE;


namespace QLSV.RESULT
{
    public partial class StaticResult : Form
    {
        public StaticResult()
        {
            InitializeComponent();
        }

        private void StaticResult_Load(object sender, EventArgs e)
        {
            
            Score score = new Score();
            STUDENT student = new STUDENT();

            double statisCSharp = Convert.ToDouble(score.getStaticCourse(3));
            double statisJava = Convert.ToDouble(score.getStaticCourse(6));
            double statisCloud = Convert.ToDouble(score.getStaticCourse(8));
            double statisMachine = Convert.ToDouble(score.getStaticCourse(9));



            //double statisCSharp = 7;
            //double statisJava = 10;
            //double statisCloud = 50;
            //double statisMachine = 9;

            labelCSharp.Text = ("C#: " + statisCSharp.ToString("0.00"));
            labelJava.Text = ("Java: " + statisJava.ToString("0.00"));
            labelCloud.Text = ("Cloud Computing: " + statisCloud.ToString("0.00" +
                ""));
            labelMachine.Text = ("Machine Learning: " + statisMachine.ToString("0.00"));

            double total = Convert.ToDouble(student.TotalStudent());
            double totalPass = Convert.ToDouble(score.getStaticPass());
            double totalFail = Convert.ToDouble(score.getStaticFail());
            // tinh %, cac ban xem lai phep toan
            // (tong student x 100) / (total students)
            double StudentPassPercentage = (totalPass * (100 / total));
            double StudentFailPercentage = (totalFail * (100 / total));
            labelPass.Text = ("Pass:" + (StudentPassPercentage.ToString("0.00") + "%"));
            labelFail.Text = ("Fail:" + (StudentFailPercentage.ToString("0.00") + "%"));




            //var cS = chart1.Series.Add("C#");
            //var java = chart1.Series.Add("java");
            //var loud_Computing = chart1.Series.Add("Cloud Computing");
            //var ML = chart1.Series.Add("Machine Learning");
            //chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            //chart1.ChartAreas[0].AxisY.MinorGrid.Enabled = false;
            //chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            //chart1.ChartAreas[0].AxisX.MinorGrid.Enabled = false;


            //cS.Points.AddXY("STATIC", statisCSharp);
            //java.Points.AddXY("STATIC", statisJava);
            //loud_Computing.Points.AddXY("STATIC", statisCloud);
            //ML.Points.AddXY("STATIC", statisMachine);



            Salary.Series["Điểm"].Points.AddXY("C#", statisCSharp);
            Salary.Series["Điểm"].Points.AddXY("Java", statisJava);
            Salary.Series["Điểm"].Points.AddXY("Cloud", statisCloud);
            Salary.Series["Điểm"].Points.AddXY("ML", statisMachine);
            //chart title  
            Salary.Titles.Add("Biểu đồ điểm");


            chart1.Series["Phần trăm"].Points.AddXY("Pass", StudentPassPercentage);
            chart1.Series["Phần trăm"].Points.AddXY("Fail", StudentFailPercentage);
            //chart title  
            chart1.Titles.Add("Proportion Chart");
            chart1.ChartAreas[0].AxisY.Maximum = 100;
                Salary.ChartAreas[0].AxisY.Maximum = 10 ;



        }
    }
}
