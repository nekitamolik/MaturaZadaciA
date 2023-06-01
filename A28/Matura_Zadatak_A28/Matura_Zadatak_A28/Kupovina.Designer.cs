namespace Matura_Zadatak_A28
{
    partial class Kupovina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kupovina));
            this.label1 = new System.Windows.Forms.Label();
            this.tbPorudzbinaID = new System.Windows.Forms.TextBox();
            this.GV = new System.Windows.Forms.DataGridView();
            this.btnKupi = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPrikaz = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtbRacun = new System.Windows.Forms.RichTextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sifra porudzbine";
            // 
            // tbPorudzbinaID
            // 
            this.tbPorudzbinaID.Location = new System.Drawing.Point(25, 41);
            this.tbPorudzbinaID.Name = "tbPorudzbinaID";
            this.tbPorudzbinaID.Size = new System.Drawing.Size(135, 20);
            this.tbPorudzbinaID.TabIndex = 1;
            // 
            // GV
            // 
            this.GV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.GV.Location = new System.Drawing.Point(12, 229);
            this.GV.MultiSelect = false;
            this.GV.Name = "GV";
            this.GV.Size = new System.Drawing.Size(634, 152);
            this.GV.TabIndex = 2;
            this.GV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GV_CellClick);
            // 
            // btnKupi
            // 
            this.btnKupi.Location = new System.Drawing.Point(12, 389);
            this.btnKupi.Name = "btnKupi";
            this.btnKupi.Size = new System.Drawing.Size(138, 51);
            this.btnKupi.TabIndex = 3;
            this.btnKupi.Text = "Dodaj u korpu";
            this.btnKupi.UseVisualStyleBackColor = true;
            this.btnKupi.Click += new System.EventHandler(this.btnKupi_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(508, 387);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(138, 51);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Izlaz";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPrikaz
            // 
            this.btnPrikaz.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrikaz.BackgroundImage")));
            this.btnPrikaz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrikaz.Location = new System.Drawing.Point(25, 137);
            this.btnPrikaz.Name = "btnPrikaz";
            this.btnPrikaz.Size = new System.Drawing.Size(125, 48);
            this.btnPrikaz.TabIndex = 5;
            this.btnPrikaz.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrikaz.UseVisualStyleBackColor = true;
            this.btnPrikaz.Click += new System.EventHandler(this.btnPrikaz_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtbRacun);
            this.groupBox1.Location = new System.Drawing.Point(180, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 172);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kupovina";
            // 
            // rtbRacun
            // 
            this.rtbRacun.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbRacun.Location = new System.Drawing.Point(7, 20);
            this.rtbRacun.Name = "rtbRacun";
            this.rtbRacun.Size = new System.Drawing.Size(453, 146);
            this.rtbRacun.TabIndex = 0;
            this.rtbRacun.Text = "";
            // 
            // Column1
            // 
            this.Column1.FillWeight = 40F;
            this.Column1.HeaderText = "Sifra";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 150F;
            this.Column2.HeaderText = "Naziv proizvoda";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 40F;
            this.Column3.HeaderText = "Jedinica mere";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 30F;
            this.Column4.HeaderText = "Cena RSD";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 50F;
            this.Column5.HeaderText = "Izabrani proizvod";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 50F;
            this.Column6.HeaderText = "Kolicina";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Kupovina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 452);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPrikaz);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnKupi);
            this.Controls.Add(this.GV);
            this.Controls.Add(this.tbPorudzbinaID);
            this.Controls.Add(this.label1);
            this.Name = "Kupovina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kupovina";
            ((System.ComponentModel.ISupportInitialize)(this.GV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPorudzbinaID;
        private System.Windows.Forms.DataGridView GV;
        private System.Windows.Forms.Button btnKupi;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPrikaz;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtbRacun;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}