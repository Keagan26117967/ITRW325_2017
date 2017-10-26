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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvActual = new System.Windows.Forms.DataGridView();
            this.lblForcasted = new System.Windows.Forms.Label();
            this.dgvForcasted = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxDams = new System.Windows.Forms.ComboBox();
            this.lblDamInfo = new System.Windows.Forms.Label();
            this.dgvDamLevels = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.forcastChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbxWeights = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvWeights = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.val = new System.Windows.Forms.Label();
            this.txtAlpha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nrPeriods = new System.Windows.Forms.Label();
            this.sedNrPeriods = new System.Windows.Forms.NumericUpDown();
            this.btnForcast = new System.Windows.Forms.Button();
            this.ForcastingMethod = new System.Windows.Forms.Label();
            this.cbxFmethod = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForcasted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDamLevels)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.forcastChart)).BeginInit();
            this.gbxWeights.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeights)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sedNrPeriods)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dgvActual);
            this.groupBox1.Controls.Add(this.lblForcasted);
            this.groupBox1.Controls.Add(this.dgvForcasted);
            this.groupBox1.Controls.Add(this.cbxDams);
            this.groupBox1.Controls.Add(this.lblDamInfo);
            this.groupBox1.Controls.Add(this.dgvDamLevels);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1613, 539);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "% Level of dam";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 492);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 39);
            this.button2.TabIndex = 19;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1289, 492);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 36);
            this.button1.TabIndex = 18;
            this.button1.Text = "Draw on Graph";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1285, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Actual:";
            // 
            // dgvActual
            // 
            this.dgvActual.AllowUserToDeleteRows = false;
            this.dgvActual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActual.Location = new System.Drawing.Point(1289, 70);
            this.dgvActual.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvActual.Name = "dgvActual";
            this.dgvActual.Size = new System.Drawing.Size(199, 415);
            this.dgvActual.TabIndex = 13;
            // 
            // lblForcasted
            // 
            this.lblForcasted.AutoSize = true;
            this.lblForcasted.Location = new System.Drawing.Point(1055, 37);
            this.lblForcasted.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblForcasted.Name = "lblForcasted";
            this.lblForcasted.Size = new System.Drawing.Size(75, 17);
            this.lblForcasted.TabIndex = 12;
            this.lblForcasted.Text = "Forcasted:";
            // 
            // dgvForcasted
            // 
            this.dgvForcasted.AllowUserToDeleteRows = false;
            this.dgvForcasted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvForcasted.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name});
            this.dgvForcasted.Location = new System.Drawing.Point(1059, 70);
            this.dgvForcasted.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvForcasted.Name = "dgvForcasted";
            this.dgvForcasted.Size = new System.Drawing.Size(199, 415);
            this.dgvForcasted.TabIndex = 11;
            // 
            // name
            // 
            this.name.HeaderText = "???";
            this.name.Name = "name";
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
            this.cbxDams.Location = new System.Drawing.Point(119, 32);
            this.cbxDams.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxDams.Name = "cbxDams";
            this.cbxDams.Size = new System.Drawing.Size(248, 24);
            this.cbxDams.TabIndex = 2;
            this.cbxDams.SelectedIndexChanged += new System.EventHandler(this.cbxDams_SelectedIndexChanged);
            // 
            // lblDamInfo
            // 
            this.lblDamInfo.AutoSize = true;
            this.lblDamInfo.Location = new System.Drawing.Point(24, 36);
            this.lblDamInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDamInfo.Name = "lblDamInfo";
            this.lblDamInfo.Size = new System.Drawing.Size(84, 17);
            this.lblDamInfo.TabIndex = 1;
            this.lblDamInfo.Text = "Select Dam:";
            // 
            // dgvDamLevels
            // 
            this.dgvDamLevels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDamLevels.Location = new System.Drawing.Point(16, 70);
            this.dgvDamLevels.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDamLevels.Name = "dgvDamLevels";
            this.dgvDamLevels.Size = new System.Drawing.Size(1013, 415);
            this.dgvDamLevels.TabIndex = 0;
            this.dgvDamLevels.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDamLevels_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.forcastChart);
            this.panel1.Location = new System.Drawing.Point(1091, 574);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 260);
            this.panel1.TabIndex = 13;
            // 
            // forcastChart
            // 
            chartArea4.Name = "ChartArea1";
            this.forcastChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.forcastChart.Legends.Add(legend4);
            this.forcastChart.Location = new System.Drawing.Point(3, 12);
            this.forcastChart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.forcastChart.Name = "forcastChart";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.forcastChart.Series.Add(series4);
            this.forcastChart.Size = new System.Drawing.Size(300, 300);
            this.forcastChart.TabIndex = 9;
            this.forcastChart.Text = "chart1";
            // 
            // gbxWeights
            // 
            this.gbxWeights.Controls.Add(this.label1);
            this.gbxWeights.Controls.Add(this.lblTotal);
            this.gbxWeights.Controls.Add(this.dgvWeights);
            this.gbxWeights.Location = new System.Drawing.Point(16, 561);
            this.gbxWeights.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxWeights.Name = "gbxWeights";
            this.gbxWeights.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxWeights.Size = new System.Drawing.Size(1035, 105);
            this.gbxWeights.TabIndex = 15;
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
            this.lblTotal.Size = new System.Drawing.Size(26, 29);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "0";
            // 
            // dgvWeights
            // 
            this.dgvWeights.AllowUserToDeleteRows = false;
            this.dgvWeights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWeights.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dgvWeights.Location = new System.Drawing.Point(8, 23);
            this.dgvWeights.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvWeights.Name = "dgvWeights";
            this.dgvWeights.Size = new System.Drawing.Size(857, 74);
            this.dgvWeights.TabIndex = 8;
            this.dgvWeights.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWeights_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "???";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.val);
            this.groupBox2.Controls.Add(this.txtAlpha);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.nrPeriods);
            this.groupBox2.Controls.Add(this.sedNrPeriods);
            this.groupBox2.Controls.Add(this.btnForcast);
            this.groupBox2.Controls.Add(this.ForcastingMethod);
            this.groupBox2.Controls.Add(this.cbxFmethod);
            this.groupBox2.Location = new System.Drawing.Point(16, 671);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1035, 162);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Forcasting";
            // 
            // val
            // 
            this.val.AutoSize = true;
            this.val.Location = new System.Drawing.Point(691, 60);
            this.val.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.val.Name = "val";
            this.val.Size = new System.Drawing.Size(124, 17);
            this.val.TabIndex = 11;
            this.val.Text = "(Between 0 and 1)";
            // 
            // txtAlpha
            // 
            this.txtAlpha.Location = new System.Drawing.Point(600, 52);
            this.txtAlpha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAlpha.Name = "txtAlpha";
            this.txtAlpha.Size = new System.Drawing.Size(81, 22);
            this.txtAlpha.TabIndex = 10;
            this.txtAlpha.TextChanged += new System.EventHandler(this.txtAlpha_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(532, 57);
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
            this.btnForcast.Location = new System.Drawing.Point(851, 30);
            this.btnForcast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnForcast.Name = "btnForcast";
            this.btnForcast.Size = new System.Drawing.Size(100, 34);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1496, 467);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = " ";
            // 
            // frmDamLevels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1775, 912);
            this.Controls.Add(this.gbxWeights);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDamLevels";
            this.Text = "frmDamLevels";
            this.Load += new System.EventHandler(this.frmDamLevels_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForcasted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDamLevels)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.forcastChart)).EndInit();
            this.gbxWeights.ResumeLayout(false);
            this.gbxWeights.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeights)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sedNrPeriods)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDamInfo;
        private System.Windows.Forms.DataGridView dgvDamLevels;
        private System.Windows.Forms.ComboBox cbxDams;
        private System.Windows.Forms.GroupBox gbxWeights;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dgvWeights;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label val;
        private System.Windows.Forms.TextBox txtAlpha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nrPeriods;
        private System.Windows.Forms.NumericUpDown sedNrPeriods;
        private System.Windows.Forms.Button btnForcast;
        private System.Windows.Forms.Label ForcastingMethod;
        private System.Windows.Forms.ComboBox cbxFmethod;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart forcastChart;
        private System.Windows.Forms.Label lblForcasted;
        private System.Windows.Forms.DataGridView dgvForcasted;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvActual;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
    }
}