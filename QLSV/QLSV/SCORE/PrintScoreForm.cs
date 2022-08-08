using System;
using QLSV.SCORE;
using QLSV.Coures;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Printing;
using iTextSharp.text.pdf;
using iTextSharp.text;
using Word = Microsoft.Office.Interop.Word;
using SautinSoft.Document;

namespace QLSV.SCORE
{
    public partial class PrintScoreForm : Form
    {
        public PrintScoreForm()
        {
            InitializeComponent();
        }
        Score score = new Score();
        STUDENT student = new STUDENT();
        Course course = new Course();

        private void PrintScoreForm_Load(object sender, EventArgs e)
        {
            dataGridViewStudentL.DataSource = student.getStudents(new SqlCommand("SELECT Id, fname, lname FROM std2 "));

            dataGridViewScoreL.DataSource = score.getStudentScore();

            listBoxCourse.DataSource = course.getAllCourse();
            listBoxCourse.DisplayMember = "Name_Course";
            listBoxCourse.ValueMember = "id";

        }

        private void listBoxCourse_Click(object sender, EventArgs e)
        {
            dataGridViewScoreL.DataSource = score.getCourseScores(int.Parse(listBoxCourse.SelectedValue.ToString()));
        }

        private void dataGridViewStudentL_Click(object sender, EventArgs e)
        {
            dataGridViewScoreL.DataSource = score.getStudentScores(int.Parse(dataGridViewStudentL.CurrentRow.Cells[0].Value.ToString()));
        }

        private void labelReset_Click(object sender, EventArgs e)
        {
            dataGridViewScoreL.DataSource = score.getStudentScore();
        }

        private void ButtonSaveFile_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\QLSV\Score_list.txt";

