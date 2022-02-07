using System;
using Task_2;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>(10);

            for (int i = 0; i < myList.Length; i++)
            {
                myList[i] = new Random().Next(0,10);
                Console.Write(myList[i] + " ");
            }

            int[] arr = myList.GetArray<int>();
            Console.WriteLine();

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
