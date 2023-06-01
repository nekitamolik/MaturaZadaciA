namespace Matura_Zadatak_A4
{
    partial class Statistika
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statistika));
            this.GV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownBrojAranzmana = new System.Windows.Forms.NumericUpDown();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.btnIzadji = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBrojAranzmana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GV
            // 
            this.GV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.GV.Location = new System.Drawing.Point(224, 12);
            this.GV.MultiSelect = false;
            this.GV.Name = "GV";
            this.GV.ReadOnly = true;
            this.GV.Size = new System.Drawing.Size(268, 300);
            this.GV.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Broj aranzmana :";
            // 
            // numericUpDownBrojAranzmana
            // 
            this.numericUpDownBrojAranzmana.Location = new System.Drawing.Point(127, 17);
            this.numericUpDownBrojAranzmana.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericUpDownBrojAranzmana.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownBrojAranzmana.Name = "numericUpDownBrojAranzmana";
            this.numericUpDownBrojAranzmana.Size = new System.Drawing.Size(58, 20);
            this.numericUpDownBrojAranzmana.TabIndex = 2;
            this.numericUpDownBrojAranzmana.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(15, 50);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(180, 36);
            this.btnPrikazi.TabIndex = 3;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // btnIzadji
            // 
            this.btnIzadji.Location = new System.Drawing.Point(15, 92);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(180, 36);
            this.btnIzadji.TabIndex = 4;
            this.btnIzadji.Text = "Izadji";
            this.btnIzadji.UseVisualStyleBackColor = true;
            this.btnIzadji.Click += new System.EventHandler(this.btnIzadji_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 134);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Statistika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 332);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnIzadji);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.numericUpDownBrojAranzmana);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GV);
            this.Name = "Statistika";
            this.Text = "Statistika";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Statistika_FormClosed);
            this.Load += new System.EventHandler(this.Vauceri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBrojAranzmana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownBrojAranzmana;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.Button btnIzadji;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}