            using (var writer = new StreamWriter(path))
            {
                if (!File.Exists(path))
                {
                    File.Create(path);
                }

                DateTime bdate;
                for (int i = 0; i < dataGridViewScoreL.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridViewScoreL.Columns.Count; j++)
                    {
                        //birthdate column

                        writer.Write("\t" + dataGridViewScoreL.Rows[i].Cells[j].Value.ToString() + "\t\t" + "|");

                    }
                    writer.WriteLine("");
                    writer.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------------");
                }
                writer.Close();
                MessageBox.Show("Data Exported");

            }
        }

        private void ButtonSavePDF_Click(object sender, EventArgs e)
        {
            if (dataGridViewScoreL.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output_Score.pdf"; bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }


                    //string FilePath = "";

                    //FilePath = Server.MapPath("Fonts\\ARIALUNI.TTF");
                    //string fontpath = FilePath;
                    //BaseFont bf = BaseFont.CreateFont(fontpath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                    //Font fontCompany = newFont(bf, 12, Font.BOLD, new Color(System.Drawing.ColorTranslator.FromHtml(Constants.DEFAULT_COLOR_COMPANYNAME)));



                    if (!fileError)
                    {
                        try
                        {


                            //string stext = "Danh Sach Sinh Vien";
                            //Chunk begingnning = new Chunk(stext, fontCompany);



                            PdfPTable pdfTable = new PdfPTable(dataGridViewScoreL.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT;
                            foreach (DataGridViewColumn column in dataGridViewScoreL.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }
                            foreach (DataGridViewRow row in dataGridViewScoreL.Rows)
                            {
                                string Student_Id = row.Cells[0].Value.ToString();
                                pdfTable.AddCell(Student_Id);
                                string Fname = row.Cells[1].Value.ToString();
                                pdfTable.AddCell(Fname);
                                string lname = row.Cells[2].Value.ToString();
                                pdfTable.AddCell(lname);
                                string course_id = row.Cells[3].Value.ToString();
                                pdfTable.AddCell(course_id);
                                string Name_Course = row.Cells[4].Value.ToString();
                                pdfTable.AddCell(Name_Course);
                                string student_score = row.Cells[5].Value.ToString();
                                pdfTable.AddCell(student_score);


                            }
                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream); pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }


        private void ButtonSaveWord_Click(object sender, EventArgs e)
        {

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.DefaultExt = "*.docx";
            savefile.Filter = "DOCX files(*.docx)|*.docx";

            if (savefile.ShowDialog() == DialogResult.OK && savefile.FileName.Length > 0)
            {
                Export_Data_To_Word(dataGridViewScoreL, savefile.FileName);
                MessageBox.Show("File saved!", "Message Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void Export_Data_To_Word(DataGridView DGV, string filename)
        {
            

            string html = @"<div style='font-size: 10pt'>
  <div style='width: 99%; margin: 0 auto'>
    <div style='display: flex'>
      <div style='flex: 1; text-align: center'>
        <p style='font-weight: bold'>TRƯỜNG ĐẠI HỌC SPKT TP.HCM</p>
        <p style='text-decoration: underline'>PHÒNG ĐÀO TẠO</p>
      </div>
      <div style='flex: 1; text-align: right'>
        <p>Ngày in: 25/05/2021</p>
        <p>Trang: 1</p>
      </div>
    </div>
    <div style='text-align: center'>
      <p style='font-weight: bold; font-size: 12pt'>
        DANH SÁCH GHI ĐIỂM QUÁ TRÌNH
      </p>
      <p>HỌC KỲ HK02 - NĂM HỌC 2020-2021</p>
    </div>
  </div>
  <hr style='border: 3px #ccc solid' />
  <div style='width: 99%; margin: 8px auto'>
    <div style='display: flex'>
      <div style=''>
        <p style=''>Môn học/Nhóm:</p>
        <p style=''>Lớp học phần:</p>
        <p style=''>CBGD:</p>
      </div>
      <div>
        <p style='font-weight: bold'>
          Windows Programming (2+1) - 02CLC
        </p>
        <p style='font-weight: bold'>202WIPR230579E_02CLC</p>
        <p style='font-weight: bold'>Lê Vĩnh Thịnh(0132)</p>
      </div>
      <div>
        <p style=''>Số tín chỉ:</p>
        <p style=''>Giờ thi:</p>
        <p style=''>% Quá trình:</p>
      </div>
      <div>
        <p style='font-weight: bold'>3</p>
        <p style='font-weight: bold'>3</p>
        <p style='font-weight: bold'>50%</p>
      </div>
    </div>
    <div class='display: flex;'>
      <span style='margin-right: 3%'>
        Hình thức đánh giá quá trình:_____________________
      </span>
      <span style='margin-right: 3%'>Ngày thi:__/__/____</span>
      <span style='margin-right: 3%; line-height: 16pt;'>Phòng thi:__________</span>
    </div>
  </div>";
            //Table start.
            html += "<table cellpadding='5' cellspacing='0' style='width: 99 %;margin: 16px auto;border: 1px solid #ccc;font - size: 9pt;font - family: arial;'>";

            //Adding HeaderRow.
            html += "<tr>";
            foreach (DataGridViewColumn column in DGV.Columns)
            {
                html += "<th style='border: 1px solid #ccc'><div style='border: none;'>" + column.HeaderText + "</div></th>";
            }
            html += "</tr>";

            //Adding DataRow.
            foreach (DataGridViewRow row in DGV.Rows)
            {
                html += "<tr>";
                foreach (DataGridViewCell cell in row.Cells)
                {
                    string value = cell.Value.ToString();
                    if (cell.Value.GetType().ToString() == "System.Byte[]")
                    {
                        string base64String = Convert.ToBase64String(((Byte[])cell.Value), 0, ((Byte[])cell.Value).Length);
                        value = "<img style='width: 100%' src=\"data:image/png;base64," + base64String + "\"/>";
                    }
                    html += "<td style='width:120px;border: 1px solid #ccc'><div style='border: none;'>" + value + "</div></td>";
                }
                html += "</tr>";
            }

            //Table end.
            html += "</table>";

            html += @"<div style='display: flex'>
    <div style='flex: 1; text-align: center'>
      <p>Xác nhận của Bộ Môn</p>
    </div>
    <div style='flex: 1; text-align: center'>
      <p>Ngày___tháng___năm_____</p>
      <p>Cán bộ chấm thi</p>
    </div>
  </div>
</div>";

            //Save the HTML string as HTML File.
            int indexOfDot = filename.IndexOf('.');
            string htmlFilename = filename.Substring(0, indexOfDot + 1) + "html";
            File.WriteAllText(htmlFilename, html);

            //Convert the HTML File to Word document.

            DocumentCore dc = DocumentCore.Load(htmlFilename);

            dc.Save(filename);

            // Open the result for demonstration purposes.
            //System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(filename) { UseShellExecute = true });

            //Delete the HTML File.
            File.Delete(htmlFilename);
        }


    }
}
