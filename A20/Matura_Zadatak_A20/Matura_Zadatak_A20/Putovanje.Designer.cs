namespace Matura_Zadatak_A20
{
    partial class Putovanje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Putovanje));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.btnUplata = new System.Windows.Forms.Button();
            this.btnPregled = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel2,
            this.toolStripLabel3,
            this.toolStripLabel4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(513, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.toolStripLabel1.Size = new System.Drawing.Size(63, 22);
            this.toolStripLabel1.Text = "Uplata";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.toolStripLabel2.Size = new System.Drawing.Size(130, 22);
            this.toolStripLabel2.Text = "Pregled dugovanja";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.toolStripLabel3.Size = new System.Drawing.Size(79, 22);
            this.toolStripLabel3.Text = "Uputstvo";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.toolStripLabel4.Size = new System.Drawing.Size(52, 22);
            this.toolStripLabel4.Text = "Izlaz";
            // 
            // btnUplata
            // 
            this.btnUplata.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUplata.BackgroundImage")));
            this.btnUplata.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUplata.Location = new System.Drawing.Point(13, 38);
            this.btnUplata.Name = "btnUplata";
            this.btnUplata.Size = new System.Drawing.Size(85, 79);
            this.btnUplata.TabIndex = 1;
            this.btnUplata.UseVisualStyleBackColor = true;
            this.btnUplata.Click += new System.EventHandler(this.btnUplata_Click);
            // 
            // btnPregled
            // 
            this.btnPregled.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPregled.BackgroundImage")));
            this.btnPregled.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPregled.Location = new System.Drawing.Point(151, 38);
            this.btnPregled.Name = "btnPregled";
            this.btnPregled.Size = new System.Drawing.Size(85, 79);
            this.btnPregled.TabIndex = 2;
            this.btnPregled.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPregled.UseVisualStyleBackColor = true;
            this.btnPregled.Click += new System.EventHandler(this.btnPregled_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInfo.BackgroundImage")));
            this.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInfo.Location = new System.Drawing.Point(278, 38);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(85, 79);
            this.btnInfo.TabIndex = 3;
            this.btnInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.BackColor = System.Drawing.Color.White;
            this.btnIzlaz.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIzlaz.BackgroundImage")));
            this.btnIzlaz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIzlaz.Location = new System.Drawing.Point(416, 38);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(85, 79);
            this.btnIzlaz.TabIndex = 4;
            this.btnIzlaz.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnIzlaz.UseVisualStyleBackColor = false;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // Putovanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 135);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnPregled);
            this.Controls.Add(this.btnUplata);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Putovanje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turisticka putovanja";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.Button btnUplata;
        private System.Windows.Forms.Button btnPregled;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnIzlaz;
    }
}

