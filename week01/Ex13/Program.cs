using System;

namespace Ex13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert a number");
            int inputNumber = int.Parse(Console.ReadLine());

            int startNumber = 0;
            int endNumber = 10;
            int result = 0;

            for (int i = startNumber; i<= endNumber; i++)
            {
                result = inputNumber * i;
                Console.WriteLine($"{inputNumber} * {i} = {result}");
            }
        }
    }
}
