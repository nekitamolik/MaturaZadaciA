namespace Matura_Zadatak_A20
{
    partial class Pregled
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
            this.lblDatum = new System.Windows.Forms.Label();
            this.GV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Spisak putnika ciji aranzman pocinje u narednih 15 dana i njihova dugovanja :  ";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(12, 321);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(35, 13);
            this.lblDatum.TabIndex = 1;
            this.lblDatum.Text = "label2";
            // 
            // GV
            // 
            this.GV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV.Location = new System.Drawing.Point(1, 40);
            this.GV.Name = "GV";
            this.GV.Size = new System.Drawing.Size(671, 262);
            this.GV.TabIndex = 2;
            // 
            // Pregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 349);
            this.Controls.Add(this.GV);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.label1);
            this.Name = "Pregled";
            this.Text = "Pregled";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Pregled_FormClosed);
            this.Load += new System.EventHandler(this.Pregled_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.DataGridView GV;
    }
}