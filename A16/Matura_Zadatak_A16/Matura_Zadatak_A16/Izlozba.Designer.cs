namespace Matura_Zadatak_A16
{
    partial class Izlozba
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Izlozba));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePrijava = new System.Windows.Forms.TabPage();
            this.pbPas = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbKategorija = new System.Windows.Forms.ComboBox();
            this.cbIzlozba = new System.Windows.Forms.ComboBox();
            this.cbPas = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageStatistika = new System.Windows.Forms.TabPage();
            this.btnExit2 = new System.Windows.Forms.Button();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GV = new System.Windows.Forms.DataGridView();
            this.lblbrTakmicenje = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblbrPrijavljenih = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbIzlozbaTab2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPageInfo = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageExit = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPagePrijava.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPas)).BeginInit();
            this.tabPageStatistika.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV)).BeginInit();
            this.tabPageInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPagePrijava);
            this.tabControl1.Controls.Add(this.tabPageStatistika);
            this.tabControl1.Controls.Add(this.tabPageInfo);
            this.tabControl1.Controls.Add(this.tabPageExit);
            this.tabControl1.Location = new System.Drawing.Point(1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(660, 452);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPagePrijava
            // 
            this.tabPagePrijava.Controls.Add(this.pbPas);
            this.tabPagePrijava.Controls.Add(this.btnExit);
            this.tabPagePrijava.Controls.Add(this.btnAdd);
            this.tabPagePrijava.Controls.Add(this.cbKategorija);
            this.tabPagePrijava.Controls.Add(this.cbIzlozba);
            this.tabPagePrijava.Controls.Add(this.cbPas);
            this.tabPagePrijava.Controls.Add(this.label4);
            this.tabPagePrijava.Controls.Add(this.label3);
            this.tabPagePrijava.Controls.Add(this.label2);
            this.tabPagePrijava.Location = new System.Drawing.Point(4, 22);
            this.tabPagePrijava.Name = "tabPagePrijava";
            this.tabPagePrijava.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePrijava.Size = new System.Drawing.Size(652, 426);
            this.tabPagePrijava.TabIndex = 0;
            this.tabPagePrijava.Text = "Unesi prijavu";
            this.tabPagePrijava.UseVisualStyleBackColor = true;
            // 
            // pbPas
            // 
            this.pbPas.Image = ((System.Drawing.Image)(resources.GetObject("pbPas.Image")));
            this.pbPas.Location = new System.Drawing.Point(378, 44);
            this.pbPas.Name = "pbPas";
            this.pbPas.Size = new System.Drawing.Size(250, 182);
            this.pbPas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPas.TabIndex = 8;
            this.pbPas.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Location = new System.Drawing.Point(206, 240);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 41);
            this.btnExit.TabIndex = 7;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.tabPageExit_Enter);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.Location = new System.Drawing.Point(73, 240);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 41);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbKategorija
            // 
            this.cbKategorija.FormattingEnabled = true;
            this.cbKategorija.Location = new System.Drawing.Point(107, 153);
            this.cbKategorija.Name = "cbKategorija";
            this.cbKategorija.Size = new System.Drawing.Size(134, 21);
            this.cbKategorija.TabIndex = 5;
            // 
            // cbIzlozba
            // 
            this.cbIzlozba.FormattingEnabled = true;
            this.cbIzlozba.Location = new System.Drawing.Point(104, 103);
            this.cbIzlozba.Name = "cbIzlozba";
            this.cbIzlozba.Size = new System.Drawing.Size(199, 21);
            this.cbIzlozba.TabIndex = 4;
            // 
            // cbPas
            // 
            this.cbPas.FormattingEnabled = true;
            this.cbPas.Location = new System.Drawing.Point(104, 68);
            this.cbPas.Name = "cbPas";
            this.cbPas.Size = new System.Drawing.Size(137, 21);
            this.cbPas.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Kategorija";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Izlozba";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pas";
            // 
            // tabPageStatistika
            // 
            this.tabPageStatistika.BackColor = System.Drawing.Color.OldLace;
            this.tabPageStatistika.Controls.Add(this.btnExit2);
            this.tabPageStatistika.Controls.Add(this.btnPrikazi);
            this.tabPageStatistika.Controls.Add(this.graph);
            this.tabPageStatistika.Controls.Add(this.GV);
            this.tabPageStatistika.Controls.Add(this.lblbrTakmicenje);
            this.tabPageStatistika.Controls.Add(this.label7);
            this.tabPageStatistika.Controls.Add(this.lblbrPrijavljenih);
            this.tabPageStatistika.Controls.Add(this.label6);
            this.tabPageStatistika.Controls.Add(this.cbIzlozbaTab2);
            this.tabPageStatistika.Controls.Add(this.label5);
            this.tabPageStatistika.Location = new System.Drawing.Point(4, 22);
            this.tabPageStatistika.Name = "tabPageStatistika";
            this.tabPageStatistika.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStatistika.Size = new System.Drawing.Size(652, 426);
            this.tabPageStatistika.TabIndex = 1;
            this.tabPageStatistika.Text = "Statistika";
            // 
            // btnExit2
            // 
            this.btnExit2.Location = new System.Drawing.Point(227, 324);
            this.btnExit2.Name = "btnExit2";
            this.btnExit2.Size = new System.Drawing.Size(87, 42);
            this.btnExit2.TabIndex = 9;
            this.btnExit2.Text = "Izadji";
            this.btnExit2.UseVisualStyleBackColor = true;
            this.btnExit2.Click += new System.EventHandler(this.btnExit2_Click);
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(24, 324);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(87, 42);
            this.btnPrikazi.TabIndex = 8;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // graph
            // 
            chartArea1.Name = "ChartArea1";
            this.graph.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.DeepSkyBlue;
            legend1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.DarkUpwardDiagonal;
            legend1.BorderColor = System.Drawing.Color.Blue;
            legend1.BorderWidth = 3;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend1.Name = "Legend1";
            this.graph.Legends.Add(legend1);
            this.graph.Location = new System.Drawing.Point(342, 29);
            this.graph.Name = "graph";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.graph.Series.Add(series1);
            this.graph.Size = new System.Drawing.Size(300, 300);
            this.graph.TabIndex = 7;
            this.graph.Text = "chart1";
            // 
            // GV
            // 
            this.GV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV.Location = new System.Drawing.Point(21, 127);
            this.GV.Name = "GV";
            this.GV.ReadOnly = true;
            this.GV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GV.Size = new System.Drawing.Size(293, 181);
            this.GV.TabIndex = 6;
            // 
            // lblbrTakmicenje
            // 
            this.lblbrTakmicenje.AutoSize = true;
            this.lblbrTakmicenje.Location = new System.Drawing.Point(202, 92);
            this.lblbrTakmicenje.Name = "lblbrTakmicenje";
            this.lblbrTakmicenje.Size = new System.Drawing.Size(0, 13);
            this.lblbrTakmicenje.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Ukupan broj pasa koji se takmice : ";
            // 
            // lblbrPrijavljenih
            // 
            this.lblbrPrijavljenih.AutoSize = true;
            this.lblbrPrijavljenih.Location = new System.Drawing.Point(199, 59);
            this.lblbrPrijavljenih.Name = "lblbrPrijavljenih";
            this.lblbrPrijavljenih.Size = new System.Drawing.Size(0, 13);
            this.lblbrPrijavljenih.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ukupan broj pasa koji je prijavljen :";
            // 
            // cbIzlozbaTab2
            // 
            this.cbIzlozbaTab2.FormattingEnabled = true;
            this.cbIzlozbaTab2.Location = new System.Drawing.Point(64, 26);
            this.cbIzlozbaTab2.Name = "cbIzlozbaTab2";
            this.cbIzlozbaTab2.Size = new System.Drawing.Size(228, 21);
            this.cbIzlozbaTab2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Izlozba";
            // 
            // tabPageInfo
            // 
            this.tabPageInfo.Controls.Add(this.label1);
            this.tabPageInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPageInfo.Name = "tabPageInfo";
            this.tabPageInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInfo.Size = new System.Drawing.Size(652, 426);
            this.tabPageInfo.TabIndex = 2;
            this.tabPageInfo.Text = "O aplikaciji";
            this.tabPageInfo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "UPUTSTVO";
            // 
            // tabPageExit
            // 
            this.tabPageExit.Location = new System.Drawing.Point(4, 22);
            this.tabPageExit.Name = "tabPageExit";
            this.tabPageExit.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageExit.Size = new System.Drawing.Size(652, 426);
            this.tabPageExit.TabIndex = 3;
            this.tabPageExit.Text = "Izlaz";
            this.tabPageExit.UseVisualStyleBackColor = true;
            this.tabPageExit.Enter += new System.EventHandler(this.tabPageExit_Enter);
            // 
            // Izlozba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 448);
            this.Controls.Add(this.tabControl1);
            this.Name = "Izlozba";
            this.Text = "Prijava za izlozbu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPagePrijava.ResumeLayout(false);
            this.tabPagePrijava.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPas)).EndInit();
            this.tabPageStatistika.ResumeLayout(false);
            this.tabPageStatistika.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV)).EndInit();
            this.tabPageInfo.ResumeLayout(false);
            this.tabPageInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagePrijava;
        private System.Windows.Forms.TabPage tabPageStatistika;
        private System.Windows.Forms.TabPage tabPageInfo;
        private System.Windows.Forms.TabPage tabPageExit;
        private System.Windows.Forms.PictureBox pbPas;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbKategorija;
        private System.Windows.Forms.ComboBox cbIzlozba;
        private System.Windows.Forms.ComboBox cbPas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart graph;
        private System.Windows.Forms.DataGridView GV;
        private System.Windows.Forms.Label lblbrTakmicenje;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblbrPrijavljenih;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbIzlozbaTab2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExit2;
        private System.Windows.Forms.Button btnPrikazi;
    }
}

