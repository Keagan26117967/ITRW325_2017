namespace DSS325
{
    partial class DBSelectMenu
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
            this.btnDams = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRainfall
            // 
            this.btnRainfall.BackColor = System.Drawing.Color.DimGray;
            this.btnRainfall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRainfall.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRainfall.ForeColor = System.Drawing.Color.White;
            this.btnRainfall.Location = new System.Drawing.Point(13, 49);
            this.btnRainfall.Name = "btnRainfall";
            this.btnRainfall.Size = new System.Drawing.Size(270, 53);
            this.btnRainfall.TabIndex = 3;
            this.btnRainfall.Text = "Rainfall";
            this.btnRainfall.UseVisualStyleBackColor = false;
            this.btnRainfall.Click += new System.EventHandler(this.btnDBV_Click);
            // 
            // btnDams
            // 
            this.btnDams.BackColor = System.Drawing.Color.DimGray;
            this.btnDams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDams.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDams.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDams.Location = new System.Drawing.Point(14, 108);
            this.btnDams.Name = "btnDams";
            this.btnDams.Size = new System.Drawing.Size(270, 53);
            this.btnDams.TabIndex = 4;
            this.btnDams.Text = "Dam Level";
            this.btnDams.UseVisualStyleBackColor = false;
            this.btnDams.Click += new System.EventHandler(this.btnDams_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(5, 5);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(282, 41);
            this.lblInfo.TabIndex = 5;
            this.lblInfo.Text = "Select Database";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(13, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 53);
            this.button1.TabIndex = 6;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DBSelectMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(297, 228);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnDams);
            this.Controls.Add(this.btnRainfall);
            this.Name = "DBSelectMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRainfall;
        private System.Windows.Forms.Button btnDams;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button button1;
    }
}