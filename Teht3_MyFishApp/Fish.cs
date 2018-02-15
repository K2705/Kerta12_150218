using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht3_MyFishApp
{
    class Fish
    {
        public string Species { get; }
        public double Length { get; }
        public double Weight { get; }
        public FishingSpot CaughtAt { get; }

        public Fish(string species, double length, double weight, FishingSpot place)
        {
            this.Species = species;
            this.Length = length;
            this.Weight = weight;
            this.CaughtAt = place;
        }

        public void Print()
        {
            Console.WriteLine(Species + ", " + Length + " cm, " + Weight + " kg");
            Console.WriteLine("Location: " + CaughtAt.Name + ", " + CaughtAt.Location);
        }
    }
}
