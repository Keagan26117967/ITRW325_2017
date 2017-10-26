using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.VisualBasic;


namespace DSS325
{
    public partial class Form1 : Form
    {
        public double[] averageDamsLevel = new double[12];
        private int[] averageRainFall;
        public int[] maxRainFall;
        public int[] minRainFall;
        public double[] avgRain;
        private double[] waterPrices;
        private bool decA = false;
        private bool ForC = false;
        public double waterAvalible;
        private double cost, pumpWater;

        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            averageRainFall = new int[12] {1,2,3,4,5,6,7,8,9,10,11,12};
            minRainFall = new int[12];
            maxRainFall = new int[12];
            waterPrices = new double[5];
            avgRain = new double[13] { 0 ,0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        }

        /*
         * This part just automatically loads values when the form opens
         */
        private void Form1_Load(object sender, EventArgs e)
        {
                //Here it should call on the class or method to get data of the rain.
            estimateTable();
            label43.Hide();
            // MessageBox.Show(Convert.ToString(getRainFall(averageRainFall[i])));
        }

        private double getDamLevel(int dam)
        {
          switch(dam)
            {
                case 1://"Alexandra"
                    return waterAva(134, 0.76);
                    break;
                case 2://"Berg_River"
                    return waterAva(130010, 0.63);
                    break;
                case 3://"De_Villiers"
                    return waterAva(242, 0.90);
                    break;
                case 4://"Hely_Hutchenson"
                    return waterAva(925, 1.01);
                    break;
                case 5://"Kleinplaats"
                    return waterAva(1301, 0.67);
                    break;
                case 6://"Lewis_Gay"
                    return waterAva(168, 0.92);
                    break;
                case 7://"Steenbras_Lower"
                    return waterAva(33517, 0.45);
                    break;
                case 8://"Steenbras_Upper"
                    return waterAva(31767, 1);
                    break;
                case 9://"TheeWaterkloof"
                    return waterAva(480188, 0.28);
                    break;
                case 10://"Victoria"
                    return waterAva(128, 1.01);
                    break;
                case 11://"Voelvlei"
                    return waterAva(164095, 0.26);
                    break;
                case 12://"Wemmerhoek"
                    return waterAva(58644, 0.44);
                    break;
                case 13://"Woodhead"
                    return waterAva(955, 0.91);
                    break;

            }
            return 0;
        }

        public double waterAva(int cap, double level)
        {
            double water = cap * level;
            waterAvalible += water;
            return water;
        }

        public double dayOfWater(int restrictionLevel)//In progress
        {
            for(int i = 0; i < 14; i++)
            {
                getDamLevel(i);
            }

            int population = 433688;
            double allowance = 0;//liters of water per person;
            double days;
            switch(restrictionLevel)
            {
                case 1:
                    allowance = 340; //Average use per person per day
                    days = (waterAvalible * 1000000) / (population * allowance);
                    label43.Text = Convert.ToString(Math.Round(days,2));
                    return days;
                    break;
                case 2:
                    allowance = 250;
                    days = (waterAvalible * 1000000) / (population * allowance);
                    label43.Text = Convert.ToString(Math.Round(days, 2));
                    days = waterAvalible / (population * allowance);
                    return days;
                    break;
                case 3:
                    allowance = 175;
                    days = (waterAvalible * 1000000) / (population * allowance);
                    label43.Text = Convert.ToString(Math.Round(days, 2));
                    return days;
                    break;
                case 4:
                    allowance = 100;
                    days = (waterAvalible * 1000000) / (population * allowance);
                    label43.Text = Convert.ToString(Math.Round(days, 2));
                    return days;
                    return 0;
                    break;
                case 5:
                    allowance = 87;
                    days = (waterAvalible * 1000000) / (population * allowance);
                    label43.Text = Convert.ToString(Math.Round(days, 2));
                    return days;
                    break;
            }

            return 0;
        }
        public double suggestedRestrictionLevel(double damLevel)//in progress
        {
            if(damLevel <= 75 && damLevel >= 65)
            {
                return dayOfWater(2);
            }
            else if(damLevel <= 65 && damLevel >= 50)
            {
                return dayOfWater(3);
            }
            else if(damLevel <= 50 && damLevel >= 30)
            {
                return dayOfWater(4);
            }
            else if(damLevel <= 30)
            {
                return dayOfWater(5);
            }
            else
            {
                return dayOfWater(1);
            }
        }

