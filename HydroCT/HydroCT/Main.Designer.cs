namespace HydroCT
{
    partial class frmMain
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
            this.btnRainfall = new System.Windows.Forms.Button();
            this.btnDamLevels = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectDataSourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRainfall
            // 
            this.btnRainfall.Location = new System.Drawing.Point(144, 232);
            this.btnRainfall.Name = "btnRainfall";
            this.btnRainfall.Size = new System.Drawing.Size(125, 38);
            this.btnRainfall.TabIndex = 0;
            this.btnRainfall.Text = "Rainfall";
            this.btnRainfall.UseVisualStyleBackColor = true;
            this.btnRainfall.Click += new System.EventHandler(this.btnRainfall_Click);
            // 
            // btnDamLevels
            // 
            this.btnDamLevels.Location = new System.Drawing.Point(144, 276);
            this.btnDamLevels.Name = "btnDamLevels";
            this.btnDamLevels.Size = new System.Drawing.Size(125, 38);
            this.btnDamLevels.TabIndex = 1;
            this.btnDamLevels.Text = "Dam Levels";
            this.btnDamLevels.UseVisualStyleBackColor = true;
            this.btnDamLevels.Click += new System.EventHandler(this.btnDamLevels_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(404, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectDataSourceToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // selectDataSourceToolStripMenuItem
            // 
            this.selectDataSourceToolStripMenuItem.Name = "selectDataSourceToolStripMenuItem";
            this.selectDataSourceToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.selectDataSourceToolStripMenuItem.Text = "Select Data Source";
            this.selectDataSourceToolStripMenuItem.Click += new System.EventHandler(this.selectDataSourceToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 405);
            this.Controls.Add(this.btnDamLevels);
            this.Controls.Add(this.btnRainfall);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRainfall;
        private System.Windows.Forms.Button btnDamLevels;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectDataSourceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

