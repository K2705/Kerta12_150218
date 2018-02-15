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
    }
}
