using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht1_Noppa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many sides?\n> ");
            int sides;
            if (!int.TryParse(Console.ReadLine(), out sides))
            {
                Console.WriteLine("Input invalid, set to 6");
                sides = 6;
            }
            Console.Write("How many throws?\n> ");
            int throws;
            if (!int.TryParse(Console.ReadLine(), out throws))
            {
                Console.WriteLine("Input invalid, set to 1");
                throws = 1;
            }

            Dice die = new Dice(sides, new Random());

            int[] sideCounts;
            Console.WriteLine("{0}d{1} : {2}", throws, sides, die.Throw(throws, out sideCounts));

            for ( int i = 0; i < die.Sides; i++)
            {
                Console.WriteLine("{0} was rolled {1} times", i + die.Smallest, sideCounts[i]);
            }
        }
    }
}
