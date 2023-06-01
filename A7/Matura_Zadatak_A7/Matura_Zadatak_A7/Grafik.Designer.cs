namespace Matura_Zadatak_A7
{
    partial class Grafik
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
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.checkedListBoxPredmeti = new System.Windows.Forms.CheckedListBox();
            this.GV = new System.Windows.Forms.DataGridView();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.btnIzadji = new System.Windows.Forms.Button();
            this.graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.GV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBoxPredmeti
            // 
            this.checkedListBoxPredmeti.FormattingEnabled = true;
            this.checkedListBoxPredmeti.Location = new System.Drawing.Point(22, 23);
            this.checkedListBoxPredmeti.Name = "checkedListBoxPredmeti";
            this.checkedListBoxPredmeti.Size = new System.Drawing.Size(219, 94);
            this.checkedListBoxPredmeti.TabIndex = 0;
            this.checkedListBoxPredmeti.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxPredmeti_ItemCheck);
            // 
            // GV
            // 
            this.GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV.Location = new System.Drawing.Point(22, 145);
            this.GV.Name = "GV";
            this.GV.Size = new System.Drawing.Size(219, 123);
            this.GV.TabIndex = 1;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(22, 290);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(75, 23);
            this.btnPrikazi.TabIndex = 2;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // btnIzadji
            // 
            this.btnIzadji.Location = new System.Drawing.Point(166, 290);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(75, 23);
            this.btnIzadji.TabIndex = 3;
            this.btnIzadji.Text = "Izadji";
            this.btnIzadji.UseVisualStyleBackColor = true;
            this.btnIzadji.Click += new System.EventHandler(this.btnIzadji_Click);
            // 
            // graph
            // 
            chartArea2.Name = "ChartArea1";
            this.graph.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.graph.Legends.Add(legend2);
            this.graph.Location = new System.Drawing.Point(265, 23);
            this.graph.Name = "graph";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series4.IsValueShownAsLabel = true;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series5.IsValueShownAsLabel = true;
            series5.Legend = "Legend1";
            series5.Name = "Series2";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series6.IsValueShownAsLabel = true;
            series6.Legend = "Legend1";
            series6.Name = "Series3";
            this.graph.Series.Add(series4);
            this.graph.Series.Add(series5);
            this.graph.Series.Add(series6);
            this.graph.Size = new System.Drawing.Size(300, 300);
            this.graph.TabIndex = 4;
            // 
            // Grafik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 377);
            this.Controls.Add(this.graph);
            this.Controls.Add(this.btnIzadji);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.GV);
            this.Controls.Add(this.checkedListBoxPredmeti);
            this.Name = "Grafik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grafik";
            this.Load += new System.EventHandler(this.Grafik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxPredmeti;
        private System.Windows.Forms.DataGridView GV;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.Button btnIzadji;
        private System.Windows.Forms.DataVisualization.Charting.Chart graph;
    }
}