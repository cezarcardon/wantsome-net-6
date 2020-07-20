using System;

namespace Ex15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert a string value");
            string inputString = Console.ReadLine();

            var first = inputString[0];

            string outputString = first + inputString + first;

            Console.WriteLine(outputString);


        }
    }
}
