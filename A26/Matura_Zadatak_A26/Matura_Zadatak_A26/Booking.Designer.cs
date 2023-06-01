namespace Matura_Zadatak_A26
{
    partial class Booking
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
            this.lblUkupno = new System.Windows.Forms.Label();
            this.lblOstalo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.monthCalendarOD = new System.Windows.Forms.MonthCalendar();
            this.monthCalendarDO = new System.Windows.Forms.MonthCalendar();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.GV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GV)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUkupno
            // 
            this.lblUkupno.AutoSize = true;
            this.lblUkupno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUkupno.Location = new System.Drawing.Point(103, 416);
            this.lblUkupno.Name = "lblUkupno";
            this.lblUkupno.Size = new System.Drawing.Size(122, 15);
            this.lblUkupno.TabIndex = 0;
            this.lblUkupno.Text = "Ukupni kapacitet: ";
            // 
            // lblOstalo
            // 
            this.lblOstalo.AutoSize = true;
            this.lblOstalo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOstalo.Location = new System.Drawing.Point(367, 416);
            this.lblOstalo.Name = "lblOstalo";
            this.lblOstalo.Size = new System.Drawing.Size(134, 15);
            this.lblOstalo.TabIndex = 1;
            this.lblOstalo.Text = "Dostupni kapacitet: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Polazak";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Povratak";
            // 
            // monthCalendarOD
            // 
            this.monthCalendarOD.Location = new System.Drawing.Point(90, 34);
            this.monthCalendarOD.Name = "monthCalendarOD";
            this.monthCalendarOD.TabIndex = 4;
            // 
            // monthCalendarDO
            // 
            this.monthCalendarDO.Location = new System.Drawing.Point(90, 229);
            this.monthCalendarDO.Name = "monthCalendarDO";
            this.monthCalendarDO.TabIndex = 5;
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(352, 13);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(124, 34);
            this.btnPretraga.TabIndex = 6;
            this.btnPretraga.Text = "Pretraga kapaciteta";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(514, 13);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(124, 34);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Zatvori";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // GV
            // 
            this.GV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV.Location = new System.Drawing.Point(352, 65);
            this.GV.MultiSelect = false;
            this.GV.Name = "GV";
            this.GV.ReadOnly = true;
            this.GV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GV.Size = new System.Drawing.Size(286, 326);
            this.GV.TabIndex = 8;
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 452);
            this.Controls.Add(this.GV);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.monthCalendarDO);
            this.Controls.Add(this.monthCalendarOD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOstalo);
            this.Controls.Add(this.lblUkupno);
            this.Name = "Booking";
            this.Text = "Book";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Booking_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.GV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUkupno;
        private System.Windows.Forms.Label lblOstalo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar monthCalendarOD;
        private System.Windows.Forms.MonthCalendar monthCalendarDO;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView GV;
    }
}