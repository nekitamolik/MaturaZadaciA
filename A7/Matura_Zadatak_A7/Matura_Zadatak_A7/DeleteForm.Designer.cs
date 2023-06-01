namespace Matura_Zadatak_A7
{
    partial class DeleteForm
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
            this.GV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbSifra = new System.Windows.Forms.TextBox();
            this.tbPredmet = new System.Windows.Forms.TextBox();
            this.tbSemestar = new System.Windows.Forms.TextBox();
            this.tbOpis = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GV)).BeginInit();
            this.SuspendLayout();
            // 
            // GV
            // 
            this.GV.AllowUserToAddRows = false;
            this.GV.AllowUserToDeleteRows = false;
            this.GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV.Location = new System.Drawing.Point(299, 54);
            this.GV.MultiSelect = false;
            this.GV.Name = "GV";
            this.GV.ReadOnly = true;
            this.GV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GV.Size = new System.Drawing.Size(308, 215);
            this.GV.TabIndex = 0;
            this.GV.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.GV_RowStateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Predmed ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sifra(kratko ime)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Predmet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Semestar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Opis";
            // 
            // tbID
            // 
            this.tbID.Enabled = false;
            this.tbID.Location = new System.Drawing.Point(110, 51);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(58, 20);
            this.tbID.TabIndex = 6;
            // 
            // tbSifra
            // 
            this.tbSifra.Location = new System.Drawing.Point(111, 82);
            this.tbSifra.Name = "tbSifra";
            this.tbSifra.Size = new System.Drawing.Size(57, 20);
            this.tbSifra.TabIndex = 7;
            // 
            // tbPredmet
            // 
            this.tbPredmet.Location = new System.Drawing.Point(110, 114);
            this.tbPredmet.Name = "tbPredmet";
            this.tbPredmet.Size = new System.Drawing.Size(134, 20);
            this.tbPredmet.TabIndex = 8;
            // 
            // tbSemestar
            // 
            this.tbSemestar.Location = new System.Drawing.Point(110, 141);
            this.tbSemestar.Name = "tbSemestar";
            this.tbSemestar.Size = new System.Drawing.Size(100, 20);
            this.tbSemestar.TabIndex = 9;
            // 
            // tbOpis
            // 
            this.tbOpis.Location = new System.Drawing.Point(110, 172);
            this.tbOpis.Multiline = true;
            this.tbOpis.Name = "tbOpis";
            this.tbOpis.Size = new System.Drawing.Size(134, 97);
            this.tbOpis.TabIndex = 10;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(418, 288);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 11;
            this.btnDel.Text = "Izbrisi";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(532, 288);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Izadji";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 323);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.tbOpis);
            this.Controls.Add(this.tbSemestar);
            this.Controls.Add(this.tbPredmet);
            this.Controls.Add(this.tbSifra);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GV);
            this.Name = "DeleteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteForm";
            this.Load += new System.EventHandler(this.DeleteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbSifra;
        private System.Windows.Forms.TextBox tbPredmet;
        private System.Windows.Forms.TextBox tbSemestar;
        private System.Windows.Forms.TextBox tbOpis;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnExit;
    }
}