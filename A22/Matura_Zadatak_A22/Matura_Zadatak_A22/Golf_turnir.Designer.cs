namespace Matura_Zadatak_A22
{
    partial class Golf_turnir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Golf_turnir));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageZakazivanje = new System.Windows.Forms.TabPage();
            this.dateTimePickerVreme = new System.Windows.Forms.DateTimePicker();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnZakazi = new System.Windows.Forms.Button();
            this.rtbIgraci = new System.Windows.Forms.RichTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbTeren = new System.Windows.Forms.ComboBox();
            this.cbGrad = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDatum = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPagePregled = new System.Windows.Forms.TabPage();
            this.GVPartija = new System.Windows.Forms.DataGridView();
            this.GVTeren = new System.Windows.Forms.DataGridView();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.btnPrikaz = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonO = new System.Windows.Forms.RadioButton();
            this.radioButtonZ = new System.Windows.Forms.RadioButton();
            this.tabPageUputstvo = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageZakazivanje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPagePregled.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVPartija)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVTeren)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPageUputstvo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageZakazivanje);
            this.tabControl1.Controls.Add(this.tabPagePregled);
            this.tabControl1.Controls.Add(this.tabPageUputstvo);
            this.tabControl1.Location = new System.Drawing.Point(1, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(637, 363);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageZakazivanje
            // 
            this.tabPageZakazivanje.Controls.Add(this.dateTimePickerVreme);
            this.tabPageZakazivanje.Controls.Add(this.btnOdustani);
            this.tabPageZakazivanje.Controls.Add(this.btnZakazi);
            this.tabPageZakazivanje.Controls.Add(this.rtbIgraci);
            this.tabPageZakazivanje.Controls.Add(this.pictureBox2);
            this.tabPageZakazivanje.Controls.Add(this.pictureBox1);
            this.tabPageZakazivanje.Controls.Add(this.cbTeren);
            this.tabPageZakazivanje.Controls.Add(this.cbGrad);
            this.tabPageZakazivanje.Controls.Add(this.dateTimePickerDatum);
            this.tabPageZakazivanje.Controls.Add(this.label5);
            this.tabPageZakazivanje.Controls.Add(this.label4);
            this.tabPageZakazivanje.Controls.Add(this.label3);
            this.tabPageZakazivanje.Controls.Add(this.label2);
            this.tabPageZakazivanje.Location = new System.Drawing.Point(4, 22);
            this.tabPageZakazivanje.Name = "tabPageZakazivanje";
            this.tabPageZakazivanje.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageZakazivanje.Size = new System.Drawing.Size(629, 337);
            this.tabPageZakazivanje.TabIndex = 0;
            this.tabPageZakazivanje.Text = "Zakazivanje";
            this.tabPageZakazivanje.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerVreme
            // 
            this.dateTimePickerVreme.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerVreme.Location = new System.Drawing.Point(84, 205);
            this.dateTimePickerVreme.Name = "dateTimePickerVreme";
            this.dateTimePickerVreme.ShowUpDown = true;
            this.dateTimePickerVreme.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerVreme.TabIndex = 13;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(172, 258);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(112, 33);
            this.btnOdustani.TabIndex = 12;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnZakazi
            // 
            this.btnZakazi.Location = new System.Drawing.Point(36, 258);
            this.btnZakazi.Name = "btnZakazi";
            this.btnZakazi.Size = new System.Drawing.Size(112, 33);
            this.btnZakazi.TabIndex = 11;
            this.btnZakazi.Text = "Zakazi";
            this.btnZakazi.UseVisualStyleBackColor = true;
            this.btnZakazi.Click += new System.EventHandler(this.btnZakazi_Click);
            // 
            // rtbIgraci
            // 
            this.rtbIgraci.Location = new System.Drawing.Point(325, 176);
            this.rtbIgraci.Name = "rtbIgraci";
            this.rtbIgraci.Size = new System.Drawing.Size(240, 115);
            this.rtbIgraci.TabIndex = 10;
            this.rtbIgraci.Text = "";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(456, 36);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(109, 88);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(325, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cbTeren
            // 
            this.cbTeren.FormattingEnabled = true;
            this.cbTeren.Location = new System.Drawing.Point(84, 92);
            this.cbTeren.Name = "cbTeren";
            this.cbTeren.Size = new System.Drawing.Size(200, 21);
            this.cbTeren.TabIndex = 7;
            // 
            // cbGrad
            // 
            this.cbGrad.FormattingEnabled = true;
            this.cbGrad.Location = new System.Drawing.Point(84, 36);
            this.cbGrad.Name = "cbGrad";
            this.cbGrad.Size = new System.Drawing.Size(200, 21);
            this.cbGrad.TabIndex = 6;
            // 
            // dateTimePickerDatum
            // 
            this.dateTimePickerDatum.CustomFormat = "dddd, dd.MM.yyyy";
            this.dateTimePickerDatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDatum.Location = new System.Drawing.Point(84, 151);
            this.dateTimePickerDatum.Name = "dateTimePickerDatum";
            this.dateTimePickerDatum.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDatum.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Vreme";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Datum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Teren";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Grad";
            // 
            // tabPagePregled
            // 
            this.tabPagePregled.Controls.Add(this.GVPartija);
            this.tabPagePregled.Controls.Add(this.GVTeren);
            this.tabPagePregled.Controls.Add(this.btnIzlaz);
            this.tabPagePregled.Controls.Add(this.btnPrikaz);
            this.tabPagePregled.Controls.Add(this.groupBox1);
            this.tabPagePregled.Location = new System.Drawing.Point(4, 22);
            this.tabPagePregled.Name = "tabPagePregled";
            this.tabPagePregled.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePregled.Size = new System.Drawing.Size(629, 337);
            this.tabPagePregled.TabIndex = 1;
            this.tabPagePregled.Text = "Pregled partija";
            this.tabPagePregled.UseVisualStyleBackColor = true;
            // 
            // GVPartija
            // 
            this.GVPartija.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GVPartija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVPartija.Location = new System.Drawing.Point(171, 163);
            this.GVPartija.MultiSelect = false;
            this.GVPartija.Name = "GVPartija";
            this.GVPartija.ReadOnly = true;
            this.GVPartija.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GVPartija.Size = new System.Drawing.Size(449, 166);
            this.GVPartija.TabIndex = 4;
            // 
            // GVTeren
            // 
            this.GVTeren.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GVTeren.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVTeren.Location = new System.Drawing.Point(171, 7);
            this.GVTeren.MultiSelect = false;
            this.GVTeren.Name = "GVTeren";
            this.GVTeren.ReadOnly = true;
            this.GVTeren.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GVTeren.Size = new System.Drawing.Size(449, 150);
            this.GVTeren.TabIndex = 3;
            this.GVTeren.SelectionChanged += new System.EventHandler(this.GVTeren_SelectionChanged);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(8, 296);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(134, 33);
            this.btnIzlaz.TabIndex = 2;
            this.btnIzlaz.Text = "Izadji";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // btnPrikaz
            // 
            this.btnPrikaz.Location = new System.Drawing.Point(8, 251);
            this.btnPrikaz.Name = "btnPrikaz";
            this.btnPrikaz.Size = new System.Drawing.Size(134, 33);
            this.btnPrikaz.TabIndex = 1;
            this.btnPrikaz.Text = "Prikazi";
            this.btnPrikaz.UseVisualStyleBackColor = true;
            this.btnPrikaz.Click += new System.EventHandler(this.btnPrikaz_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonO);
            this.groupBox1.Controls.Add(this.radioButtonZ);
            this.groupBox1.Location = new System.Drawing.Point(8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prikazi";
            // 
            // radioButtonO
            // 
            this.radioButtonO.AutoSize = true;
            this.radioButtonO.Location = new System.Drawing.Point(17, 56);
            this.radioButtonO.Name = "radioButtonO";
            this.radioButtonO.Size = new System.Drawing.Size(99, 17);
            this.radioButtonO.TabIndex = 1;
            this.radioButtonO.TabStop = true;
            this.radioButtonO.Text = "Odigrane partije";
            this.radioButtonO.UseVisualStyleBackColor = true;
            // 
            // radioButtonZ
            // 
            this.radioButtonZ.AutoSize = true;
            this.radioButtonZ.Location = new System.Drawing.Point(17, 33);
            this.radioButtonZ.Name = "radioButtonZ";
            this.radioButtonZ.Size = new System.Drawing.Size(104, 17);
            this.radioButtonZ.TabIndex = 0;
            this.radioButtonZ.TabStop = true;
            this.radioButtonZ.Text = "Zakazane partije";
            this.radioButtonZ.UseVisualStyleBackColor = true;
            // 
            // tabPageUputstvo
            // 
            this.tabPageUputstvo.Controls.Add(this.label1);
            this.tabPageUputstvo.Location = new System.Drawing.Point(4, 22);
            this.tabPageUputstvo.Name = "tabPageUputstvo";
            this.tabPageUputstvo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUputstvo.Size = new System.Drawing.Size(629, 337);
            this.tabPageUputstvo.TabIndex = 2;
            this.tabPageUputstvo.Text = "Uputstvo";
            this.tabPageUputstvo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Uputstvo";
            // 
            // Golf_turnir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 367);
            this.Controls.Add(this.tabControl1);
            this.Name = "Golf_turnir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Golf turnir";
            this.Load += new System.EventHandler(this.Golf_turnir_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageZakazivanje.ResumeLayout(false);
            this.tabPageZakazivanje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPagePregled.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GVPartija)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVTeren)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageUputstvo.ResumeLayout(false);
            this.tabPageUputstvo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageZakazivanje;
        private System.Windows.Forms.ComboBox cbGrad;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPagePregled;
        private System.Windows.Forms.TabPage tabPageUputstvo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTeren;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnZakazi;
        private System.Windows.Forms.RichTextBox rtbIgraci;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerVreme;
        private System.Windows.Forms.DataGridView GVPartija;
        private System.Windows.Forms.DataGridView GVTeren;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Button btnPrikaz;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonO;
        private System.Windows.Forms.RadioButton radioButtonZ;
    }
}

