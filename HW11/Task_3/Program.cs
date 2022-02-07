using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            dictionary.Add("1", "zero");
            dictionary.Add("2", "one");
            dictionary.Add("3", "two");
            dictionary.Add("4", "three");

            for (int i = 0; i < dictionary.Count; i++)
            {
                Console.WriteLine(dictionary[i]);
            }

            Console.WriteLine(new string('-',Console.BufferWidth));
            Console.WriteLine(dictionary["0"]);
            Console.WriteLine(dictionary["1"]);
            Console.WriteLine(dictionary["2"]);
            Console.WriteLine(dictionary["3"]);

        }
    }
}
