using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            House h1 = new House(10, 300);
            House h2 = h1.Clone();
            House h3 = h1.DeepClone() as House;

            Console.WriteLine($"Before change" +
                $"\n(Original)\th1:\t{h1}" +
                $"\n(Clone) \th2:\t{h2}" +
                $"\n(DeepClone)\th3:\t{h3}\n");

            h1.Size = 13; h1.Size = 400;
            Console.WriteLine($"After change" +
                $"\n(Original)\th1:\t{h1}" +
                $"\n(Clone) \th2:\t{h2}" +
                $"\n(DeepClone)\th3:\t{h3}");
        }
    }
}
