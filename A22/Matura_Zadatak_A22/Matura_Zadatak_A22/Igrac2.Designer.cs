namespace Matura_Zadatak_A22
{
    partial class Igrac2
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
            this.btnDrugiIgrac = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBoxIgraci
            // 
            this.checkedListBoxIgraci.FormattingEnabled = true;
            this.checkedListBoxIgraci.Location = new System.Drawing.Point(0, 1);
            this.checkedListBoxIgraci.Name = "checkedListBoxIgraci";
            this.checkedListBoxIgraci.Size = new System.Drawing.Size(176, 199);
            this.checkedListBoxIgraci.TabIndex = 0;
            // 
            // btnDrugiIgrac
            // 
            this.btnDrugiIgrac.Location = new System.Drawing.Point(0, 207);
            this.btnDrugiIgrac.Name = "btnDrugiIgrac";
            this.btnDrugiIgrac.Size = new System.Drawing.Size(176, 42);
            this.btnDrugiIgrac.TabIndex = 1;
            this.btnDrugiIgrac.Text = "Drugi igrac";
            this.btnDrugiIgrac.UseVisualStyleBackColor = true;
            this.btnDrugiIgrac.Click += new System.EventHandler(this.btnDrugiIgrac_Click);
            // 
            // Igrac2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(176, 250);
            this.Controls.Add(this.btnDrugiIgrac);
            this.Controls.Add(this.checkedListBoxIgraci);
            this.Name = "Igrac2";
            this.Text = "Igrac2";
            this.Load += new System.EventHandler(this.Igrac2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxIgraci;
        private System.Windows.Forms.Button btnDrugiIgrac;
    }
}