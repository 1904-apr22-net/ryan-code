using Animals.library;
using System;

namespace Animals.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();

            dog.Name = "Bill";
            dog.Breed = "Labrador";
            dog.Bark();

            Console.WriteLine("Hello World!");
        }
    }
}
