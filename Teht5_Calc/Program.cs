using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht5_Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
            Console.WriteLine("Sum: {0:n2}", ArrayCalcs.Sum(numbers));
            Console.WriteLine("Avg: {0:n2}", ArrayCalcs.Average(numbers));
            Console.WriteLine("Max: {0:n2}", ArrayCalcs.Max(numbers));
            Console.WriteLine("Min: {0:n2}", ArrayCalcs.Min(numbers));
        }
    }
}
