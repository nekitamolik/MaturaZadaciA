namespace Matura_Zadatak_A3
{
    partial class Projekat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Projekat));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonPregled = new System.Windows.Forms.ToolStripButton();
            this.listViewProjekti = new System.Windows.Forms.ListView();
            this.columnHeaderSifra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNaziv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDatumPocetka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBudzet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderZavrsen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderOpis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnIzadji = new System.Windows.Forms.Button();
            this.tbSifra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNaziv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDatumPocetka = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbBudzet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbOpis = new System.Windows.Forms.TextBox();
            this.cbZavrsen = new System.Windows.Forms.CheckBox();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonPregled});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(691, 57);
            this.toolStrip.TabIndex = 0;
            // 
            // toolStripButtonPregled
            // 
            this.toolStripButtonPregled.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPregled.Image")));
            this.toolStripButtonPregled.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButtonPregled.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPregled.Name = "toolStripButtonPregled";
            this.toolStripButtonPregled.Size = new System.Drawing.Size(156, 54);
            this.toolStripButtonPregled.Text = " Pregled projekata";
            this.toolStripButtonPregled.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButtonPregled.Click += new System.EventHandler(this.toolStripButtonPregled_Click);
            // 
            // listViewProjekti
            // 
            this.listViewProjekti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderSifra,
            this.columnHeaderNaziv,
            this.columnHeaderDatumPocetka,
            this.columnHeaderBudzet,
            this.columnHeaderZavrsen,
            this.columnHeaderOpis});
            this.listViewProjekti.FullRowSelect = true;
            this.listViewProjekti.GridLines = true;
            this.listViewProjekti.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewProjekti.HideSelection = false;
            this.listViewProjekti.Location = new System.Drawing.Point(284, 72);
            this.listViewProjekti.MultiSelect = false;
            this.listViewProjekti.Name = "listViewProjekti";
            this.listViewProjekti.Size = new System.Drawing.Size(390, 282);
            this.listViewProjekti.TabIndex = 1;
            this.listViewProjekti.UseCompatibleStateImageBehavior = false;
            this.listViewProjekti.View = System.Windows.Forms.View.Details;
            this.listViewProjekti.SelectedIndexChanged += new System.EventHandler(this.listViewProjekti_SelectedIndexChanged);
            // 
            // columnHeaderSifra
            // 
            this.columnHeaderSifra.Text = "Sifra";
            // 
            // columnHeaderNaziv
            // 
            this.columnHeaderNaziv.Text = "Naziv";
            // 
            // columnHeaderDatumPocetka
            // 
            this.columnHeaderDatumPocetka.Text = "Datum Pocetka";
            // 
            // columnHeaderBudzet
            // 
            this.columnHeaderBudzet.Text = "Budzet";
            // 
            // columnHeaderZavrsen
            // 
            this.columnHeaderZavrsen.Text = "Zavrsen";
            // 
            // columnHeaderOpis
            // 
            this.columnHeaderOpis.Text = "Opis";
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(466, 360);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(88, 35);
            this.btnObrisi.TabIndex = 2;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnIzadji
            // 
            this.btnIzadji.Location = new System.Drawing.Point(579, 360);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(95, 35);
            this.btnIzadji.TabIndex = 3;
            this.btnIzadji.Text = "Izadji";
            this.btnIzadji.UseVisualStyleBackColor = true;
            this.btnIzadji.Click += new System.EventHandler(this.btnIzadji_Click);
            // 
            // tbSifra
            // 
            this.tbSifra.BackColor = System.Drawing.Color.White;
            this.tbSifra.Location = new System.Drawing.Point(96, 84);
            this.tbSifra.Name = "tbSifra";
            this.tbSifra.ReadOnly = true;
            this.tbSifra.Size = new System.Drawing.Size(115, 20);
            this.tbSifra.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sifra ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Naziv ";
            // 
            // tbNaziv
            // 
            this.tbNaziv.BackColor = System.Drawing.Color.White;
            this.tbNaziv.Location = new System.Drawing.Point(96, 124);
            this.tbNaziv.Name = "tbNaziv";
            this.tbNaziv.ReadOnly = true;
            this.tbNaziv.Size = new System.Drawing.Size(115, 20);
            this.tbNaziv.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Datum Pocetka";
            // 
            // tbDatumPocetka
            // 
            this.tbDatumPocetka.BackColor = System.Drawing.Color.White;
            this.tbDatumPocetka.Location = new System.Drawing.Point(96, 160);
            this.tbDatumPocetka.Name = "tbDatumPocetka";
            this.tbDatumPocetka.ReadOnly = true;
            this.tbDatumPocetka.Size = new System.Drawing.Size(115, 20);
            this.tbDatumPocetka.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Budzet";
            // 
            // tbBudzet
            // 
            this.tbBudzet.BackColor = System.Drawing.Color.White;
            this.tbBudzet.Location = new System.Drawing.Point(96, 192);
            this.tbBudzet.Name = "tbBudzet";
            this.tbBudzet.ReadOnly = true;
            this.tbBudzet.Size = new System.Drawing.Size(115, 20);
            this.tbBudzet.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Opis ";
            // 
            // tbOpis
            // 
            this.tbOpis.BackColor = System.Drawing.Color.White;
            this.tbOpis.Location = new System.Drawing.Point(96, 275);
            this.tbOpis.Multiline = true;
            this.tbOpis.Name = "tbOpis";
            this.tbOpis.ReadOnly = true;
            this.tbOpis.Size = new System.Drawing.Size(115, 79);
            this.tbOpis.TabIndex = 12;
            // 
            // cbZavrsen
            // 
            this.cbZavrsen.AutoCheck = false;
            this.cbZavrsen.AutoSize = true;
            this.cbZavrsen.Cursor = System.Windows.Forms.Cursors.No;
            this.cbZavrsen.Location = new System.Drawing.Point(43, 234);
            this.cbZavrsen.Name = "cbZavrsen";
            this.cbZavrsen.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbZavrsen.Size = new System.Drawing.Size(65, 17);
            this.cbZavrsen.TabIndex = 14;
            this.cbZavrsen.Text = "Zavrsen";
            this.cbZavrsen.UseVisualStyleBackColor = true;
            // 
            // Projekat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 415);
            this.Controls.Add(this.cbZavrsen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbOpis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbBudzet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDatumPocetka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNaziv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSifra);
            this.Controls.Add(this.btnIzadji);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.listViewProjekti);
            this.Controls.Add(this.toolStrip);
            this.Name = "Projekat";
            this.Text = "Projekat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonPregled;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnIzadji;
        private System.Windows.Forms.TextBox tbSifra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNaziv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDatumPocetka;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbBudzet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbOpis;
        private System.Windows.Forms.CheckBox cbZavrsen;
        private System.Windows.Forms.ColumnHeader columnHeaderSifra;
        private System.Windows.Forms.ColumnHeader columnHeaderNaziv;
        private System.Windows.Forms.ColumnHeader columnHeaderDatumPocetka;
        private System.Windows.Forms.ColumnHeader columnHeaderBudzet;
        private System.Windows.Forms.ColumnHeader columnHeaderZavrsen;
        private System.Windows.Forms.ColumnHeader columnHeaderOpis;
        private System.Windows.Forms.ListView listViewProjekti;
    }
}

