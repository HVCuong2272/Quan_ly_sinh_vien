
namespace QLSV.ACCOUT
{
    partial class ManageAccout
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageAccout));
            this.loginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDBDataSet = new QLSV.myDBDataSet();
            this.loginTableAdapter = new QLSV.myDBDataSetTableAdapters.LoginTableAdapter();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.labelPass = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDEL = new System.Windows.Forms.Button();
            this.buttonUPDATE = new System.Windows.Forms.Button();
            this.labelReset = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonAddInfo = new System.Windows.Forms.Button();
            this.labelDecentralization = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // loginBindingSource
            // 
            this.loginBindingSource.DataMember = "Login";
            this.loginBindingSource.DataSource = this.myDBDataSet;
            // 
            // myDBDataSet
            // 
            this.myDBDataSet.DataSetName = "myDBDataSet";
            this.myDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginTableAdapter
            // 
            this.loginTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.Beige;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView.Location = new System.Drawing.Point(508, 64);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(770, 351);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridView.Click += new System.EventHandler(this.dataGridView_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.BackColor = System.Drawing.Color.YellowGreen;
            this.textBoxID.Location = new System.Drawing.Point(241, 64);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.textBoxID.Multiline = true;
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(254, 37);
            this.textBoxID.TabIndex = 29;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.BackColor = System.Drawing.Color.DarkCyan;
            this.labelID.Font = new System.Drawing.Font("Footlight MT Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.labelID.Location = new System.Drawing.Point(3, 71);
            this.labelID.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(121, 30);
            this.labelID.TabIndex = 28;
            this.labelID.Text = "User  ID: ";
            this.labelID.Click += new System.EventHandler(this.labelID_Click);
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.BackColor = System.Drawing.Color.YellowGreen;
            this.textBoxUserName.Location = new System.Drawing.Point(241, 144);
            this.textBoxUserName.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.textBoxUserName.Multiline = true;
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(254, 37);
            this.textBoxUserName.TabIndex = 31;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.DarkCyan;
            this.labelUsername.Font = new System.Drawing.Font("Footlight MT Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.labelUsername.Location = new System.Drawing.Point(-3, 151);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(145, 30);
            this.labelUsername.TabIndex = 30;
            this.labelUsername.Text = "User Name:";
            this.labelUsername.Click += new System.EventHandler(this.labelUsername_Click);
            // 
            // textBoxPass
            // 
            this.textBoxPass.BackColor = System.Drawing.Color.YellowGreen;
            this.textBoxPass.Location = new System.Drawing.Point(241, 219);
            this.textBoxPass.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.textBoxPass.Multiline = true;
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(254, 37);
            this.textBoxPass.TabIndex = 33;
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.BackColor = System.Drawing.Color.DarkCyan;
            this.labelPass.Font = new System.Drawing.Font("Footlight MT Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPass.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.labelPass.Location = new System.Drawing.Point(-3, 226);
            this.labelPass.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(127, 30);
            this.labelPass.TabIndex = 32;
            this.labelPass.Text = "Password:";
            this.labelPass.Click += new System.EventHandler(this.labelPass_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.DarkGray;
            this.buttonAdd.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.Blue;
            this.buttonAdd.Location = new System.Drawing.Point(31, 348);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(129, 57);
            this.buttonAdd.TabIndex = 34;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDEL
            // 
            this.buttonDEL.BackColor = System.Drawing.Color.DarkGray;
            this.buttonDEL.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDEL.ForeColor = System.Drawing.Color.Blue;
            this.buttonDEL.Location = new System.Drawing.Point(166, 348);
            this.buttonDEL.Name = "buttonDEL";
            this.buttonDEL.Size = new System.Drawing.Size(129, 57);
            this.buttonDEL.TabIndex = 35;
            this.buttonDEL.Text = "DELETE";
            this.buttonDEL.UseVisualStyleBackColor = false;
            this.buttonDEL.Click += new System.EventHandler(this.buttonDEL_Click);
            // 
            // buttonUPDATE
            // 
            this.buttonUPDATE.BackColor = System.Drawing.Color.DarkGray;
            this.buttonUPDATE.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUPDATE.ForeColor = System.Drawing.Color.Blue;
            this.buttonUPDATE.Location = new System.Drawing.Point(301, 348);
            this.buttonUPDATE.Name = "buttonUPDATE";
            this.buttonUPDATE.Size = new System.Drawing.Size(129, 58);
            this.buttonUPDATE.TabIndex = 36;
            this.buttonUPDATE.Text = "UPDATE";
            this.buttonUPDATE.UseVisualStyleBackColor = false;
            this.buttonUPDATE.Click += new System.EventHandler(this.buttonUPDATE_Click);
            // 
            // labelReset
            // 
            this.labelReset.AutoSize = true;
            this.labelReset.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReset.ForeColor = System.Drawing.Color.Crimson;
            this.labelReset.Location = new System.Drawing.Point(1190, 9);
            this.labelReset.Name = "labelReset";
            this.labelReset.Size = new System.Drawing.Size(88, 36);
            this.labelReset.TabIndex = 37;
            this.labelReset.Text = "Reset";
            this.labelReset.Click += new System.EventHandler(this.labelReset_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button1.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(563, 447);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(266, 42);
            this.button1.TabIndex = 39;
            this.button1.Text = "ADD or UPDATE ID";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAddInfo
            // 
            this.buttonAddInfo.BackColor = System.Drawing.Color.DarkMagenta;
            this.buttonAddInfo.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddInfo.ForeColor = System.Drawing.Color.Chartreuse;
            this.buttonAddInfo.Location = new System.Drawing.Point(22, 466);
            this.buttonAddInfo.Name = "buttonAddInfo";
            this.buttonAddInfo.Size = new System.Drawing.Size(399, 42);
            this.buttonAddInfo.TabIndex = 40;
            this.buttonAddInfo.Text = "Add Information User ";
            this.buttonAddInfo.UseVisualStyleBackColor = false;
            this.buttonAddInfo.Click += new System.EventHandler(this.buttonAddInfo_Click);
            // 
            // labelDecentralization
            // 
            this.labelDecentralization.AutoSize = true;
            this.labelDecentralization.BackColor = System.Drawing.Color.DarkCyan;
            this.labelDecentralization.Font = new System.Drawing.Font("Footlight MT Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDecentralization.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.labelDecentralization.Location = new System.Drawing.Point(-3, 288);
            this.labelDecentralization.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.labelDecentralization.Name = "labelDecentralization";
            this.labelDecentralization.Size = new System.Drawing.Size(211, 30);
            this.labelDecentralization.TabIndex = 41;
            this.labelDecentralization.Text = "Decentralization:";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.YellowGreen;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(241, 285);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(254, 33);
            this.comboBox1.TabIndex = 42;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ManageAccout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1353, 557);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelDecentralization);
            this.Controls.Add(this.buttonAddInfo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelReset);
            this.Controls.Add(this.buttonUPDATE);
            this.Controls.Add(this.buttonDEL);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.dataGridView);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageAccout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageAccout";
            this.Load += new System.EventHandler(this.ManageAccout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private myDBDataSet myDBDataSet;
        private System.Windows.Forms.BindingSource loginBindingSource;
        private myDBDataSetTableAdapters.LoginTableAdapter loginTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDEL;
        private System.Windows.Forms.Button buttonUPDATE;
        private System.Windows.Forms.Label labelReset;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonAddInfo;
        private System.Windows.Forms.Label labelDecentralization;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}