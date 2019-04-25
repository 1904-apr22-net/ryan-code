using System;

//namespace is just a sport of street address to a collection of classes
//the usual convention is to have your namespaces match your folder structure
namespace CSharpBasics
{
    //a class "Program"
    //(double slash is comments) in VS
    //Ctrl+k , Ctrl+C comments, Ctrl+k

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Variables and types
            // (Type) (new name) = (value)
            string s = "abc";
            s = "cba";

            //declaration of the variables 
            string s2;
            // the initialization of the variables
            // giving it its initial value
            s2 = "a";

            //numeric types
            //integer types
            //int (4 byte) (used this one)
            //byte (1), short (2), long (8)\

            //decimal types
            //double (8 bytes)(use this one)
            //float (4)
            //the benefit of the higher memory of the double
            // .. we can store more precision, about 15 decimal places

            //boolean
            bool b = true;
            b = false;

            //boolean operations
            b = true || true; // OR
            b = false && true; //AND




            //Conditional 
            // if { 3 <=4 }

            //For LOOP
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            while (b)
            {
                //this code runs many times so long as the condition is true
            }


            //Switches
            switch (s)
            {
                case "1":
                    //do something 
                    break;
                case "abc":
                    //do something 
                    break;
                default:
                    break;


            }




        }


        static void AnotherMethod()
        {
            
        }
    }
}
