using System;
using System.Text.RegularExpressions;

namespace palindrome.Library
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Type a word:");
            string word = Console.ReadLine();

            MessageVerdict(word);
        }

        public static bool GetPStatus(string myString)
        {
            string firstWord = myString.Substring(0, myString.Length / 2);

          //  firstWord.Replace(/\s +/ g, '');

            char[] arr = myString.ToCharArray();

            Array.Reverse(arr);


            string temp = new string(arr);
            string secondWord = temp.Substring(0, temp.Length / 2);

            return firstWord.Equals(secondWord);
        }

        public static void MessageVerdict(string word)
        {
            bool bIsPal = GetPStatus(word);
            if (bIsPal)
            {
                Console.WriteLine($"The word: {word} is a palindrome");
            }
            else
            {
                Console.WriteLine($"The word: {word} is NOT a palindrome");
            }
        }
    }
}
