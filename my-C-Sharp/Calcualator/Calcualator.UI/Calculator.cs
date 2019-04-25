using System;
using System.Collections.Generic;
using System.Text;

namespace TriplesCalc.UI
{
    class Calculator
    {
        public void Calc(int n)
        {
            for (int i = 0; i < n; i+=3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
