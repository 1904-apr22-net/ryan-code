using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Library
{
    public class Circle
    {

        private double radius;

        public double GetRadius()
        {
            return radius;
        }

        public void SetRadius(double radius)
        {
            if (radius < 0)
            {
                Console.WriteLine("Not Allowed");
            }
            else
            {
                this.radius = radius;
            }


        }
    }
}
