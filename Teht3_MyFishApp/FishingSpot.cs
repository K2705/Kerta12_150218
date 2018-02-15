using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht3_MyFishApp
{
    class FishingSpot
    {
        public string Name { get; }
        public string Location { get; }

        public FishingSpot(string name, string location)
        {
            this.Name = name;
            this.Location = location;
        }
    }
}
