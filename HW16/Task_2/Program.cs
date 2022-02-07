using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Block b1 = new Block(1, 2, 4, 6);
            Block b2 = new Block(2, 4, 8, 12);
            Block b3 = new Block(1, 2, 4, 6);

            Console.WriteLine($"b1 == b2: {b1.Equals(b2)}");
            Console.WriteLine($"b2 == b3: {b2.Equals(b3)}");
            Console.WriteLine($"b1 == b3: {b1.Equals(b3)}");

            Console.WriteLine($"\n{b1}" +
                $"\n{b2}" +
                $"\n{b3}");
        }
    }
}
