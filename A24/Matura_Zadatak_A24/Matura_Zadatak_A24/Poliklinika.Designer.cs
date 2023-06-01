namespace Matura_Zadatak_A24
{
    partial class Poliklinika
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageAngazovanjeLekara = new System.Windows.Forms.TabPage();
            this.GV = new System.Windows.Forms.DataGridView();
            this.Grad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cbLekar = new System.Windows.Forms.ComboBox();
            this.cbSpecijalizacija = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageStatistika = new System.Windows.Forms.TabPage();
            this.graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnExit2 = new System.Windows.Forms.Button();
            this.btnPrikaz = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbKlinika = new System.Windows.Forms.RadioButton();
            this.rbSpec = new System.Windows.Forms.RadioButton();
            this.rbGrad = new System.Windows.Forms.RadioButton();
            this.tbDateDO = new System.Windows.Forms.TextBox();
            this.tbDateOD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPageInfo = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageAngazovanjeLekara.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV)).BeginInit();
            this.tabPageStatistika.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPageInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageAngazovanjeLekara);
            this.tabControl1.Controls.Add(this.tabPageStatistika);
            this.tabControl1.Controls.Add(this.tabPageInfo);
            this.tabControl1.Location = new System.Drawing.Point(3, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(731, 439);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageAngazovanjeLekara
            // 
            this.tabPageAngazovanjeLekara.AllowDrop = true;
            this.tabPageAngazovanjeLekara.Controls.Add(this.GV);
            this.tabPageAngazovanjeLekara.Controls.Add(this.btnExit);
            this.tabPageAngazovanjeLekara.Controls.Add(this.btnUpdate);
            this.tabPageAngazovanjeLekara.Controls.Add(this.cbLekar);
            this.tabPageAngazovanjeLekara.Controls.Add(this.cbSpecijalizacija);
            this.tabPageAngazovanjeLekara.Controls.Add(this.label3);
            this.tabPageAngazovanjeLekara.Controls.Add(this.label2);
            this.tabPageAngazovanjeLekara.Location = new System.Drawing.Point(4, 22);
            this.tabPageAngazovanjeLekara.Name = "tabPageAngazovanjeLekara";
            this.tabPageAngazovanjeLekara.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAngazovanjeLekara.Size = new System.Drawing.Size(723, 413);
            this.tabPageAngazovanjeLekara.TabIndex = 0;
            this.tabPageAngazovanjeLekara.Text = "Angazovanje Lekara";
            this.tabPageAngazovanjeLekara.UseVisualStyleBackColor = true;
            // 
            // GV
            // 
            this.GV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Grad,
            this.Naziv,
            this.Status});
            this.GV.Location = new System.Drawing.Point(275, 0);
            this.GV.Name = "GV";
            this.GV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GV.Size = new System.Drawing.Size(445, 408);
            this.GV.TabIndex = 6;
            this.GV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GV_CellClick);
            // 
            // Grad
            // 
            this.Grad.HeaderText = "Grad";
            this.Grad.Name = "Grad";
            this.Grad.ReadOnly = true;
            // 
            // Naziv
            // 
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(33, 363);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(220, 32);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Izadji";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(33, 292);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(220, 34);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Azuriraj podatke o zangazovanjima";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cbLekar
            // 
            this.cbLekar.FormattingEnabled = true;
            this.cbLekar.Location = new System.Drawing.Point(33, 205);
            this.cbLekar.Name = "cbLekar";
            this.cbLekar.Size = new System.Drawing.Size(208, 21);
            this.cbLekar.TabIndex = 3;
            this.cbLekar.SelectedIndexChanged += new System.EventHandler(this.cbLekar_SelectedIndexChanged);
            // 
            // cbSpecijalizacija
            // 
            this.cbSpecijalizacija.FormattingEnabled = true;
            this.cbSpecijalizacija.Location = new System.Drawing.Point(33, 87);
            this.cbSpecijalizacija.Name = "cbSpecijalizacija";
            this.cbSpecijalizacija.Size = new System.Drawing.Size(208, 21);
            this.cbSpecijalizacija.TabIndex = 2;
            this.cbSpecijalizacija.SelectedIndexChanged += new System.EventHandler(this.cbSpecijalizacija_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Lekar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Specijalizacija";
            // 
            // tabPageStatistika
            // 
            this.tabPageStatistika.Controls.Add(this.graph);
            this.tabPageStatistika.Controls.Add(this.btnExit2);
            this.tabPageStatistika.Controls.Add(this.btnPrikaz);
            this.tabPageStatistika.Controls.Add(this.groupBox1);
            this.tabPageStatistika.Controls.Add(this.tbDateDO);
            this.tabPageStatistika.Controls.Add(this.tbDateOD);
            this.tabPageStatistika.Controls.Add(this.label5);
            this.tabPageStatistika.Controls.Add(this.label4);
            this.tabPageStatistika.Location = new System.Drawing.Point(4, 22);
            this.tabPageStatistika.Name = "tabPageStatistika";
            this.tabPageStatistika.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStatistika.Size = new System.Drawing.Size(723, 413);
            this.tabPageStatistika.TabIndex = 1;
            this.tabPageStatistika.Text = "Statistika";
            this.tabPageStatistika.UseVisualStyleBackColor = true;
            // 
            // graph
            // 
            chartArea2.Name = "ChartArea1";
            this.graph.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.graph.Legends.Add(legend2);
            this.graph.Location = new System.Drawing.Point(218, 7);
            this.graph.Name = "graph";
            series2.ChartArea = "ChartArea1";
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            this.graph.Series.Add(series2);
            this.graph.Size = new System.Drawing.Size(494, 372);
            this.graph.TabIndex = 7;
            this.graph.Text = "chart1";
            // 
            // btnExit2
            // 
            this.btnExit2.Location = new System.Drawing.Point(124, 334);
            this.btnExit2.Name = "btnExit2";
            this.btnExit2.Size = new System.Drawing.Size(75, 45);
            this.btnExit2.TabIndex = 6;
            this.btnExit2.Text = "Izadji";
            this.btnExit2.UseVisualStyleBackColor = true;
            this.btnExit2.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPrikaz
            // 
            this.btnPrikaz.Location = new System.Drawing.Point(22, 334);
            this.btnPrikaz.Name = "btnPrikaz";
            this.btnPrikaz.Size = new System.Drawing.Size(75, 45);
            this.btnPrikaz.TabIndex = 5;
            this.btnPrikaz.Text = "Prikazi";
            this.btnPrikaz.UseVisualStyleBackColor = true;
            this.btnPrikaz.Click += new System.EventHandler(this.btnPrikaz_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbKlinika);
            this.groupBox1.Controls.Add(this.rbSpec);
            this.groupBox1.Controls.Add(this.rbGrad);
            this.groupBox1.Location = new System.Drawing.Point(22, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 110);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prikazi broj pregleda (prvih 10)";
            // 
            // rbKlinika
            // 
            this.rbKlinika.AutoSize = true;
            this.rbKlinika.Location = new System.Drawing.Point(17, 77);
            this.rbKlinika.Name = "rbKlinika";
            this.rbKlinika.Size = new System.Drawing.Size(84, 17);
            this.rbKlinika.TabIndex = 2;
            this.rbKlinika.Text = "po klinikama";
            this.rbKlinika.UseVisualStyleBackColor = true;
            // 
            // rbSpec
            // 
            this.rbSpec.AutoSize = true;
            this.rbSpec.Location = new System.Drawing.Point(17, 53);
            this.rbSpec.Name = "rbSpec";
            this.rbSpec.Size = new System.Drawing.Size(100, 17);
            this.rbSpec.TabIndex = 1;
            this.rbSpec.Text = "po specijalizaciji";
            this.rbSpec.UseVisualStyleBackColor = true;
            // 
            // rbGrad
            // 
            this.rbGrad.AutoSize = true;
            this.rbGrad.Checked = true;
            this.rbGrad.Location = new System.Drawing.Point(17, 29);
            this.rbGrad.Name = "rbGrad";
            this.rbGrad.Size = new System.Drawing.Size(89, 17);
            this.rbGrad.TabIndex = 0;
            this.rbGrad.TabStop = true;
            this.rbGrad.Text = "po gradovima";
            this.rbGrad.UseVisualStyleBackColor = true;
            // 
            // tbDateDO
            // 
            this.tbDateDO.Location = new System.Drawing.Point(87, 70);
            this.tbDateDO.Name = "tbDateDO";
            this.tbDateDO.Size = new System.Drawing.Size(127, 20);
            this.tbDateDO.TabIndex = 3;
            // 
            // tbDateOD
            // 
            this.tbDateOD.Location = new System.Drawing.Point(84, 21);
            this.tbDateOD.Name = "tbDateOD";
            this.tbDateOD.Size = new System.Drawing.Size(127, 20);
            this.tbDateOD.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Do datuma";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Od datuma";
            // 
            // tabPageInfo
            // 
            this.tabPageInfo.Controls.Add(this.label1);
            this.tabPageInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPageInfo.Name = "tabPageInfo";
            this.tabPageInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInfo.Size = new System.Drawing.Size(723, 444);
            this.tabPageInfo.TabIndex = 2;
            this.tabPageInfo.Text = "O aplikaciji";
            this.tabPageInfo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Uputstvo";
            // 
            // Poliklinika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 438);
            this.Controls.Add(this.tabControl1);
            this.Name = "Poliklinika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Poliklinika";
            this.Load += new System.EventHandler(this.Poliklinika_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageAngazovanjeLekara.ResumeLayout(false);
            this.tabPageAngazovanjeLekara.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV)).EndInit();
            this.tabPageStatistika.ResumeLayout(false);
            this.tabPageStatistika.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageInfo.ResumeLayout(false);
            this.tabPageInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAngazovanjeLekara;
        private System.Windows.Forms.DataGridView GV;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cbLekar;
        private System.Windows.Forms.ComboBox cbSpecijalizacija;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPageStatistika;
        private System.Windows.Forms.TabPage tabPageInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart graph;
        private System.Windows.Forms.Button btnExit2;
        private System.Windows.Forms.Button btnPrikaz;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbKlinika;
        private System.Windows.Forms.RadioButton rbSpec;
        private System.Windows.Forms.RadioButton rbGrad;
        private System.Windows.Forms.TextBox tbDateDO;
        private System.Windows.Forms.TextBox tbDateOD;
        private System.Windows.Forms.Label label5;
    }
}

