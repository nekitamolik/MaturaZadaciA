namespace Matura_Zadatak_A28
{
    partial class Stovariste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stovariste));
            this.btnKupovina = new System.Windows.Forms.Button();
            this.btnIsporuka = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKupovina
            // 
            this.btnKupovina.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKupovina.BackgroundImage")));
            this.btnKupovina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKupovina.Location = new System.Drawing.Point(33, 27);
            this.btnKupovina.Name = "btnKupovina";
            this.btnKupovina.Size = new System.Drawing.Size(100, 100);
            this.btnKupovina.TabIndex = 0;
            this.btnKupovina.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKupovina.UseVisualStyleBackColor = true;
            this.btnKupovina.Click += new System.EventHandler(this.btnKupovina_Click);
            // 
            // btnIsporuka
            // 
            this.btnIsporuka.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIsporuka.BackgroundImage")));
            this.btnIsporuka.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIsporuka.Location = new System.Drawing.Point(153, 27);
            this.btnIsporuka.Name = "btnIsporuka";
            this.btnIsporuka.Size = new System.Drawing.Size(100, 100);
            this.btnIsporuka.TabIndex = 0;
            this.btnIsporuka.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIsporuka.UseVisualStyleBackColor = true;
            this.btnIsporuka.Click += new System.EventHandler(this.btnIsporuka_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInfo.BackgroundImage")));
            this.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInfo.Location = new System.Drawing.Point(273, 27);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(100, 100);
            this.btnInfo.TabIndex = 0;
            this.btnInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Location = new System.Drawing.Point(393, 27);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 100);
            this.btnExit.TabIndex = 0;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Stovariste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 156);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnIsporuka);
            this.Controls.Add(this.btnKupovina);
            this.Name = "Stovariste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stovariste";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKupovina;
        private System.Windows.Forms.Button btnIsporuka;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnExit;
    }
}

