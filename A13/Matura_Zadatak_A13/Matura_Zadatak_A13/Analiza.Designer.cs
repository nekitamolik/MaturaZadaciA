namespace Matura_Zadatak_A13
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.GV = new System.Windows.Forms.DataGridView();
            this.graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnPrikaz = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).BeginInit();
            this.SuspendLayout();
            // 
            // GV
            // 
            this.GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV.Location = new System.Drawing.Point(13, 13);
            this.GV.Name = "GV";
            this.GV.Size = new System.Drawing.Size(358, 348);
            this.GV.TabIndex = 0;
            // 
            // graph
            // 
            chartArea2.Name = "ChartArea1";
            this.graph.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.graph.Legends.Add(legend2);
            this.graph.Location = new System.Drawing.Point(378, 13);
            this.graph.Name = "graph";
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            series2.ChartArea = "ChartArea1";
            series2.IsValueShownAsLabel = true;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.MarkerColor = System.Drawing.Color.Transparent;
            series2.Name = "Series1";
            series2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            this.graph.Series.Add(series2);
            this.graph.Size = new System.Drawing.Size(491, 468);
            this.graph.TabIndex = 1;
            this.graph.Text = "chart1";
            // 
            // btnPrikaz
            // 
            this.btnPrikaz.Location = new System.Drawing.Point(28, 390);
            this.btnPrikaz.Name = "btnPrikaz";
            this.btnPrikaz.Size = new System.Drawing.Size(95, 59);
            this.btnPrikaz.TabIndex = 2;
            this.btnPrikaz.Text = "Prikazi";
            this.btnPrikaz.UseVisualStyleBackColor = true;
            this.btnPrikaz.Click += new System.EventHandler(this.btnPrikaz_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(227, 390);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 59);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Izlaz";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Analiza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 493);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPrikaz);
            this.Controls.Add(this.graph);
            this.Controls.Add(this.GV);
            this.Name = "Analiza";
            this.Text = "Analiza";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Analiza_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.GV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GV;
        private System.Windows.Forms.DataVisualization.Charting.Chart graph;
        private System.Windows.Forms.Button btnPrikaz;
        private System.Windows.Forms.Button btnExit;
    }
}