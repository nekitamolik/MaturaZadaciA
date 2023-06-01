namespace Matura_Zadatak_A23
{
    partial class Pozoriste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pozoriste));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonRegistracija = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRepertoar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonInfo = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonExit = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(110, 110);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonRegistracija,
            this.toolStripButtonRepertoar,
            this.toolStripButtonInfo,
            this.toolStripButtonExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(489, 132);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonRegistracija
            // 
            this.toolStripButtonRegistracija.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRegistracija.Image")));
            this.toolStripButtonRegistracija.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRegistracija.Name = "toolStripButtonRegistracija";
            this.toolStripButtonRegistracija.Size = new System.Drawing.Size(114, 129);
            this.toolStripButtonRegistracija.Text = "Registracija";
            this.toolStripButtonRegistracija.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonRegistracija.Click += new System.EventHandler(this.toolStripButtonRegistracija_Click);
            // 
            // toolStripButtonRepertoar
            // 
            this.toolStripButtonRepertoar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRepertoar.Image")));
            this.toolStripButtonRepertoar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRepertoar.Name = "toolStripButtonRepertoar";
            this.toolStripButtonRepertoar.Size = new System.Drawing.Size(114, 129);
            this.toolStripButtonRepertoar.Text = "Repertoar";
            this.toolStripButtonRepertoar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonRepertoar.Click += new System.EventHandler(this.toolStripButtonRepertoar_Click);
            // 
            // toolStripButtonInfo
            // 
            this.toolStripButtonInfo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonInfo.Image")));
            this.toolStripButtonInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonInfo.Name = "toolStripButtonInfo";
            this.toolStripButtonInfo.Size = new System.Drawing.Size(114, 129);
            this.toolStripButtonInfo.Text = "O aplikaciji";
            this.toolStripButtonInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonInfo.Click += new System.EventHandler(this.toolStripButtonInfo_Click);
            // 
            // toolStripButtonExit
            // 
            this.toolStripButtonExit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonExit.Image")));
            this.toolStripButtonExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExit.Name = "toolStripButtonExit";
            this.toolStripButtonExit.Size = new System.Drawing.Size(114, 129);
            this.toolStripButtonExit.Text = "Izlaz";
            this.toolStripButtonExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonExit.Click += new System.EventHandler(this.toolStripButtonExit_Click);
            // 
            // Pozoriste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 137);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Pozoriste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pozoriste-Neregistrovani Korisnik";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonRegistracija;
        private System.Windows.Forms.ToolStripButton toolStripButtonRepertoar;
        private System.Windows.Forms.ToolStripButton toolStripButtonInfo;
        private System.Windows.Forms.ToolStripButton toolStripButtonExit;
    }
}

