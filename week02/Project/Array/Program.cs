using System;
using System.Linq.Expressions;

namespace Array
{
    class Program
    {   // Reverse an Array
        static void Main(string[] args)
        {
            var array = new int[5] {1, 32, 3, 4, 5};
            var newArray = new int[5];

            // i = 4; newPos = 0
            for (int i = array.Length - 1; i >= 0; i--)
            {
                int newPos = array.Length - 1 - i;
                newArray[newPos] = array[i];
            }

            foreach (int value in newArray)
            {
                Console.WriteLine(value);
            }
        }
    }
}
