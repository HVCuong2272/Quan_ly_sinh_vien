
namespace QLSV.Coures
{
    partial class EditCourseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCourseForm));
            this.labelSelectCourse = new System.Windows.Forms.Label();
            this.numericUpDownHours = new System.Windows.Forms.NumericUpDown();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxNameCourse = new System.Windows.Forms.TextBox();
            this.buttonEditCourse = new System.Windows.Forms.Button();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelHours = new System.Windows.Forms.Label();
            this.labelNameCourse = new System.Windows.Forms.Label();
            this.comboBoxCourse = new System.Windows.Forms.ComboBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.labelSemester = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSelectCourse
            // 
            this.labelSelectCourse.AutoSize = true;
            this.labelSelectCourse.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectCourse.Location = new System.Drawing.Point(220, 59);
            this.labelSelectCourse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSelectCourse.Name = "labelSelectCourse";
            this.labelSelectCourse.Size = new System.Drawing.Size(220, 37);
            this.labelSelectCourse.TabIndex = 16;
            this.labelSelectCourse.Text = "Select Course: ";
            // 
            // numericUpDownHours
            // 
            this.numericUpDownHours.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.numericUpDownHours.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDownHours.Location = new System.Drawing.Point(444, 189);
            this.numericUpDownHours.Margin = new System.Windows.Forms.Padding(8);
            this.numericUpDownHours.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownHours.Name = "numericUpDownHours";
            this.numericUpDownHours.Size = new System.Drawing.Size(236, 36);
            this.numericUpDownHours.TabIndex = 15;
            this.numericUpDownHours.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxDescription.Location = new System.Drawing.Point(444, 323);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(8);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(638, 183);
            this.textBoxDescription.TabIndex = 14;
            // 
            // textBoxNameCourse
            // 
            this.textBoxNameCourse.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxNameCourse.Location = new System.Drawing.Point(444, 122);
            this.textBoxNameCourse.Margin = new System.Windows.Forms.Padding(8);
            this.textBoxNameCourse.Name = "textBoxNameCourse";
            this.textBoxNameCourse.Size = new System.Drawing.Size(638, 40);
            this.textBoxNameCourse.TabIndex = 13;
            // 
            // buttonEditCourse
            // 
            this.buttonEditCourse.BackColor = System.Drawing.Color.DarkMagenta;
            this.buttonEditCourse.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditCourse.ForeColor = System.Drawing.Color.AliceBlue;
            this.buttonEditCourse.Location = new System.Drawing.Point(444, 522);
            this.buttonEditCourse.Margin = new System.Windows.Forms.Padding(8);
            this.buttonEditCourse.Name = "buttonEditCourse";
            this.buttonEditCourse.Size = new System.Drawing.Size(640, 94);
            this.buttonEditCourse.TabIndex = 12;
            this.buttonEditCourse.Text = "EDIT COURSE";
            this.buttonEditCourse.UseVisualStyleBackColor = false;
            this.buttonEditCourse.Click += new System.EventHandler(this.buttonEditCourse_Click);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(267, 320);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(173, 37);
            this.labelDescription.TabIndex = 11;
            this.labelDescription.Text = "Desciption: ";
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHours.Location = new System.Drawing.Point(324, 189);
            this.labelHours.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(116, 37);
            this.labelHours.TabIndex = 10;
            this.labelHours.Text = "Hours: ";
            // 
            // labelNameCourse
            // 
            this.labelNameCourse.AutoSize = true;
            this.labelNameCourse.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameCourse.Location = new System.Drawing.Point(182, 125);
            this.labelNameCourse.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelNameCourse.Name = "labelNameCourse";
            this.labelNameCourse.Size = new System.Drawing.Size(246, 37);
            this.labelNameCourse.TabIndex = 9;
            this.labelNameCourse.Text = "Name Of Course:";
            // 
            // comboBoxCourse
            // 
            this.comboBoxCourse.FormattingEnabled = true;
            this.comboBoxCourse.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comboBoxCourse.Location = new System.Drawing.Point(444, 59);
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.Size = new System.Drawing.Size(388, 34);
            this.comboBoxCourse.TabIndex = 17;
            this.comboBoxCourse.SelectedIndexChanged += new System.EventHandler(this.comboBoxCourse_SelectedIndexChanged);
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBox.Location = new System.Drawing.Point(444, 249);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 34);
            this.comboBox.TabIndex = 40;
            // 
            // labelSemester
            // 
            this.labelSemester.AutoSize = true;
            this.labelSemester.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSemester.Location = new System.Drawing.Point(312, 255);
            this.labelSemester.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSemester.Name = "labelSemester";
            this.labelSemester.Size = new System.Drawing.Size(103, 20);
            this.labelSemester.TabIndex = 39;
            this.labelSemester.Text = "Semester :";
            // 
            // EditCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1183, 633);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.labelSemester);
            this.Controls.Add(this.comboBoxCourse);
            this.Controls.Add(this.labelSelectCourse);
            this.Controls.Add(this.numericUpDownHours);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxNameCourse);
            this.Controls.Add(this.buttonEditCourse);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelHours);
            this.Controls.Add(this.labelNameCourse);
            this.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EditCourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditCourseForm";
            this.Load += new System.EventHandler(this.EditCourseForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelSelectCourse;
        private System.Windows.Forms.NumericUpDown numericUpDownHours;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxNameCourse;
        private System.Windows.Forms.Button buttonEditCourse;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.Label labelNameCourse;
        private System.Windows.Forms.ComboBox comboBoxCourse;
        private System.Windows.Forms.ComboBox comboBox;
        public System.Windows.Forms.Label labelSemester;
    }
}