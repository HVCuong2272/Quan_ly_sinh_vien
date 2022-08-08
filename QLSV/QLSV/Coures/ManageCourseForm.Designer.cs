
namespace QLSV.Coures
{
    partial class ManageCourseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCourseForm));
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxNameCourse = new System.Windows.Forms.TextBox();
            this.buttonEditCourse = new System.Windows.Forms.Button();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelHours = new System.Windows.Forms.Label();
            this.labelNameCourse = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.buttonADDCourse = new System.Windows.Forms.Button();
            this.buttonRemoveCourse = new System.Windows.Forms.Button();
            this.listBoxCourse = new System.Windows.Forms.ListBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.buttonRR = new System.Windows.Forms.Button();
            this.buttonL = new System.Windows.Forms.Button();
            this.buttonR = new System.Windows.Forms.Button();
            this.buttonLL = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.labelSemester = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(174, 29);
            this.labelID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(68, 37);
            this.labelID.TabIndex = 25;
            this.labelID.Text = "ID: ";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxDescription.Location = new System.Drawing.Point(267, 261);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(8);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(369, 120);
            this.textBoxDescription.TabIndex = 23;
            // 
            // textBoxNameCourse
            // 
            this.textBoxNameCourse.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxNameCourse.Location = new System.Drawing.Point(273, 92);
            this.textBoxNameCourse.Margin = new System.Windows.Forms.Padding(8);
            this.textBoxNameCourse.Multiline = true;
            this.textBoxNameCourse.Name = "textBoxNameCourse";
            this.textBoxNameCourse.Size = new System.Drawing.Size(369, 26);
            this.textBoxNameCourse.TabIndex = 22;
            // 
            // buttonEditCourse
            // 
            this.buttonEditCourse.BackColor = System.Drawing.Color.DarkMagenta;
            this.buttonEditCourse.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditCourse.ForeColor = System.Drawing.Color.AliceBlue;
            this.buttonEditCourse.Location = new System.Drawing.Point(270, 460);
            this.buttonEditCourse.Margin = new System.Windows.Forms.Padding(8);
            this.buttonEditCourse.Name = "buttonEditCourse";
            this.buttonEditCourse.Size = new System.Drawing.Size(161, 59);
            this.buttonEditCourse.TabIndex = 21;
            this.buttonEditCourse.Text = "EDIT ";
            this.buttonEditCourse.UseVisualStyleBackColor = false;
            this.buttonEditCourse.Click += new System.EventHandler(this.buttonEditCourse_Click);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(95, 261);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(173, 37);
            this.labelDescription.TabIndex = 20;
            this.labelDescription.Text = "Desciption: ";
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHours.Location = new System.Drawing.Point(152, 159);
            this.labelHours.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(116, 37);
            this.labelHours.TabIndex = 19;
            this.labelHours.Text = "Hours: ";
            // 
            // labelNameCourse
            // 
            this.labelNameCourse.AutoSize = true;
            this.labelNameCourse.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameCourse.Location = new System.Drawing.Point(10, 95);
            this.labelNameCourse.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelNameCourse.Name = "labelNameCourse";
            this.labelNameCourse.Size = new System.Drawing.Size(246, 37);
            this.labelNameCourse.TabIndex = 18;
            this.labelNameCourse.Text = "Name Of Course:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(271, 159);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(371, 34);
            this.numericUpDown1.TabIndex = 27;
            // 
            // buttonADDCourse
            // 
            this.buttonADDCourse.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonADDCourse.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonADDCourse.ForeColor = System.Drawing.Color.AliceBlue;
            this.buttonADDCourse.Location = new System.Drawing.Point(85, 460);
            this.buttonADDCourse.Margin = new System.Windows.Forms.Padding(8);
            this.buttonADDCourse.Name = "buttonADDCourse";
            this.buttonADDCourse.Size = new System.Drawing.Size(157, 59);
            this.buttonADDCourse.TabIndex = 29;
            this.buttonADDCourse.Text = "ADD";
            this.buttonADDCourse.UseVisualStyleBackColor = false;
            this.buttonADDCourse.Click += new System.EventHandler(this.buttonADDCourse_Click);
            // 
            // buttonRemoveCourse
            // 
            this.buttonRemoveCourse.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonRemoveCourse.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveCourse.ForeColor = System.Drawing.Color.AliceBlue;
            this.buttonRemoveCourse.Location = new System.Drawing.Point(465, 460);
            this.buttonRemoveCourse.Margin = new System.Windows.Forms.Padding(8);
            this.buttonRemoveCourse.Name = "buttonRemoveCourse";
            this.buttonRemoveCourse.Size = new System.Drawing.Size(177, 59);
            this.buttonRemoveCourse.TabIndex = 28;
            this.buttonRemoveCourse.Text = "REMOVE";
            this.buttonRemoveCourse.UseVisualStyleBackColor = false;
            this.buttonRemoveCourse.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxCourse
            // 
            this.listBoxCourse.BackColor = System.Drawing.Color.YellowGreen;
            this.listBoxCourse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBoxCourse.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCourse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listBoxCourse.FormattingEnabled = true;
            this.listBoxCourse.ItemHeight = 34;
            this.listBoxCourse.Location = new System.Drawing.Point(707, 29);
            this.listBoxCourse.Name = "listBoxCourse";
            this.listBoxCourse.Size = new System.Drawing.Size(434, 340);
            this.listBoxCourse.TabIndex = 30;
            this.listBoxCourse.SelectedIndexChanged += new System.EventHandler(this.listBoxCourse_SelectedIndexChanged);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelTotal.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelTotal.Location = new System.Drawing.Point(710, 405);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(110, 37);
            this.labelTotal.TabIndex = 31;
            this.labelTotal.Text = "Total: ";
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonRR
            // 
            this.buttonRR.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonRR.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRR.ForeColor = System.Drawing.Color.AliceBlue;
            this.buttonRR.Location = new System.Drawing.Point(562, 407);
            this.buttonRR.Margin = new System.Windows.Forms.Padding(8);
            this.buttonRR.Name = "buttonRR";
            this.buttonRR.Size = new System.Drawing.Size(78, 37);
            this.buttonRR.TabIndex = 32;
            this.buttonRR.Text = ">>";
            this.buttonRR.UseVisualStyleBackColor = false;
            this.buttonRR.Click += new System.EventHandler(this.buttonRR_Click);
            // 
            // buttonL
            // 
            this.buttonL.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonL.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonL.ForeColor = System.Drawing.Color.AliceBlue;
            this.buttonL.Location = new System.Drawing.Point(464, 407);
            this.buttonL.Margin = new System.Windows.Forms.Padding(8);
            this.buttonL.Name = "buttonL";
            this.buttonL.Size = new System.Drawing.Size(79, 37);
            this.buttonL.TabIndex = 33;
            this.buttonL.Text = "<";
            this.buttonL.UseVisualStyleBackColor = false;
            this.buttonL.Click += new System.EventHandler(this.buttonL_Click);
            // 
            // buttonR
            // 
            this.buttonR.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonR.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonR.ForeColor = System.Drawing.Color.AliceBlue;
            this.buttonR.Location = new System.Drawing.Point(385, 407);
            this.buttonR.Margin = new System.Windows.Forms.Padding(8);
            this.buttonR.Name = "buttonR";
            this.buttonR.Size = new System.Drawing.Size(75, 37);
            this.buttonR.TabIndex = 34;
            this.buttonR.Text = ">";
            this.buttonR.UseVisualStyleBackColor = false;
            this.buttonR.Click += new System.EventHandler(this.buttonR_Click);
            // 
            // buttonLL
            // 
            this.buttonLL.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonLL.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLL.ForeColor = System.Drawing.Color.AliceBlue;
            this.buttonLL.Location = new System.Drawing.Point(275, 407);
            this.buttonLL.Margin = new System.Windows.Forms.Padding(8);
            this.buttonLL.Name = "buttonLL";
            this.buttonLL.Size = new System.Drawing.Size(82, 37);
            this.buttonLL.TabIndex = 35;
            this.buttonLL.Text = "<<";
            this.buttonLL.UseVisualStyleBackColor = false;
            this.buttonLL.Click += new System.EventHandler(this.buttonLL_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxID.Location = new System.Drawing.Point(271, 40);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(8);
            this.textBoxID.Multiline = true;
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(369, 26);
            this.textBoxID.TabIndex = 36;
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBox.Location = new System.Drawing.Point(271, 209);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 24);
            this.comboBox.TabIndex = 38;
            // 
            // labelSemester
            // 
            this.labelSemester.AutoSize = true;
            this.labelSemester.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSemester.Location = new System.Drawing.Point(139, 215);
            this.labelSemester.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSemester.Name = "labelSemester";
            this.labelSemester.Size = new System.Drawing.Size(103, 20);
            this.labelSemester.TabIndex = 37;
            this.labelSemester.Text = "Semester :";
            // 
            // ManageCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1573, 536);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.labelSemester);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.buttonLL);
            this.Controls.Add(this.buttonR);
            this.Controls.Add(this.buttonL);
            this.Controls.Add(this.buttonRR);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.listBoxCourse);
            this.Controls.Add(this.buttonADDCourse);
            this.Controls.Add(this.buttonRemoveCourse);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxNameCourse);
            this.Controls.Add(this.buttonEditCourse);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelHours);
            this.Controls.Add(this.labelNameCourse);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageCourseForm";
            this.Text = "ManageCourseForm";
            this.Load += new System.EventHandler(this.ManageCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxNameCourse;
        private System.Windows.Forms.Button buttonEditCourse;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.Label labelNameCourse;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button buttonADDCourse;
        private System.Windows.Forms.Button buttonRemoveCourse;
        private System.Windows.Forms.ListBox listBoxCourse;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button buttonRR;
        private System.Windows.Forms.Button buttonL;
        private System.Windows.Forms.Button buttonR;
        private System.Windows.Forms.Button buttonLL;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.ComboBox comboBox;
        public System.Windows.Forms.Label labelSemester;
    }
}