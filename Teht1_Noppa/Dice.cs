using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht1_Noppa
{
    class Dice
    {
        public int Sides { get; }
        public int Smallest { get; }
        private Random random;

        public Dice() : this(6, 1, new Random())
        {
        }

        public Dice(int sides) : this(sides, 1, new Random())
        {
        }

        public Dice(int sides, int smallest) : this(sides, smallest, new Random())
        {
        }

        public Dice(Random rand) : this(6, 1, rand)
        {
        }

        public Dice(int sides, Random rand) : this(sides, 1, rand)
        {
        }

        public Dice (int sides, int smallest, Random rand)
        {
            this.Sides = sides;
            this.Smallest = smallest;
            this.random = rand;
        }

        public int Throw()
        {
            return random.Next(Smallest, Smallest + Sides);
        }

        public int Throw(int times)
        {
            int ret = 0;
            for (int i = 0; i < times; i++)
            {
                ret += Throw();
            }
            return ret;
        }

        public int Throw(int times, out int[] sideCounts)
        {
            int ret = 0;
            sideCounts = new int[Sides];
            for (int i = 0; i < times; i++)
            {
                int t = Throw();
                sideCounts[t-Smallest]++;
                ret += t;
            }
            return ret;
        }
    }
}
