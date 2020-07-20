using System;
using System.Reflection.Metadata;

namespace Ex16
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 500;
            int counterDivizori = 0;
            int sum = 0;

            for (int i = 1; i <= counter; i++)
            {
                for (int x = 1; x <= counter; x++ )
                {
                    if (i % x == 0)
                    {
                        counterDivizori += 1;
                    }
                }
                
                if (counterDivizori == 2)
                {
                    Console.WriteLine($"{i} was added to sum: {sum}");
                    sum += i;
                    Console.WriteLine($"New sum is: {sum}");
                }
            }

        }

    }
}
