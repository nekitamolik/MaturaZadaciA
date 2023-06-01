namespace Matura_Zadatak_A7
{
    partial class Komunikacija
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Komunikacija));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnGraph = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel2,
            this.toolStripLabel3,
            this.toolStripLabel4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(559, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.toolStripLabel1.Size = new System.Drawing.Size(78, 22);
            this.toolStripLabel1.Text = "Obrisi";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.toolStripLabel2.Size = new System.Drawing.Size(118, 22);
            this.toolStripLabel2.Text = "Nacrtaj grafik";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.toolStripLabel3.Size = new System.Drawing.Size(95, 22);
            this.toolStripLabel3.Text = "Uputstvo";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.toolStripLabel4.Size = new System.Drawing.Size(69, 22);
            this.toolStripLabel4.Text = "Izlaz";
            // 
            // btnDel
            // 
            this.btnDel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDel.BackgroundImage")));
            this.btnDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDel.Location = new System.Drawing.Point(13, 29);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(100, 100);
            this.btnDel.TabIndex = 1;
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnGraph
            // 
            this.btnGraph.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGraph.BackgroundImage")));
            this.btnGraph.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGraph.Location = new System.Drawing.Point(130, 29);
            this.btnGraph.Name = "btnGraph";
            this.btnGraph.Size = new System.Drawing.Size(100, 100);
            this.btnGraph.TabIndex = 2;
            this.btnGraph.UseVisualStyleBackColor = true;
            this.btnGraph.Click += new System.EventHandler(this.btnGraph_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInfo.BackgroundImage")));
            this.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInfo.Location = new System.Drawing.Point(247, 29);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(100, 100);
            this.btnInfo.TabIndex = 3;
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Location = new System.Drawing.Point(364, 28);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 100);
            this.btnExit.TabIndex = 4;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Komunikacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 140);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnGraph);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Komunikacija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Komunikacija student profesor";
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
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnGraph;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnExit;

    }
}

