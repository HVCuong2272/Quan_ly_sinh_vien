
namespace QLSV.SCORE
{
    partial class ManageScoreForm
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
            this.buttonAddScore = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxCourse = new System.Windows.Forms.ComboBox();
            this.labelSelectCourse = new System.Windows.Forms.Label();
            this.textBoxIDStudent = new System.Windows.Forms.TextBox();
            this.labelIDCourse = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxScore = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelNameScore = new System.Windows.Forms.Label();
            this.buttonAvgScore = new System.Windows.Forms.Button();
            this.buttonRemoveScore = new System.Windows.Forms.Button();
            this.labelnote = new System.Windows.Forms.Label();
            this.buttonShowStd = new System.Windows.Forms.Button();
            this.buttonShowScore = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddScore
            // 
            this.buttonAddScore.Location = new System.Drawing.Point(139, 447);
            this.buttonAddScore.Margin = new System.Windows.Forms.Padding(5);
            this.buttonAddScore.Name = "buttonAddScore";
            this.buttonAddScore.Size = new System.Drawing.Size(109, 54);
            this.buttonAddScore.TabIndex = 31;
            this.buttonAddScore.Text = "Add ";
            this.buttonAddScore.UseVisualStyleBackColor = true;
            this.buttonAddScore.Click += new System.EventHandler(this.buttonAddScore_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(534, 128);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(890, 294);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // comboBoxCourse
            // 
            this.comboBoxCourse.FormattingEnabled = true;
            this.comboBoxCourse.Location = new System.Drawing.Point(196, 132);
            this.comboBoxCourse.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.Size = new System.Drawing.Size(315, 37);
            this.comboBoxCourse.TabIndex = 29;
            // 
            // labelSelectCourse
            // 
            this.labelSelectCourse.AutoSize = true;
            this.labelSelectCourse.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectCourse.Location = new System.Drawing.Point(-5, 132);
            this.labelSelectCourse.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.labelSelectCourse.Name = "labelSelectCourse";
            this.labelSelectCourse.Size = new System.Drawing.Size(220, 37);
            this.labelSelectCourse.TabIndex = 28;
            this.labelSelectCourse.Text = "Select Course: ";
            this.labelSelectCourse.Click += new System.EventHandler(this.labelSelectCourse_Click);
            // 
            // textBoxIDStudent
            // 
            this.textBoxIDStudent.BackColor = System.Drawing.Color.Wheat;
            this.textBoxIDStudent.Location = new System.Drawing.Point(196, 51);
            this.textBoxIDStudent.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.textBoxIDStudent.Multiline = true;
            this.textBoxIDStudent.Name = "textBoxIDStudent";
            this.textBoxIDStudent.Size = new System.Drawing.Size(315, 37);
            this.textBoxIDStudent.TabIndex = 27;
            // 
            // labelIDCourse
            // 
            this.labelIDCourse.AutoSize = true;
            this.labelIDCourse.Location = new System.Drawing.Point(30, 51);
            this.labelIDCourse.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.labelIDCourse.Name = "labelIDCourse";
            this.labelIDCourse.Size = new System.Drawing.Size(163, 31);
            this.labelIDCourse.TabIndex = 26;
            this.labelIDCourse.Text = "Student ID: ";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BackColor = System.Drawing.Color.Aquamarine;
            this.textBoxDescription.Location = new System.Drawing.Point(196, 286);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(18, 20, 18, 20);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(315, 136);
            this.textBoxDescription.TabIndex = 25;
            // 
            // textBoxScore
            // 
            this.textBoxScore.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxScore.Location = new System.Drawing.Point(196, 183);
            this.textBoxScore.Margin = new System.Windows.Forms.Padding(18, 20, 18, 20);
            this.textBoxScore.Multiline = true;
            this.textBoxScore.Name = "textBoxScore";
            this.textBoxScore.Size = new System.Drawing.Size(315, 88);
            this.textBoxScore.TabIndex = 24;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(30, 298);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(18, 0, 18, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(149, 31);
            this.labelDescription.TabIndex = 23;
            this.labelDescription.Text = "Desciption: ";
            // 
            // labelNameScore
            // 
            this.labelNameScore.AutoSize = true;
            this.labelNameScore.Location = new System.Drawing.Point(89, 212);
            this.labelNameScore.Margin = new System.Windows.Forms.Padding(18, 0, 18, 0);
            this.labelNameScore.Name = "labelNameScore";
            this.labelNameScore.Size = new System.Drawing.Size(83, 31);
            this.labelNameScore.TabIndex = 22;
            this.labelNameScore.Text = "Score:";
            // 
            // buttonAvgScore
            // 
            this.buttonAvgScore.Location = new System.Drawing.Point(534, 447);
            this.buttonAvgScore.Margin = new System.Windows.Forms.Padding(5);
            this.buttonAvgScore.Name = "buttonAvgScore";
            this.buttonAvgScore.Size = new System.Drawing.Size(279, 54);
            this.buttonAvgScore.TabIndex = 33;
            this.buttonAvgScore.Text = "Avg Score By Course";
            this.buttonAvgScore.UseVisualStyleBackColor = true;
            this.buttonAvgScore.Click += new System.EventHandler(this.buttonAvgScore_Click);
            // 
            // buttonRemoveScore
            // 
            this.buttonRemoveScore.Location = new System.Drawing.Point(258, 447);
            this.buttonRemoveScore.Margin = new System.Windows.Forms.Padding(5);
            this.buttonRemoveScore.Name = "buttonRemoveScore";
            this.buttonRemoveScore.Size = new System.Drawing.Size(118, 54);
            this.buttonRemoveScore.TabIndex = 34;
            this.buttonRemoveScore.Text = "Remove";
            this.buttonRemoveScore.UseVisualStyleBackColor = true;
            this.buttonRemoveScore.Click += new System.EventHandler(this.buttonRemoveScore_Click);
            // 
            // labelnote
            // 
            this.labelnote.AutoSize = true;
            this.labelnote.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnote.Location = new System.Drawing.Point(7, 530);
            this.labelnote.Name = "labelnote";
            this.labelnote.Size = new System.Drawing.Size(524, 19);
            this.labelnote.TabIndex = 35;
            this.labelnote.Text = "* To edit a score you have to delete it and RE add it with the values you want";
            // 
            // buttonShowStd
            // 
            this.buttonShowStd.Location = new System.Drawing.Point(534, 69);
            this.buttonShowStd.Name = "buttonShowStd";
            this.buttonShowStd.Size = new System.Drawing.Size(247, 51);
            this.buttonShowStd.TabIndex = 36;
            this.buttonShowStd.Text = "Show Students";
            this.buttonShowStd.UseVisualStyleBackColor = true;
            this.buttonShowStd.Click += new System.EventHandler(this.buttonShowStd_Click);
            // 
            // buttonShowScore
            // 
            this.buttonShowScore.Location = new System.Drawing.Point(787, 69);
            this.buttonShowScore.Name = "buttonShowScore";
            this.buttonShowScore.Size = new System.Drawing.Size(247, 51);
            this.buttonShowScore.TabIndex = 37;
            this.buttonShowScore.Text = "Show Score";
            this.buttonShowScore.UseVisualStyleBackColor = true;
            this.buttonShowScore.Click += new System.EventHandler(this.buttonShowScore_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1486, 557);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(10, 10);
            this.textBox1.TabIndex = 38;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1486, 557);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(10, 10);
            this.textBox2.TabIndex = 39;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1486, 557);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(10, 10);
            this.textBox3.TabIndex = 40;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(1486, 557);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(10, 10);
            this.textBox4.TabIndex = 41;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(1486, 557);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(10, 10);
            this.textBox5.TabIndex = 42;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(1486, 557);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(10, 10);
            this.textBox6.TabIndex = 43;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(1486, 557);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(10, 10);
            this.dataGridView2.TabIndex = 44;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(388, 447);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 54);
            this.button1.TabIndex = 45;
            this.button1.Text = "Edit score";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.Wheat;
            this.textBox7.Location = new System.Drawing.Point(11, 533);
            this.textBox7.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(10, 10);
            this.textBox7.TabIndex = 46;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // ManageScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1508, 574);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonShowScore);
            this.Controls.Add(this.buttonShowStd);
            this.Controls.Add(this.labelnote);
            this.Controls.Add(this.buttonRemoveScore);
            this.Controls.Add(this.buttonAvgScore);
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
            this.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ManageScoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageScoreForm";
            this.Load += new System.EventHandler(this.ManageScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddScore;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxCourse;
        private System.Windows.Forms.Label labelSelectCourse;
        private System.Windows.Forms.TextBox textBoxIDStudent;
        private System.Windows.Forms.Label labelIDCourse;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxScore;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelNameScore;
        private System.Windows.Forms.Button buttonAvgScore;
        private System.Windows.Forms.Button buttonRemoveScore;
        private System.Windows.Forms.Label labelnote;
        private System.Windows.Forms.Button buttonShowStd;
        private System.Windows.Forms.Button buttonShowScore;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox7;
    }
}