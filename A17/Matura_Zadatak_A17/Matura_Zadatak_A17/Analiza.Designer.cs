namespace Matura_Zadatak_A17
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
            this.cbModel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrikaz = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.GV = new System.Windows.Forms.DataGridView();
            this.graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.GV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).BeginInit();
            this.SuspendLayout();
            // 
            // cbModel
            // 
            this.cbModel.FormattingEnabled = true;
            this.cbModel.Location = new System.Drawing.Point(29, 50);
            this.cbModel.Name = "cbModel";
            this.cbModel.Size = new System.Drawing.Size(168, 21);
            this.cbModel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Model :";
            // 
            // btnPrikaz
            // 
            this.btnPrikaz.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPrikaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikaz.ForeColor = System.Drawing.Color.White;
            this.btnPrikaz.Location = new System.Drawing.Point(226, 38);
            this.btnPrikaz.Name = "btnPrikaz";
            this.btnPrikaz.Size = new System.Drawing.Size(89, 33);
            this.btnPrikaz.TabIndex = 2;
            this.btnPrikaz.Text = "Prikazi";
            this.btnPrikaz.UseVisualStyleBackColor = false;
            this.btnPrikaz.Click += new System.EventHandler(this.btnPrikaz_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(29, 351);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 33);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Izadji";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // GV
            // 
            this.GV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV.Location = new System.Drawing.Point(29, 108);
            this.GV.Name = "GV";
            this.GV.ReadOnly = true;
            this.GV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GV.Size = new System.Drawing.Size(286, 224);
            this.GV.TabIndex = 4;
            // 
            // graph
            // 
            chartArea1.Name = "ChartArea1";
            this.graph.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.graph.Legends.Add(legend1);
            this.graph.Location = new System.Drawing.Point(358, 21);
            this.graph.Name = "graph";
            this.graph.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.graph.Series.Add(series1);
            this.graph.Size = new System.Drawing.Size(356, 311);
            this.graph.TabIndex = 5;
            this.graph.Text = "chart1";
            // 
            // Analiza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(736, 455);
            this.Controls.Add(this.graph);
            this.Controls.Add(this.GV);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPrikaz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbModel);
            this.Name = "Analiza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prosecna cena automobila po godini proizvodnje";
            this.Load += new System.EventHandler(this.Analiza_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbModel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrikaz;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView GV;
        private System.Windows.Forms.DataVisualization.Charting.Chart graph;
    }
}