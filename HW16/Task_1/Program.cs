using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(2, 5, 5);
            Point p2 = new Point(5, 1, 7);

            p1 += p2;
            Console.WriteLine(p1);
        }
    }
}
