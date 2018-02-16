using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht5_Calc
{
    public class ArrayCalcs
    {
        public static double Sum(double[] array)
        {
            if (array.Length == 0) throw new ArgumentException("Cannot sum an empty array!");
            double sum = 0;
            foreach (double d in array) { sum += d; }
            return sum;
        }

        public static double Average(double[] array)
        {
            if (array.Length == 0) throw new ArgumentException("Cannot average an empty array!");
            double avg = 0;
            foreach (double d in array) { avg += d; }
            avg = avg / array.Length;
            return avg;
        }

        public static double Min(double[] array)
        {
            if (array.Length == 0) throw new ArgumentException("Cannot find the minimum of an empty array!");
            double min = double.MaxValue;
            foreach (double d in array)
            {
                if (d < min)
                {
                    min = d;
                }
            }
            return min;
        }

        public static double Max(double[] array)
        {
            if (array.Length == 0) throw new ArgumentException("Cannot find the maximum of an empty array!");
            double max = double.MinValue;
            foreach (double d in array)
            {
                if (d > max)
                {
                    max = d;
                }
            }
            return max;
        }
    }
}
