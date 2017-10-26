using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DSS325
{
    public partial class frmDamLevels : Form
    {
        string myDBFile;
        public string conn = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source =";
        OleDbDataAdapter adapter;
        OleDbConnection myDB;
        DBSelectMenu parentVar;
        string[] months = { "JAN", "FEB", "MAR", "APR", "MAY", "JUN", "JUL", "AUG", "SEP", "OCT", "NOV", "DEC" };
        string Dam;
        Forecasting casting;
        int nr_columns;
        Decimal[] January, February, March, April, May, June, July, August, September, October,
            November, December;

        private void btnForcast_Click(object sender, EventArgs e)
        {
            dgvForcasted.Rows.Clear();
            dgvForcasted.Columns.Clear();
            if (cbxFmethod.SelectedIndex == 0)
            {
                setArrays();
                DoSMF();
            }
            if (cbxFmethod.SelectedIndex == 1)
            {
                setArrays();
                DoWMA();
            }
            if (cbxFmethod.SelectedIndex == 2)
            {
                setArrays();
                if (txtAlpha.Text != null || txtAlpha.Text != "")
                {
                    if (Convert.ToDecimal(txtAlpha.Text) >= 0 && Convert.ToDecimal(txtAlpha.Text) <= 1)
                        DoES();
                    else
                    {
                        MessageBox.Show("Please make sure Alpha is between 0 and 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Please make sure an Alpha value is inputted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAlpha.Focus();
                    return;
                }
            }
        }

        private void DoES()
        {
            int newName = Convert.ToInt32(dgvDamLevels.Columns[dgvDamLevels.ColumnCount - 1].Name) + 1;
            dgvForcasted.Columns.Add(newName.ToString(), newName.ToString());
            double alpha1 = Convert.ToDouble(txtAlpha.Text);
            decimal alpha = Convert.ToDecimal(alpha1);
            double[] forcastedArray = new double[12];
            forcastedArray[0] = Convert.ToDouble(casting.ExponentialSmoothing(January, alpha));
            forcastedArray[1] = Convert.ToDouble(casting.ExponentialSmoothing(February, alpha));
            forcastedArray[2] = Convert.ToDouble(casting.ExponentialSmoothing(March, alpha));
            forcastedArray[3] = Convert.ToDouble(casting.ExponentialSmoothing(April, alpha));
            forcastedArray[4] = Convert.ToDouble(casting.ExponentialSmoothing(May, alpha));
            forcastedArray[5] = Convert.ToDouble(casting.ExponentialSmoothing(June, alpha));
            forcastedArray[6] = Convert.ToDouble(casting.ExponentialSmoothing(July, alpha));
            forcastedArray[7] = Convert.ToDouble(casting.ExponentialSmoothing(August, alpha));
            forcastedArray[8] = Convert.ToDouble(casting.ExponentialSmoothing(September, alpha));
            forcastedArray[9] = Convert.ToDouble(casting.ExponentialSmoothing(October, alpha));
            forcastedArray[10] = Convert.ToDouble(casting.ExponentialSmoothing(November, alpha));
            forcastedArray[11] = Convert.ToDouble(casting.ExponentialSmoothing(December, alpha));

            foreach (double x in forcastedArray)
            {
                dgvForcasted.Rows.Add(x);
            }
            for (int x = 0; x < 12; x++)
            {
                forcastedArray[x] = Math.Round(forcastedArray[x], 2);
            }
            

            ChartArea first = new ChartArea("Predicted_Rainfall");

            first.AxisX.Title = "Months Of Year";
            first.AxisY.Title = "mm";
            first.AxisX.MajorGrid.LineWidth = 0;
            first.AxisY.MajorGrid.LineWidth = 0;

            forcastChart.ChartAreas[0] = first;
            Series barSeries = new Series();
            barSeries.Points.DataBindXY(months, forcastedArray);

            barSeries.ChartType = SeriesChartType.Line;
            barSeries.Name = "ES";

            forcastChart.Series[0] = (barSeries);
            forcastChart.Series[0].Points.FindMaxByValue().Color = Color.Blue;
            forcastChart.Series[0].Points.FindMinByValue().Color = Color.Red;
            forcastChart.Dock = DockStyle.Fill;

            foreach (DataPoint item in forcastChart.Series[0].Points)
            {
                double[] values = item.YValues;
                double value = values[0];
                item.Label = Convert.ToString(value);
            }
        }


        public void SetParent(DBSelectMenu setParent)
        {
            parentVar = setParent;
        }

        private void cbxFmethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxFmethod.SelectedIndex == 0)
            {

                dgvWeights.Enabled = false;
                sedNrPeriods.Enabled = true;
                txtAlpha.Enabled = false;
            }
            else
                if (cbxFmethod.SelectedIndex == 1)
            {

                dgvWeights.Enabled = true;
                sedNrPeriods.Enabled = false;
                txtAlpha.Enabled = false;
                dgvWeights.Rows.Clear();
                dgvWeights.Columns.Clear();
                int totalIndex = 0;
                for (int i = 0; i <= dgvDamLevels.ColumnCount - 2; ++i)
                {
                    dgvWeights.Columns.Add((2012 + i).ToString(), (2012 + i).ToString());
                    dgvWeights[i, 0].Value = i + 1;
                    totalIndex += i + 1;
                }

                lblTotal.Text = Convert.ToString(totalIndex);

            }
            if (cbxFmethod.SelectedIndex == 2)
            {

                dgvWeights.Enabled = false;
                sedNrPeriods.Enabled = false;
                txtAlpha.Enabled = true;
                txtAlpha.Focus();
            }
        }

        private void dgvWeights_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDamLevels_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            parentVar.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] actualValues = new double[12];
            double[] forcastedValues = new double[12];
           
            for(int i = 0; i<12; i++)
            {
                actualValues[i] = Convert.ToDouble(dgvActual[0,i].Value);
            }

            
            Series barSeries = new Series();
            barSeries.Points.DataBindXY(months, actualValues);

            barSeries.ChartType = SeriesChartType.Line;
            barSeries.Name = "Actual";

            if(forcastChart.Series.Count != 2)
            {
                forcastChart.Series.Add(barSeries);
            }else
            {
                forcastChart.Series[1] = barSeries;
            }
            
            forcastChart.Series[1].Points.FindMaxByValue().Color = Color.Blue;
            forcastChart.Series[1].Points.FindMinByValue().Color = Color.Red;

            
           
            foreach(Series i in forcastChart.Series)
                foreach (DataPoint item in i.Points)
                {
                    double[] values = item.YValues;
                    double value = values[0];
                    item.Label = Convert.ToString(value);
                    item.LabelAngle = 45;
                }
            forcastChart.Invalidate();
            int index = 0;
            foreach (DataPoint item in forcastChart.Series[0].Points)
            {
                forcastedValues[index++] = item.YValues[0];
            }

            double squaredError = 0;

            for(int i = 0; i<12; i++)
            {
                squaredError += Math.Pow(forcastedValues[i] - actualValues[i],2);
            }

            double mse = squaredError / 12;
            label4.Text = "MSE: " + Math.Round(mse,2);

        }

        private void DoWMA()
        {
            int newName = Convert.ToInt32(dgvDamLevels.Columns[dgvDamLevels.ColumnCount - 1].Name) + 1;
            dgvForcasted.Columns.Add(newName.ToString(), newName.ToString());
            Decimal[] weights = new Decimal[Convert.ToInt32(dgvDamLevels.ColumnCount)];
            try
            {

                decimal total = 0;
                for (int i = 0; i < dgvDamLevels.ColumnCount - 1; i++)
                {
                    if (dgvWeights[i, 0].Value == null)
                    {
                        MessageBox.Show("Please ensure that the correct number of weights are inserted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    total += Convert.ToDecimal(dgvWeights[i, 0].Value);

                }

                if (total.ToString() == lblTotal.Text)
                {
                    for (int i = 0; i < dgvDamLevels.ColumnCount - 1; i++)
                    {
                        weights[i] = Convert.ToDecimal(dgvWeights[i, 0].Value);
                        // MessageBox.Show(weights[i].ToString());
                    }
                }
                else
                {
                    MessageBox.Show("The sum of the weights must be " + lblTotal.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }



            }
            catch (FormatException e)
            {
                MessageBox.Show("Please ensure that the format of the weights are correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgvForcasted.Rows.Add(casting.WeightedMovingAverage(January, weights));
            dgvForcasted.Rows.Add(casting.WeightedMovingAverage(February, weights));
            dgvForcasted.Rows.Add(casting.WeightedMovingAverage(March, weights));
            dgvForcasted.Rows.Add(casting.WeightedMovingAverage(April, weights));
            dgvForcasted.Rows.Add(casting.WeightedMovingAverage(May, weights));
            dgvForcasted.Rows.Add(casting.WeightedMovingAverage(June, weights));
            dgvForcasted.Rows.Add(casting.WeightedMovingAverage(July, weights));
            dgvForcasted.Rows.Add(casting.WeightedMovingAverage(August, weights));
            dgvForcasted.Rows.Add(casting.WeightedMovingAverage(September, weights));
            dgvForcasted.Rows.Add(casting.WeightedMovingAverage(October, weights));
            dgvForcasted.Rows.Add(casting.WeightedMovingAverage(November, weights));
            dgvForcasted.Rows.Add(casting.WeightedMovingAverage(December, weights));


        }

        private void txtAlpha_TextChanged(object sender, EventArgs e)
        {
            txtAlpha.Text.Replace('.', ',');
        }

        private void sedNrPeriods_ValueChanged(object sender, EventArgs e)
        {
            dgvForcasted.Rows.Clear();
            dgvForcasted.Columns.Clear();
            if (cbxFmethod.SelectedIndex == 0)
            {
                setArrays();
                DoSMF();
            }
        }

       
        public frmDamLevels()
        {
            InitializeComponent();
        }

        public frmDamLevels(string Filepath)
        {
            InitializeComponent();
            myDBFile = Filepath;
            myDB = new OleDbConnection(conn + myDBFile);
            cbxDams.SelectedIndex = 0;
           
            cbxFmethod.SelectedIndex = 0;
            RefreshDb();
            casting = new Forecasting();
            nr_columns = dgvDamLevels.ColumnCount;
            January = new Decimal[nr_columns];
            February = new Decimal[nr_columns];
            March = new Decimal[nr_columns];
            April = new Decimal[nr_columns];
            May = new Decimal[nr_columns];
            June = new Decimal[nr_columns];
            July = new Decimal[nr_columns];
            August = new Decimal[nr_columns];
            September = new Decimal[nr_columns];
            October = new Decimal[nr_columns];
            November = new Decimal[nr_columns];
            December = new Decimal[nr_columns];
            int newName = Convert.ToInt32(dgvDamLevels.Columns[dgvDamLevels.ColumnCount - 1].Name) + 1;
            dgvActual.Columns.Add(newName.ToString(), newName.ToString());
            for (int i=0; i <=11; i++)
            {
                dgvActual.Rows.Add("0");
            }
            dgvActual.AllowUserToAddRows = false;
        }

        private void RefreshDb()
        {
            myDB.Open();
            adapter = new OleDbDataAdapter("SELECT * FROM " + Dam, myDB);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Dam");
            dgvDamLevels.DataSource = ds;
            dgvDamLevels.DataMember = "Dam";
            myDB.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        

        private void cbxDams_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxDams.SelectedIndex == 0)
                Dam = "Alexandra";
            else if (cbxDams.SelectedIndex == 1)
                Dam = "Berg_River";
            else if (cbxDams.SelectedIndex == 2)
                Dam = "De_Villiers";
            else if (cbxDams.SelectedIndex == 3)
                Dam = "Hely_Hutchenson";
            else if (cbxDams.SelectedIndex == 4)
                Dam = "Kleinplaats";
            else if (cbxDams.SelectedIndex == 5)
                Dam = "Lewis_Gay";
            else if (cbxDams.SelectedIndex == 6)
                Dam = "Steenbras_Lower";
            else if (cbxDams.SelectedIndex == 7)
                Dam = "Steenbras_Upper";
            else if (cbxDams.SelectedIndex == 8)
                Dam = "TheeWaterkloof";
            else if (cbxDams.SelectedIndex == 9)
                Dam = "Victoria";
            else if (cbxDams.SelectedIndex == 10)
                Dam = "Voelvlei";
            else if (cbxDams.SelectedIndex == 11)
                Dam = "Wemmerhoek";
            else if (cbxDams.SelectedIndex == 12)
                Dam = "Woodhead";

            cbxFmethod.SelectedIndex = 0;
            dgvForcasted.Columns.Clear();
            RefreshDb();
            sedNrPeriods.Maximum = dgvDamLevels.ColumnCount - 2;
        }

        private void frmDamLevels_Load(object sender, EventArgs e)
        {

        }

        private void DoSMF()
        {
            int newName = Convert.ToInt32(dgvDamLevels.Columns[dgvDamLevels.ColumnCount - 1].Name) + 1;
            dgvForcasted.Columns.Add(newName.ToString(), newName.ToString());
            dgvForcasted.Rows.Add(casting.SimpleMovingAverage(January, sedNrPeriods.Value));
            dgvForcasted.Rows.Add(casting.SimpleMovingAverage(February, sedNrPeriods.Value));
            dgvForcasted.Rows.Add(casting.SimpleMovingAverage(March, sedNrPeriods.Value));
            dgvForcasted.Rows.Add(casting.SimpleMovingAverage(April, sedNrPeriods.Value));
            dgvForcasted.Rows.Add(casting.SimpleMovingAverage(May, sedNrPeriods.Value));
            dgvForcasted.Rows.Add(casting.SimpleMovingAverage(June, sedNrPeriods.Value));
            dgvForcasted.Rows.Add(casting.SimpleMovingAverage(July, sedNrPeriods.Value));
            dgvForcasted.Rows.Add(casting.SimpleMovingAverage(August, sedNrPeriods.Value));
            dgvForcasted.Rows.Add(casting.SimpleMovingAverage(September, sedNrPeriods.Value));
            dgvForcasted.Rows.Add(casting.SimpleMovingAverage(October, sedNrPeriods.Value));
            dgvForcasted.Rows.Add(casting.SimpleMovingAverage(November, sedNrPeriods.Value));
            dgvForcasted.Rows.Add(casting.SimpleMovingAverage(December, sedNrPeriods.Value));


        }

        private void setArrays()
        {

            for (int i = 0; i < nr_columns - 1; i++)
            {
                January[i] = Convert.ToDecimal(dgvDamLevels[i + 1, 0].Value);
                February[i] = Convert.ToDecimal(dgvDamLevels[i + 1, 1].Value);
                March[i] = Convert.ToDecimal(dgvDamLevels[i + 1, 2].Value);
                April[i] = Convert.ToDecimal(dgvDamLevels[i + 1, 3].Value);
                May[i] = Convert.ToDecimal(dgvDamLevels[i + 1, 4].Value);
                June[i] = Convert.ToDecimal(dgvDamLevels[i + 1, 5].Value);
                July[i] = Convert.ToDecimal(dgvDamLevels[i + 1, 6].Value);
                August[i] = Convert.ToDecimal(dgvDamLevels[i + 1, 7].Value);
                September[i] = Convert.ToDecimal(dgvDamLevels[i + 1, 8].Value);
                October[i] = Convert.ToDecimal(dgvDamLevels[i + 1, 9].Value);
                November[i] = Convert.ToDecimal(dgvDamLevels[i + 1, 10].Value);
                December[i] = Convert.ToDecimal(dgvDamLevels[i + 1, 11].Value);
            }
        }
    }
}
