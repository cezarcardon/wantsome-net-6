using System;

namespace Array_Even_1_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = 1;
            int endNumber = 10;
            int counter = 0;

            var array1 = new int[endNumber / 2  + startNumber];

            for (int i = startNumber; i <= endNumber; i++)
            {
                Console.WriteLine($"i: {i}");
                if (i % 2 == 0)
                {
                    array1[counter] = i;
                    Console.WriteLine($"Counter: {counter}, i: {i}, Array1: {array1[counter]}");
                    counter += 1;
                }
            }
            foreach(int value in array1)
            {
                Console.WriteLine(value);
            }
        }
    }
}
