namespace Matura_Zadatak_A20
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
            this.cbDestinacija = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbAranzman = new System.Windows.Forms.ComboBox();
            this.monthCalendarTrajanje = new System.Windows.Forms.MonthCalendar();
            this.listViewUplate = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelUplata = new System.Windows.Forms.Panel();
            this.btnUplati = new System.Windows.Forms.Button();
            this.tbIznos = new System.Windows.Forms.TextBox();
            this.lblDug = new System.Windows.Forms.Label();
            this.lblUkCena = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelUplata.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbDestinacija
            // 
            this.cbDestinacija.FormattingEnabled = true;
            this.cbDestinacija.Location = new System.Drawing.Point(93, 29);
            this.cbDestinacija.Name = "cbDestinacija";
            this.cbDestinacija.Size = new System.Drawing.Size(163, 21);
            this.cbDestinacija.TabIndex = 0;
            this.cbDestinacija.SelectedIndexChanged += new System.EventHandler(this.cbDestinacija_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Destinacija";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Aranzman";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Trajanje\r\naranzmana";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbAranzman
            // 
            this.cbAranzman.FormattingEnabled = true;
            this.cbAranzman.Location = new System.Drawing.Point(90, 78);
            this.cbAranzman.Name = "cbAranzman";
            this.cbAranzman.Size = new System.Drawing.Size(166, 21);
            this.cbAranzman.TabIndex = 4;
            this.cbAranzman.SelectedIndexChanged += new System.EventHandler(this.cnAranzman_SelectedIndexChanged);
            // 
            // monthCalendarTrajanje
            // 
            this.monthCalendarTrajanje.Location = new System.Drawing.Point(93, 128);
            this.monthCalendarTrajanje.Name = "monthCalendarTrajanje";
            this.monthCalendarTrajanje.TabIndex = 6;
            // 
            // listViewUplate
            // 
            this.listViewUplate.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewUplate.FullRowSelect = true;
            this.listViewUplate.Location = new System.Drawing.Point(423, 1);
            this.listViewUplate.MultiSelect = false;
            this.listViewUplate.Name = "listViewUplate";
            this.listViewUplate.Size = new System.Drawing.Size(255, 146);
            this.listViewUplate.TabIndex = 7;
            this.listViewUplate.UseCompatibleStateImageBehavior = false;
            this.listViewUplate.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Rata";
            this.columnHeader1.Width = 46;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Uplaceno";
            this.columnHeader2.Width = 87;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Datum uplate";
            this.columnHeader3.Width = 116;
            // 
            // panelUplata
            // 
            this.panelUplata.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelUplata.Controls.Add(this.btnUplati);
            this.panelUplata.Controls.Add(this.tbIznos);
            this.panelUplata.Controls.Add(this.lblDug);
            this.panelUplata.Controls.Add(this.lblUkCena);
            this.panelUplata.Controls.Add(this.label6);
            this.panelUplata.Controls.Add(this.label5);
            this.panelUplata.Controls.Add(this.label4);
            this.panelUplata.Location = new System.Drawing.Point(423, 153);
            this.panelUplata.Name = "panelUplata";
            this.panelUplata.Size = new System.Drawing.Size(255, 186);
            this.panelUplata.TabIndex = 8;
            // 
            // btnUplati
            // 
            this.btnUplati.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUplati.Location = new System.Drawing.Point(20, 135);
            this.btnUplati.Name = "btnUplati";
            this.btnUplati.Size = new System.Drawing.Size(220, 33);
            this.btnUplati.TabIndex = 6;
            this.btnUplati.Text = "Uplati";
            this.btnUplati.UseVisualStyleBackColor = true;
            this.btnUplati.Click += new System.EventHandler(this.btnUplati_Click);
            // 
            // tbIznos
            // 
            this.tbIznos.Location = new System.Drawing.Point(116, 94);
            this.tbIznos.Name = "tbIznos";
            this.tbIznos.Size = new System.Drawing.Size(136, 20);
            this.tbIznos.TabIndex = 5;
            // 
            // lblDug
            // 
            this.lblDug.AutoSize = true;
            this.lblDug.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDug.ForeColor = System.Drawing.Color.White;
            this.lblDug.Location = new System.Drawing.Point(113, 47);
            this.lblDug.Name = "lblDug";
            this.lblDug.Size = new System.Drawing.Size(0, 13);
            this.lblDug.TabIndex = 4;
            // 
            // lblUkCena
            // 
            this.lblUkCena.AutoSize = true;
            this.lblUkCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUkCena.ForeColor = System.Drawing.Color.White;
            this.lblUkCena.Location = new System.Drawing.Point(113, 16);
            this.lblUkCena.Name = "lblUkCena";
            this.lblUkCena.Size = new System.Drawing.Size(0, 13);
            this.lblUkCena.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(11, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Iznos za uplatu :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(30, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Iznos duga :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ukupna cena : ";
            // 
            // Uplata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 333);
            this.Controls.Add(this.panelUplata);
            this.Controls.Add(this.listViewUplate);
            this.Controls.Add(this.monthCalendarTrajanje);
            this.Controls.Add(this.cbAranzman);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbDestinacija);
            this.Name = "Uplata";
            this.Text = "Uplata";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Uplata_FormClosed);
            this.Load += new System.EventHandler(this.Uplata_Load);
            this.panelUplata.ResumeLayout(false);
            this.panelUplata.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDestinacija;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbAranzman;
        private System.Windows.Forms.MonthCalendar monthCalendarTrajanje;
        private System.Windows.Forms.ListView listViewUplate;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Panel panelUplata;
        private System.Windows.Forms.Button btnUplati;
        private System.Windows.Forms.TextBox tbIznos;
        private System.Windows.Forms.Label lblDug;
        private System.Windows.Forms.Label lblUkCena;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}