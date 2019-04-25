using System;

namespace Calcualator.UI
{
    class Program
    {

       //public int n;

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer: ");
            string input = Console.ReadLine();
            int num = int.Parse(input);

            Calculator calc new Calculator();
        }

        public static void Calc()
        {
            int n = int.Parse(Console.ReadLine());
            int nMax;
            for (int i = 0; i < n; i += 3)
            {
                Console.WriteLine("For Loop: "+i);
                nMax = i;
            }

            while (n > 0)
            {
                nMax = (nMax + 3);
                Console.WriteLine("Backwards: "+ nMax+" iterations: "+ n);
                n -= 1;
            }
        }
    }
}
