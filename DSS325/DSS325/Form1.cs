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
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            averageRainFall = new int[12] {1,2,3,4,5,6,7,8,9,10,11,12};
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 13;i++)
            {
                MessageBox.Show(Convert.ToString(getRainFall(averageRainFall[i])));
            }
            
        }

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

        private double monthRandomizer(int max, int min)
        {
            return ((random.NextDouble() * (max - min)) + min);
        }
    }
}
