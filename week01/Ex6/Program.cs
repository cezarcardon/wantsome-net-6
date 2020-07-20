using System;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            for (int i = 1400; i<=2300; i++)
            {
                if (i % 7 == 0 && i % 5 == 0)
                {
                    counter += 1;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
