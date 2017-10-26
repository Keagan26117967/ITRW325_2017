﻿namespace DSS325
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvActual = new System.Windows.Forms.DataGridView();
            this.btnDBV = new System.Windows.Forms.Button();
            this.lblForcasted = new System.Windows.Forms.Label();
            this.dgvForcasted = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRainfall = new System.Windows.Forms.DataGridView();
            this.gbxWeights = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvWeights = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.forcastChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.val = new System.Windows.Forms.Label();
            this.txtAlpha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nrPeriods = new System.Windows.Forms.Label();
            this.sedNrPeriods = new System.Windows.Forms.NumericUpDown();
            this.btnForcast = new System.Windows.Forms.Button();
            this.ForcastingMethod = new System.Windows.Forms.Label();
            this.cbxFmethod = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForcasted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRainfall)).BeginInit();
            this.gbxWeights.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeights)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.forcastChart)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sedNrPeriods)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DimGray;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dgvActual);
            this.groupBox1.Controls.Add(this.btnDBV);
            this.groupBox1.Controls.Add(this.lblForcasted);
            this.groupBox1.Controls.Add(this.dgvForcasted);
            this.groupBox1.Controls.Add(this.dgvRainfall);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1256, 419);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rainfall for Cape Town in -mm-";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1130, 384);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = " ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(282, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 29);
            this.button2.TabIndex = 18;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(974, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 29);
            this.button1.TabIndex = 17;
            this.button1.Text = "Draw on Graph";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(971, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Actual:";
            // 
            // dgvActual
            // 
            this.dgvActual.AllowUserToDeleteRows = false;
            this.dgvActual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActual.Location = new System.Drawing.Point(974, 41);
            this.dgvActual.Name = "dgvActual";
            this.dgvActual.Size = new System.Drawing.Size(149, 337);
            this.dgvActual.TabIndex = 15;
            // 
            // btnDBV
            // 
            this.btnDBV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDBV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDBV.Location = new System.Drawing.Point(6, 384);
            this.btnDBV.Name = "btnDBV";
            this.btnDBV.Size = new System.Drawing.Size(270, 29);
            this.btnDBV.TabIndex = 4;
            this.btnDBV.Text = "Calculate MIN and MAX";
            this.btnDBV.UseVisualStyleBackColor = true;
            this.btnDBV.Click += new System.EventHandler(this.btnDBV_Click);
            // 
            // lblForcasted
            // 
            this.lblForcasted.AutoSize = true;
            this.lblForcasted.Location = new System.Drawing.Point(789, 14);
            this.lblForcasted.Name = "lblForcasted";
            this.lblForcasted.Size = new System.Drawing.Size(57, 13);
            this.lblForcasted.TabIndex = 14;
            this.lblForcasted.Text = "Forcasted:";
            // 
            // dgvForcasted
            // 
            this.dgvForcasted.AllowUserToDeleteRows = false;
            this.dgvForcasted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvForcasted.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name});
            this.dgvForcasted.Location = new System.Drawing.Point(792, 41);
            this.dgvForcasted.Name = "dgvForcasted";
            this.dgvForcasted.Size = new System.Drawing.Size(149, 337);
            this.dgvForcasted.TabIndex = 13;
            this.dgvForcasted.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvForcasted_CellContentClick);
            // 
            // name
            // 
            this.name.HeaderText = "???";
            this.name.Name = "name";
            // 
            // dgvRainfall
            // 
            this.dgvRainfall.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRainfall.Location = new System.Drawing.Point(6, 41);
            this.dgvRainfall.Name = "dgvRainfall";
            this.dgvRainfall.Size = new System.Drawing.Size(760, 337);
            this.dgvRainfall.TabIndex = 0;
            // 
            // gbxWeights
            // 
            this.gbxWeights.BackColor = System.Drawing.Color.DimGray;
            this.gbxWeights.Controls.Add(this.label1);
            this.gbxWeights.Controls.Add(this.lblTotal);
            this.gbxWeights.Controls.Add(this.dgvWeights);
            this.gbxWeights.ForeColor = System.Drawing.Color.White;
            this.gbxWeights.Location = new System.Drawing.Point(13, 439);
            this.gbxWeights.Name = "gbxWeights";
            this.gbxWeights.Size = new System.Drawing.Size(765, 85);
            this.gbxWeights.TabIndex = 18;
            this.gbxWeights.TabStop = false;
            this.gbxWeights.Text = "Weighs (Weighted Moving Average)";
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
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(701, 36);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(60, 24);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "label1";
            // 
            // dgvWeights
            // 
            this.dgvWeights.AllowUserToDeleteRows = false;
            this.dgvWeights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWeights.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dgvWeights.Location = new System.Drawing.Point(6, 19);
            this.dgvWeights.Name = "dgvWeights";
            this.dgvWeights.Size = new System.Drawing.Size(643, 60);
            this.dgvWeights.TabIndex = 8;
            this.dgvWeights.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWeights_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "???";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.forcastChart);
            this.panel1.Location = new System.Drawing.Point(804, 447);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 211);
            this.panel1.TabIndex = 16;
            // 
            // forcastChart
            // 
            chartArea1.Name = "ChartArea1";
            this.forcastChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.forcastChart.Legends.Add(legend1);
            this.forcastChart.Location = new System.Drawing.Point(2, 10);
            this.forcastChart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.forcastChart.Name = "forcastChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.forcastChart.Series.Add(series1);
            this.forcastChart.Size = new System.Drawing.Size(225, 244);
            this.forcastChart.TabIndex = 9;
            this.forcastChart.Text = "chart1";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DimGray;
            this.groupBox2.Controls.Add(this.val);
            this.groupBox2.Controls.Add(this.txtAlpha);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.nrPeriods);
            this.groupBox2.Controls.Add(this.sedNrPeriods);
            this.groupBox2.Controls.Add(this.btnForcast);
            this.groupBox2.Controls.Add(this.ForcastingMethod);
            this.groupBox2.Controls.Add(this.cbxFmethod);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(13, 534);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(765, 132);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Forcasting";
            // 
            // val
            // 
            this.val.AutoSize = true;
            this.val.Location = new System.Drawing.Point(518, 46);
            this.val.Name = "val";
            this.val.Size = new System.Drawing.Size(94, 13);
            this.val.TabIndex = 11;
            this.val.Text = "(Between 0 and 1)";
            // 
            // txtAlpha
            // 
            this.txtAlpha.Location = new System.Drawing.Point(450, 42);
            this.txtAlpha.Name = "txtAlpha";
            this.txtAlpha.Size = new System.Drawing.Size(62, 20);
            this.txtAlpha.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(399, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Alpha:";
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
            this.sedNrPeriods.ValueChanged += new System.EventHandler(this.sedNrPeriods_ValueChanged_1);
            // 
            // btnForcast
            // 
            this.btnForcast.Location = new System.Drawing.Point(645, 19);
            this.btnForcast.Name = "btnForcast";
            this.btnForcast.Size = new System.Drawing.Size(75, 28);
            this.btnForcast.TabIndex = 6;
            this.btnForcast.Text = "Forcast";
            this.btnForcast.UseVisualStyleBackColor = true;
            this.btnForcast.Click += new System.EventHandler(this.btnForcast_Click_1);
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
            this.cbxFmethod.SelectedIndexChanged += new System.EventHandler(this.cbxFmethod_SelectedIndexChanged_1);
            // 
            // frmRainfall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1197, 669);
            this.Controls.Add(this.gbxWeights);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRainfall";
            this.Text = "frmRainfall";
            this.Load += new System.EventHandler(this.frmRainfall_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForcasted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRainfall)).EndInit();
            this.gbxWeights.ResumeLayout(false);
            this.gbxWeights.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeights)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.forcastChart)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sedNrPeriods)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvRainfall;
        private System.Windows.Forms.Button btnDBV;
        private System.Windows.Forms.Label lblForcasted;
        private System.Windows.Forms.DataGridView dgvForcasted;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.GroupBox gbxWeights;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dgvWeights;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart forcastChart;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label val;
        private System.Windows.Forms.TextBox txtAlpha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nrPeriods;
        private System.Windows.Forms.NumericUpDown sedNrPeriods;
        private System.Windows.Forms.Button btnForcast;
        private System.Windows.Forms.Label ForcastingMethod;
        private System.Windows.Forms.ComboBox cbxFmethod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvActual;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
    }
}