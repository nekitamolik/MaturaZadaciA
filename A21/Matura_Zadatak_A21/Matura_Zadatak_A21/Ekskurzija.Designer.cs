namespace Matura_Zadatak_A21
{
    partial class Ekskurzija
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
            this.cbDestinacija = new System.Windows.Forms.ComboBox();
            this.listViewEkskurzije = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbNed = new System.Windows.Forms.CheckBox();
            this.cbSub = new System.Windows.Forms.CheckBox();
            this.cbPet = new System.Windows.Forms.CheckBox();
            this.cbCet = new System.Windows.Forms.CheckBox();
            this.cbSre = new System.Windows.Forms.CheckBox();
            this.cbUto = new System.Windows.Forms.CheckBox();
            this.cbPon = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Destinacija";
            // 
            // cbDestinacija
            // 
            this.cbDestinacija.FormattingEnabled = true;
            this.cbDestinacija.Location = new System.Drawing.Point(145, 34);
            this.cbDestinacija.Name = "cbDestinacija";
            this.cbDestinacija.Size = new System.Drawing.Size(190, 21);
            this.cbDestinacija.TabIndex = 1;
            this.cbDestinacija.SelectedIndexChanged += new System.EventHandler(this.cbDestinacija_SelectedIndexChanged);
            // 
            // listViewEkskurzije
            // 
            this.listViewEkskurzije.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewEkskurzije.FullRowSelect = true;
            this.listViewEkskurzije.Location = new System.Drawing.Point(2, 69);
            this.listViewEkskurzije.MultiSelect = false;
            this.listViewEkskurzije.Name = "listViewEkskurzije";
            this.listViewEkskurzije.Size = new System.Drawing.Size(209, 296);
            this.listViewEkskurzije.TabIndex = 2;
            this.listViewEkskurzije.UseCompatibleStateImageBehavior = false;
            this.listViewEkskurzije.View = System.Windows.Forms.View.Details;
            this.listViewEkskurzije.SelectedIndexChanged += new System.EventHandler(this.listViewEkskurzije_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sifra";
            this.columnHeader1.Width = 44;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ekskurzija";
            this.columnHeader2.Width = 78;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cena";
            this.columnHeader3.Width = 80;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(217, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 296);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(18, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Unesi izmene u raspored";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbNed);
            this.groupBox1.Controls.Add(this.cbSub);
            this.groupBox1.Controls.Add(this.cbPet);
            this.groupBox1.Controls.Add(this.cbCet);
            this.groupBox1.Controls.Add(this.cbSre);
            this.groupBox1.Controls.Add(this.cbUto);
            this.groupBox1.Controls.Add(this.cbPon);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(18, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 164);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Organizuje se sledecim danima";
            // 
            // cbNed
            // 
            this.cbNed.AutoSize = true;
            this.cbNed.Location = new System.Drawing.Point(6, 113);
            this.cbNed.Name = "cbNed";
            this.cbNed.Size = new System.Drawing.Size(82, 20);
            this.cbNed.TabIndex = 6;
            this.cbNed.Text = "Nedelja";
            this.cbNed.UseVisualStyleBackColor = true;
            // 
            // cbSub
            // 
            this.cbSub.AutoSize = true;
            this.cbSub.Location = new System.Drawing.Point(126, 87);
            this.cbSub.Name = "cbSub";
            this.cbSub.Size = new System.Drawing.Size(76, 20);
            this.cbSub.TabIndex = 5;
            this.cbSub.Text = "Subota";
            this.cbSub.UseVisualStyleBackColor = true;
            // 
            // cbPet
            // 
            this.cbPet.AutoSize = true;
            this.cbPet.Location = new System.Drawing.Point(126, 60);
            this.cbPet.Name = "cbPet";
            this.cbPet.Size = new System.Drawing.Size(67, 20);
            this.cbPet.TabIndex = 4;
            this.cbPet.Text = "Petak";
            this.cbPet.UseVisualStyleBackColor = true;
            // 
            // cbCet
            // 
            this.cbCet.AutoSize = true;
            this.cbCet.Location = new System.Drawing.Point(126, 36);
            this.cbCet.Name = "cbCet";
            this.cbCet.Size = new System.Drawing.Size(84, 20);
            this.cbCet.TabIndex = 3;
            this.cbCet.Text = "Cetvrtak";
            this.cbCet.UseVisualStyleBackColor = true;
            // 
            // cbSre
            // 
            this.cbSre.AutoSize = true;
            this.cbSre.Location = new System.Drawing.Point(6, 87);
            this.cbSre.Name = "cbSre";
            this.cbSre.Size = new System.Drawing.Size(69, 20);
            this.cbSre.TabIndex = 2;
            this.cbSre.Text = "Sreda";
            this.cbSre.UseVisualStyleBackColor = true;
            // 
            // cbUto
            // 
            this.cbUto.AutoSize = true;
            this.cbUto.Location = new System.Drawing.Point(6, 60);
            this.cbUto.Name = "cbUto";
            this.cbUto.Size = new System.Drawing.Size(73, 20);
            this.cbUto.TabIndex = 1;
            this.cbUto.Text = "Utorak";
            this.cbUto.UseVisualStyleBackColor = true;
            // 
            // cbPon
            // 
            this.cbPon.AutoSize = true;
            this.cbPon.Location = new System.Drawing.Point(6, 34);
            this.cbPon.Name = "cbPon";
            this.cbPon.Size = new System.Drawing.Size(106, 20);
            this.cbPon.TabIndex = 0;
            this.cbPon.Text = "Ponedeljak";
            this.cbPon.UseVisualStyleBackColor = true;
            // 
            // Ekskurzija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 365);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listViewEkskurzije);
            this.Controls.Add(this.cbDestinacija);
            this.Controls.Add(this.label1);
            this.Name = "Ekskurzija";
            this.Text = "Ekskurzija";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Ekskurzija_FormClosed);
            this.Load += new System.EventHandler(this.Ekskurzija_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDestinacija;
        private System.Windows.Forms.ListView listViewEkskurzije;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbNed;
        private System.Windows.Forms.CheckBox cbSub;
        private System.Windows.Forms.CheckBox cbPet;
        private System.Windows.Forms.CheckBox cbCet;
        private System.Windows.Forms.CheckBox cbSre;
        private System.Windows.Forms.CheckBox cbUto;
        private System.Windows.Forms.CheckBox cbPon;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}