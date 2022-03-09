using System;
using System.Collections;

namespace Task_1
{
    class Program
    {
        static void Main()
        {
            int[] temp = new int[10];

            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = i;
            }

            foreach (var item in temp.SqrtUnPair())
            {
                Console.WriteLine(item);
            }
        }
    }
}


