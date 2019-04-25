using Shapes.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Library
{
    public class BetterCircle :IShape
    {

        public double x { get; set; }
        public double y { get; set; }

        //private double _radius;
        protected double _radius;

        public double Radius
        {
            get
            {
                return _radius * 1.01;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Error");
                }
                else
                {
                    _radius = value;
                }
            }
        }
        public double GetPerimeter() => 2 * Math.PI * Radius;

        public double Area => Math.PI * Math.Pow(Radius, 2);

        public int Sides => 0;
    }
}
