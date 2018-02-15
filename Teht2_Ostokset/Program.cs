using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht2_Ostokset
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> prods = new List<Product>();

            prods.Add(new Product("Milk", 1.4));
            prods.Add(new Product("Beer", 2.2));
            prods.Add(new Product("Butter", 3.4));
            prods.Add(new Product("Cheese", 4.2));

            Console.WriteLine("Products in list:");
            foreach (Product p in prods)
            {
                Console.WriteLine(p.Name + " " + p.Price + "e");
            }
        }
    }
}
