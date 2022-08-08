using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using iTextSharp.text.pdf;
using iTextSharp.text;
using Word = Microsoft.Office.Interop.Word;
using SautinSoft.Document;


namespace QLSV
{
    public partial class PrintStdForm : Form
    {
        public PrintStdForm()
        {
            InitializeComponent();
        }
        STUDENT student = new STUDENT();
        private void PrintStdForm_Load(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("SELECT * FROM std2"));

            if (radioButtonNo.Checked)
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
            }

            SqlCommand command = new SqlCommand("SELECT * from std2 ");
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Columns[0].Width = 90;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 125;
            dataGridView1.Columns[4].Width = 75;
            dataGridView1.Columns[5].Width = 100;
            dataGridView1.Columns[6].Width = 128;
            dataGridView1.Columns[7].Width = 150;
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

        private void radioButtonNo_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
        }

        private void radioButtonYes_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            string query;

            if (radioButtonYes.Checked)
            {
                string data1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string data2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                if (radioButtonMale.Checked)
                {
                    query = "SELECT * FROM std2 WHERE gender = 'Male' AND bdate BETWEEN " + data1 + "AND" + data2 + "'";
                }
                else if (radioButtonFemale.Checked)
                {
                    query = "SELECT * FROM std2 WHERE gender = 'female' AND bdate BETWEEN " + data1 + "AND" + data2 + "'";
                }
                else
                {
                    query = "SELECT * FROM std2 WHERE bdate BETWEEN " + data1 + "AND" + data2 + "";

                }
                command = new SqlCommand(query);
                fillGrid(command);


            }
            else
            {
                if (radioButtonMale.Checked)
                {
                    query = "SELECT * FROM std2 WHERE gender = 'Male'";
                }

                else if (radioButtonFemale.Checked)
                {
                    query = "SELECT * FROM std2 WHERE gender = 'Female'";
                }
                else
                {
                    query = "SELECT * FROM std2";
                }
                command = new SqlCommand(query);
                fillGrid(command);
            }



            //if (radioButtonYes.Checked)
            //{
            //    DateTime start = dateTimePicker1.Value;
            //    DateTime end = dateTimePicker2.Value;
            //    if (start > end)
            //    {
            //        DateTime temp = start;
            //        start = end;
            //        end = temp;
            //    }
            //    if (radioButtonMale.Checked)
            //    {
            //        SqlCommand command = new SqlCommand("SELECT * from std where bdate between @start and @end and gender = 'Male'");
            //        command.Parameters.Add("@start", SqlDbType.DateTime).Value = start;
            //        command.Parameters.Add("@end", SqlDbType.DateTime).Value = end;
            //        dataGridView1.DataSource = student.getStudents(command);
            //    }
            //    else if (radioButtonFemale.Checked)
            //    {
            //        SqlCommand command = new SqlCommand("SELECT * from std where bdate between @start and @end and gender = 'Female'");
            //        command.Parameters.Add("@start", SqlDbType.DateTime).Value = start;
            //        command.Parameters.Add("@end", SqlDbType.DateTime).Value = end;
            //        dataGridView1.DataSource = student.getStudents(command);
            //    }
            //    else
            //    {
            //        SqlCommand command = new SqlCommand("SELECT * from std where bdate between @start and @end");
            //        command.Parameters.Add("@start", SqlDbType.DateTime).Value = start;
            //        command.Parameters.Add("@end", SqlDbType.DateTime).Value = end;
            //        dataGridView1.DataSource = student.getStudents(command);
            //    }
            //}
            //else
            //{
            //    if (radioButtonAll.Checked)
            //    {
            //        SqlCommand command = new SqlCommand("SELECT * from std");
            //        dataGridView1.DataSource = student.getStudents(command);
            //    }
            //    else if (radioButtonFemale.Checked)
            //    {
            //        SqlCommand command = new SqlCommand("SELECT * from std where gender = 'Female'");
            //        dataGridView1.DataSource = student.getStudents(command);
            //    }
            //    else
            //    {
            //        SqlCommand command = new SqlCommand("SELECT * from std where gender = 'Male'");
            //        dataGridView1.DataSource = student.getStudents(command);
            //    }
            //}



        }

   

        
        

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDlg = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Print Document";
            printDlg.Document = printDoc;
            printDlg.AllowSelection = true;
            printDlg.AllowSomePages = true;
            if (printDlg.ShowDialog() == DialogResult.OK) printDoc.Print();
        }

        private void ButtonSaveFile_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\QLSV\student_list.txt";

            using (var writer = new StreamWriter(path))
            {
                if (!File.Exists(path))
                {
                    File.Create(path);
                }

                DateTime bdate;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count - 1; j++)
                    {
                        //birthdate column
                        if (j == 3)
                        {
                            bdate = Convert.ToDateTime(dataGridView1.Rows[i].Cells[j].Value.ToString());
                            writer.Write("\t" + bdate.ToString("yyyy-MM-dd") + "\t" + "|");
                        }
                        //the last column
                        else if (j == dataGridView1.Columns.Count - 2)
                        {
                            writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString());
                        }
                        else
                        {
                            writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                        }
                    }
                    writer.WriteLine("");
                    writer.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------------");
                }
                writer.Close();
                MessageBox.Show("Data Exported");
            }
        }

        private void radioButtonAll_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ButtonSaveWord_Click(object sender, EventArgs e)
        {

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.DefaultExt = "*.docx";
            savefile.Filter = "DOCX files(*.docx)|*.docx";

            if (savefile.ShowDialog() == DialogResult.OK && savefile.FileName.Length > 0)
            {
                Export_Data_To_Word(dataGridView1, savefile.FileName);
                MessageBox.Show("File saved!", "Message Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //    public void Export_Data_To_Word(DataGridView DGV, string filename)
        //{
        //    if (dataGridView1.Rows.Count != 0)
        //    {






        //        int RowCount = dataGridView1.Rows.Count;
        //        int ColumnCount = dataGridView1.Columns.Count;
        //        Word.Document oDoc = new Word.Document();
        //        oDoc.Application.Visible = true;
        //        oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;


        //        //header text
        //        foreach (Word.Section section in oDoc.Application.ActiveDocument.Sections)
        //        {
        //            Word.Range headerRange = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
        //            headerRange.Fields.Add(headerRange, Word.WdFieldType.wdFieldPage);
        //            headerRange.Text = "Danh Sach Sinh Vien";
        //            headerRange.Font.Size = 16;
        //            headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
        //        }





        //        //dynamic oRange = oDoc.Content.Application.Selection.Range;
        //        string oTemp = "";
        //        Object oMissing = System.Reflection.Missing.Value;
        //        for (int r = 0; r <= RowCount - 1; r++)
        //        {
        //            oTemp = "";
        //            for (int c = 0; c < ColumnCount - 1; c++)
        //            {
        //                oTemp = oTemp + dataGridView1.Rows[r].Cells[c].Value + "\t";
        //            }
        //            var oPara1 = oDoc.Content.Paragraphs.Add(ref oMissing);
        //            oPara1.Range.Text = oTemp;
        //            oPara1.Range.InsertParagraphAfter();
        //            byte[] imgbyte = (byte[])dataGridView1.Rows[r].Cells[7].Value;
        //            MemoryStream ms = new MemoryStream(imgbyte);
        //            System.Drawing.Image sparePicture = System.Drawing.Image.FromStream(ms);
        //            System.Drawing.Image finalPic = (System.Drawing.Image)(new Bitmap(sparePicture, new
        //           Size(90, 90)));
        //            Clipboard.SetDataObject(finalPic);
        //            var oPara2 = oDoc.Content.Paragraphs.Add(ref oMissing);
        //            oPara2.Range.Paste();
        //            oPara2.Range.InsertParagraphAfter();
        //            oTemp += "\n";



        //        }
        //        //save the file
        //        oDoc.SaveAs2(filename);
        //    }
        //}

        public void Export_Data_To_Word(DataGridView DGV, string filename)
        {
            //if (DGV.Rows.Count != 0)
            //{
            //    int RowCount = DGV.Rows.Count;
            //    int ColumnCount = DGV.Columns.Count;

            //    Document oDoc = new Document();
            //    oDoc.Application.Visible = true;

            //    oDoc.PageSetup.Orientation = WdOrientation.wdOrientLandscape;

            //    //dynamic oRange = oDoc.Content.Application.Selection.Range;
            //    string oTemp = "";
            //    Object oMissing = System.Reflection.Missing.Value;
            //    for (int r = 0; r <= RowCount - 1; r++)
            //    {
            //        oTemp = "";
            //        for (int c = 0; c < ColumnCount - 1; c++)
            //        {
            //            oTemp = oTemp + DGV.Rows[r].Cells[c].Value + "\t";
            //        }
            //        var oPara1 = oDoc.Content.Paragraphs.Add(ref oMissing);
            //        oPara1.Range.Text = oTemp;
            //        oPara1.Range.InsertParagraphAfter();
            //        byte[] imgbyte = (byte[])dataGridView1.Rows[r].Cells[7].Value;
            //        MemoryStream ms = new MemoryStream(imgbyte);
            //        //Image sparePicture = Image.FromStream(ms);
            //        Image finalPic = (Image)(new Bitmap(Image.FromStream(ms), new Size(50, 50)));
            //        Clipboard.SetDataObject(finalPic);
            //        var oPara2 = oDoc.Content.Paragraphs.Add(ref oMissing);
            //        oPara2.Range.Paste();
            //        oPara2.Range.InsertParagraphAfter();
            //        //oTemp += "\n";
            //    }

            //    //save the file
            //    oDoc.SaveAs2(filename);
            //}

            //if (dataGridView1.Rows.Count != 0)
            //{
            //    int RowCount = dataGridView1.Rows.Count;
            //    int ColumnCount = dataGridView1.Columns.Count;
            //    Word.Document oDoc = new Word.Document();
            //    oDoc.Application.Visible = true;
            //    oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;
            //    //dynamic oRange = oDoc.Content.Application.Selection.Range;
            //    string oTemp = "";
            //    Object oMissing = System.Reflection.Missing.Value;
            //    for (int r = 0; r <= RowCount - 1; r++)
            //    {
            //        oTemp = "";
            //        for (int c = 0; c < ColumnCount - 1; c++)
            //        {
            //            oTemp = oTemp + dataGridView1.Rows[r].Cells[c].Value + "\t";
            //        }
            //        var oPara1 = oDoc.Content.Paragraphs.Add(ref oMissing);
            //        oPara1.Range.Text = oTemp;
            //        oPara1.Range.InsertParagraphAfter();
            //        byte[] imgbyte = (byte[])dataGridView1.Rows[r].Cells[7].Value;
            //        MemoryStream ms = new MemoryStream(imgbyte);
            //        System.Drawing.Image sparePicture = System.Drawing.Image.FromStream(ms);
            //        System.Drawing.Image finalPic = (System.Drawing.Image)(new Bitmap(sparePicture, new
            //       Size(90, 90)));
            //        Clipboard.SetDataObject(finalPic);
            //        var oPara2 = oDoc.Content.Paragraphs.Add(ref oMissing);
            //        oPara2.Range.Paste();
            //        oPara2.Range.InsertParagraphAfter();
            //        //oTemp += "\n";
            //    }
            //    //save the file
            //    oDoc.SaveAs2(filename);
            //}

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


        private void ButtonSavePDF_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf"; bool fileError = false;
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



                            PdfPTable pdfTable = new PdfPTable(dataGridView1.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT;
                            foreach (DataGridViewColumn column in dataGridView1.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                string id = row.Cells[0].Value.ToString();
                                pdfTable.AddCell(id);
                                string Fname = row.Cells[1].Value.ToString();
                                pdfTable.AddCell(Fname);
                                string Lname = row.Cells[2].Value.ToString();
                                pdfTable.AddCell(Lname);
                                string Bdate = row.Cells[3].Value.ToString();
                                pdfTable.AddCell(Bdate);
                                string gender = row.Cells[4].Value.ToString();
                                pdfTable.AddCell(gender);
                                string phone = row.Cells[5].Value.ToString();
                                pdfTable.AddCell(phone);
                                string address = row.Cells[6].Value.ToString();
                                pdfTable.AddCell(address);
                                byte[] imageByte = (byte[])row.Cells[7].Value;
                                iTextSharp.text.Image Image = iTextSharp.text.Image.GetInstance(imageByte);
                                pdfTable.AddCell(Image);
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
    }
}
