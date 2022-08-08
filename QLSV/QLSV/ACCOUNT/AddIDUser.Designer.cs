
namespace QLSV.ACCOUNT
{
    partial class AddIDUser
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.buttonUPDATE = new System.Windows.Forms.Button();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.Beige;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView.Location = new System.Drawing.Point(172, 123);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(715, 351);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.Click += new System.EventHandler(this.dataGridView_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.BackColor = System.Drawing.Color.YellowGreen;
            this.textBoxID.Location = new System.Drawing.Point(172, 72);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.textBoxID.Multiline = true;
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(315, 37);
            this.textBoxID.TabIndex = 31;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.BackColor = System.Drawing.Color.DarkCyan;
            this.labelID.Font = new System.Drawing.Font("Footlight MT Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.labelID.Location = new System.Drawing.Point(31, 79);
            this.labelID.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(121, 30);
            this.labelID.TabIndex = 30;
            this.labelID.Text = "User  ID: ";
            // 
            // buttonUPDATE
            // 
            this.buttonUPDATE.BackColor = System.Drawing.Color.DarkGray;
            this.buttonUPDATE.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUPDATE.ForeColor = System.Drawing.Color.Blue;
            this.buttonUPDATE.Location = new System.Drawing.Point(172, 480);
            this.buttonUPDATE.Name = "buttonUPDATE";
            this.buttonUPDATE.Size = new System.Drawing.Size(715, 58);
            this.buttonUPDATE.TabIndex = 37;
            this.buttonUPDATE.Text = "--- UPDATE ID ---";
            this.buttonUPDATE.UseVisualStyleBackColor = false;
            this.buttonUPDATE.Click += new System.EventHandler(this.buttonUPDATE_Click);
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.BackColor = System.Drawing.Color.YellowGreen;
            this.textBoxUserName.Location = new System.Drawing.Point(5, 582);
            this.textBoxUserName.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.textBoxUserName.Multiline = true;
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(10, 10);
            this.textBoxUserName.TabIndex = 38;
            // 
            // AddIDUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 599);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.buttonUPDATE);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.dataGridView);
            this.Name = "AddIDUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddIDUser";
            this.Load += new System.EventHandler(this.AddIDUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button buttonUPDATE;
        private System.Windows.Forms.TextBox textBoxUserName;
    }
}