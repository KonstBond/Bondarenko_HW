using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Random().Next(0, 10);
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
            arr.ExtSort();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }
    }
}
