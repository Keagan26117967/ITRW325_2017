namespace HydroCT
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
            this.gbxData = new System.Windows.Forms.GroupBox();
            this.lblDam = new System.Windows.Forms.Label();
            this.cbxDams = new System.Windows.Forms.ComboBox();
            this.dgvDamLevels = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nrPeriods = new System.Windows.Forms.Label();
            this.sedNrPeriods = new System.Windows.Forms.NumericUpDown();
            this.btnForcast = new System.Windows.Forms.Button();
            this.ForcastingMethod = new System.Windows.Forms.Label();
            this.cbxFmethod = new System.Windows.Forms.ComboBox();
            this.dgvForcasted = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblForcasted = new System.Windows.Forms.Label();
            this.gbxWeights = new System.Windows.Forms.GroupBox();
            this.dgvWeights = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAlpha = new System.Windows.Forms.TextBox();
            this.val = new System.Windows.Forms.Label();
            this.gbxData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDamLevels)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sedNrPeriods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForcasted)).BeginInit();
            this.gbxWeights.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeights)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxData
            // 
            this.gbxData.Controls.Add(this.lblDam);
            this.gbxData.Controls.Add(this.cbxDams);
            this.gbxData.Controls.Add(this.dgvDamLevels);
            this.gbxData.Location = new System.Drawing.Point(12, 12);
            this.gbxData.Name = "gbxData";
            this.gbxData.Size = new System.Drawing.Size(776, 347);
            this.gbxData.TabIndex = 1;
            this.gbxData.TabStop = false;
            this.gbxData.Text = "% of Dam Level";
            this.gbxData.Enter += new System.EventHandler(this.gbxData_Enter);
            // 
            // lblDam
            // 
            this.lblDam.AutoSize = true;
            this.lblDam.Location = new System.Drawing.Point(14, 22);
            this.lblDam.Name = "lblDam";
            this.lblDam.Size = new System.Drawing.Size(74, 13);
            this.lblDam.TabIndex = 2;
            this.lblDam.Text = "Select a Dam:";
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
            this.cbxDams.Location = new System.Drawing.Point(94, 19);
            this.cbxDams.Name = "cbxDams";
            this.cbxDams.Size = new System.Drawing.Size(180, 21);
            this.cbxDams.TabIndex = 1;
            this.cbxDams.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dgvDamLevels
            // 
            this.dgvDamLevels.AllowUserToAddRows = false;
            this.dgvDamLevels.AllowUserToDeleteRows = false;
            this.dgvDamLevels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDamLevels.Location = new System.Drawing.Point(17, 46);
            this.dgvDamLevels.Name = "dgvDamLevels";
            this.dgvDamLevels.Size = new System.Drawing.Size(744, 288);
            this.dgvDamLevels.TabIndex = 0;
            this.dgvDamLevels.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDamLevels_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.val);
            this.groupBox1.Controls.Add(this.txtAlpha);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nrPeriods);
            this.groupBox1.Controls.Add(this.sedNrPeriods);
            this.groupBox1.Controls.Add(this.btnForcast);
            this.groupBox1.Controls.Add(this.ForcastingMethod);
            this.groupBox1.Controls.Add(this.cbxFmethod);
            this.groupBox1.Location = new System.Drawing.Point(12, 456);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 132);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Forcasting";
            // 
            // nrPeriods
            // 
            this.nrPeriods.AutoSize = true;
            this.nrPeriods.Location = new System.Drawing.Point(361, 19);
            this.nrPeriods.Name = "nrPeriods";
            this.nrPeriods.Size = new System.Drawing.Size(74, 13);
            this.nrPeriods.TabIndex = 8;
            this.nrPeriods.Text = "Nr. of Periods:";
            // 
            // sedNrPeriods
            // 
            this.sedNrPeriods.Location = new System.Drawing.Point(450, 17);
            this.sedNrPeriods.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sedNrPeriods.Name = "sedNrPeriods";
            this.sedNrPeriods.Size = new System.Drawing.Size(62, 20);
            this.sedNrPeriods.TabIndex = 7;
            this.sedNrPeriods.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sedNrPeriods.ValueChanged += new System.EventHandler(this.sedNrPeriods_ValueChanged);
            // 
            // btnForcast
            // 
            this.btnForcast.Location = new System.Drawing.Point(182, 77);
            this.btnForcast.Name = "btnForcast";
            this.btnForcast.Size = new System.Drawing.Size(75, 23);
            this.btnForcast.TabIndex = 6;
            this.btnForcast.Text = "Forcast";
            this.btnForcast.UseVisualStyleBackColor = true;
            this.btnForcast.Click += new System.EventHandler(this.btnForcast_Click);
            // 
            // ForcastingMethod
            // 
            this.ForcastingMethod.AutoSize = true;
            this.ForcastingMethod.Location = new System.Drawing.Point(6, 24);
            this.ForcastingMethod.Name = "ForcastingMethod";
            this.ForcastingMethod.Size = new System.Drawing.Size(98, 13);
            this.ForcastingMethod.TabIndex = 5;
            this.ForcastingMethod.Text = "Forcasting Method:";
            // 
            // cbxFmethod
            // 
            this.cbxFmethod.FormattingEnabled = true;
            this.cbxFmethod.Items.AddRange(new object[] {
            "Simple Moving Average",
            "Weighted Moving Average",
            "Exponential Smoothing"});
            this.cbxFmethod.Location = new System.Drawing.Point(110, 19);
            this.cbxFmethod.Name = "cbxFmethod";
            this.cbxFmethod.Size = new System.Drawing.Size(180, 21);
            this.cbxFmethod.TabIndex = 4;
            this.cbxFmethod.SelectedIndexChanged += new System.EventHandler(this.cbxFmethod_SelectedIndexChanged);
            // 
            // dgvForcasted
            // 
            this.dgvForcasted.AllowUserToDeleteRows = false;
            this.dgvForcasted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvForcasted.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name});
            this.dgvForcasted.Location = new System.Drawing.Point(812, 58);
            this.dgvForcasted.Name = "dgvForcasted";
            this.dgvForcasted.Size = new System.Drawing.Size(149, 288);
            this.dgvForcasted.TabIndex = 3;
            this.dgvForcasted.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvForcasted_CellContentClick);
            // 
            // name
            // 
            this.name.HeaderText = "???";
            this.name.Name = "name";
            // 
            // lblForcasted
            // 
            this.lblForcasted.AutoSize = true;
            this.lblForcasted.Location = new System.Drawing.Point(809, 31);
            this.lblForcasted.Name = "lblForcasted";
            this.lblForcasted.Size = new System.Drawing.Size(57, 13);
            this.lblForcasted.TabIndex = 6;
            this.lblForcasted.Text = "Forcasted:";
            // 
            // gbxWeights
            // 
            this.gbxWeights.Controls.Add(this.label1);
            this.gbxWeights.Controls.Add(this.lblTotal);
            this.gbxWeights.Controls.Add(this.dgvWeights);
            this.gbxWeights.Location = new System.Drawing.Point(12, 365);
            this.gbxWeights.Name = "gbxWeights";
            this.gbxWeights.Size = new System.Drawing.Size(776, 85);
            this.gbxWeights.TabIndex = 8;
            this.gbxWeights.TabStop = false;
            this.gbxWeights.Text = "Weighs (Weighted Moving Average)";
            // 
            // dgvWeights
            // 
            this.dgvWeights.AllowUserToDeleteRows = false;
            this.dgvWeights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWeights.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dgvWeights.Location = new System.Drawing.Point(17, 19);
            this.dgvWeights.Name = "dgvWeights";
            this.dgvWeights.Size = new System.Drawing.Size(643, 60);
            this.dgvWeights.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "???";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(701, 36);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(60, 24);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "label1";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(685, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "/";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Alpha:";
            // 
            // txtAlpha
            // 
            this.txtAlpha.Location = new System.Drawing.Point(450, 54);
            this.txtAlpha.Name = "txtAlpha";
            this.txtAlpha.Size = new System.Drawing.Size(62, 20);
            this.txtAlpha.TabIndex = 10;
            // 
            // val
            // 
            this.val.AutoSize = true;
            this.val.Location = new System.Drawing.Point(518, 57);
            this.val.Name = "val";
            this.val.Size = new System.Drawing.Size(94, 13);
            this.val.TabIndex = 11;
            this.val.Text = "(Between 0 and 1)";
            // 
            // frmDamLevels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 682);
            this.Controls.Add(this.gbxWeights);
            this.Controls.Add(this.lblForcasted);
            this.Controls.Add(this.dgvForcasted);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxData);
            this.Name = "frmDamLevels";
            this.Text = "Dam Levels";
            this.Load += new System.EventHandler(this.frmDamLevels_Load);
            this.gbxData.ResumeLayout(false);
            this.gbxData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDamLevels)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sedNrPeriods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForcasted)).EndInit();
            this.gbxWeights.ResumeLayout(false);
            this.gbxWeights.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeights)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxData;
        private System.Windows.Forms.ComboBox cbxDams;
        private System.Windows.Forms.DataGridView dgvDamLevels;
        private System.Windows.Forms.Label lblDam;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ForcastingMethod;
        private System.Windows.Forms.ComboBox cbxFmethod;
        private System.Windows.Forms.DataGridView dgvForcasted;
        private System.Windows.Forms.Label lblForcasted;
        private System.Windows.Forms.Button btnForcast;
        private System.Windows.Forms.Label nrPeriods;
        private System.Windows.Forms.NumericUpDown sedNrPeriods;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.GroupBox gbxWeights;
        private System.Windows.Forms.DataGridView dgvWeights;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAlpha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label val;
    }
}