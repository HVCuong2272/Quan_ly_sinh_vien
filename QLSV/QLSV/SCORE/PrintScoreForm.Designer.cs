
namespace QLSV.SCORE
{
    partial class PrintScoreForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelCourseList = new System.Windows.Forms.Label();
            this.labelScoreList = new System.Windows.Forms.Label();
            this.labelStudentList = new System.Windows.Forms.Label();
            this.dataGridViewScoreL = new System.Windows.Forms.DataGridView();
            this.dataGridViewStudentL = new System.Windows.Forms.DataGridView();
            this.ButtonSaveWord = new System.Windows.Forms.Button();
            this.ButtonSavePDF = new System.Windows.Forms.Button();
            this.ButtonSaveFile = new System.Windows.Forms.Button();
            this.listBoxCourse = new System.Windows.Forms.ListBox();
            this.labelReset = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScoreL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentL)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCourseList
            // 
            this.labelCourseList.AutoSize = true;
            this.labelCourseList.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCourseList.ForeColor = System.Drawing.Color.White;
            this.labelCourseList.Location = new System.Drawing.Point(66, 28);
            this.labelCourseList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCourseList.Name = "labelCourseList";
            this.labelCourseList.Size = new System.Drawing.Size(179, 37);
            this.labelCourseList.TabIndex = 0;
            this.labelCourseList.Text = "Course List";
            // 
            // labelScoreList
            // 
            this.labelScoreList.AutoSize = true;
            this.labelScoreList.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScoreList.ForeColor = System.Drawing.Color.White;
            this.labelScoreList.Location = new System.Drawing.Point(552, 28);
            this.labelScoreList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelScoreList.Name = "labelScoreList";
            this.labelScoreList.Size = new System.Drawing.Size(162, 37);
            this.labelScoreList.TabIndex = 1;
            this.labelScoreList.Text = "Score List";
            // 
            // labelStudentList
            // 
            this.labelStudentList.AutoSize = true;
            this.labelStudentList.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentList.ForeColor = System.Drawing.Color.White;
            this.labelStudentList.Location = new System.Drawing.Point(1084, 28);
            this.labelStudentList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStudentList.Name = "labelStudentList";
            this.labelStudentList.Size = new System.Drawing.Size(201, 37);
            this.labelStudentList.TabIndex = 2;
            this.labelStudentList.Text = "Student List";
            // 
            // dataGridViewScoreL
            // 
            this.dataGridViewScoreL.AllowUserToAddRows = false;
            this.dataGridViewScoreL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewScoreL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewScoreL.Location = new System.Drawing.Point(288, 70);
            this.dataGridViewScoreL.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewScoreL.Name = "dataGridViewScoreL";
            this.dataGridViewScoreL.RowHeadersWidth = 51;
            this.dataGridViewScoreL.Size = new System.Drawing.Size(692, 300);
            this.dataGridViewScoreL.TabIndex = 4;
            // 
            // dataGridViewStudentL
            // 
            this.dataGridViewStudentL.AllowUserToAddRows = false;
            this.dataGridViewStudentL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStudentL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudentL.Location = new System.Drawing.Point(1025, 70);
            this.dataGridViewStudentL.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewStudentL.Name = "dataGridViewStudentL";
            this.dataGridViewStudentL.RowHeadersWidth = 51;
            this.dataGridViewStudentL.Size = new System.Drawing.Size(331, 397);
            this.dataGridViewStudentL.TabIndex = 5;
            this.dataGridViewStudentL.Click += new System.EventHandler(this.dataGridViewStudentL_Click);
            // 
            // ButtonSaveWord
            // 
            this.ButtonSaveWord.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ButtonSaveWord.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSaveWord.ForeColor = System.Drawing.Color.Crimson;
            this.ButtonSaveWord.Location = new System.Drawing.Point(288, 443);
            this.ButtonSaveWord.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonSaveWord.Name = "ButtonSaveWord";
            this.ButtonSaveWord.Size = new System.Drawing.Size(187, 33);
            this.ButtonSaveWord.TabIndex = 15;
            this.ButtonSaveWord.Text = "Save To Docx";
            this.ButtonSaveWord.UseVisualStyleBackColor = false;
            this.ButtonSaveWord.Click += new System.EventHandler(this.ButtonSaveWord_Click);
            // 
            // ButtonSavePDF
            // 
            this.ButtonSavePDF.BackColor = System.Drawing.Color.DarkGreen;
            this.ButtonSavePDF.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSavePDF.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.ButtonSavePDF.Location = new System.Drawing.Point(804, 443);
            this.ButtonSavePDF.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonSavePDF.Name = "ButtonSavePDF";
            this.ButtonSavePDF.Size = new System.Drawing.Size(167, 33);
            this.ButtonSavePDF.TabIndex = 14;
            this.ButtonSavePDF.Text = "Save To PDF";
            this.ButtonSavePDF.UseVisualStyleBackColor = false;
            this.ButtonSavePDF.Click += new System.EventHandler(this.ButtonSavePDF_Click);
            // 
            // ButtonSaveFile
            // 
            this.ButtonSaveFile.BackColor = System.Drawing.Color.DarkBlue;
            this.ButtonSaveFile.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSaveFile.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.ButtonSaveFile.Location = new System.Drawing.Point(288, 388);
            this.ButtonSaveFile.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonSaveFile.Name = "ButtonSaveFile";
            this.ButtonSaveFile.Size = new System.Drawing.Size(683, 51);
            this.ButtonSaveFile.TabIndex = 13;
            this.ButtonSaveFile.Text = "Save To File Text ";
            this.ButtonSaveFile.UseVisualStyleBackColor = false;
            this.ButtonSaveFile.Click += new System.EventHandler(this.ButtonSaveFile_Click);
            // 
            // listBoxCourse
            // 
            this.listBoxCourse.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCourse.FormattingEnabled = true;
            this.listBoxCourse.ItemHeight = 26;
            this.listBoxCourse.Location = new System.Drawing.Point(10, 70);
            this.listBoxCourse.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxCourse.Name = "listBoxCourse";
            this.listBoxCourse.Size = new System.Drawing.Size(235, 368);
            this.listBoxCourse.TabIndex = 16;
            this.listBoxCourse.Click += new System.EventHandler(this.listBoxCourse_Click);
            // 
            // labelReset
            // 
            this.labelReset.AutoSize = true;
            this.labelReset.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReset.ForeColor = System.Drawing.Color.Coral;
            this.labelReset.Location = new System.Drawing.Point(925, 45);
            this.labelReset.Name = "labelReset";
            this.labelReset.Size = new System.Drawing.Size(55, 23);
            this.labelReset.TabIndex = 17;
            this.labelReset.Text = "Reset";
            this.labelReset.Click += new System.EventHandler(this.labelReset_Click);
            // 
            // PrintScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(1375, 478);
            this.Controls.Add(this.labelReset);
            this.Controls.Add(this.listBoxCourse);
            this.Controls.Add(this.ButtonSaveWord);
            this.Controls.Add(this.ButtonSavePDF);
            this.Controls.Add(this.ButtonSaveFile);
            this.Controls.Add(this.dataGridViewStudentL);
            this.Controls.Add(this.dataGridViewScoreL);
            this.Controls.Add(this.labelStudentList);
            this.Controls.Add(this.labelScoreList);
            this.Controls.Add(this.labelCourseList);
            this.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "PrintScoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrintScoreForm";
            this.Load += new System.EventHandler(this.PrintScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScoreL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCourseList;
        private System.Windows.Forms.Label labelScoreList;
        private System.Windows.Forms.Label labelStudentList;
        private System.Windows.Forms.DataGridView dataGridViewScoreL;
        private System.Windows.Forms.DataGridView dataGridViewStudentL;
        public System.Windows.Forms.Button ButtonSaveWord;
        public System.Windows.Forms.Button ButtonSavePDF;
        public System.Windows.Forms.Button ButtonSaveFile;
        private System.Windows.Forms.ListBox listBoxCourse;
        private System.Windows.Forms.Label labelReset;
    }
}