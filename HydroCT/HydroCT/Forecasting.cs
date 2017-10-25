using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace HydroCT
{
    class Forecasting
    {
        public Forecasting()
        {

        }

        public decimal SimpleMovingAverage(Decimal[] values,decimal period)
        {
            int max = values.Count() - 1;
            decimal total = 0;
            decimal number = period;

            for (int i=max; i >= (max - period); i--)
            {
                total += values[i];
            }
            return total / number;
        }

        public decimal WeightedMovingAverage(Decimal[] values, Decimal[] weights)
        {
            int length = values.Count()-1;
            decimal sum = 0;
            decimal indextot;
   
            indextot = weights.Sum();
           
           for (int i = 1; i < length; i++)
            {
                sum += values[i] * (weights[i]/ indextot);
 
            }

 
            return sum;
        }

        public decimal ExponentialSmoothing(Decimal[] values, decimal Alpha)
        {
            Decimal[] forcasted = new Decimal[values.Count()];
            forcasted[0] = values[0];
            for(int i=1; i<values.Count();i++)
            {
                forcasted[i] = forcasted[i - 1] + Alpha * (values[i - 1] - forcasted[i - 1]);
            }

            return forcasted[values.Count() - 1] + Alpha * (values[values.Count() - 1] - forcasted[values.Count() - 1]);
        }

      

    }

}
