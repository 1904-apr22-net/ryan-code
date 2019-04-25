using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Library
{
    class NoisyCircle : BetterCircle
    {
        private double Radius
        {
            get
            {
                Console.WriteLine("Getting Radius");
                return _radius;
            }
            set
            {
                Console.WriteLine("Setting Radius");
                _radius = value;
            }
        }

        public override double Area
        {
            get
            {
                Console.WriteLine("getting area");
                return base.Area;
            }
        }
        public override double GetParimeter()
        {
            Console.WriteLine("getting parimeter");
            return base.
        }


    }
}
