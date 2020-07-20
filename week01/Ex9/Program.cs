using System;
using System.Dynamic;

namespace Ex9
//9. Read a text from console and print it reversed.
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert a string value");
            string input = Console.ReadLine();

            string reverseInput = "";

            for (int i = input.Length - 1; i >= 0; i --)
            {
                reverseInput += input[i];
            }

            Console.WriteLine(reverseInput);
        }
    }
}
