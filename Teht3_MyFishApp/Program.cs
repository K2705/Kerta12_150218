using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht3_MyFishApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // ready the database
            FishRegistry fishers = new FishRegistry();
            // add fisher
            fishers.AddFisher("Kirsi Kernel", "020-12345678");
            // see if we can find it again
            Fisherman kirsi = fishers.FindFisher("Kirsi Kernel");
            // catch some fish
            FishingSpot jyvaskyla = new FishingSpot("The Lake of Jyväskylä", "Jyväskylä");
            kirsi.Catch(new Fish("pike", 120, 4.5, jyvaskyla, kirsi));
            kirsi.Catch(new Fish("salmon", 190, 13.2, new FishingSpot("River Teno", "The Northern edge of Finland"), kirsi));
            // let's get a second fisherman and give him a fish
            {
                Fisherman uolevi = new Fisherman("Uolevi Kärppä");
                uolevi.Catch(new Fish("crucian carp", 20, 0.4, jyvaskyla, uolevi));
                fishers.AddFisher(uolevi);
            }

            // list all fish
            Console.WriteLine();
            fishers.PrintAllFish();
            // and sort them by weight
            Console.WriteLine();
            fishers.PrintAllFishByWeight();
        }
    }
}
