using System;
using System.Collections;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            IEnumerable temp = Arr.Filter();

            foreach (var item in temp)
            {
                Console.WriteLine(item);
            }
        }
    }

    static class ExtInt32Arr
    {
        public static IEnumerable Filter(this int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    yield return arr[i];
                }
            }
        }
    }
}
