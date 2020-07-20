using System;
using System.Linq;

namespace Ex14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[4];

            Console.WriteLine("Please insert the 1st number");
            int number1 = int.Parse(Console.ReadLine());
            array1[0] = number1;

            Console.WriteLine("Please insert the 2nd number");
            int number2 = int.Parse(Console.ReadLine());
            array1[1] = number2;

            Console.WriteLine("Please insert the 3rd number");
            int number3 = int.Parse(Console.ReadLine());
            array1[2] = number3;

            Console.WriteLine("Please insert the 4th number");
            int number4 = int.Parse(Console.ReadLine());
            array1[3] = number4;

            double avg = array1.Sum() / array1.Length;
            Console.WriteLine($"The average of {number1}, {number2}, {number3}, {number4} is: {avg}");

        }

    }
}
