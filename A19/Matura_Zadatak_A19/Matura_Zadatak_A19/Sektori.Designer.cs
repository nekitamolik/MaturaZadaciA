namespace Matura_Zadatak_A19
{
    partial class Sektori
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sektori));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAnaliza = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonExit = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSektor = new System.Windows.Forms.ComboBox();
            this.btnRukovodilacIzmena = new System.Windows.Forms.Button();
            this.listViewRukovodioci = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rtbOpis = new System.Windows.Forms.RichTextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAnaliza,
            this.toolStripButtonExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(730, 57);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonAnaliza
            // 
            this.toolStripButtonAnaliza.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAnaliza.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAnaliza.Image")));
            this.toolStripButtonAnaliza.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAnaliza.Name = "toolStripButtonAnaliza";
            this.toolStripButtonAnaliza.Size = new System.Drawing.Size(54, 54);
            this.toolStripButtonAnaliza.Text = "toolStripButton1";
            this.toolStripButtonAnaliza.Click += new System.EventHandler(this.toolStripButtonAnaliza_Click);
            // 
            // toolStripButtonExit
            // 
            this.toolStripButtonExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonExit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonExit.Image")));
            this.toolStripButtonExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExit.Name = "toolStripButtonExit";
            this.toolStripButtonExit.Size = new System.Drawing.Size(54, 54);
            this.toolStripButtonExit.Text = "toolStripButton2";
            this.toolStripButtonExit.Click += new System.EventHandler(this.toolStripButtonExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sektor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Podaci o sektoru";
            // 
            // cbSektor
            // 
            this.cbSektor.FormattingEnabled = true;
            this.cbSektor.Location = new System.Drawing.Point(130, 85);
            this.cbSektor.Name = "cbSektor";
            this.cbSektor.Size = new System.Drawing.Size(195, 21);
            this.cbSektor.TabIndex = 3;
            this.cbSektor.SelectedIndexChanged += new System.EventHandler(this.cbSektor_SelectedIndexChanged);
            // 
            // btnRukovodilacIzmena
            // 
            this.btnRukovodilacIzmena.Location = new System.Drawing.Point(130, 283);
            this.btnRukovodilacIzmena.Name = "btnRukovodilacIzmena";
            this.btnRukovodilacIzmena.Size = new System.Drawing.Size(195, 23);
            this.btnRukovodilacIzmena.TabIndex = 5;
            this.btnRukovodilacIzmena.Text = "Promeni rukovodioca";
            this.btnRukovodilacIzmena.UseVisualStyleBackColor = true;
            this.btnRukovodilacIzmena.Click += new System.EventHandler(this.btnRukovodilacIzmena_Click);
            // 
            // listViewRukovodioci
            // 
            this.listViewRukovodioci.AccessibleName = "";
            this.listViewRukovodioci.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewRukovodioci.FullRowSelect = true;
            this.listViewRukovodioci.Location = new System.Drawing.Point(377, 85);
            this.listViewRukovodioci.MultiSelect = false;
            this.listViewRukovodioci.Name = "listViewRukovodioci";
            this.listViewRukovodioci.Size = new System.Drawing.Size(341, 221);
            this.listViewRukovodioci.TabIndex = 6;
            this.listViewRukovodioci.UseCompatibleStateImageBehavior = false;
            this.listViewRukovodioci.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sifra";
            this.columnHeader1.Width = 37;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ime";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 78;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Prezime";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 83;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "OD";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 70;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "DO";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 68;
            // 
            // rtbOpis
            // 
            this.rtbOpis.BackColor = System.Drawing.SystemColors.Control;
            this.rtbOpis.Location = new System.Drawing.Point(130, 122);
            this.rtbOpis.Name = "rtbOpis";
            this.rtbOpis.ReadOnly = true;
            this.rtbOpis.Size = new System.Drawing.Size(195, 130);
            this.rtbOpis.TabIndex = 7;
            this.rtbOpis.Text = "";
            // 
            // Sektori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 320);
            this.Controls.Add(this.rtbOpis);
            this.Controls.Add(this.listViewRukovodioci);
            this.Controls.Add(this.btnRukovodilacIzmena);
            this.Controls.Add(this.cbSektor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Sektori";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAnaliza;
        private System.Windows.Forms.ToolStripButton toolStripButtonExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSektor;
        private System.Windows.Forms.Button btnRukovodilacIzmena;
        private System.Windows.Forms.ListView listViewRukovodioci;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.RichTextBox rtbOpis;
    }
}

