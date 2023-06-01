namespace Matura_Zadatak_A12
{
    partial class Stadion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stadion));
            this.listViewStadioni = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownKapacitet = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBrojUlaza = new System.Windows.Forms.NumericUpDown();
            this.cbGrad = new System.Windows.Forms.ComboBox();
            this.tbSifra = new System.Windows.Forms.TextBox();
            this.tbNaziv = new System.Windows.Forms.TextBox();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSrc = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnGraph = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKapacitet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBrojUlaza)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewStadioni
            // 
            this.listViewStadioni.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewStadioni.FullRowSelect = true;
            this.listViewStadioni.Location = new System.Drawing.Point(222, 99);
            this.listViewStadioni.MultiSelect = false;
            this.listViewStadioni.Name = "listViewStadioni";
            this.listViewStadioni.Size = new System.Drawing.Size(380, 311);
            this.listViewStadioni.TabIndex = 0;
            this.listViewStadioni.UseCompatibleStateImageBehavior = false;
            this.listViewStadioni.View = System.Windows.Forms.View.Details;
            this.listViewStadioni.SelectedIndexChanged += new System.EventHandler(this.listViewStadioni_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sifra";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Naziv";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Adresa";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 81;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Kapacitet";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 51;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Broj ulaza";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 42;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Grad";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 84;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sifra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Naziv";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kapacitet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Broj ulaza";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Grad";
            // 
            // numericUpDownKapacitet
            // 
            this.numericUpDownKapacitet.Location = new System.Drawing.Point(60, 257);
            this.numericUpDownKapacitet.Name = "numericUpDownKapacitet";
            this.numericUpDownKapacitet.Size = new System.Drawing.Size(69, 20);
            this.numericUpDownKapacitet.TabIndex = 7;
            // 
            // numericUpDownBrojUlaza
            // 
            this.numericUpDownBrojUlaza.Location = new System.Drawing.Point(60, 303);
            this.numericUpDownBrojUlaza.Name = "numericUpDownBrojUlaza";
            this.numericUpDownBrojUlaza.Size = new System.Drawing.Size(69, 20);
            this.numericUpDownBrojUlaza.TabIndex = 8;
            // 
            // cbGrad
            // 
            this.cbGrad.FormattingEnabled = true;
            this.cbGrad.Location = new System.Drawing.Point(60, 353);
            this.cbGrad.Name = "cbGrad";
            this.cbGrad.Size = new System.Drawing.Size(121, 21);
            this.cbGrad.TabIndex = 9;
            // 
            // tbSifra
            // 
            this.tbSifra.Location = new System.Drawing.Point(60, 106);
            this.tbSifra.Name = "tbSifra";
            this.tbSifra.ReadOnly = true;
            this.tbSifra.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbSifra.Size = new System.Drawing.Size(57, 20);
            this.tbSifra.TabIndex = 10;
            // 
            // tbNaziv
            // 
            this.tbNaziv.Location = new System.Drawing.Point(60, 164);
            this.tbNaziv.Name = "tbNaziv";
            this.tbNaziv.Size = new System.Drawing.Size(138, 20);
            this.tbNaziv.TabIndex = 11;
            // 
            // tbAdresa
            // 
            this.tbAdresa.Location = new System.Drawing.Point(60, 212);
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(138, 20);
            this.tbAdresa.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Adresa";
            // 
            // btnSrc
            // 
            this.btnSrc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSrc.BackgroundImage")));
            this.btnSrc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSrc.Location = new System.Drawing.Point(222, 44);
            this.btnSrc.Name = "btnSrc";
            this.btnSrc.Size = new System.Drawing.Size(57, 49);
            this.btnSrc.TabIndex = 13;
            this.btnSrc.UseVisualStyleBackColor = true;
            this.btnSrc.Click += new System.EventHandler(this.btnSrc_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.Location = new System.Drawing.Point(285, 44);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(57, 49);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnGraph
            // 
            this.btnGraph.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGraph.BackgroundImage")));
            this.btnGraph.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGraph.Location = new System.Drawing.Point(348, 44);
            this.btnGraph.Name = "btnGraph";
            this.btnGraph.Size = new System.Drawing.Size(57, 49);
            this.btnGraph.TabIndex = 15;
            this.btnGraph.UseVisualStyleBackColor = true;
            this.btnGraph.Click += new System.EventHandler(this.btnGraph_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInfo.BackgroundImage")));
            this.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInfo.Location = new System.Drawing.Point(476, 44);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(57, 49);
            this.btnInfo.TabIndex = 16;
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Location = new System.Drawing.Point(539, 44);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(57, 49);
            this.btnExit.TabIndex = 17;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Stadion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 422);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnGraph);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSrc);
            this.Controls.Add(this.tbAdresa);
            this.Controls.Add(this.tbNaziv);
            this.Controls.Add(this.tbSifra);
            this.Controls.Add(this.cbGrad);
            this.Controls.Add(this.numericUpDownBrojUlaza);
            this.Controls.Add(this.numericUpDownKapacitet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewStadioni);
            this.Name = "Stadion";
            this.Text = "Stadion";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKapacitet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBrojUlaza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewStadioni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownKapacitet;
        private System.Windows.Forms.NumericUpDown numericUpDownBrojUlaza;
        private System.Windows.Forms.ComboBox cbGrad;
        private System.Windows.Forms.TextBox tbSifra;
        private System.Windows.Forms.TextBox tbNaziv;
        private System.Windows.Forms.TextBox tbAdresa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSrc;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnGraph;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}

