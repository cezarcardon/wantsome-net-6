using System;

namespace EvenNumbers0_100
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = 0;
            int endNumber = 100;
            int increment = 2;

            while (startNumber <= endNumber)
            {
                Console.WriteLine(startNumber);
                startNumber += increment;
            }


        }
    }
}
