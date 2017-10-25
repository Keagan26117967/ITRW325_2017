namespace HydroCT
{
    partial class frmRainfall
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
            this.gbxData = new System.Windows.Forms.GroupBox();
            this.dgvRainfall = new System.Windows.Forms.DataGridView();
            this.gbxData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRainfall)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxData
            // 
            this.gbxData.Controls.Add(this.dgvRainfall);
            this.gbxData.Location = new System.Drawing.Point(12, 12);
            this.gbxData.Name = "gbxData";
            this.gbxData.Size = new System.Drawing.Size(793, 344);
            this.gbxData.TabIndex = 0;
            this.gbxData.TabStop = false;
            this.gbxData.Text = "Rainfall of Cape Town (mm)";
            // 
            // dgvRainfall
            // 
            this.dgvRainfall.AllowUserToAddRows = false;
            this.dgvRainfall.AllowUserToDeleteRows = false;
            this.dgvRainfall.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRainfall.Location = new System.Drawing.Point(20, 29);
            this.dgvRainfall.Name = "dgvRainfall";
            this.dgvRainfall.ReadOnly = true;
            this.dgvRainfall.Size = new System.Drawing.Size(744, 288);
            this.dgvRainfall.TabIndex = 0;
            // 
            // frmRainfall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 606);
            this.Controls.Add(this.gbxData);
            this.Name = "frmRainfall";
            this.Text = "Rainfall";
            this.Load += new System.EventHandler(this.frmRainfall_Load);
            this.gbxData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRainfall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxData;
        private System.Windows.Forms.DataGridView dgvRainfall;
    }
}