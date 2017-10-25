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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.gbxData = new System.Windows.Forms.GroupBox();
            this.lblDam = new System.Windows.Forms.Label();
            this.cbxDams = new System.Windows.Forms.ComboBox();
            this.dgvDamLevels = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.val = new System.Windows.Forms.Label();
            this.txtAlpha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nrPeriods = new System.Windows.Forms.Label();
            this.sedNrPeriods = new System.Windows.Forms.NumericUpDown();
            this.btnForcast = new System.Windows.Forms.Button();
            this.ForcastingMethod = new System.Windows.Forms.Label();
            this.cbxFmethod = new System.Windows.Forms.ComboBox();
            this.dgvForcasted = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblForcasted = new System.Windows.Forms.Label();
            this.gbxWeights = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvWeights = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forcastChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbxData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDamLevels)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sedNrPeriods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForcasted)).BeginInit();
            this.gbxWeights.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forcastChart)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxData
            // 
            this.gbxData.Controls.Add(this.lblDam);
            this.gbxData.Controls.Add(this.cbxDams);
            this.gbxData.Controls.Add(this.dgvDamLevels);
            this.gbxData.Location = new System.Drawing.Point(16, 15);
            this.gbxData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxData.Name = "gbxData";
            this.gbxData.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxData.Size = new System.Drawing.Size(1035, 427);
            this.gbxData.TabIndex = 1;
            this.gbxData.TabStop = false;
            this.gbxData.Text = "% of Dam Level";
            this.gbxData.Enter += new System.EventHandler(this.gbxData_Enter);
            // 
            // lblDam
            // 
            this.lblDam.AutoSize = true;
            this.lblDam.Location = new System.Drawing.Point(19, 27);
            this.lblDam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDam.Name = "lblDam";
            this.lblDam.Size = new System.Drawing.Size(96, 17);
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
            this.cbxDams.Location = new System.Drawing.Point(125, 23);
            this.cbxDams.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxDams.Name = "cbxDams";
            this.cbxDams.Size = new System.Drawing.Size(239, 24);
            this.cbxDams.TabIndex = 1;
            this.cbxDams.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dgvDamLevels
            // 
            this.dgvDamLevels.AllowUserToAddRows = false;
            this.dgvDamLevels.AllowUserToDeleteRows = false;
            this.dgvDamLevels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDamLevels.Location = new System.Drawing.Point(23, 57);
            this.dgvDamLevels.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDamLevels.Name = "dgvDamLevels";
            this.dgvDamLevels.Size = new System.Drawing.Size(992, 354);
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
            this.groupBox1.Location = new System.Drawing.Point(16, 561);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1035, 162);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Forcasting";
            // 
            // val
            // 
            this.val.AutoSize = true;
            this.val.Location = new System.Drawing.Point(691, 70);
            this.val.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.val.Name = "val";
            this.val.Size = new System.Drawing.Size(124, 17);
            this.val.TabIndex = 11;
            this.val.Text = "(Between 0 and 1)";
            // 
            // txtAlpha
            // 
            this.txtAlpha.Location = new System.Drawing.Point(600, 66);
            this.txtAlpha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAlpha.Name = "txtAlpha";
            this.txtAlpha.Size = new System.Drawing.Size(81, 22);
            this.txtAlpha.TabIndex = 10;
            this.txtAlpha.TextChanged += new System.EventHandler(this.txtAlpha_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(531, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Alpha:";
            // 
            // nrPeriods
            // 
            this.nrPeriods.AutoSize = true;
            this.nrPeriods.Location = new System.Drawing.Point(481, 23);
            this.nrPeriods.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nrPeriods.Name = "nrPeriods";
            this.nrPeriods.Size = new System.Drawing.Size(99, 17);
            this.nrPeriods.TabIndex = 8;
            this.nrPeriods.Text = "Nr. of Periods:";
            // 
            // sedNrPeriods
            // 
            this.sedNrPeriods.Location = new System.Drawing.Point(600, 21);
            this.sedNrPeriods.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sedNrPeriods.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sedNrPeriods.Name = "sedNrPeriods";
            this.sedNrPeriods.Size = new System.Drawing.Size(83, 22);
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
            this.btnForcast.Location = new System.Drawing.Point(243, 95);
            this.btnForcast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnForcast.Name = "btnForcast";
            this.btnForcast.Size = new System.Drawing.Size(100, 28);
            this.btnForcast.TabIndex = 6;
            this.btnForcast.Text = "Forcast";
            this.btnForcast.UseVisualStyleBackColor = true;
            this.btnForcast.Click += new System.EventHandler(this.btnForcast_Click);
            // 
            // ForcastingMethod
            // 
            this.ForcastingMethod.AutoSize = true;
            this.ForcastingMethod.Location = new System.Drawing.Point(8, 30);
            this.ForcastingMethod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ForcastingMethod.Name = "ForcastingMethod";
            this.ForcastingMethod.Size = new System.Drawing.Size(129, 17);
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
            this.cbxFmethod.Location = new System.Drawing.Point(147, 23);
            this.cbxFmethod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxFmethod.Name = "cbxFmethod";
            this.cbxFmethod.Size = new System.Drawing.Size(239, 24);
            this.cbxFmethod.TabIndex = 4;
            this.cbxFmethod.SelectedIndexChanged += new System.EventHandler(this.cbxFmethod_SelectedIndexChanged);
            // 
            // dgvForcasted
            // 
            this.dgvForcasted.AllowUserToDeleteRows = false;
            this.dgvForcasted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvForcasted.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name});
            this.dgvForcasted.Location = new System.Drawing.Point(1083, 71);
            this.dgvForcasted.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvForcasted.Name = "dgvForcasted";
            this.dgvForcasted.Size = new System.Drawing.Size(199, 354);
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
            this.lblForcasted.Location = new System.Drawing.Point(1079, 38);
            this.lblForcasted.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblForcasted.Name = "lblForcasted";
            this.lblForcasted.Size = new System.Drawing.Size(75, 17);
            this.lblForcasted.TabIndex = 6;
            this.lblForcasted.Text = "Forcasted:";
            // 
            // gbxWeights
            // 
            this.gbxWeights.Controls.Add(this.label1);
            this.gbxWeights.Controls.Add(this.lblTotal);
            this.gbxWeights.Controls.Add(this.dgvWeights);
            this.gbxWeights.Location = new System.Drawing.Point(16, 449);
            this.gbxWeights.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxWeights.Name = "gbxWeights";
            this.gbxWeights.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxWeights.Size = new System.Drawing.Size(1035, 105);
            this.gbxWeights.TabIndex = 8;
            this.gbxWeights.TabStop = false;
            this.gbxWeights.Text = "Weighs (Weighted Moving Average)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(913, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "/";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(935, 44);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(79, 29);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "label1";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // dgvWeights
            // 
            this.dgvWeights.AllowUserToDeleteRows = false;
            this.dgvWeights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWeights.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dgvWeights.Location = new System.Drawing.Point(23, 23);
            this.dgvWeights.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvWeights.Name = "dgvWeights";
            this.dgvWeights.Size = new System.Drawing.Size(857, 74);
            this.dgvWeights.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "???";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // forcastChart
            // 
            chartArea2.Name = "ChartArea1";
            this.forcastChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.forcastChart.Legends.Add(legend2);
            this.forcastChart.Location = new System.Drawing.Point(-130, -11);
            this.forcastChart.Name = "forcastChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.forcastChart.Series.Add(series2);
            this.forcastChart.Size = new System.Drawing.Size(300, 300);
            this.forcastChart.TabIndex = 9;
            this.forcastChart.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.forcastChart);
            this.panel1.Location = new System.Drawing.Point(1083, 463);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 260);
            this.panel1.TabIndex = 10;
            // 
            // frmDamLevels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1635, 839);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbxWeights);
            this.Controls.Add(this.lblForcasted);
            this.Controls.Add(this.dgvForcasted);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxData);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            ((System.ComponentModel.ISupportInitialize)(this.forcastChart)).EndInit();
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.DataVisualization.Charting.Chart forcastChart;
        private System.Windows.Forms.Panel panel1;
    }
}