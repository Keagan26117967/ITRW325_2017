using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSS325
{
    class CalculateMinMaxArrays
    {
        public double[] arrRainfallMIN = new double[12];
        public double[] arrRainfallMAX = new double[12];

        public void setMinMaxArrays(string[,] arr2d)
        {

            int count = 0; ;

            for (int r = 0; r < arr2d.GetLength(0) - 1; r++)
            {
                double min = Convert.ToDouble(arr2d[r, 1]);
                double max = Convert.ToDouble(arr2d[r, 1]);
                for (int c = 1; c < arr2d.GetLength(1); c++)
                {
                    double temp;
                    if (arr2d[r, c] != "")
                    {
                        temp = Convert.ToDouble(arr2d[r, c]);
                        if (temp < min)
                            min = temp;
                        if (temp > max)
                            max = temp;
                    }
                    else
                    {
                        temp = 0;
                    }
                }
                arrRainfallMIN[count] = min;
                arrRainfallMAX[count] = max;
                count++;
            }
            string concatenated = string.Join(",\n",
                      arrRainfallMIN.Select(x => x.ToString()).ToArray());
            MessageBox.Show("This is for testing purposes Delete later \nMin Values of dataset:\n" + concatenated);
            string concatenated2 = string.Join(",\n",
                      arrRainfallMAX.Select(x => x.ToString()).ToArray());
            MessageBox.Show("This is for testing purposes Delete later \nMax Values of dataset:\n" + concatenated2);
        }// end public setMinMaxArrays

        public double[] getRainfallMin()
        {
            return arrRainfallMIN;
        }

        public double[] getRainfallMax()
        {
            return arrRainfallMAX;
        }
    }
}