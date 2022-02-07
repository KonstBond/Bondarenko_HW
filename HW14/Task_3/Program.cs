using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, DateTime> dict = new MyDictionary<string, DateTime>();

            for (int i = 0; i < 4; i++)
            {
                dict.Add(new Random().Next(0, 10).ToString(), Convert.ToDateTime($"{new Random().Next(1, 28)}/{new Random().Next(1, 12)}/{new Random().Next(0, 9999)}"));
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine("--------------");
            dict.Remove();
            foreach (var item in dict)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine("--------------");
            dict.Add(new Random().Next(0, 100).ToString(), Convert.ToDateTime($"{new Random().Next(1, 28)}/{new Random().Next(1, 12)}/{new Random().Next(0, 9999)}"));
            foreach (var item in dict)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
