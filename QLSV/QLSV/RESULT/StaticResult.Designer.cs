
namespace QLSV.RESULT
{
    partial class StaticResult
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaticResult));
            this.labelStatic = new System.Windows.Forms.Label();
            this.labelCSharp = new System.Windows.Forms.Label();
            this.labelJava = new System.Windows.Forms.Label();
            this.labelCloud = new System.Windows.Forms.Label();
            this.labelMachine = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.labelFail = new System.Windows.Forms.Label();
            this.Salary = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.Salary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelStatic
            // 
            this.labelStatic.AutoSize = true;
            this.labelStatic.Font = new System.Drawing.Font("Vivaldi", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatic.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelStatic.Location = new System.Drawing.Point(333, 9);
            this.labelStatic.Name = "labelStatic";
            this.labelStatic.Size = new System.Drawing.Size(568, 71);
            this.labelStatic.TabIndex = 1;
            this.labelStatic.Text = "Student Static Result ";
            // 
            // labelCSharp
            // 
            this.labelCSharp.AutoSize = true;
            this.labelCSharp.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold);
            this.labelCSharp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelCSharp.Location = new System.Drawing.Point(336, 162);
            this.labelCSharp.Name = "labelCSharp";
            this.labelCSharp.Size = new System.Drawing.Size(113, 52);
            this.labelCSharp.TabIndex = 2;
            this.labelCSharp.Text = "C#: ";
            // 
            // labelJava
            // 
            this.labelJava.AutoSize = true;
            this.labelJava.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold);
            this.labelJava.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelJava.Location = new System.Drawing.Point(308, 269);
            this.labelJava.Name = "labelJava";
            this.labelJava.Size = new System.Drawing.Size(128, 52);
            this.labelJava.TabIndex = 3;
            this.labelJava.Text = "Java:";
            // 
            // labelCloud
            // 
            this.labelCloud.AutoSize = true;
            this.labelCloud.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold);
            this.labelCloud.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelCloud.Location = new System.Drawing.Point(79, 390);
            this.labelCloud.Name = "labelCloud";
            this.labelCloud.Size = new System.Drawing.Size(369, 52);
            this.labelCloud.TabIndex = 4;
            this.labelCloud.Text = "Cloud Computing:";
            // 
            // labelMachine
            // 
            this.labelMachine.AutoSize = true;
            this.labelMachine.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold);
            this.labelMachine.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelMachine.Location = new System.Drawing.Point(61, 511);
            this.labelMachine.Name = "labelMachine";
            this.labelMachine.Size = new System.Drawing.Size(375, 52);
            this.labelMachine.TabIndex = 5;
            this.labelMachine.Text = "Machine Learning:";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelPass.Location = new System.Drawing.Point(604, 165);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(108, 40);
            this.labelPass.TabIndex = 6;
            this.labelPass.Text = "Pass: ";
            // 
            // labelFail
            // 
            this.labelFail.AutoSize = true;
            this.labelFail.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelFail.Location = new System.Drawing.Point(604, 244);
            this.labelFail.Name = "labelFail";
            this.labelFail.Size = new System.Drawing.Size(97, 40);
            this.labelFail.TabIndex = 7;
            this.labelFail.Text = "Fail: ";
            // 
            // Salary
            // 
            chartArea1.Name = "ChartArea1";
            this.Salary.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Salary.Legends.Add(legend1);
            this.Salary.Location = new System.Drawing.Point(899, 128);
            this.Salary.Name = "Salary";
            this.Salary.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Điểm";
            this.Salary.Series.Add(series1);
            this.Salary.Size = new System.Drawing.Size(519, 263);
            this.Salary.TabIndex = 8;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(899, 426);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            this.chart1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Phần trăm";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(519, 263);
            this.chart1.TabIndex = 9;
            // 
            // StaticResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1536, 739);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.Salary);
            this.Controls.Add(this.labelFail);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelMachine);
            this.Controls.Add(this.labelCloud);
            this.Controls.Add(this.labelJava);
            this.Controls.Add(this.labelCSharp);
            this.Controls.Add(this.labelStatic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StaticResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Static Result";
            this.Load += new System.EventHandler(this.StaticResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Salary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStatic;
        private System.Windows.Forms.Label labelCSharp;
        private System.Windows.Forms.Label labelJava;
        private System.Windows.Forms.Label labelCloud;
        private System.Windows.Forms.Label labelMachine;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Label labelFail;
        private System.Windows.Forms.DataVisualization.Charting.Chart Salary;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}