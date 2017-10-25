namespace DSS325
{
    partial class frmDamLevels
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxDams = new System.Windows.Forms.ComboBox();
            this.lblDamInfo = new System.Windows.Forms.Label();
            this.dgvDamLevels = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDamLevels)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxDams);
            this.groupBox1.Controls.Add(this.lblDamInfo);
            this.groupBox1.Controls.Add(this.dgvDamLevels);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1027, 486);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "% Level of dam";
            // 
            // cbxDams
            // 
            this.cbxDams.FormattingEnabled = true;
            this.cbxDams.Items.AddRange(new object[] {
            "ALEXANDRA",
            "BERG RIVER",
            "DE VILLIERS",
            "HELY-HUTCHENSON",
            "KLEINPLAATS",
            "LEWIS GAY",
            "STEENBRAS LOWER",
            "STEENBRAS UPPER",
            "THEEWATERKLOOF",
            "VICTORIA",
            "VOëLVLEI",
            "WEMMERHOEK",
            "WOODHEAD"});
            this.cbxDams.Location = new System.Drawing.Point(89, 26);
            this.cbxDams.Name = "cbxDams";
            this.cbxDams.Size = new System.Drawing.Size(187, 21);
            this.cbxDams.TabIndex = 2;
            this.cbxDams.SelectedIndexChanged += new System.EventHandler(this.cbxDams_SelectedIndexChanged);
            // 
            // lblDamInfo
            // 
            this.lblDamInfo.AutoSize = true;
            this.lblDamInfo.Location = new System.Drawing.Point(18, 29);
            this.lblDamInfo.Name = "lblDamInfo";
            this.lblDamInfo.Size = new System.Drawing.Size(65, 13);
            this.lblDamInfo.TabIndex = 1;
            this.lblDamInfo.Text = "Select Dam:";
            // 
            // dgvDamLevels
            // 
            this.dgvDamLevels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDamLevels.Location = new System.Drawing.Point(12, 57);
            this.dgvDamLevels.Name = "dgvDamLevels";
            this.dgvDamLevels.Size = new System.Drawing.Size(1002, 414);
            this.dgvDamLevels.TabIndex = 0;
            // 
            // frmDamLevels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 570);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDamLevels";
            this.Text = "frmDamLevels";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDamLevels)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDamInfo;
        private System.Windows.Forms.DataGridView dgvDamLevels;
        private System.Windows.Forms.ComboBox cbxDams;
    }
}