        public double avgDamLevel(int month)
        {
            int i = 0;
            double[] Alex = new double[12] { 51.936559139785, 43.9481141614881, 33.5942555245, 31.7678809526667, 33.4877648462366, 49.2138498041111, 60.0485434391935, 70.2780997543548, 72.4968133877778, 66.5739314644205, 61.16, 52.32193548};
            double[] Berg = new double[12] { 77.26666667, 67.69886134, 59.0718998, 55.59075815, 56.3875529, 63.76491334, 73.47886928, 83.65428677, 87.21160586, 87.66466682, 90.452, 84.64193548 };
            double[] Vil = new double[12] {76.95537634, 60.5872089, 58.40920252, 58.24191106, 61.42070929, 71.84358318, 85.47122461, 92.91024611, 94.70129399, 91.57749507, 84.78866667, 82.28580645 };
            double[] Hely = new double[12] {85.5016129, 65.98049348, 39.15179044, 34.84521972, 36.59881693, 65.84147724, 95.7554962, 100.4672319, 100.2137935, 96.70602174, 87.23933333, 86.72258065 };
            double[] Klein = new double[12] { 56.4, 48.19378146, 41.52850967, 37.24107514, 35.34222931, 44.71845097, 62.26840739, 82.70533931, 90.7623578, 88.80257721, 85.804, 74.14193548 };
            double[] Levis = new double[12] { 66.3983871, 58.46162327, 46.66296723, 37.15251323, 38.26804916, 57.75398148, 81.49420123, 99.05107527, 95.0689418, 90.35729015, 84.988, 84.25096774 };
            double[] SteenLow = new double[12] { 61.68870968, 55.17161991, 48.45494108, 44.04352905, 41.02360301, 49.1332283, 62.56316076, 79.56263583, 83.65612099, 80.70645123, 80.82466667, 70.3 };
            double[] SteenUp = new double[12] { 87.8327957, 82.02660094, 72.94265983, 62.97478612, 60.52195174, 68.83005775, 85.85608249, 99.09723807, 98.76325673, 98.34836482, 93.99333333, 88.89354839 };
            double[] ThreeWater = new double[12] { 69.94731183, 62.12617905, 55.0824878, 50.40342871, 48.28297476, 54.4699799, 62.73517088, 72.38667191, 77.19206592, 76.72086641, 83.58133333, 77.65419355 };
            double[] Victoria = new double[12] { 69.01236559, 61.26276875, 38.79799936, 35.47717117, 29.05367384, 48.6173226, 75.56557884, 92.9439043, 97.50989616, 99.95765842, 97.80866667, 93.4083871 };
            double[] Voel = new double[12] { 64.29892473, 55.60025555, 47.65978321, 41.75214623, 38.95021473, 43.66434821, 55.38118127, 67.05727752, 74.00500863, 73.70284138, 78.87866667, 71.5483871 };
            double[] Wemmer = new double[12] { 69.02634409, 63.7542806, 58.21686854, 54.02439613, 51.1493983, 57.66050588, 67.0536531, 76.6280084, 80.8421198, 78.5468142, 80.40066667, 74.8116129 };
            double[] Wood = new double[12] { 74.5844086, 69.41653711, 69.29247509, 68.35572364, 63.40346031, 69.70357996, 80.66510275, 95.68117131, 90.23262808, 80.25521223, 80.42, 80.90774194 };

            switch (month)
            {
                case 1:
                    i = 0;
                    List<double> Jan = new List<double> { Alex[i], Berg[i], Vil[i], Hely[i], Klein[i], Levis[i], SteenLow[i], SteenUp[i], ThreeWater[i], Victoria[i], Voel[i], Wemmer[i], Wood[i] };
                    label30.Text = Convert.ToString(Math.Round(Jan.Average(),2) + "%");
                    averageDamsLevel[i] = Jan.Average();
                    return  Jan.Average();                               //January
                    break;
                case 2:
                    i = 1;
                    List<double> Feb = new List<double> { Alex[i], Berg[i], Vil[i], Hely[i], Klein[i], Levis[i], SteenLow[i], SteenUp[i], ThreeWater[i], Victoria[i], Voel[i], Wemmer[i], Wood[i] };
                    label32.Text = Convert.ToString(Math.Round(Feb.Average(),2) + "%");
                    averageDamsLevel[i] = Feb.Average();
                    return Feb.Average();          //February
                    break;
                case 3:
                    i = 2;
                    List<double> Mar = new List<double> { Alex[i], Berg[i], Vil[i], Hely[i], Klein[i], Levis[i], SteenLow[i], SteenUp[i], ThreeWater[i], Victoria[i], Voel[i], Wemmer[i], Wood[i] };
                    label33.Text = Convert.ToString(Math.Round(Mar.Average(),2) + "%");
                    averageDamsLevel[i] = Mar.Average();
                    return Mar.Average();          //March
                    break;
                case 4:
                    i = 3;
                    List<double> Apr = new List<double> { Alex[i], Berg[i], Vil[i], Hely[i], Klein[i], Levis[i], SteenLow[i], SteenUp[i], ThreeWater[i], Victoria[i], Voel[i], Wemmer[i], Wood[i] };
                    label34.Text = Convert.ToString(Math.Round(Apr.Average(),2) + "%");
                    averageDamsLevel[i] = Apr.Average();
                    return Apr.Average();          //April
                    break;
                case 5:
                    i = 4;
                    List<double> May = new List<double> { Alex[i], Berg[i], Vil[i], Hely[i], Klein[i], Levis[i], SteenLow[i], SteenUp[i], ThreeWater[i], Victoria[i], Voel[i], Wemmer[i], Wood[i] };
                    label35.Text = Convert.ToString(Math.Round(May.Average(),2) + "%");
                    averageDamsLevel[i] = May.Average();
                    return May.Average();        //May
                    break;
                case 6:
                    i = 5;
                    List<double> Jun = new List<double> { Alex[i], Berg[i], Vil[i], Hely[i], Klein[i], Levis[i], SteenLow[i], SteenUp[i], ThreeWater[i], Victoria[i], Voel[i], Wemmer[i], Wood[i] };
                    label36.Text = Convert.ToString(Math.Round(Jun.Average(),2) + "%");
                    averageDamsLevel[i] = Jun.Average();
                    return Jun.Average();       //June
                    break;
                case 7:
                    i = 6;
                    List<double> Jul = new List<double> { Alex[i], Berg[i], Vil[i], Hely[i], Klein[i], Levis[i], SteenLow[i], SteenUp[i], ThreeWater[i], Victoria[i], Voel[i], Wemmer[i], Wood[i] };
                    label37.Text = Convert.ToString(Math.Round(Jul.Average(),2) + "%");
                    averageDamsLevel[i] = Jul.Average();
                    return Jul.Average();        //July
                    break;
                case 8:
                    i = 7;
                    List<double> Aug = new List<double> { Alex[i], Berg[i], Vil[i], Hely[i], Klein[i], Levis[i], SteenLow[i], SteenUp[i], ThreeWater[i], Victoria[i], Voel[i], Wemmer[i], Wood[i] };
                    label38.Text = Convert.ToString(Math.Round(Aug.Average(),2) + "%");
                    averageDamsLevel[i] = Aug.Average();
                    return Aug.Average();        //August   
                    break;
                case 9:
                    i = 8;
                    List<double> Sep = new List<double> { Alex[i], Berg[i], Vil[i], Hely[i], Klein[i], Levis[i], SteenLow[i], SteenUp[i], ThreeWater[i], Victoria[i], Voel[i], Wemmer[i], Wood[i] };
                    label39.Text = Convert.ToString(Math.Round(Sep.Average(),2) + "%");
                    averageDamsLevel[i] = Sep.Average();
                    return Sep.Average();         //September
                    break;
                case 10:
                    i = 9;
                    List<double> Oct = new List<double> { Alex[i], Berg[i], Vil[i], Hely[i], Klein[i], Levis[i], SteenLow[i], SteenUp[i], ThreeWater[i], Victoria[i], Voel[i], Wemmer[i], Wood[i] };
                    label40.Text = Convert.ToString(Math.Round(Oct.Average(),2) + "%");
                    averageDamsLevel[i] = Oct.Average();
                    return Oct.Average();          //October
                    break;
                case 11:
                    i = 10;
                    List<double> Nov = new List<double> { Alex[i], Berg[i], Vil[i], Hely[i], Klein[i], Levis[i], SteenLow[i], SteenUp[i], ThreeWater[i], Victoria[i], Voel[i], Wemmer[i], Wood[i] };
                    label41.Text = Convert.ToString(Math.Round(Nov.Average(),2) + "%");
                    averageDamsLevel[i] = Nov.Average();
                    return Nov.Average();          //November  
                    break;
                case 12:
                    i = 11;
                    List<double> Dec = new List<double> { Alex[i], Berg[i], Vil[i], Hely[i], Klein[i], Levis[i], SteenLow[i], SteenUp[i], ThreeWater[i], Victoria[i], Voel[i], Wemmer[i], Wood[i] };
                    label42.Text = Convert.ToString(Math.Round(Dec.Average(),2) + "%");
                    averageDamsLevel[i] = Dec.Average();
                    return Dec.Average();          //December          
                    break;
            }
           return 0;
        }



