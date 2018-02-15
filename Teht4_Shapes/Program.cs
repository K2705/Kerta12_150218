using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht4_Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapeList = new List<Shape>();

            shapeList.Add(new Circle(1));
            shapeList.Add(new Circle(2));
            shapeList.Add(new Circle(3));
            shapeList.Add(new Rectangle(10, 20));
            shapeList.Add(new Rectangle(20, 30));
            shapeList.Add(new Rectangle(40, 50));

            foreach (Shape s in shapeList)
            {
                Console.WriteLine(s);
            }
        }
    }
}
