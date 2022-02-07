using System;
using System.Linq;
using System.Collections.Generic;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[new Random().Next(10, 20)];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(0, 11);
                Console.Write($"{array[i]} ");
            }

            ArrTasks.Info(array);
        }
    }
}
