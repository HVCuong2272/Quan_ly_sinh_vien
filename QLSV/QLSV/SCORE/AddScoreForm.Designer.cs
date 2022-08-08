
namespace QLSV.SCORE
{
    partial class AddScoreForm
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
            this.textBoxIDStudent = new System.Windows.Forms.TextBox();
            this.labelIDCourse = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxScore = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelNameScore = new System.Windows.Forms.Label();
            this.comboBoxCourse = new System.Windows.Forms.ComboBox();
            this.labelSelectCourse = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAddScore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxIDStudent
            // 
            this.textBoxIDStudent.BackColor = System.Drawing.Color.Wheat;
            this.textBoxIDStudent.Location = new System.Drawing.Point(333, 40);
            this.textBoxIDStudent.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxIDStudent.Multiline = true;
            this.textBoxIDStudent.Name = "textBoxIDStudent";
            this.textBoxIDStudent.Size = new System.Drawing.Size(457, 38);
            this.textBoxIDStudent.TabIndex = 14;
            // 
            // labelIDCourse
            // 
            this.labelIDCourse.AutoSize = true;
            this.labelIDCourse.Location = new System.Drawing.Point(95, 43);
            this.labelIDCourse.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelIDCourse.Name = "labelIDCourse";
            this.labelIDCourse.Size = new System.Drawing.Size(189, 37);
            this.labelIDCourse.TabIndex = 13;
            this.labelIDCourse.Text = "Student ID: ";
            this.labelIDCourse.Click += new System.EventHandler(this.labelIDCourse_Click);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BackColor = System.Drawing.Color.Aquamarine;
            this.textBoxDescription.Location = new System.Drawing.Point(333, 261);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(457, 154);
            this.textBoxDescription.TabIndex = 12;
            // 
            // textBoxScore
            // 
            this.textBoxScore.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxScore.Location = new System.Drawing.Point(333, 190);
            this.textBoxScore.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.textBoxScore.Multiline = true;
            this.textBoxScore.Name = "textBoxScore";
            this.textBoxScore.Size = new System.Drawing.Size(457, 49);
            this.textBoxScore.TabIndex = 11;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(95, 264);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(173, 37);
            this.labelDescription.TabIndex = 10;
            this.labelDescription.Text = "Desciption: ";
            // 
            // labelNameScore
            // 
            this.labelNameScore.AutoSize = true;
            this.labelNameScore.Location = new System.Drawing.Point(156, 202);
            this.labelNameScore.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.labelNameScore.Name = "labelNameScore";
            this.labelNameScore.Size = new System.Drawing.Size(97, 37);
            this.labelNameScore.TabIndex = 9;
            this.labelNameScore.Text = "Score:";
            // 
            // comboBoxCourse
            // 
            this.comboBoxCourse.FormattingEnabled = true;
            this.comboBoxCourse.Location = new System.Drawing.Point(333, 118);
            this.comboBoxCourse.Margin = new System.Windows.Forms.Padding(6);
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.Size = new System.Drawing.Size(457, 42);
            this.comboBoxCourse.TabIndex = 19;
            // 
            // labelSelectCourse
            // 
            this.labelSelectCourse.AutoSize = true;
            this.labelSelectCourse.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectCourse.Location = new System.Drawing.Point(54, 123);
            this.labelSelectCourse.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelSelectCourse.Name = "labelSelectCourse";
            this.labelSelectCourse.Size = new System.Drawing.Size(220, 37);
            this.labelSelectCourse.TabIndex = 18;
            this.labelSelectCourse.Text = "Select Course: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(844, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(682, 372);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // buttonAddScore
            // 
            this.buttonAddScore.Location = new System.Drawing.Point(17, 461);
            this.buttonAddScore.Name = "buttonAddScore";
            this.buttonAddScore.Size = new System.Drawing.Size(773, 60);
            this.buttonAddScore.TabIndex = 21;
            this.buttonAddScore.Text = "Add Score";
            this.buttonAddScore.UseVisualStyleBackColor = true;
            this.buttonAddScore.Click += new System.EventHandler(this.buttonAddScore_Click);
            // 
            // AddScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.HotPink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1588, 566);
            this.Controls.Add(this.buttonAddScore);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxCourse);
            this.Controls.Add(this.labelSelectCourse);
            this.Controls.Add(this.textBoxIDStudent);
            this.Controls.Add(this.labelIDCourse);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxScore);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelNameScore);
            this.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AddScoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddScoreForm";
            this.Load += new System.EventHandler(this.AddScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIDStudent;
        private System.Windows.Forms.Label labelIDCourse;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxScore;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelNameScore;
        private System.Windows.Forms.ComboBox comboBoxCourse;
        private System.Windows.Forms.Label labelSelectCourse;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAddScore;
    }
}