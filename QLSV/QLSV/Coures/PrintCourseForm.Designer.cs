
namespace QLSV.Coures
{
    partial class PrintCourseForm
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
            this.ButtonSavePDF = new System.Windows.Forms.Button();
            this.ButtonSaveFile = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonPrintToWord = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonSavePDF
            // 
            this.ButtonSavePDF.BackColor = System.Drawing.Color.DarkGreen;
            this.ButtonSavePDF.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSavePDF.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.ButtonSavePDF.Location = new System.Drawing.Point(1102, 434);
            this.ButtonSavePDF.Name = "ButtonSavePDF";
            this.ButtonSavePDF.Size = new System.Drawing.Size(207, 43);
            this.ButtonSavePDF.TabIndex = 11;
            this.ButtonSavePDF.Text = "Save To PDF";
            this.ButtonSavePDF.UseVisualStyleBackColor = false;
            this.ButtonSavePDF.Click += new System.EventHandler(this.ButtonSavePDF_Click);
            // 
            // ButtonSaveFile
            // 
            this.ButtonSaveFile.BackColor = System.Drawing.Color.DarkBlue;
            this.ButtonSaveFile.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSaveFile.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.ButtonSaveFile.Location = new System.Drawing.Point(341, 434);
            this.ButtonSaveFile.Name = "ButtonSaveFile";
            this.ButtonSaveFile.Size = new System.Drawing.Size(755, 67);
            this.ButtonSaveFile.TabIndex = 10;
            this.ButtonSaveFile.Text = "Save To File Text ";
            this.ButtonSaveFile.UseVisualStyleBackColor = false;
            this.ButtonSaveFile.Click += new System.EventHandler(this.ButtonSaveFile_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Aquamarine;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlText;
            this.dataGridView1.Location = new System.Drawing.Point(4, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1422, 407);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonPrintToWord
            // 
            this.buttonPrintToWord.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonPrintToWord.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrintToWord.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonPrintToWord.Location = new System.Drawing.Point(112, 434);
            this.buttonPrintToWord.Name = "buttonPrintToWord";
            this.buttonPrintToWord.Size = new System.Drawing.Size(207, 43);
            this.buttonPrintToWord.TabIndex = 12;
            this.buttonPrintToWord.Text = "Save To WORD ";
            this.buttonPrintToWord.UseVisualStyleBackColor = false;
            this.buttonPrintToWord.Click += new System.EventHandler(this.buttonPrintToEX_Click);
            // 
            // PrintCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1429, 572);
            this.Controls.Add(this.buttonPrintToWord);
            this.Controls.Add(this.ButtonSavePDF);
            this.Controls.Add(this.ButtonSaveFile);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PrintCourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrintCourseForm";
            this.Load += new System.EventHandler(this.PrintCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button ButtonSavePDF;
        public System.Windows.Forms.Button ButtonSaveFile;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button buttonPrintToWord;
    }
}