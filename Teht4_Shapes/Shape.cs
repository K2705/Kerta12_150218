using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht4_Shapes
{
    public abstract class Shape
    {
        public string Name { get; set; }

        public abstract double Area();
        public abstract double Circumference();
    }

    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            this.Name = "Rectangle";
            this.Width = width;
            this.Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }

        public override double Circumference()
        {
            return (Width + Height) * 2;
        }

        public override string ToString()
        {
            return Name + " Width: " + Width + " Height: " + Height + " Area: " + Area() + " Circumference: " + Circumference();
        }
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }
        
        public Circle(double radius)
        {
            this.Name = "Circle";
            this.Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override double Circumference()
        {
            return Math.PI * Radius * 2;
        }

        public override string ToString()
        {
            return Name + " Radius: " + Radius + " Area: " + Area() + " Circumference: " + Circumference();
        }
    }
}
