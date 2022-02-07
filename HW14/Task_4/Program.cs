using System;
using Task_2;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> ints = new MyList<int>();

            for (int i = 0; i < 5; i++)
            {
                ints.Add(new Random().Next(10, 20));
            }

            int[] arr = ints.GetArray();

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
