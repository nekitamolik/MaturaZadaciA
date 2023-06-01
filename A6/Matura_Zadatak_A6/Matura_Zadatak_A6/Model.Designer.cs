namespace Matura_Zadatak_A6
{
    partial class Model
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Model));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageModeli = new System.Windows.Forms.TabPage();
            this.listBoxModeli = new System.Windows.Forms.ListBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSifra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnIzadji = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.tbNazivModela = new System.Windows.Forms.TextBox();
            this.cbProizvodjac = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageBr_R_Vozila = new System.Windows.Forms.TabPage();
            this.Graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnIzadjiTab2 = new System.Windows.Forms.Button();
            this.btnPrikaziTab2 = new System.Windows.Forms.Button();
            this.listViewProizvodjac = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbKm = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDownDO = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownOD = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPageUputsvo = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageModeli.SuspendLayout();
            this.tabPageBr_R_Vozila.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Graph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOD)).BeginInit();
            this.tabPageUputsvo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageModeli);
            this.tabControl1.Controls.Add(this.tabPageBr_R_Vozila);
            this.tabControl1.Controls.Add(this.tabPageUputsvo);
            this.tabControl1.Location = new System.Drawing.Point(-3, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(652, 385);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageModeli
            // 
            this.tabPageModeli.Controls.Add(this.listBoxModeli);
            this.tabPageModeli.Controls.Add(this.btnSearch);
            this.tabPageModeli.Controls.Add(this.tbSifra);
            this.tabPageModeli.Controls.Add(this.label5);
            this.tabPageModeli.Controls.Add(this.label4);
            this.tabPageModeli.Controls.Add(this.btnIzadji);
            this.tabPageModeli.Controls.Add(this.btnIzmeni);
            this.tabPageModeli.Controls.Add(this.tbNazivModela);
            this.tabPageModeli.Controls.Add(this.cbProizvodjac);
            this.tabPageModeli.Controls.Add(this.label3);
            this.tabPageModeli.Controls.Add(this.label2);
            this.tabPageModeli.Location = new System.Drawing.Point(4, 22);
            this.tabPageModeli.Name = "tabPageModeli";
            this.tabPageModeli.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageModeli.Size = new System.Drawing.Size(644, 359);
            this.tabPageModeli.TabIndex = 0;
            this.tabPageModeli.Text = "Modeli automobila";
            this.tabPageModeli.UseVisualStyleBackColor = true;
            // 
            // listBoxModeli
            // 
            this.listBoxModeli.FormattingEnabled = true;
            this.listBoxModeli.Location = new System.Drawing.Point(289, 54);
            this.listBoxModeli.Name = "listBoxModeli";
            this.listBoxModeli.Size = new System.Drawing.Size(286, 277);
            this.listBoxModeli.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.Location = new System.Drawing.Point(535, 8);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(40, 40);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSifra
            // 
            this.tbSifra.Location = new System.Drawing.Point(461, 19);
            this.tbSifra.Name = "tbSifra";
            this.tbSifra.Size = new System.Drawing.Size(68, 20);
            this.tbSifra.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(417, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Sifra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Model :";
            // 
            // btnIzadji
            // 
            this.btnIzadji.Location = new System.Drawing.Point(107, 279);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(130, 36);
            this.btnIzadji.TabIndex = 5;
            this.btnIzadji.Text = "Izadji";
            this.btnIzadji.UseVisualStyleBackColor = true;
            this.btnIzadji.Click += new System.EventHandler(this.btnIzadji_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(107, 225);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(130, 36);
            this.btnIzmeni.TabIndex = 4;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // tbNazivModela
            // 
            this.tbNazivModela.Location = new System.Drawing.Point(93, 87);
            this.tbNazivModela.Name = "tbNazivModela";
            this.tbNazivModela.Size = new System.Drawing.Size(144, 20);
            this.tbNazivModela.TabIndex = 3;
            // 
            // cbProizvodjac
            // 
            this.cbProizvodjac.FormattingEnabled = true;
            this.cbProizvodjac.Location = new System.Drawing.Point(93, 37);
            this.cbProizvodjac.Name = "cbProizvodjac";
            this.cbProizvodjac.Size = new System.Drawing.Size(144, 21);
            this.cbProizvodjac.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Naziv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Proizvodjac";
            // 
            // tabPageBr_R_Vozila
            // 
            this.tabPageBr_R_Vozila.Controls.Add(this.Graph);
            this.tabPageBr_R_Vozila.Controls.Add(this.btnIzadjiTab2);
            this.tabPageBr_R_Vozila.Controls.Add(this.btnPrikaziTab2);
            this.tabPageBr_R_Vozila.Controls.Add(this.listViewProizvodjac);
            this.tabPageBr_R_Vozila.Controls.Add(this.tbKm);
            this.tabPageBr_R_Vozila.Controls.Add(this.label9);
            this.tabPageBr_R_Vozila.Controls.Add(this.numericUpDownDO);
            this.tabPageBr_R_Vozila.Controls.Add(this.numericUpDownOD);
            this.tabPageBr_R_Vozila.Controls.Add(this.label8);
            this.tabPageBr_R_Vozila.Controls.Add(this.label7);
            this.tabPageBr_R_Vozila.Controls.Add(this.label6);
            this.tabPageBr_R_Vozila.Location = new System.Drawing.Point(4, 22);
            this.tabPageBr_R_Vozila.Name = "tabPageBr_R_Vozila";
            this.tabPageBr_R_Vozila.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBr_R_Vozila.Size = new System.Drawing.Size(644, 359);
            this.tabPageBr_R_Vozila.TabIndex = 1;
            this.tabPageBr_R_Vozila.Text = "Broj raspolozvih vozila";
            this.tabPageBr_R_Vozila.UseVisualStyleBackColor = true;
            // 
            // Graph
            // 
            chartArea1.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea1.Name = "ChartArea1";
            this.Graph.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Graph.Legends.Add(legend1);
            this.Graph.Location = new System.Drawing.Point(269, 0);
            this.Graph.Name = "Graph";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "S";
            this.Graph.Series.Add(series1);
            this.Graph.Size = new System.Drawing.Size(369, 342);
            this.Graph.TabIndex = 10;
            // 
            // btnIzadjiTab2
            // 
            this.btnIzadjiTab2.Location = new System.Drawing.Point(152, 319);
            this.btnIzadjiTab2.Name = "btnIzadjiTab2";
            this.btnIzadjiTab2.Size = new System.Drawing.Size(75, 23);
            this.btnIzadjiTab2.TabIndex = 9;
            this.btnIzadjiTab2.Text = "Izadji";
            this.btnIzadjiTab2.UseVisualStyleBackColor = true;
            this.btnIzadjiTab2.Click += new System.EventHandler(this.btnIzadji_Click);
            // 
            // btnPrikaziTab2
            // 
            this.btnPrikaziTab2.Location = new System.Drawing.Point(28, 320);
            this.btnPrikaziTab2.Name = "btnPrikaziTab2";
            this.btnPrikaziTab2.Size = new System.Drawing.Size(75, 23);
            this.btnPrikaziTab2.TabIndex = 8;
            this.btnPrikaziTab2.Text = "Prikazi";
            this.btnPrikaziTab2.UseVisualStyleBackColor = true;
            this.btnPrikaziTab2.Click += new System.EventHandler(this.btnPrikaziTab2_Click);
            // 
            // listViewProizvodjac
            // 
            this.listViewProizvodjac.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewProizvodjac.FullRowSelect = true;
            this.listViewProizvodjac.Location = new System.Drawing.Point(28, 147);
            this.listViewProizvodjac.MultiSelect = false;
            this.listViewProizvodjac.Name = "listViewProizvodjac";
            this.listViewProizvodjac.Size = new System.Drawing.Size(208, 166);
            this.listViewProizvodjac.TabIndex = 7;
            this.listViewProizvodjac.TileSize = new System.Drawing.Size(168, 50);
            this.listViewProizvodjac.UseCompatibleStateImageBehavior = false;
            this.listViewProizvodjac.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Tag = "1";
            this.columnHeader1.Text = "Proizvodjac";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Broj";
            // 
            // tbKm
            // 
            this.tbKm.Location = new System.Drawing.Point(136, 114);
            this.tbKm.Name = "tbKm";
            this.tbKm.Size = new System.Drawing.Size(100, 20);
            this.tbKm.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(64, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Kilometraza :";
            // 
            // numericUpDownDO
            // 
            this.numericUpDownDO.Location = new System.Drawing.Point(161, 64);
            this.numericUpDownDO.Name = "numericUpDownDO";
            this.numericUpDownDO.Size = new System.Drawing.Size(54, 20);
            this.numericUpDownDO.TabIndex = 4;
            // 
            // numericUpDownOD
            // 
            this.numericUpDownOD.Location = new System.Drawing.Point(161, 35);
            this.numericUpDownOD.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDownOD.Name = "numericUpDownOD";
            this.numericUpDownOD.Size = new System.Drawing.Size(54, 20);
            this.numericUpDownOD.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(133, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "do";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(133, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "od";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Godiste :";
            // 
            // tabPageUputsvo
            // 
            this.tabPageUputsvo.Controls.Add(this.label1);
            this.tabPageUputsvo.Location = new System.Drawing.Point(4, 22);
            this.tabPageUputsvo.Name = "tabPageUputsvo";
            this.tabPageUputsvo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUputsvo.Size = new System.Drawing.Size(644, 359);
            this.tabPageUputsvo.TabIndex = 2;
            this.tabPageUputsvo.Text = "tabPage1";
            this.tabPageUputsvo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Uputstvo";
            // 
            // Model
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 384);
            this.Controls.Add(this.tabControl1);
            this.Name = "Model";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Model";
            this.Load += new System.EventHandler(this.Model_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageModeli.ResumeLayout(false);
            this.tabPageModeli.PerformLayout();
            this.tabPageBr_R_Vozila.ResumeLayout(false);
            this.tabPageBr_R_Vozila.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Graph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOD)).EndInit();
            this.tabPageUputsvo.ResumeLayout(false);
            this.tabPageUputsvo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageModeli;
        private System.Windows.Forms.TabPage tabPageBr_R_Vozila;
        private System.Windows.Forms.TabPage tabPageUputsvo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIzadji;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.TextBox tbNazivModela;
        private System.Windows.Forms.ComboBox cbProizvodjac;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSifra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxModeli;
        private System.Windows.Forms.NumericUpDown numericUpDownDO;
        private System.Windows.Forms.NumericUpDown numericUpDownOD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart Graph;
        private System.Windows.Forms.Button btnIzadjiTab2;
        private System.Windows.Forms.Button btnPrikaziTab2;
        private System.Windows.Forms.ListView listViewProizvodjac;
        private System.Windows.Forms.TextBox tbKm;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

