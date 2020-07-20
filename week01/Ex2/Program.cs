using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert the 1st number");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please insert the 2nd number");
            int number2 = int.Parse(Console.ReadLine());
            if (number1 != 0 && number2 != 0)
            {
                double division = Division(number1, number2);
                Console.WriteLine("Division is: " + division);
            }
            else
            {
                Console.WriteLine("Not possible");
            }
            int multuiplication = Multiplication(number1, number2);
            Console.WriteLine("Multiplication is: " + multuiplication);
            int min = Min(number1, number2);
            Console.WriteLine("Min is: " + min);
            int max = Max(number1, number2);
            Console.WriteLine("Max is: " + max);
        }
        static double Division(int a, int b)
        {
            double c = (double)a / b;
            return c;
        }
        static int Multiplication(int a, int b)
        {
            int c = a * b;
            return c;
        }
        static int Min(int a, int b)
        {
            if (a < b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        static int Max(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}

