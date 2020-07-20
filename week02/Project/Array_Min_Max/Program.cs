using System;

namespace Array_Min_Max
{
    class Program
    {
        static void Main(string[] args)
        {
            int array = new int[] { 20, 11, 45, 2, 55, 62, 1 };

            int max = -1, min = int.MaxValue;

            foreach (int val in array)
            {
                if (val < min)
                {
                    min = val;
                }
                if (val > max)
                {
                    max = val;
                }
            }

            Console.WriteLine()
        }
    }
}