        /*
         * Assigns values between the min and max values                    //USE MIN MAX VALUES HERE
         */
         //Still needs to be updated because of the reading from a file thing.
        private double getRainFall(int iMonth)
        {
            switch (iMonth)
            {
                case 1:
                    return monthRandomizer(18,3);           //January
                    break;
                case 2:
                    return monthRandomizer(16, 1);          //February
                    break;
                case 3:
                    return monthRandomizer(48, 6);          //March
                    break;
                case 4:
                    return monthRandomizer(62, 4);          //April
                    break;
                case 5:
                    return monthRandomizer(109, 17);        //May
                    break;
                case 6:
                    return monthRandomizer(219, 110);       //June
                    break;
                case 7:
                    return monthRandomizer(143, 51);        //July
                    break;
                case 8:
                    return monthRandomizer(119, 48);        //August   
                    break;
                case 9:
                    return monthRandomizer(57, 29);         //September
                    break;
                case 10:
                    return monthRandomizer(14, 9);          //October
                    break;
                case 11:
                    return monthRandomizer(58, 9);          //November  
                    break;
                case 12:
                    return monthRandomizer(30, 6);          //December          
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;      
            }
            return 0;
        }

        /*
         * Acquires the min and max value arrays 
         */
        private void setMinMaxRainFall(int[] max, int[] min)
        {
            for (int i = 0; i < 13; i++)
            {
                maxRainFall[i] = max[i];
                minRainFall[i] = max[i];
            }
        }           //SET MIN MAX OVE HERE!!!!!!!!!!!!!!!!!!

