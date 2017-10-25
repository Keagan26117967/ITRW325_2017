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
            this.btnDBV = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnSelectDB = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDBV
            // 
            this.btnDBV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDBV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDBV.Location = new System.Drawing.Point(12, 152);
            this.btnDBV.Name = "btnDBV";
            this.btnDBV.Size = new System.Drawing.Size(270, 53);
            this.btnDBV.TabIndex = 3;
            this.btnDBV.Text = "Rainfall";
            this.btnDBV.UseVisualStyleBackColor = true;
            this.btnDBV.Click += new System.EventHandler(this.btnDBV_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(13, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 53);
            this.button1.TabIndex = 4;
            this.button1.Text = "Dam Level";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(5, 5);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(278, 41);
            this.lblInfo.TabIndex = 5;
            this.lblInfo.Text = "Select database";
            // 
            // btnSelectDB
            // 
            this.btnSelectDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectDB.Location = new System.Drawing.Point(12, 71);
            this.btnSelectDB.Name = "btnSelectDB";
            this.btnSelectDB.Size = new System.Drawing.Size(270, 53);
            this.btnSelectDB.TabIndex = 7;
            this.btnSelectDB.Text = "Select Database";
            this.btnSelectDB.UseVisualStyleBackColor = true;
            this.btnSelectDB.Click += new System.EventHandler(this.btnSelectDB_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Step1:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Step2:";
            // 
            // DBSelectMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 271);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSelectDB);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDBV);
            this.Name = "DBSelectMenu";
            this.Text = "DBSelectMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDBV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnSelectDB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}