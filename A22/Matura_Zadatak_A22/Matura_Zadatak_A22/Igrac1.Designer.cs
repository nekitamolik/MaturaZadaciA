namespace Matura_Zadatak_A22
{
    partial class Igrac1
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
            this.checkedListBoxIgraci = new System.Windows.Forms.CheckedListBox();
            this.btnPrviIgrac = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBoxIgraci
            // 
            this.checkedListBoxIgraci.FormattingEnabled = true;
            this.checkedListBoxIgraci.Location = new System.Drawing.Point(1, 1);
            this.checkedListBoxIgraci.Name = "checkedListBoxIgraci";
            this.checkedListBoxIgraci.Size = new System.Drawing.Size(176, 199);
            this.checkedListBoxIgraci.TabIndex = 1;
            // 
            // btnPrviIgrac
            // 
            this.btnPrviIgrac.Location = new System.Drawing.Point(1, 207);
            this.btnPrviIgrac.Name = "btnPrviIgrac";
            this.btnPrviIgrac.Size = new System.Drawing.Size(176, 42);
            this.btnPrviIgrac.TabIndex = 2;
            this.btnPrviIgrac.Text = "Prvi igrac";
            this.btnPrviIgrac.UseVisualStyleBackColor = true;
            this.btnPrviIgrac.Click += new System.EventHandler(this.btnPrviIgrac_Click);
            // 
            // Igrac1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(179, 248);
            this.Controls.Add(this.btnPrviIgrac);
            this.Controls.Add(this.checkedListBoxIgraci);
            this.Name = "Igrac1";
            this.Text = "Igrac1";
            this.Load += new System.EventHandler(this.Igrac1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxIgraci;
        private System.Windows.Forms.Button btnPrviIgrac;
    }
}