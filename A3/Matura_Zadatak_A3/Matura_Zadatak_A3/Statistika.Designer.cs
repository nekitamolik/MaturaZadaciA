namespace Matura_Zadatak_A3
{
    partial class Statistika
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
            this.numericUpDownGodineStarostiProjekta = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.GV = new System.Windows.Forms.DataGridView();
            this.ChartProjekat = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGodineStarostiProjekta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartProjekat)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownGodineStarostiProjekta
            // 
            this.numericUpDownGodineStarostiProjekta.Location = new System.Drawing.Point(127, 27);
            this.numericUpDownGodineStarostiProjekta.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownGodineStarostiProjekta.Name = "numericUpDownGodineStarostiProjekta";
            this.numericUpDownGodineStarostiProjekta.ReadOnly = true;
            this.numericUpDownGodineStarostiProjekta.Size = new System.Drawing.Size(38, 20);
            this.numericUpDownGodineStarostiProjekta.TabIndex = 0;
            this.numericUpDownGodineStarostiProjekta.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownGodineStarostiProjekta.ValueChanged += new System.EventHandler(this.numericUpDownGodineStarostiProjekta_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "\"Starost\" projekta :";
            // 
            // GV
            // 
            this.GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV.Location = new System.Drawing.Point(12, 75);
            this.GV.Name = "GV";
            this.GV.Size = new System.Drawing.Size(288, 266);
            this.GV.TabIndex = 2;
            // 
            // ChartProjekat
            // 
            chartArea1.Name = "ChartArea1";
            this.ChartProjekat.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChartProjekat.Legends.Add(legend1);
            this.ChartProjekat.Location = new System.Drawing.Point(338, 41);
            this.ChartProjekat.Name = "ChartProjekat";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "projekti";
            this.ChartProjekat.Series.Add(series1);
            this.ChartProjekat.Size = new System.Drawing.Size(300, 300);
            this.ChartProjekat.TabIndex = 3;
            this.ChartProjekat.Text = "chart1";
            // 
            // Statistika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 367);
            this.Controls.Add(this.ChartProjekat);
            this.Controls.Add(this.GV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownGodineStarostiProjekta);
            this.Name = "Statistika";
            this.Text = "Statistika";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Statistika_FormClosing);
            this.Load += new System.EventHandler(this.Statistika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGodineStarostiProjekta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartProjekat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownGodineStarostiProjekta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GV;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartProjekat;
    }
}