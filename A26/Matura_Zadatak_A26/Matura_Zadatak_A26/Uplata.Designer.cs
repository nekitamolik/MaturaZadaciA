namespace Matura_Zadatak_A26
{
    partial class Uplata
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
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listViewPregled = new System.Windows.Forms.ListView();
            this.btnUplata = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tbIznos = new System.Windows.Forms.TextBox();
            this.cbNP = new System.Windows.Forms.ComboBox();
            this.cbUgovorID = new System.Windows.Forms.ComboBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblUgovor = new System.Windows.Forms.Label();
            this.lblUgovarac = new System.Windows.Forms.Label();
            this.lblPocetak = new System.Windows.Forms.Label();
            this.lblBrDana = new System.Windows.Forms.Label();
            this.lblUkupno = new System.Windows.Forms.Label();
            this.lblRok = new System.Windows.Forms.Label();
            this.lblDug = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Broj ugovora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nacin placanja";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(248, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Iznos uplate";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDug);
            this.groupBox1.Controls.Add(this.lblRok);
            this.groupBox1.Controls.Add(this.lblUkupno);
            this.groupBox1.Controls.Add(this.lblBrDana);
            this.groupBox1.Controls.Add(this.lblPocetak);
            this.groupBox1.Controls.Add(this.lblUgovarac);
            this.groupBox1.Controls.Add(this.lblUgovor);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 189);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci o ugovoravacu";
            // 
            // listViewPregled
            // 
            this.listViewPregled.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewPregled.FullRowSelect = true;
            this.listViewPregled.Location = new System.Drawing.Point(236, 159);
            this.listViewPregled.MultiSelect = false;
            this.listViewPregled.Name = "listViewPregled";
            this.listViewPregled.Size = new System.Drawing.Size(292, 127);
            this.listViewPregled.TabIndex = 4;
            this.listViewPregled.UseCompatibleStateImageBehavior = false;
            this.listViewPregled.View = System.Windows.Forms.View.Details;
            // 
            // btnUplata
            // 
            this.btnUplata.Location = new System.Drawing.Point(453, 29);
            this.btnUplata.Name = "btnUplata";
            this.btnUplata.Size = new System.Drawing.Size(75, 39);
            this.btnUplata.TabIndex = 5;
            this.btnUplata.Text = "Uplati";
            this.btnUplata.UseVisualStyleBackColor = true;
            this.btnUplata.Click += new System.EventHandler(this.btnUplata_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(453, 97);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 39);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Zatvori";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tbIznos
            // 
            this.tbIznos.Location = new System.Drawing.Point(233, 115);
            this.tbIznos.Name = "tbIznos";
            this.tbIznos.Size = new System.Drawing.Size(173, 20);
            this.tbIznos.TabIndex = 7;
            // 
            // cbNP
            // 
            this.cbNP.FormattingEnabled = true;
            this.cbNP.Location = new System.Drawing.Point(222, 47);
            this.cbNP.Name = "cbNP";
            this.cbNP.Size = new System.Drawing.Size(184, 21);
            this.cbNP.TabIndex = 8;
            // 
            // cbUgovorID
            // 
            this.cbUgovorID.FormattingEnabled = true;
            this.cbUgovorID.Location = new System.Drawing.Point(13, 47);
            this.cbUgovorID.Name = "cbUgovorID";
            this.cbUgovorID.Size = new System.Drawing.Size(175, 21);
            this.cbUgovorID.TabIndex = 9;
            this.cbUgovorID.SelectedIndexChanged += new System.EventHandler(this.cbUgovorID_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Rata";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Iznos";
            this.columnHeader2.Width = 72;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nacin placanja";
            this.columnHeader3.Width = 114;
            // 
            // lblUgovor
            // 
            this.lblUgovor.AutoSize = true;
            this.lblUgovor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUgovor.Location = new System.Drawing.Point(13, 25);
            this.lblUgovor.Name = "lblUgovor";
            this.lblUgovor.Size = new System.Drawing.Size(63, 15);
            this.lblUgovor.TabIndex = 0;
            this.lblUgovor.Text = "Ugovor br:";
            // 
            // lblUgovarac
            // 
            this.lblUgovarac.AutoSize = true;
            this.lblUgovarac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUgovarac.Location = new System.Drawing.Point(13, 44);
            this.lblUgovarac.Name = "lblUgovarac";
            this.lblUgovarac.Size = new System.Drawing.Size(62, 15);
            this.lblUgovarac.TabIndex = 1;
            this.lblUgovarac.Text = "Ugovarac:";
            // 
            // lblPocetak
            // 
            this.lblPocetak.AutoSize = true;
            this.lblPocetak.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPocetak.Location = new System.Drawing.Point(13, 63);
            this.lblPocetak.Name = "lblPocetak";
            this.lblPocetak.Size = new System.Drawing.Size(94, 15);
            this.lblPocetak.TabIndex = 2;
            this.lblPocetak.Text = "Pocetak usluge:";
            // 
            // lblBrDana
            // 
            this.lblBrDana.AutoSize = true;
            this.lblBrDana.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrDana.Location = new System.Drawing.Point(13, 82);
            this.lblBrDana.Name = "lblBrDana";
            this.lblBrDana.Size = new System.Drawing.Size(63, 15);
            this.lblBrDana.TabIndex = 3;
            this.lblBrDana.Text = "Broj dana:";
            // 
            // lblUkupno
            // 
            this.lblUkupno.AutoSize = true;
            this.lblUkupno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUkupno.Location = new System.Drawing.Point(13, 101);
            this.lblUkupno.Name = "lblUkupno";
            this.lblUkupno.Size = new System.Drawing.Size(85, 15);
            this.lblUkupno.TabIndex = 4;
            this.lblUkupno.Text = "Ukupan iznos:";
            // 
            // lblRok
            // 
            this.lblRok.AutoSize = true;
            this.lblRok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRok.Location = new System.Drawing.Point(13, 120);
            this.lblRok.Name = "lblRok";
            this.lblRok.Size = new System.Drawing.Size(85, 15);
            this.lblRok.TabIndex = 5;
            this.lblRok.Text = "Rok za uplatu:";
            // 
            // lblDug
            // 
            this.lblDug.AutoSize = true;
            this.lblDug.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDug.Location = new System.Drawing.Point(13, 139);
            this.lblDug.Name = "lblDug";
            this.lblDug.Size = new System.Drawing.Size(33, 15);
            this.lblDug.TabIndex = 6;
            this.lblDug.Text = "Dug:";
            // 
            // Uplata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 298);
            this.Controls.Add(this.cbUgovorID);
            this.Controls.Add(this.cbNP);
            this.Controls.Add(this.tbIznos);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUplata);
            this.Controls.Add(this.listViewPregled);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Uplata";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Placanja";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Uplata_FormClosed);
            this.Load += new System.EventHandler(this.Uplata_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDug;
        private System.Windows.Forms.Label lblRok;
        private System.Windows.Forms.Label lblUkupno;
        private System.Windows.Forms.Label lblBrDana;
        private System.Windows.Forms.Label lblPocetak;
        private System.Windows.Forms.Label lblUgovarac;
        private System.Windows.Forms.Label lblUgovor;
        private System.Windows.Forms.ListView listViewPregled;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnUplata;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox tbIznos;
        private System.Windows.Forms.ComboBox cbNP;
        private System.Windows.Forms.ComboBox cbUgovorID;
    }
}