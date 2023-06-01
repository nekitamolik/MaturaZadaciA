namespace Matura_Zadatak_A5
{
    partial class Aktivnost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aktivnost));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonStatistika = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabelInfo = new System.Windows.Forms.ToolStripLabel();
            this.listViewAktivnosti = new System.Windows.Forms.ListView();
            this.Sifra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Naziv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dan_U_Nedelji = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vreme_pocetka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vreme_kraja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnUnesi = new System.Windows.Forms.Button();
            this.btnIzadji = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSifra = new System.Windows.Forms.TextBox();
            this.tbNaziv = new System.Windows.Forms.TextBox();
            this.tbVremePocetka = new System.Windows.Forms.TextBox();
            this.tbVremeZavrsetka = new System.Windows.Forms.TextBox();
            this.cbDanUNedelji = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonStatistika,
            this.toolStripLabelInfo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(617, 57);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonStatistika
            // 
            this.toolStripButtonStatistika.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonStatistika.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonStatistika.Image")));
            this.toolStripButtonStatistika.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStatistika.Name = "toolStripButtonStatistika";
            this.toolStripButtonStatistika.Size = new System.Drawing.Size(54, 54);
            this.toolStripButtonStatistika.Text = "toolStripButton1";
            this.toolStripButtonStatistika.Click += new System.EventHandler(this.toolStripButtonStatistika_Click);
            // 
            // toolStripLabelInfo
            // 
            this.toolStripLabelInfo.Name = "toolStripLabelInfo";
            this.toolStripLabelInfo.Size = new System.Drawing.Size(65, 54);
            this.toolStripLabelInfo.Text = "O aplikaciji";
            this.toolStripLabelInfo.Click += new System.EventHandler(this.toolStripLabelInfo_Click);
            // 
            // listViewAktivnosti
            // 
            this.listViewAktivnosti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Sifra,
            this.Naziv,
            this.Dan_U_Nedelji,
            this.vreme_pocetka,
            this.vreme_kraja});
            this.listViewAktivnosti.FullRowSelect = true;
            this.listViewAktivnosti.Location = new System.Drawing.Point(262, 77);
            this.listViewAktivnosti.MultiSelect = false;
            this.listViewAktivnosti.Name = "listViewAktivnosti";
            this.listViewAktivnosti.Size = new System.Drawing.Size(314, 303);
            this.listViewAktivnosti.TabIndex = 1;
            this.listViewAktivnosti.UseCompatibleStateImageBehavior = false;
            this.listViewAktivnosti.View = System.Windows.Forms.View.Details;
            this.listViewAktivnosti.SelectedIndexChanged += new System.EventHandler(this.listViewAktivnosti_SelectedIndexChanged);
            // 
            // Sifra
            // 
            this.Sifra.Text = "Sifra";
            // 
            // Naziv
            // 
            this.Naziv.Text = "Naziv";
            // 
            // Dan_U_Nedelji
            // 
            this.Dan_U_Nedelji.Text = "Dan u nedelji";
            // 
            // vreme_pocetka
            // 
            this.vreme_pocetka.Text = "Vreme pocetka";
            // 
            // vreme_kraja
            // 
            this.vreme_kraja.Text = "Vreme zavrsetka";
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(107, 312);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(120, 31);
            this.btnUnesi.TabIndex = 2;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // btnIzadji
            // 
            this.btnIzadji.Location = new System.Drawing.Point(107, 349);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(120, 31);
            this.btnIzadji.TabIndex = 3;
            this.btnIzadji.Text = "Izadji";
            this.btnIzadji.UseVisualStyleBackColor = true;
            this.btnIzadji.Click += new System.EventHandler(this.btnIzadji_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sifra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Naziv";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Vreme pocetka";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Vreme zavrsetka";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Dan u nedelji";
            // 
            // tbSifra
            // 
            this.tbSifra.Location = new System.Drawing.Point(107, 100);
            this.tbSifra.Name = "tbSifra";
            this.tbSifra.Size = new System.Drawing.Size(78, 20);
            this.tbSifra.TabIndex = 9;
            // 
            // tbNaziv
            // 
            this.tbNaziv.Location = new System.Drawing.Point(107, 131);
            this.tbNaziv.Name = "tbNaziv";
            this.tbNaziv.Size = new System.Drawing.Size(120, 20);
            this.tbNaziv.TabIndex = 10;
            // 
            // tbVremePocetka
            // 
            this.tbVremePocetka.Location = new System.Drawing.Point(107, 194);
            this.tbVremePocetka.Name = "tbVremePocetka";
            this.tbVremePocetka.Size = new System.Drawing.Size(54, 20);
            this.tbVremePocetka.TabIndex = 11;
            // 
            // tbVremeZavrsetka
            // 
            this.tbVremeZavrsetka.Location = new System.Drawing.Point(106, 221);
            this.tbVremeZavrsetka.Name = "tbVremeZavrsetka";
            this.tbVremeZavrsetka.Size = new System.Drawing.Size(55, 20);
            this.tbVremeZavrsetka.TabIndex = 12;
            // 
            // cbDanUNedelji
            // 
            this.cbDanUNedelji.FormattingEnabled = true;
            this.cbDanUNedelji.Location = new System.Drawing.Point(106, 160);
            this.cbDanUNedelji.Name = "cbDanUNedelji";
            this.cbDanUNedelji.Size = new System.Drawing.Size(121, 21);
            this.cbDanUNedelji.TabIndex = 13;
            // 
            // Aktivnost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 414);
            this.Controls.Add(this.cbDanUNedelji);
            this.Controls.Add(this.tbVremeZavrsetka);
            this.Controls.Add(this.tbVremePocetka);
            this.Controls.Add(this.tbNaziv);
            this.Controls.Add(this.tbSifra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIzadji);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.listViewAktivnosti);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Aktivnost";
            this.Text = "Aktivnost";
            this.Load += new System.EventHandler(this.Aktivnost_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonStatistika;
        private System.Windows.Forms.ToolStripLabel toolStripLabelInfo;
        private System.Windows.Forms.ListView listViewAktivnosti;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.Button btnIzadji;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSifra;
        private System.Windows.Forms.TextBox tbNaziv;
        private System.Windows.Forms.TextBox tbVremePocetka;
        private System.Windows.Forms.TextBox tbVremeZavrsetka;
        private System.Windows.Forms.ComboBox cbDanUNedelji;
        private System.Windows.Forms.ColumnHeader Sifra;
        private System.Windows.Forms.ColumnHeader Naziv;
        private System.Windows.Forms.ColumnHeader Dan_U_Nedelji;
        private System.Windows.Forms.ColumnHeader vreme_pocetka;
        private System.Windows.Forms.ColumnHeader vreme_kraja;
    }
}

