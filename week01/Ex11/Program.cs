using System;

namespace Ex12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert the 1st number");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please insert the 2nd number");
            int number2 = int.Parse(Console.ReadLine());

            int adding = Adding(number1, number2);
            Console.WriteLine("{0} + {1} = {2}", number1, number2, adding);

            int subtracting = Subtracting(number1, number2);
            Console.WriteLine("{0} - {1} = {2}", number1, number2, subtracting);

            int multuiplication = Multiplication(number1, number2);
            Console.WriteLine("{0} * {1} = {2}", number1, number2, multuiplication);

            if (number1 != 0 && number2 != 0)
            {
                double division = Division(number1, number2);
                Console.WriteLine("{0} / {1} = {2}", number1, number2, division);
            }
            else
            {
                Console.WriteLine("Not possible");
            }

            int mod = Mod(number1, number2);
            Console.WriteLine("{0} mod {1} = {2}", number1, number2, mod);


        }

        static int Adding(int a, int b)
        {
            int c = a + b;
            return c;
        }

        static int Subtracting(int a, int b)
        {
            int c = a - b;
            return Math.Abs(c);
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

        static int Mod (int a, int b)
        {
            int c = a % b;
            return c;
        }
    }

}

