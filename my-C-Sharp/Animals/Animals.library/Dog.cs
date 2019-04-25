using System;

namespace Animals.library
{
    public class Dog
    {
        public string Breed { get; set; }
        public string Name { get; set; }

        public void Bark()
        {
            Console.WriteLine("BARK!!!");
        }

    }
}
