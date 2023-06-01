namespace Matura_Zadatak_A10
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GV = new System.Windows.Forms.DataGridView();
            this.dateTimePickerOD = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDO = new System.Windows.Forms.DateTimePicker();
            this.cbPecaros = new System.Windows.Forms.ComboBox();
            this.graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pecaros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Od datuma";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Do datuma";
            // 
            // GV
            // 
            this.GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV.Location = new System.Drawing.Point(16, 120);
            this.GV.MultiSelect = false;
            this.GV.Name = "GV";
            this.GV.Size = new System.Drawing.Size(240, 244);
            this.GV.TabIndex = 3;
            // 
            // dateTimePickerOD
            // 
            this.dateTimePickerOD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerOD.Location = new System.Drawing.Point(79, 49);
            this.dateTimePickerOD.Name = "dateTimePickerOD";
            this.dateTimePickerOD.Size = new System.Drawing.Size(141, 20);
            this.dateTimePickerOD.TabIndex = 4;
            // 
            // dateTimePickerDO
            // 
            this.dateTimePickerDO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDO.Location = new System.Drawing.Point(79, 82);
            this.dateTimePickerDO.Name = "dateTimePickerDO";
            this.dateTimePickerDO.Size = new System.Drawing.Size(141, 20);
            this.dateTimePickerDO.TabIndex = 5;
            // 
            // cbPecaros
            // 
            this.cbPecaros.FormattingEnabled = true;
            this.cbPecaros.Location = new System.Drawing.Point(66, 13);
            this.cbPecaros.Name = "cbPecaros";
            this.cbPecaros.Size = new System.Drawing.Size(154, 21);
            this.cbPecaros.TabIndex = 6;
            // 
            // graph
            // 
            chartArea1.Name = "ChartArea1";
            this.graph.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.graph.Legends.Add(legend1);
            this.graph.Location = new System.Drawing.Point(283, 64);
            this.graph.Name = "graph";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.graph.Series.Add(series1);
            this.graph.Size = new System.Drawing.Size(300, 300);
            this.graph.TabIndex = 7;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(392, 13);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(79, 38);
            this.btnPrikazi.TabIndex = 8;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(488, 13);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(82, 38);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Izadji";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Analiza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 376);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.graph);
            this.Controls.Add(this.cbPecaros);
            this.Controls.Add(this.dateTimePickerDO);
            this.Controls.Add(this.dateTimePickerOD);
            this.Controls.Add(this.GV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Analiza";
            this.Text = "Analiza";
            ((System.ComponentModel.ISupportInitialize)(this.GV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView GV;
        private System.Windows.Forms.DateTimePicker dateTimePickerOD;
        private System.Windows.Forms.DateTimePicker dateTimePickerDO;
        private System.Windows.Forms.ComboBox cbPecaros;
        private System.Windows.Forms.DataVisualization.Charting.Chart graph;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.Button btnExit;
    }
}