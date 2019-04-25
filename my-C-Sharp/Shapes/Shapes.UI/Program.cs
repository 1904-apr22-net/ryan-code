using Shapes.Library;
using Shapes.Library.Interfaces;
using System;

namespace Shapes.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle cir = new Circle();

            double r = cir.GetRadius();

            cir.SetRadius(-4);

            BetterCircle better = new BetterCircle();

            better.Radius = 5;
            Console.WriteLine(better.Radius);


            Console.WriteLine("Hello World!");
            ShapeWork();
        }

        static void ShapeWork()
        {
            Rectangle r = new Rectangle();

            r.Length = 4;
            r.Width = 3;

            Console.WriteLine(r.GetPerimeter());
            Console.WriteLine(r.Area);
        }

        static void PrintShapeDetails(IShape shape, String name)
        {
            Console.WriteLine("shape: " + name);
            Console.WriteLine("Area is " + shape.Area);
            Console.WriteLine("Perimeter is " + shape.GetPerimeter());
            Console.WriteLine("Sides are " + shape.Sides);
        }
    }
}