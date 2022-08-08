
namespace QLSV.Coures
{
    partial class AddCourseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCourseForm));
            this.labelNameCourse = new System.Windows.Forms.Label();
            this.labelHours = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.buttonAddCourse = new System.Windows.Forms.Button();
            this.textBoxNameCourse = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.numericUpDownHours = new System.Windows.Forms.NumericUpDown();
            this.labelIDCourse = new System.Windows.Forms.Label();
            this.textBoxIDCourse = new System.Windows.Forms.TextBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.labelSemester = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNameCourse
            // 
            this.labelNameCourse.AutoSize = true;
            this.labelNameCourse.Location = new System.Drawing.Point(13, 138);
            this.labelNameCourse.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelNameCourse.Name = "labelNameCourse";
            this.labelNameCourse.Size = new System.Drawing.Size(210, 31);
            this.labelNameCourse.TabIndex = 0;
            this.labelNameCourse.Text = "Name Of Course:";
            this.labelNameCourse.Click += new System.EventHandler(this.labelNameCourse_Click);
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.Location = new System.Drawing.Point(125, 222);
            this.labelHours.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(98, 31);
            this.labelHours.TabIndex = 1;
            this.labelHours.Text = "Hours: ";
            this.labelHours.Click += new System.EventHandler(this.labelHours_Click);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(74, 292);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(149, 31);
            this.labelDescription.TabIndex = 2;
            this.labelDescription.Text = "Desciption: ";
            this.labelDescription.Click += new System.EventHandler(this.labelDescription_Click);
            // 
            // buttonAddCourse
            // 
            this.buttonAddCourse.BackColor = System.Drawing.Color.DarkMagenta;
            this.buttonAddCourse.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddCourse.ForeColor = System.Drawing.Color.AliceBlue;
            this.buttonAddCourse.Location = new System.Drawing.Point(232, 433);
            this.buttonAddCourse.Margin = new System.Windows.Forms.Padding(5);
            this.buttonAddCourse.Name = "buttonAddCourse";
            this.buttonAddCourse.Size = new System.Drawing.Size(427, 58);
            this.buttonAddCourse.TabIndex = 3;
            this.buttonAddCourse.Text = "ADD COURSE";
            this.buttonAddCourse.UseVisualStyleBackColor = false;
            this.buttonAddCourse.Click += new System.EventHandler(this.buttonAddCourse_Click);
            // 
            // textBoxNameCourse
            // 
            this.textBoxNameCourse.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxNameCourse.Location = new System.Drawing.Point(232, 124);
            this.textBoxNameCourse.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxNameCourse.Name = "textBoxNameCourse";
            this.textBoxNameCourse.Size = new System.Drawing.Size(427, 45);
            this.textBoxNameCourse.TabIndex = 4;
            this.textBoxNameCourse.TextChanged += new System.EventHandler(this.textBoxNameCourse_TextChanged);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxDescription.Location = new System.Drawing.Point(233, 292);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(427, 114);
            this.textBoxDescription.TabIndex = 5;
            this.textBoxDescription.TextChanged += new System.EventHandler(this.textBoxDescription_TextChanged);
            // 
            // numericUpDownHours
            // 
            this.numericUpDownHours.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.numericUpDownHours.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDownHours.Location = new System.Drawing.Point(232, 212);
            this.numericUpDownHours.Margin = new System.Windows.Forms.Padding(5);
            this.numericUpDownHours.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownHours.Name = "numericUpDownHours";
            this.numericUpDownHours.Size = new System.Drawing.Size(157, 41);
            this.numericUpDownHours.TabIndex = 6;
            this.numericUpDownHours.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownHours.ValueChanged += new System.EventHandler(this.numericUpDownHours_ValueChanged);
            // 
            // labelIDCourse
            // 
            this.labelIDCourse.AutoSize = true;
            this.labelIDCourse.Location = new System.Drawing.Point(42, 71);
            this.labelIDCourse.Name = "labelIDCourse";
            this.labelIDCourse.Size = new System.Drawing.Size(143, 31);
            this.labelIDCourse.TabIndex = 7;
            this.labelIDCourse.Text = "ID Course: ";
            this.labelIDCourse.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxIDCourse
            // 
            this.textBoxIDCourse.BackColor = System.Drawing.Color.Wheat;
            this.textBoxIDCourse.Location = new System.Drawing.Point(233, 57);
            this.textBoxIDCourse.Name = "textBoxIDCourse";
            this.textBoxIDCourse.Size = new System.Drawing.Size(156, 45);
            this.textBoxIDCourse.TabIndex = 8;
            this.textBoxIDCourse.TextChanged += new System.EventHandler(this.textBoxIDCourse_TextChanged);
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBox.Location = new System.Drawing.Point(618, 40);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 37);
            this.comboBox.TabIndex = 32;
            // 
            // labelSemester
            // 
            this.labelSemester.AutoSize = true;
            this.labelSemester.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSemester.Location = new System.Drawing.Point(486, 57);
            this.labelSemester.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSemester.Name = "labelSemester";
            this.labelSemester.Size = new System.Drawing.Size(103, 20);
            this.labelSemester.TabIndex = 31;
            this.labelSemester.Text = "Semester :";
            // 
            // AddCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(905, 545);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.labelSemester);
            this.Controls.Add(this.textBoxIDCourse);
            this.Controls.Add(this.labelIDCourse);
            this.Controls.Add(this.numericUpDownHours);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxNameCourse);
            this.Controls.Add(this.buttonAddCourse);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelHours);
            this.Controls.Add(this.labelNameCourse);
            this.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Yellow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddCourseForm";
            this.Text = "AddCourseForm";
            this.Load += new System.EventHandler(this.AddCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNameCourse;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Button buttonAddCourse;
        private System.Windows.Forms.TextBox textBoxNameCourse;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.NumericUpDown numericUpDownHours;
        private System.Windows.Forms.Label labelIDCourse;
        private System.Windows.Forms.TextBox textBoxIDCourse;
        private System.Windows.Forms.ComboBox comboBox;
        public System.Windows.Forms.Label labelSemester;
    }
}