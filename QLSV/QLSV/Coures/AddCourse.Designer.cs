
namespace QLSV.Coures
{
    partial class AddCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCourse));
            this.TextBoxID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSemester = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelAvai = new System.Windows.Forms.Label();
            this.labelSELECT = new System.Windows.Forms.Label();
            this.buttonqua = new System.Windows.Forms.Button();
            this.buttonADD = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_Semester = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxID
            // 
            this.TextBoxID.Location = new System.Drawing.Point(143, 30);
            this.TextBoxID.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxID.Name = "TextBoxID";
            this.TextBoxID.Size = new System.Drawing.Size(136, 22);
            this.TextBoxID.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "ID Student: ";
            // 
            // labelSemester
            // 
            this.labelSemester.AutoSize = true;
            this.labelSemester.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSemester.Location = new System.Drawing.Point(418, 30);
            this.labelSemester.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSemester.Name = "labelSemester";
            this.labelSemester.Size = new System.Drawing.Size(174, 20);
            this.labelSemester.TabIndex = 29;
            this.labelSemester.Text = "SELECT Semester :";
            this.labelSemester.Click += new System.EventHandler(this.labelSemester_Click);
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBox.Location = new System.Drawing.Point(612, 30);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 24);
            this.comboBox.TabIndex = 30;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 15;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(296, 234);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // labelAvai
            // 
            this.labelAvai.AutoSize = true;
            this.labelAvai.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvai.Location = new System.Drawing.Point(95, 132);
            this.labelAvai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAvai.Name = "labelAvai";
            this.labelAvai.Size = new System.Drawing.Size(156, 20);
            this.labelAvai.TabIndex = 33;
            this.labelAvai.Text = "Available Course";
            // 
            // labelSELECT
            // 
            this.labelSELECT.AutoSize = true;
            this.labelSELECT.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSELECT.Location = new System.Drawing.Point(536, 132);
            this.labelSELECT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSELECT.Name = "labelSELECT";
            this.labelSELECT.Size = new System.Drawing.Size(158, 20);
            this.labelSELECT.TabIndex = 34;
            this.labelSELECT.Text = "Selected Course:";
            // 
            // buttonqua
            // 
            this.buttonqua.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonqua.Location = new System.Drawing.Point(357, 246);
            this.buttonqua.Name = "buttonqua";
            this.buttonqua.Size = new System.Drawing.Size(87, 45);
            this.buttonqua.TabIndex = 36;
            this.buttonqua.Text = ">>";
            this.buttonqua.UseVisualStyleBackColor = false;
            this.buttonqua.Click += new System.EventHandler(this.buttonREMOVE_Click);
            // 
            // buttonADD
            // 
            this.buttonADD.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonADD.Location = new System.Drawing.Point(357, 351);
            this.buttonADD.Name = "buttonADD";
            this.buttonADD.Size = new System.Drawing.Size(87, 45);
            this.buttonADD.TabIndex = 35;
            this.buttonADD.Text = "lưu";
            this.buttonADD.UseVisualStyleBackColor = false;
            this.buttonADD.Click += new System.EventHandler(this.buttonADD_Click);
            // 
            // buttonThem
            // 
            this.buttonThem.BackColor = System.Drawing.Color.PaleVioletRed;
            this.buttonThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThem.Location = new System.Drawing.Point(127, 410);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(87, 45);
            this.buttonThem.TabIndex = 37;
            this.buttonThem.Text = "Add";
            this.buttonThem.UseVisualStyleBackColor = false;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(651, 422);
            this.textBox_name.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_name.Multiline = true;
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(10, 10);
            this.textBox_name.TabIndex = 38;
            // 
            // textBox_Semester
            // 
            this.textBox_Semester.Location = new System.Drawing.Point(699, 455);
            this.textBox_Semester.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Semester.Multiline = true;
            this.textBox_Semester.Name = "textBox_Semester";
            this.textBox_Semester.Size = new System.Drawing.Size(10, 10);
            this.textBox_Semester.TabIndex = 39;
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(773, 422);
            this.textBox_id.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_id.Multiline = true;
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(10, 10);
            this.textBox_id.TabIndex = 40;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(488, 155);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(280, 234);
            this.listView2.TabIndex = 42;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ID";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Name_Course";
            this.columnHeader4.Width = 200;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(699, 422);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 15;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(10, 10);
            this.dataGridView2.TabIndex = 43;
            // 
            // AddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(795, 477);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.textBox_Semester);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.buttonqua);
            this.Controls.Add(this.buttonADD);
            this.Controls.Add(this.labelSELECT);
            this.Controls.Add(this.labelAvai);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.labelSemester);
            this.Controls.Add(this.TextBoxID);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Course";
            this.Load += new System.EventHandler(this.AddCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox TextBoxID;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label labelSemester;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Label labelAvai;
        public System.Windows.Forms.Label labelSELECT;
        private System.Windows.Forms.Button buttonqua;
        private System.Windows.Forms.Button buttonADD;
        private System.Windows.Forms.Button buttonThem;
        public System.Windows.Forms.TextBox textBox_name;
        public System.Windows.Forms.TextBox textBox_Semester;
        public System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}