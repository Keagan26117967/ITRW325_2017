using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSS325
{
    public partial class Form1 : Form
    {
        private int[] averageRainFall;
        public int[] maxRainFall;
        public int[] minRainFall;
        private double[] waterPrices;
        private bool decA = false;
        private double cost, pumpWater;

        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            averageRainFall = new int[12] {1,2,3,4,5,6,7,8,9,10,11,12};
            minRainFall = new int[12];
            maxRainFall = new int[12];
            waterPrices = new double[5];
        }

        /*
         * This part just automatically loads values when the form opens
         */
        private void Form1_Load(object sender, EventArgs e)
        {
                //Here it should call on the class or method to get data of the rain.
            estimateTable();
            setWaterPriceNumbers();
            pnlDecision.Hide();
            // MessageBox.Show(Convert.ToString(getRainFall(averageRainFall[i])));
        }

        /*
         * Assigns values between the min and max values 
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
        }

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
            for (int i = 0; i < 13; i++)
            {
                intToLabel(i).Text = (Convert.ToString(getRainFall(i)) + " " + "mm");
            }
        }

        /*
         * Water prices are adjusted according to the numeric box
         */
        private void setWaterPriceNumbers()
        {
            double adjust = (double)numericUpDown1.Value;
            waterPrices[0] = 16 + (16 * (adjust / 100));
            waterPrices[1] = 18.97 + (18.97 * (adjust / 100));
            waterPrices[2] = 25.26 + (25.26 * (adjust / 100));
            waterPrices[3] = 38.97 + (38.97 * (adjust / 100));
            waterPrices[4] = 45.86 + (45.86 * (adjust / 100));
            lblTier1.Text = "< 9Kl          R" + Convert.ToString(Math.Round(waterPrices[0], 2));
            lblTier2.Text = "9 - 25Kl       R" + Convert.ToString(Math.Round(waterPrices[1], 2));
            lblTier3.Text = "25 - 30Kl      R" + Convert.ToString(Math.Round(waterPrices[2], 2));
            lblTier4.Text = "30 - 40Kl      R" + Convert.ToString(Math.Round(waterPrices[3], 2));
            lblTier5.Text = "> 40Kl         R" + Convert.ToString(Math.Round(waterPrices[4], 2));
        }

        /*
         * When button1 is clicked
         */
        private void button1_Click(object sender, EventArgs e)
        {
            estimateTable();
        }

        /*
         * Auto adjust the prices of water based on key releases, any other events do not read properly.
         */
        private void numericUpDown1_KeyUp(object sender, KeyEventArgs e)
        {
            setWaterPriceNumbers();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1524, 480);
            button2.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1340, 480);
            button2.Show();
        }

        //Shows a panel for decision making
        private void button4_Click(object sender, EventArgs e)
        {
            if (decA == false)
            {
                pnlDecision.Show();
                DecisionAnalysis();
                decA = true;
                return;
            }
            if (decA == true)
            {
                pnlDecision.Hide();
                decA = false;
                return;
            }
        }

        private void numericUpDown2_KeyUp(object sender, KeyEventArgs e)
        {
            Random Rndm = new Random();
            pumpWater = ((double)numericUpDown2.Value / cost);
            int pumpSpeed = Rndm.Next(150, 266);
            label29.Text = Convert.ToString(Math.Round(pumpWater, 2)) + "       " + Convert.ToString(Math.Round(pumpWater*pumpSpeed, 2));
        }

        public void DecisionAnalysis()
        {
            Random Rndm = new Random();
            int population = Rndm.Next(3665226, 3814826);
            lblPop.Text = "Population:  " + Convert.ToString(population);
            int kwH = Rndm.Next(184, 381);
            cost = (kwH * 1.28) + (235);
            lblCost.Text = "Cost(per Hour):  " + Convert.ToString(cost);
        }

        /*200mm offset 18%
* Avg w pp * population = demand
* if demand < supply
* give advice
* pump cost = R45
* R1.24 Kilowatt/Hour
* avg. station Kw/h = 282 offset 35%
* Acquire threshold from others so it tells you it isn't possible you might need to upgrade pumps???
* //////////////////////////////////////
* 
* 
*/
    }
}