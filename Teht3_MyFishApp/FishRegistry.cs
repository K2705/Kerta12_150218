using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht3_MyFishApp
{
    class FishRegistry
    {
        private List<Fisherman> FisherList;

        public FishRegistry()
        {
            this.FisherList = new List<Fisherman>();
        }

        public void AddFisher(Fisherman fisher)
        {
            FisherList.Add(fisher);
            Console.WriteLine("New fisherman added: " + fisher.Name + ", Phone: " + fisher.PhoneNumber);
        }

        public void AddFisher(string name, string phone)
        {
            Fisherman fisher = new Fisherman(name);
            fisher.PhoneNumber = phone;
            AddFisher(fisher);
        }

        public Fisherman FindFisher(string name)
        {
            return FisherList.Find(x => x.Name == name);
        }

        public void PrintAllFish()
        {
            foreach (Fisherman fisher in FisherList)
            {
                Console.WriteLine(fisher.Name + " Has caught the following fish:");
                foreach (Fish fish in fisher.ListFish())
                {
                    fish.Print();
                }
            }
        }

        public void PrintAllFishByWeight()
        {
            List<Fish> allFish = new List<Fish>();
            foreach (Fisherman fisher in FisherList)
            {
                allFish.AddRange(fisher.ListFish());
            }
            allFish.Sort((x, y) => y.Weight.CompareTo(x.Weight));
            foreach (Fish fish in allFish)
            {
                fish.Print();
                Console.WriteLine("Caught by " + fish.CaughtBy.Name);
            }
        }
    }
}
