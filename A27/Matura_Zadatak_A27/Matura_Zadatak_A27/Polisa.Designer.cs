namespace Matura_Zadatak_A27
{
    partial class Polisa
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
            this.lbldatum = new System.Windows.Forms.Label();
            this.listViewPolise = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPrikaz = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.numericUpDownDani = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDani)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Polise koje ce isteci u narednih";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "dana";
            // 
            // lbldatum
            // 
            this.lbldatum.AutoSize = true;
            this.lbldatum.Location = new System.Drawing.Point(16, 376);
            this.lbldatum.Name = "lbldatum";
            this.lbldatum.Size = new System.Drawing.Size(35, 13);
            this.lbldatum.TabIndex = 2;
            this.lbldatum.Text = "label3";
            // 
            // listViewPolise
            // 
            this.listViewPolise.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listViewPolise.FullRowSelect = true;
            this.listViewPolise.Location = new System.Drawing.Point(12, 71);
            this.listViewPolise.MultiSelect = false;
            this.listViewPolise.Name = "listViewPolise";
            this.listViewPolise.Size = new System.Drawing.Size(585, 292);
            this.listViewPolise.TabIndex = 3;
            this.listViewPolise.UseCompatibleStateImageBehavior = false;
            this.listViewPolise.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ime";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Prezime";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Model";
            this.columnHeader3.Width = 74;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Proizvodjac";
            this.columnHeader4.Width = 88;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Registracija";
            this.columnHeader5.Width = 79;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Broj polise";
            this.columnHeader6.Width = 62;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Vazi od";
            this.columnHeader7.Width = 70;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Vazi do";
            this.columnHeader8.Width = 68;
            // 
            // btnPrikaz
            // 
            this.btnPrikaz.Location = new System.Drawing.Point(392, 13);
            this.btnPrikaz.Name = "btnPrikaz";
            this.btnPrikaz.Size = new System.Drawing.Size(86, 39);
            this.btnPrikaz.TabIndex = 4;
            this.btnPrikaz.Text = "Prikazi";
            this.btnPrikaz.UseVisualStyleBackColor = true;
            this.btnPrikaz.Click += new System.EventHandler(this.btnPrikaz_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(511, 13);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 39);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Izlaz";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // numericUpDownDani
            // 
            this.numericUpDownDani.Location = new System.Drawing.Point(197, 24);
            this.numericUpDownDani.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDani.Name = "numericUpDownDani";
            this.numericUpDownDani.Size = new System.Drawing.Size(59, 20);
            this.numericUpDownDani.TabIndex = 6;
            this.numericUpDownDani.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Polisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 411);
            this.Controls.Add(this.numericUpDownDani);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPrikaz);
            this.Controls.Add(this.listViewPolise);
            this.Controls.Add(this.lbldatum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Polisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Polisa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Polisa_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDani)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbldatum;
        private System.Windows.Forms.ListView listViewPolise;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button btnPrikaz;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.NumericUpDown numericUpDownDani;
    }
}