        /*
         * Finds out what label it should write to 
         */
        public Label intToLabel(int month)
        {
            switch (month)
            {
                case 1:
                    return label13;             //January
                    break;
                case 2:
                    return label14;             //February
                    break;
                case 3:
                    return label15;             //March
                    break;
                case 4:
                    return label16;             //April
                    break;
                case 5:
                    return label17;             //May
                    break;
                case 6:
                    return label18;             //June
                    break;
                case 7:
                    return label19;             //July
                    break;
                case 8:
                    return label20;             //August   
                    break;
                case 9:
                    return label21;             //September
                    break;
                case 10:
                    return label22;             //October
                    break;
                case 11:
                    return label23;             //November  
                    break;
                case 12:
                    return label24;             //December          
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
            return label13;
        }

        /*
         * gets a month name from an integer 
         */
        public string getMonthName(int monthNum)
        {
            DateTime dtDate = new DateTime(2000, monthNum, 1);
            string monthFullName = dtDate.ToString("MMMM");
            return monthFullName;
        }

        /*
         * Randoms an integer between min and max values 
         */
        private double monthRandomizer(int max, int min)
        {
            return Math.Round(((random.NextDouble() * (max - min)) + min),2);
        }

        /*
         * Writes to labels
         */
        private void estimateTable()
        {
            for (int i = 1; i < 13; i++)
            {
                avgRain[i] = 0;
                for (int u = 0; u < 100000; u++)           //Use AvgRain[] for your data Vorster
                {
                    avgRain[i] = avgRain[i] + getRainFall(i);
                }   
                intToLabel(i).Text = (Convert.ToString(Math.Round(avgRain[i]/ 100000, 2)) + " " + "mm");
            }
            label28.Text = "Avg. Dam Level";
            label25.Text = "Predicted Rainfall";
            for (int y = 0; y < 13; y++)
            {
                avgDamLevel(y);
            }

            //Drawing chart
            string[] months = { "JAN", "FEB", "MAR", "APR", "MAY", "JUN", "JUL", "AUG", "SEP", "OCT", "NOV", "DEC" };
            double[] twelveAvg = new double[12]; //A version of avgRainfall with 12 spaces instead of 13
            simulateDamIncrease();
            for (int i = 0; i < 12; i++)
            {
                twelveAvg[i] = Math.Round(avgRain[i + 1]/100000,2);
            }

            ChartArea first = new ChartArea("Predicted_Rainfall");
           
            first.AxisX.Title = "Months Of Year";
            first.AxisY.Title = "mm";
            first.AxisX.MajorGrid.LineWidth = 0;
            first.AxisY.MajorGrid.LineWidth = 0;

            predictedChart.ChartAreas[0] = first;
            Series barSeries = new Series();
            barSeries.Points.DataBindXY(months, twelveAvg);

            barSeries.ChartType = SeriesChartType.Column;
            barSeries.Name = "Predicted Rainfall";

            predictedChart.Series[0] = (barSeries);
            predictedChart.Series[0].Points.FindMaxByValue().Color = Color.Blue;
            predictedChart.Series[0].Points.FindMinByValue().Color = Color.Red;
            

            foreach (DataPoint item in predictedChart.Series[0].Points)
            {
                double[] values = item.YValues;
                double value = values[0];
                item.Label = Convert.ToString(value);
            }

            ChartArea avgFirst = new ChartArea("Predicted_Rainfall");

            avgFirst.AxisX.Title = "Months Of Year";
            avgFirst.AxisY.Title = "%";
            avgFirst.AxisX.MajorGrid.LineWidth = 0;
            avgFirst.AxisY.MajorGrid.LineWidth = 0;
            

            averageChart.ChartAreas[0] = avgFirst;
            Series avgSeries = new Series();
            avgSeries.Points.DataBindXY(months, averageDamsLevel);

            avgSeries.ChartType = SeriesChartType.Column;
            avgSeries.Name = "Dam Level";

            averageChart.Series[0] = (avgSeries);
            averageChart.Series[0].Points.FindMaxByValue().Color = Color.Blue;
            averageChart.Series[0].Points.FindMinByValue().Color = Color.Red;
            

            foreach (DataPoint item in averageChart.Series[0].Points)
            {
                double[] values = item.YValues;
                double value = values[0];
                item.Label = Convert.ToString(Math.Round(value,2));
            }

        }

        private double detectMonthReduction(int x)
        {
            if ((x > 0) && (x <= 4))
            { return Math.Round(((random.NextDouble() * (0.23 - 0.05)) + 0.05), 2); }
            if ((x > 4) && (x <= 8))
            { return 0; }
            if ((x > 8))
            { return Math.Round(((random.NextDouble() * (0.23 - 0.05)) + 0.05), 2); }
            return 0;
        }

        private void simulateDamIncrease()
        {
            double damChange = 0;
            double PDA = 0;
            for (int i = 1; i < 13; i++)
            {
                if (((avgRain[i]/100000) >= 1) && ((avgRain[i] / 100000) < 11))
                {
                    damChange = 0 - detectMonthReduction(i);
                    PDA = PDA + damChange;
                    intToLabel(i).Text = intToLabel(i).Text + " \t" + Convert.ToString(damChange) + "%";
                }
                else if (((avgRain[i] / 100000) > 12) && ((avgRain[i] / 100000) <= 20))
                {
                    damChange = Math.Round(((random.NextDouble() * (0.11 - 0.03)) + 0.03), 2) - detectMonthReduction(i);
                    PDA = PDA + damChange;
                    intToLabel(i).Text = intToLabel(i).Text + " \t" + Convert.ToString(damChange) + "%";
                }
                else if (((avgRain[i] / 100000) > 20) && ((avgRain[i] / 100000) <= 40))
                {
                    damChange = Math.Round(((random.NextDouble() * (0.13 - 0.03)) + 0.03), 2) - detectMonthReduction(i);
                    PDA = PDA + (damChange/100);
                    intToLabel(i).Text = intToLabel(i).Text + " \t" + Convert.ToString(damChange) + "%";
                }
                else if (((avgRain[i] / 100000) > 20) && ((avgRain[i] / 100000) <= 40))
                {
                    damChange = Math.Round(((random.NextDouble() * (0.19 - 0.06)) + 0.06), 2) - detectMonthReduction(i);
                    PDA = PDA + damChange;
                    intToLabel(i).Text = intToLabel(i).Text + " \t" + Convert.ToString(damChange) + "%";
                }
                else if (((avgRain[i] / 100000) > 40) && ((avgRain[i] / 100000) <= 65))
                {
                    damChange = Math.Round(((random.NextDouble() * (0.35 - 0.07)) + 0.07), 2) - detectMonthReduction(i);
                    PDA = PDA + damChange;
                    intToLabel(i).Text = intToLabel(i).Text + " \t" + Convert.ToString(damChange) + "%";
                }
                else if (((avgRain[i] / 100000) > 65) && ((avgRain[i] / 100000) <= 80))
                {
                    damChange = Math.Round(((random.NextDouble() * (0.71 - 0.1)) + 0.1), 2) - detectMonthReduction(i);
                    PDA = PDA + damChange;
                    intToLabel(i).Text = intToLabel(i).Text + " \t" + Convert.ToString(damChange) + "%";
                }
                else if (((avgRain[i] / 100000) > 80) && ((avgRain[i] / 100000) <= 100))
                {
                    damChange = Math.Round(((random.NextDouble() * (0.87 - 0.32)) + 0.32), 2) - detectMonthReduction(i);
                    PDA = PDA + damChange;
                    intToLabel(i).Text = intToLabel(i).Text +  "\t" + Convert.ToString(damChange) + "%";
                }
                else if (((avgRain[i] / 100000) > 100) && ((avgRain[i] / 100000) <= 125))
                {
                    damChange = Math.Round(((random.NextDouble() * (0.89 - 0.34)) + 0.34), 2) - detectMonthReduction(i);
                    PDA = PDA + damChange;
                    intToLabel(i).Text = intToLabel(i).Text + " \t" + Convert.ToString(damChange) + "%";
                }
                else if (((avgRain[i] / 100000) > 125) && ((avgRain[i] / 100000) <= 140))
                {
                    damChange = Math.Round(((random.NextDouble() * (0.96 - 0.36)) + 0.36), 2) - detectMonthReduction(i);
                    PDA = PDA + damChange;
                    intToLabel(i).Text = intToLabel(i).Text + " \t" + Convert.ToString(damChange) + "%";
                }
                else if (((avgRain[i] / 100000) > 140) && ((avgRain[i] / 100000) <= 156))
                {
                    damChange = Math.Round(((random.NextDouble() * (1.01 - 0.37)) + 0.37), 2) - detectMonthReduction(i);
                    PDA = PDA + damChange; 
                    intToLabel(i).Text = intToLabel(i).Text + " \t" + Convert.ToString(damChange) + "%";
                }
                else if (((avgRain[i] / 100000) > 156) && ((avgRain[i] / 100000) <= 160))
                {
                    damChange = Math.Round(((random.NextDouble() * (1.05 - 0.38))+0.38), 2) - detectMonthReduction(i);
                    PDA = PDA + damChange;
                    intToLabel(i).Text = intToLabel(i).Text + " \t" + Convert.ToString(damChange) + "%";
                }
                else if ((avgRain[i] / 100000) >= 160)
                {
                    damChange = Math.Round(((random.NextDouble() * (1.15 - 0.2)) + 0.2), 2) - detectMonthReduction(i);
                    PDA = PDA + damChange;
                    intToLabel(i).Text = intToLabel(i).Text + " \t" + Convert.ToString(damChange) + "%";
                }
                if (i == 10)
                {
                    intToLabel(i).Text = intToLabel(i).Text + " \t" + Convert.ToString(damChange) + "%";
                }
            }
            lblPDA.Text = "PDG: " + Math.Round((PDA /12),2) + "%";

        }


        /*
         * When button1 is clicked
         */
        private void button1_Click(object sender, EventArgs e)
        {
            estimateTable();
            suggestedRestrictionLevel(32); // Test Data
        }

        //Shows a panel for decision making
        private void button4_Click(object sender, EventArgs e)
        {
            ForC = false;
            if (decA == false)
            {
                predictedChart.Show();
                decA = true;
                return;
            }
            if (decA == true)
            {
                predictedChart.Hide();
                decA = false;
                return;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void predictedChart_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void btnDBV_Click(object sender, EventArgs e)
        {
            DBSelectMenu myDBSelect = new DBSelectMenu();
            myDBSelect.SetParent(this);
            myDBSelect.Show();

        }

    }
}