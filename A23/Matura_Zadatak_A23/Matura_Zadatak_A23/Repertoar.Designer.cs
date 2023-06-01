namespace Matura_Zadatak_A23
{
    partial class Repertoar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.cbKomad = new System.Windows.Forms.ComboBox();
            this.btnRepertoar = new System.Windows.Forms.Button();
            this.GV = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPretplatnik = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numericUpDownBrmesta = new System.Windows.Forms.NumericUpDown();
            this.lblCena = new System.Windows.Forms.Label();
            this.lblUplata = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.btnRezervacija = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.monthCalendarObseg = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.GV)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBrmesta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Komad";
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(38, 44);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(212, 20);
            this.tbDate.TabIndex = 2;
            this.tbDate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbDate_MouseClick);
            // 
            // cbKomad
            // 
            this.cbKomad.FormattingEnabled = true;
            this.cbKomad.Location = new System.Drawing.Point(256, 43);
            this.cbKomad.Name = "cbKomad";
            this.cbKomad.Size = new System.Drawing.Size(163, 21);
            this.cbKomad.TabIndex = 3;
            this.cbKomad.SelectedIndexChanged += new System.EventHandler(this.cbKomad_SelectedIndexChanged);
            // 
            // btnRepertoar
            // 
            this.btnRepertoar.Location = new System.Drawing.Point(463, 26);
            this.btnRepertoar.Name = "btnRepertoar";
            this.btnRepertoar.Size = new System.Drawing.Size(111, 38);
            this.btnRepertoar.TabIndex = 4;
            this.btnRepertoar.Text = "Na repertoaru >>";
            this.btnRepertoar.UseVisualStyleBackColor = true;
            this.btnRepertoar.Click += new System.EventHandler(this.btnRepertoar_Click);
            // 
            // GV
            // 
            this.GV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV.Location = new System.Drawing.Point(2, 82);
            this.GV.MultiSelect = false;
            this.GV.Name = "GV";
            this.GV.ReadOnly = true;
            this.GV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GV.Size = new System.Drawing.Size(709, 208);
            this.GV.TabIndex = 5;
            this.GV.SelectionChanged += new System.EventHandler(this.GV_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblPretplatnik);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 296);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 164);
            this.panel1.TabIndex = 6;
            // 
            // lblPretplatnik
            // 
            this.lblPretplatnik.AutoSize = true;
            this.lblPretplatnik.Location = new System.Drawing.Point(12, 35);
            this.lblPretplatnik.Name = "lblPretplatnik";
            this.lblPretplatnik.Size = new System.Drawing.Size(0, 13);
            this.lblPretplatnik.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Pretplatnik :";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.numericUpDownBrmesta);
            this.panel2.Controls.Add(this.lblCena);
            this.panel2.Controls.Add(this.lblUplata);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(256, 296);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(318, 164);
            this.panel2.TabIndex = 7;
            // 
            // numericUpDownBrmesta
            // 
            this.numericUpDownBrmesta.Location = new System.Drawing.Point(80, 9);
            this.numericUpDownBrmesta.Name = "numericUpDownBrmesta";
            this.numericUpDownBrmesta.Size = new System.Drawing.Size(41, 20);
            this.numericUpDownBrmesta.TabIndex = 5;
            // 
            // lblCena
            // 
            this.lblCena.AutoSize = true;
            this.lblCena.Location = new System.Drawing.Point(84, 45);
            this.lblCena.Name = "lblCena";
            this.lblCena.Size = new System.Drawing.Size(0, 13);
            this.lblCena.TabIndex = 4;
            // 
            // lblUplata
            // 
            this.lblUplata.AutoSize = true;
            this.lblUplata.Location = new System.Drawing.Point(77, 91);
            this.lblUplata.Name = "lblUplata";
            this.lblUplata.Size = new System.Drawing.Size(0, 13);
            this.lblUplata.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Za uplatu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Cena karte";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Broj mesta";
            // 
            // btnPrijava
            // 
            this.btnPrijava.Location = new System.Drawing.Point(586, 296);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(115, 41);
            this.btnPrijava.TabIndex = 8;
            this.btnPrijava.Text = "Prijavite se";
            this.btnPrijava.UseVisualStyleBackColor = true;
            this.btnPrijava.Click += new System.EventHandler(this.btnPrijava_Click);
            // 
            // btnRezervacija
            // 
            this.btnRezervacija.Location = new System.Drawing.Point(586, 361);
            this.btnRezervacija.Name = "btnRezervacija";
            this.btnRezervacija.Size = new System.Drawing.Size(115, 41);
            this.btnRezervacija.TabIndex = 9;
            this.btnRezervacija.Text = "Rezervisi";
            this.btnRezervacija.UseVisualStyleBackColor = true;
            this.btnRezervacija.Click += new System.EventHandler(this.btnRezervacija_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(586, 419);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(115, 41);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Izadji";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // monthCalendarObseg
            // 
            this.monthCalendarObseg.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.monthCalendarObseg.Location = new System.Drawing.Point(38, 70);
            this.monthCalendarObseg.MaxSelectionCount = 60;
            this.monthCalendarObseg.Name = "monthCalendarObseg";
            this.monthCalendarObseg.TabIndex = 11;
            this.monthCalendarObseg.Leave += new System.EventHandler(this.monthCalendarObseg_Leave);
            // 
            // Repertoar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 472);
            this.Controls.Add(this.monthCalendarObseg);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRezervacija);
            this.Controls.Add(this.btnPrijava);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GV);
            this.Controls.Add(this.btnRepertoar);
            this.Controls.Add(this.cbKomad);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Repertoar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Repertoar";
            this.Load += new System.EventHandler(this.Repertoar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBrmesta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.ComboBox cbKomad;
        private System.Windows.Forms.Button btnRepertoar;
        private System.Windows.Forms.DataGridView GV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.Button btnRezervacija;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblPretplatnik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownBrmesta;
        private System.Windows.Forms.Label lblCena;
        private System.Windows.Forms.Label lblUplata;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MonthCalendar monthCalendarObseg;
    }
}