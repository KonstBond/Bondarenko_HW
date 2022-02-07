using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> myList = new MyList<string>(3);

            for (int i = 0; i < myList.Length; i++)
            {
                myList[i] = "raise";
                Console.Write(myList[i] + " ");
            }

            myList.Append("check");
            Console.WriteLine();

            for (int i = 0; i < myList.Length; i++)
            {
                Console.Write(myList[i] + " ");
            }

            myList.Remove();
            Console.WriteLine();

            for (int i = 0; i < myList.Length; i++)
            {
                Console.Write(myList[i] + " ");
            }
        }
    }
}
