namespace Matura_Zadatak_A19
{
    partial class NoviRukovodioc
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
            this.cbRukovodioc = new System.Windows.Forms.ComboBox();
            this.tbDatum = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbRukovodioc
            // 
            this.cbRukovodioc.FormattingEnabled = true;
            this.cbRukovodioc.Location = new System.Drawing.Point(34, 52);
            this.cbRukovodioc.Name = "cbRukovodioc";
            this.cbRukovodioc.Size = new System.Drawing.Size(184, 21);
            this.cbRukovodioc.TabIndex = 0;
            // 
            // tbDatum
            // 
            this.tbDatum.Location = new System.Drawing.Point(34, 111);
            this.tbDatum.Name = "tbDatum";
            this.tbDatum.Size = new System.Drawing.Size(184, 20);
            this.tbDatum.TabIndex = 1;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(119, 193);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(99, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Unesi izmenu >>";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rukovodilac i datum stupanja na duznost";
            // 
            // NoviRukovodioc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.tbDatum);
            this.Controls.Add(this.cbRukovodioc);
            this.Name = "NoviRukovodioc";
            this.Text = "NoviRukovodioac";
            this.Load += new System.EventHandler(this.NoviRukovodioc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbRukovodioc;
        private System.Windows.Forms.TextBox tbDatum;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label1;
    }
}