using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> dictionary = new MyDictionary<string, string>(1);
            dictionary[0] = new KeyValue<string, string>("Sun","Moon");

            for (int i = 0; i < dictionary.Length; i++)
            {
                Console.WriteLine(dictionary[i].Key + " - " + dictionary[i].Value);
            }

            Console.WriteLine();
            dictionary.Append("Konstantin", "Bondarenko");

            for (int i = 0; i < dictionary.Length; i++)
            {
                Console.WriteLine(dictionary[i].Key + " - " + dictionary[i].Value);
            }

            dictionary.Remove();
            Console.WriteLine();

            for (int i = 0; i < dictionary.Length; i++)
            {
                Console.WriteLine(dictionary[i].Key + " - " + dictionary[i].Value);
            }
        }
    }
}
