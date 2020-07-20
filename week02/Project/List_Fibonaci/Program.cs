using System;
using System.Collections.Generic;

namespace List_Fibonaci
// First no 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = 0;
            int sum = 0;
            int nextNumber = 1;

            int threshold = 50;

            List<int> listFibo = new List<int> { startNumber, nextNumber};

            string listToPrint = "";


            while (startNumber + nextNumber <= threshold)
            {
                sum = startNumber + nextNumber;
                listFibo.Add(sum);

                startNumber = nextNumber;
                nextNumber = sum;
            }

            foreach (int x in listFibo)
            {
                listToPrint += $"{x} ";
            }
            Console.WriteLine(listToPrint);
        }
    }
}
