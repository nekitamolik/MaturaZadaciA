namespace Matura_Zadatak_A27
{
    partial class Osiguranje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Osiguranje));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.modeliAutomobilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemModeli = new System.Windows.Forms.ToolStripMenuItem();
            this.osiguranjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemPolise = new System.Windows.Forms.ToolStripMenuItem();
            this.uputstvoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.krajRadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modeliAutomobilaToolStripMenuItem,
            this.osiguranjeToolStripMenuItem,
            this.uputstvoToolStripMenuItem,
            this.krajRadaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(345, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // modeliAutomobilaToolStripMenuItem
            // 
            this.modeliAutomobilaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemModeli});
            this.modeliAutomobilaToolStripMenuItem.Name = "modeliAutomobilaToolStripMenuItem";
            this.modeliAutomobilaToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.modeliAutomobilaToolStripMenuItem.Text = "Modeli automobila";
            // 
            // toolStripMenuItemModeli
            // 
            this.toolStripMenuItemModeli.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemModeli.Image")));
            this.toolStripMenuItemModeli.Name = "toolStripMenuItemModeli";
            this.toolStripMenuItemModeli.Size = new System.Drawing.Size(186, 56);
            this.toolStripMenuItemModeli.Text = "Modeli";
            this.toolStripMenuItemModeli.Click += new System.EventHandler(this.toolStripMenuItemModeli_Click);
            // 
            // osiguranjeToolStripMenuItem
            // 
            this.osiguranjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemPolise});
            this.osiguranjeToolStripMenuItem.Name = "osiguranjeToolStripMenuItem";
            this.osiguranjeToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.osiguranjeToolStripMenuItem.Text = "Osiguranje";
            // 
            // toolStripMenuItemPolise
            // 
            this.toolStripMenuItemPolise.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemPolise.Image")));
            this.toolStripMenuItemPolise.Name = "toolStripMenuItemPolise";
            this.toolStripMenuItemPolise.Size = new System.Drawing.Size(195, 56);
            this.toolStripMenuItemPolise.Text = "Polise koje isticu";
            this.toolStripMenuItemPolise.Click += new System.EventHandler(this.toolStripMenuItemPolise_Click);
            // 
            // uputstvoToolStripMenuItem
            // 
            this.uputstvoToolStripMenuItem.Name = "uputstvoToolStripMenuItem";
            this.uputstvoToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.uputstvoToolStripMenuItem.Text = "Uputstvo";
            this.uputstvoToolStripMenuItem.Click += new System.EventHandler(this.uputstvoToolStripMenuItem_Click);
            // 
            // krajRadaToolStripMenuItem
            // 
            this.krajRadaToolStripMenuItem.Name = "krajRadaToolStripMenuItem";
            this.krajRadaToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.krajRadaToolStripMenuItem.Text = "Kraj rada";
            this.krajRadaToolStripMenuItem.Click += new System.EventHandler(this.krajRadaToolStripMenuItem_Click);
            // 
            // Osiguranje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 136);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Osiguranje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Osiguranje motornih vozila";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modeliAutomobilaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemModeli;
        private System.Windows.Forms.ToolStripMenuItem osiguranjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPolise;
        private System.Windows.Forms.ToolStripMenuItem uputstvoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem krajRadaToolStripMenuItem;
    }
}

