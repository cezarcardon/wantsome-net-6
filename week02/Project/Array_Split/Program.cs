using System;
using System.Diagnostics.CodeAnalysis;

namespace Array_Split
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[5];
            Console.WriteLine("Please insert 5 numbers separated by comma");
            string input = Console.ReadLine();
            string[] separatedNumbers = input.Split(',');
            
            for (var i = 0; i <= 4; i++)
            {
                array[i] = int.Parse(separatedNumbers[i]);
            }

            var sum = 0;

            foreach (var nr in array)
            {
                sum += nr; 
            }

            double avg = (double)sum / array.Length;
            Console.WriteLine($"the average is: {avg}");

        }
    }
}
