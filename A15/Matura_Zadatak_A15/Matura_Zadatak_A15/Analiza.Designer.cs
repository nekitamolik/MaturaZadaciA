namespace Matura_Zadatak_A15
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBoxGrupeLekova = new System.Windows.Forms.CheckedListBox();
            this.btnPrikaz = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.checkedListBoxGrupeLekova);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 197);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaShell;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnPrikaz);
            this.panel2.Location = new System.Drawing.Point(295, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(226, 197);
            this.panel2.TabIndex = 1;
            // 
            // graph
            // 
            this.graph.BackColor = System.Drawing.Color.SeaShell;
            this.graph.BorderlineColor = System.Drawing.Color.Black;
            this.graph.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.graph.BorderSkin.BackColor = System.Drawing.SystemColors.Control;
            this.graph.BorderSkin.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea3.Name = "ChartArea1";
            this.graph.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.graph.Legends.Add(legend3);
            this.graph.Location = new System.Drawing.Point(2, 205);
            this.graph.Name = "graph";
            series3.ChartArea = "ChartArea1";
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.Name = "Grupa Leka";
            this.graph.Series.Add(series3);
            this.graph.Size = new System.Drawing.Size(519, 240);
            this.graph.TabIndex = 2;
            this.graph.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(27, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Izaberi grupu :";
            // 
            // checkedListBoxGrupeLekova
            // 
            this.checkedListBoxGrupeLekova.FormattingEnabled = true;
            this.checkedListBoxGrupeLekova.Location = new System.Drawing.Point(10, 36);
            this.checkedListBoxGrupeLekova.Name = "checkedListBoxGrupeLekova";
            this.checkedListBoxGrupeLekova.Size = new System.Drawing.Size(260, 154);
            this.checkedListBoxGrupeLekova.TabIndex = 1;
            // 
            // btnPrikaz
            // 
            this.btnPrikaz.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPrikaz.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrikaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikaz.ForeColor = System.Drawing.Color.White;
            this.btnPrikaz.Location = new System.Drawing.Point(50, 36);
            this.btnPrikaz.Name = "btnPrikaz";
            this.btnPrikaz.Size = new System.Drawing.Size(117, 50);
            this.btnPrikaz.TabIndex = 0;
            this.btnPrikaz.Text = "Prikazi";
            this.btnPrikaz.UseVisualStyleBackColor = false;
            this.btnPrikaz.Click += new System.EventHandler(this.btnPrikaz_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(50, 106);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(117, 51);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Izadji";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Analiza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 446);
            this.Controls.Add(this.graph);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Analiza";
            this.Text = "Broj razlicitih lekova po odabranim grupama lekova";
            this.Load += new System.EventHandler(this.Analiza_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.graph)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckedListBox checkedListBoxGrupeLekova;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPrikaz;
        private System.Windows.Forms.DataVisualization.Charting.Chart graph;
    }
}