using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht3_MyFishApp
{
    class Fisherman
    {
        public string Name { get; }
        public string PhoneNumber { get; set; }
        private List<Fish> CaughtFish;

        public Fisherman(string name)
        {
            this.Name = name;
            this.CaughtFish = new List<Fish>();
        }

        public void Catch(Fish fish)
        {
            CaughtFish.Add(fish);
            Console.WriteLine(Name + " has caught a fish: ");
            fish.Print();
        }

        public List<Fish> ListFish()
        {
            return new List<Fish>(CaughtFish);
        }
    }
}
