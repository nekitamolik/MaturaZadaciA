namespace Matura_Zadatak_A9
{
    partial class Game
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpPodaci = new System.Windows.Forms.TabPage();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.cbKlub = new System.Windows.Forms.ComboBox();
            this.cbGrad = new System.Windows.Forms.ComboBox();
            this.cbDrzava = new System.Windows.Forms.ComboBox();
            this.pbGrb = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpPregled = new System.Windows.Forms.TabPage();
            this.tpUputstvo = new System.Windows.Forms.TabPage();
            this.lblGrad = new System.Windows.Forms.Label();
            this.LlblSajt = new System.Windows.Forms.LinkLabel();
            this.lblStadion = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerDatum = new System.Windows.Forms.DateTimePicker();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.btnExit2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.listViewUtakmice = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tpPodaci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrb)).BeginInit();
            this.tpPregled.SuspendLayout();
            this.tpUputstvo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpPodaci);
            this.tabControl1.Controls.Add(this.tpPregled);
            this.tabControl1.Controls.Add(this.tpUputstvo);
            this.tabControl1.Location = new System.Drawing.Point(-1, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(642, 407);
            this.tabControl1.TabIndex = 0;
            // 
            // tpPodaci
            // 
            this.tpPodaci.Controls.Add(this.lblStadion);
            this.tpPodaci.Controls.Add(this.LlblSajt);
            this.tpPodaci.Controls.Add(this.lblGrad);
            this.tpPodaci.Controls.Add(this.btnExit);
            this.tpPodaci.Controls.Add(this.btnPretraga);
            this.tpPodaci.Controls.Add(this.cbKlub);
            this.tpPodaci.Controls.Add(this.cbGrad);
            this.tpPodaci.Controls.Add(this.cbDrzava);
            this.tpPodaci.Controls.Add(this.pbGrb);
            this.tpPodaci.Controls.Add(this.label4);
            this.tpPodaci.Controls.Add(this.label3);
            this.tpPodaci.Controls.Add(this.label2);
            this.tpPodaci.Controls.Add(this.label1);
            this.tpPodaci.Location = new System.Drawing.Point(4, 22);
            this.tpPodaci.Name = "tpPodaci";
            this.tpPodaci.Padding = new System.Windows.Forms.Padding(3);
            this.tpPodaci.Size = new System.Drawing.Size(634, 381);
            this.tpPodaci.TabIndex = 0;
            this.tpPodaci.Text = "Podaci o utakmicama";
            this.tpPodaci.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(544, 303);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(76, 57);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Izadji";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(544, 51);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(76, 51);
            this.btnPretraga.TabIndex = 11;
            this.btnPretraga.Text = "Reset pretrage";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // cbKlub
            // 
            this.cbKlub.FormattingEnabled = true;
            this.cbKlub.Location = new System.Drawing.Point(350, 79);
            this.cbKlub.Name = "cbKlub";
            this.cbKlub.Size = new System.Drawing.Size(121, 21);
            this.cbKlub.TabIndex = 10;
            this.cbKlub.SelectedIndexChanged += new System.EventHandler(this.cbKlub_SelectedIndexChanged);
            // 
            // cbGrad
            // 
            this.cbGrad.FormattingEnabled = true;
            this.cbGrad.Location = new System.Drawing.Point(190, 79);
            this.cbGrad.Name = "cbGrad";
            this.cbGrad.Size = new System.Drawing.Size(121, 21);
            this.cbGrad.TabIndex = 9;
            this.cbGrad.SelectedIndexChanged += new System.EventHandler(this.cbGrad_SelectedIndexChanged);
            // 
            // cbDrzava
            // 
            this.cbDrzava.FormattingEnabled = true;
            this.cbDrzava.Location = new System.Drawing.Point(23, 79);
            this.cbDrzava.Name = "cbDrzava";
            this.cbDrzava.Size = new System.Drawing.Size(121, 21);
            this.cbDrzava.TabIndex = 8;
            this.cbDrzava.SelectedIndexChanged += new System.EventHandler(this.cbDrzava_SelectedIndexChanged);
            // 
            // pbGrb
            // 
            this.pbGrb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbGrb.Location = new System.Drawing.Point(23, 170);
            this.pbGrb.Name = "pbGrb";
            this.pbGrb.Size = new System.Drawing.Size(190, 190);
            this.pbGrb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGrb.TabIndex = 7;
            this.pbGrb.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Podaci o klubu :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(362, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Klub";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Grad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Drzava";
            // 
            // tpPregled
            // 
            this.tpPregled.Controls.Add(this.listViewUtakmice);
            this.tpPregled.Controls.Add(this.label6);
            this.tpPregled.Controls.Add(this.btnExit2);
            this.tpPregled.Controls.Add(this.btnPrikazi);
            this.tpPregled.Controls.Add(this.dateTimePickerDatum);
            this.tpPregled.Location = new System.Drawing.Point(4, 22);
            this.tpPregled.Name = "tpPregled";
            this.tpPregled.Padding = new System.Windows.Forms.Padding(3);
            this.tpPregled.Size = new System.Drawing.Size(634, 381);
            this.tpPregled.TabIndex = 1;
            this.tpPregled.Text = "Pregled rezultata";
            this.tpPregled.UseVisualStyleBackColor = true;
            // 
            // tpUputstvo
            // 
            this.tpUputstvo.Controls.Add(this.label5);
            this.tpUputstvo.Location = new System.Drawing.Point(4, 22);
            this.tpUputstvo.Name = "tpUputstvo";
            this.tpUputstvo.Size = new System.Drawing.Size(634, 381);
            this.tpUputstvo.TabIndex = 2;
            this.tpUputstvo.Text = "Uputstvo";
            this.tpUputstvo.UseVisualStyleBackColor = true;
            // 
            // lblGrad
            // 
            this.lblGrad.AutoSize = true;
            this.lblGrad.Location = new System.Drawing.Point(276, 170);
            this.lblGrad.Name = "lblGrad";
            this.lblGrad.Size = new System.Drawing.Size(0, 13);
            this.lblGrad.TabIndex = 13;
            // 
            // LlblSajt
            // 
            this.LlblSajt.AutoSize = true;
            this.LlblSajt.Location = new System.Drawing.Point(276, 278);
            this.LlblSajt.Name = "LlblSajt";
            this.LlblSajt.Size = new System.Drawing.Size(0, 13);
            this.LlblSajt.TabIndex = 14;
            // 
            // lblStadion
            // 
            this.lblStadion.AutoSize = true;
            this.lblStadion.Location = new System.Drawing.Point(276, 224);
            this.lblStadion.Name = "lblStadion";
            this.lblStadion.Size = new System.Drawing.Size(0, 13);
            this.lblStadion.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Uputstvo";
            // 
            // dateTimePickerDatum
            // 
            this.dateTimePickerDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDatum.Location = new System.Drawing.Point(118, 23);
            this.dateTimePickerDatum.Name = "dateTimePickerDatum";
            this.dateTimePickerDatum.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerDatum.TabIndex = 0;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(380, 16);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(108, 34);
            this.btnPrikazi.TabIndex = 1;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // btnExit2
            // 
            this.btnExit2.Location = new System.Drawing.Point(504, 15);
            this.btnExit2.Name = "btnExit2";
            this.btnExit2.Size = new System.Drawing.Size(107, 36);
            this.btnExit2.TabIndex = 2;
            this.btnExit2.Text = "Izadji";
            this.btnExit2.UseVisualStyleBackColor = true;
            this.btnExit2.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Datum utakmice";
            // 
            // listViewUtakmice
            // 
            this.listViewUtakmice.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewUtakmice.Location = new System.Drawing.Point(10, 60);
            this.listViewUtakmice.MultiSelect = false;
            this.listViewUtakmice.Name = "listViewUtakmice";
            this.listViewUtakmice.Size = new System.Drawing.Size(618, 313);
            this.listViewUtakmice.TabIndex = 4;
            this.listViewUtakmice.UseCompatibleStateImageBehavior = false;
            this.listViewUtakmice.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Stadion";
            this.columnHeader1.Width = 223;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Domaca ekipa";
            this.columnHeader2.Width = 132;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Golovi domacina";
            this.columnHeader3.Width = 67;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Golovi gosta";
            this.columnHeader4.Width = 69;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Gostujuca ekipa";
            this.columnHeader5.Width = 125;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 405);
            this.Controls.Add(this.tabControl1);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The name of the game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpPodaci.ResumeLayout(false);
            this.tpPodaci.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrb)).EndInit();
            this.tpPregled.ResumeLayout(false);
            this.tpPregled.PerformLayout();
            this.tpUputstvo.ResumeLayout(false);
            this.tpUputstvo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpPodaci;
        private System.Windows.Forms.TabPage tpPregled;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.ComboBox cbKlub;
        private System.Windows.Forms.ComboBox cbGrad;
        private System.Windows.Forms.ComboBox cbDrzava;
        private System.Windows.Forms.PictureBox pbGrb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpUputstvo;
        private System.Windows.Forms.Label lblStadion;
        private System.Windows.Forms.LinkLabel LlblSajt;
        private System.Windows.Forms.Label lblGrad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExit2;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatum;
        private System.Windows.Forms.ListView listViewUtakmice;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label6;
    }
}

