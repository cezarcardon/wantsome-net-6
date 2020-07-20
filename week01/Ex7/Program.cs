using System;

namespace Ex7
//7. Write a program to guess a number between 1 and 10. To generate a random number, use Random class from .NET Framework.
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = new Random().Next(1, 10);
            int y = Convert.ToInt32(Console.ReadLine());

            while (y != x)
            {
                Console.WriteLine("Wrong number, try again:");
                Console.WriteLine(x);
                y = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
