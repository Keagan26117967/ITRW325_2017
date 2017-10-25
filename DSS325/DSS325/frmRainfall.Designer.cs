namespace DSS325
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvRainfall = new System.Windows.Forms.DataGridView();
            this.btnDBV = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRainfall)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvRainfall);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1014, 454);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rainfall for Cape Town in -mm-";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dgvRainfall
            // 
            this.dgvRainfall.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRainfall.Location = new System.Drawing.Point(6, 20);
            this.dgvRainfall.Name = "dgvRainfall";
            this.dgvRainfall.Size = new System.Drawing.Size(1002, 414);
            this.dgvRainfall.TabIndex = 0;
            // 
            // btnDBV
            // 
            this.btnDBV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDBV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDBV.Location = new System.Drawing.Point(18, 472);
            this.btnDBV.Name = "btnDBV";
            this.btnDBV.Size = new System.Drawing.Size(270, 53);
            this.btnDBV.TabIndex = 4;
            this.btnDBV.Text = "Calculate MIN and MAX";
            this.btnDBV.UseVisualStyleBackColor = true;
            this.btnDBV.Click += new System.EventHandler(this.btnDBV_Click);
            // 
            // frmRainfall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 535);
            this.Controls.Add(this.btnDBV);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRainfall";
            this.Text = "frmRainfall";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRainfall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvRainfall;
        private System.Windows.Forms.Button btnDBV;
    }
}