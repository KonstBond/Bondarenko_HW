using System;
using Task_3;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> dict = new MyDictionary<string, string>();

            for (int i = 0; i < 3; i++)
            {
                dict.Add(new Random().Next(0, 100).ToString(), new Random().Next(0, 100).ToString());
            }

            foreach (var item in dict)
            {
                Console.WriteLine(item);
            }
        }
    }
}
