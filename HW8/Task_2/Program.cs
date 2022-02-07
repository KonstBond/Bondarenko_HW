using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your msg: ");
            string msg = Console.ReadLine();
            Console.Write("Enter your Color: ");
            string color = Console.ReadLine();
            ColorPrint.Print(msg, (int)ColorPrint.ColorParser(color));
        }
    }
}
