namespace Matura_Zadatak_A25
{
    partial class IzmenaDatuma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IzmenaDatuma));
            this.label1 = new System.Windows.Forms.Label();
            this.cbPacijent = new System.Windows.Forms.ComboBox();
            this.btnSrc = new System.Windows.Forms.Button();
            this.rtbPodaci = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.btnIzmenaDatuma = new System.Windows.Forms.Button();
            this.btnOtkazivanje = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.listViewPregled = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Podaci o pacijentu";
            // 
            // cbPacijent
            // 
            this.cbPacijent.FormattingEnabled = true;
            this.cbPacijent.Location = new System.Drawing.Point(16, 47);
            this.cbPacijent.Name = "cbPacijent";
            this.cbPacijent.Size = new System.Drawing.Size(168, 21);
            this.cbPacijent.TabIndex = 1;
            this.cbPacijent.TextChanged += new System.EventHandler(this.cbPacijent_TextChanged);
            // 
            // btnSrc
            // 
            this.btnSrc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSrc.BackgroundImage")));
            this.btnSrc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSrc.Location = new System.Drawing.Point(211, 29);
            this.btnSrc.Name = "btnSrc";
            this.btnSrc.Size = new System.Drawing.Size(63, 55);
            this.btnSrc.TabIndex = 2;
            this.btnSrc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSrc.UseVisualStyleBackColor = true;
            this.btnSrc.Click += new System.EventHandler(this.btnSrc_Click);
            // 
            // rtbPodaci
            // 
            this.rtbPodaci.Location = new System.Drawing.Point(13, 90);
            this.rtbPodaci.Name = "rtbPodaci";
            this.rtbPodaci.Size = new System.Drawing.Size(261, 169);
            this.rtbPodaci.TabIndex = 3;
            this.rtbPodaci.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Promena datuma";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(19, 337);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(255, 20);
            this.dateTimePickerDate.TabIndex = 5;
            // 
            // btnIzmenaDatuma
            // 
            this.btnIzmenaDatuma.Location = new System.Drawing.Point(311, 337);
            this.btnIzmenaDatuma.Name = "btnIzmenaDatuma";
            this.btnIzmenaDatuma.Size = new System.Drawing.Size(145, 40);
            this.btnIzmenaDatuma.TabIndex = 6;
            this.btnIzmenaDatuma.Text = "Izmeni datum";
            this.btnIzmenaDatuma.UseVisualStyleBackColor = true;
            this.btnIzmenaDatuma.Click += new System.EventHandler(this.btnIzmenaDatuma_Click);
            // 
            // btnOtkazivanje
            // 
            this.btnOtkazivanje.Location = new System.Drawing.Point(521, 337);
            this.btnOtkazivanje.Name = "btnOtkazivanje";
            this.btnOtkazivanje.Size = new System.Drawing.Size(145, 40);
            this.btnOtkazivanje.TabIndex = 7;
            this.btnOtkazivanje.Text = "Otkazi";
            this.btnOtkazivanje.UseVisualStyleBackColor = true;
            this.btnOtkazivanje.Click += new System.EventHandler(this.btnOtkazivanje_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(731, 337);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(145, 40);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Izlaz";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // listViewPregled
            // 
            this.listViewPregled.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewPregled.FullRowSelect = true;
            this.listViewPregled.Location = new System.Drawing.Point(290, 2);
            this.listViewPregled.MultiSelect = false;
            this.listViewPregled.Name = "listViewPregled";
            this.listViewPregled.Size = new System.Drawing.Size(608, 315);
            this.listViewPregled.TabIndex = 9;
            this.listViewPregled.UseCompatibleStateImageBehavior = false;
            this.listViewPregled.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Klinika";
            this.columnHeader1.Width = 185;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Lekar";
            this.columnHeader2.Width = 191;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Datum";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Status";
            this.columnHeader4.Width = 106;
            // 
            // IzmenaDatuma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 407);
            this.Controls.Add(this.listViewPregled);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOtkazivanje);
            this.Controls.Add(this.btnIzmenaDatuma);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtbPodaci);
            this.Controls.Add(this.btnSrc);
            this.Controls.Add(this.cbPacijent);
            this.Controls.Add(this.label1);
            this.Name = "IzmenaDatuma";
            this.Text = "Pacijenti";
            this.Load += new System.EventHandler(this.IzmenaDatuma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPacijent;
        private System.Windows.Forms.Button btnSrc;
        private System.Windows.Forms.RichTextBox rtbPodaci;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Button btnIzmenaDatuma;
        private System.Windows.Forms.Button btnOtkazivanje;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListView listViewPregled;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}