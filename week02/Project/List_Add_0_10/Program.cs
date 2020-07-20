using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace List_Add_0_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = 1;
            int endNumber = 10;
            List<int> list1 = new List<int>();

            List<int> list2 = new List<int> { 4, 7 };

            string listToPrint = "";

            for (int i = startNumber; i <= endNumber; i++)
            {
                if (! list2.Contains(i))
                {
                    list1.Add(i);
                }
            }

            foreach (int x in list1)
            {
                listToPrint += $"{x} ";
            }
            Console.WriteLine(listToPrint);
        }
    }
}
