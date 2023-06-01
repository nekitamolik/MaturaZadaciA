namespace Matura_Zadatak_A29
{
    partial class Analiza
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
            this.GV = new System.Windows.Forms.DataGridView();
            this.PieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbGodinaDO = new System.Windows.Forms.TextBox();
            this.tbGodinaOD = new System.Windows.Forms.TextBox();
            this.cbMesecDO = new System.Windows.Forms.ComboBox();
            this.cbMesecOD = new System.Windows.Forms.ComboBox();
            this.cbDanDO = new System.Windows.Forms.ComboBox();
            this.cbDanOD = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPrikaz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PieChart)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GV
            // 
            this.GV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV.Location = new System.Drawing.Point(3, 144);
            this.GV.MultiSelect = false;
            this.GV.Name = "GV";
            this.GV.ReadOnly = true;
            this.GV.Size = new System.Drawing.Size(400, 300);
            this.GV.TabIndex = 0;
            // 
            // PieChart
            // 
            chartArea1.Name = "ChartArea1";
            this.PieChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.PieChart.Legends.Add(legend1);
            this.PieChart.Location = new System.Drawing.Point(409, 144);
            this.PieChart.Name = "PieChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            this.PieChart.Series.Add(series1);
            this.PieChart.Size = new System.Drawing.Size(448, 300);
            this.PieChart.TabIndex = 1;
            this.PieChart.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.tbGodinaDO);
            this.panel1.Controls.Add(this.tbGodinaOD);
            this.panel1.Controls.Add(this.cbMesecDO);
            this.panel1.Controls.Add(this.cbMesecOD);
            this.panel1.Controls.Add(this.cbDanDO);
            this.panel1.Controls.Add(this.cbDanOD);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnPrikaz);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(3, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 142);
            this.panel1.TabIndex = 2;
            // 
            // tbGodinaDO
            // 
            this.tbGodinaDO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGodinaDO.ForeColor = System.Drawing.Color.DarkRed;
            this.tbGodinaDO.Location = new System.Drawing.Point(206, 106);
            this.tbGodinaDO.Name = "tbGodinaDO";
            this.tbGodinaDO.Size = new System.Drawing.Size(64, 21);
            this.tbGodinaDO.TabIndex = 24;
            // 
            // tbGodinaOD
            // 
            this.tbGodinaOD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGodinaOD.ForeColor = System.Drawing.Color.DarkRed;
            this.tbGodinaOD.Location = new System.Drawing.Point(206, 70);
            this.tbGodinaOD.Name = "tbGodinaOD";
            this.tbGodinaOD.Size = new System.Drawing.Size(64, 21);
            this.tbGodinaOD.TabIndex = 23;
            // 
            // cbMesecDO
            // 
            this.cbMesecDO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMesecDO.ForeColor = System.Drawing.Color.DarkRed;
            this.cbMesecDO.FormattingEnabled = true;
            this.cbMesecDO.Location = new System.Drawing.Point(135, 106);
            this.cbMesecDO.Name = "cbMesecDO";
            this.cbMesecDO.Size = new System.Drawing.Size(42, 23);
            this.cbMesecDO.TabIndex = 22;
            // 
            // cbMesecOD
            // 
            this.cbMesecOD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMesecOD.ForeColor = System.Drawing.Color.DarkRed;
            this.cbMesecOD.FormattingEnabled = true;
            this.cbMesecOD.Location = new System.Drawing.Point(135, 70);
            this.cbMesecOD.Name = "cbMesecOD";
            this.cbMesecOD.Size = new System.Drawing.Size(42, 23);
            this.cbMesecOD.TabIndex = 21;
            // 
            // cbDanDO
            // 
            this.cbDanDO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDanDO.ForeColor = System.Drawing.Color.DarkRed;
            this.cbDanDO.FormattingEnabled = true;
            this.cbDanDO.Location = new System.Drawing.Point(63, 106);
            this.cbDanDO.Name = "cbDanDO";
            this.cbDanDO.Size = new System.Drawing.Size(42, 23);
            this.cbDanDO.TabIndex = 20;
            // 
            // cbDanOD
            // 
            this.cbDanOD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDanOD.ForeColor = System.Drawing.Color.DarkRed;
            this.cbDanOD.FormattingEnabled = true;
            this.cbDanOD.Location = new System.Drawing.Point(63, 70);
            this.cbDanOD.Name = "cbDanOD";
            this.cbDanOD.Size = new System.Drawing.Size(42, 23);
            this.cbDanOD.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Do";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Od";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(212, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Godina";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(132, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Mesec";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Dan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Odaberite vremenski interval:";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.SteelBlue;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(659, 58);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(121, 42);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "IZAĐI";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPrikaz
            // 
            this.btnPrikaz.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPrikaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikaz.ForeColor = System.Drawing.Color.White;
            this.btnPrikaz.Location = new System.Drawing.Point(474, 57);
            this.btnPrikaz.Name = "btnPrikaz";
            this.btnPrikaz.Size = new System.Drawing.Size(121, 42);
            this.btnPrikaz.TabIndex = 11;
            this.btnPrikaz.Text = "PRIKAŽI";
            this.btnPrikaz.UseVisualStyleBackColor = false;
            this.btnPrikaz.Click += new System.EventHandler(this.btnPrikaz_Click);
            // 
            // Analiza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(857, 446);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PieChart);
            this.Controls.Add(this.GV);
            this.Name = "Analiza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analiza";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Analiza_FormClosed);
            this.Load += new System.EventHandler(this.Analiza_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PieChart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GV;
        private System.Windows.Forms.DataVisualization.Charting.Chart PieChart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbGodinaDO;
        private System.Windows.Forms.TextBox tbGodinaOD;
        private System.Windows.Forms.ComboBox cbMesecDO;
        private System.Windows.Forms.ComboBox cbMesecOD;
        private System.Windows.Forms.ComboBox cbDanDO;
        private System.Windows.Forms.ComboBox cbDanOD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPrikaz;
    }
}