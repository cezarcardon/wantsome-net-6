using System;
using System.Security.Cryptography;

namespace Ex10
//10. Print numbers from 1 to 10 except 4 and 7.
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = 1;
            int endNumber = 10;
            int counter = 1;

            while (counter <= endNumber)
            {
                if (counter != 4 && counter != 7)
                {
                    Console.WriteLine(counter);
                }
                counter += 1;
            }

        }

    }
}
