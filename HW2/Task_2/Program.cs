using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter curse_25_10_21 = new Converter(0.038, 0.033, 2.64);

            Console.WriteLine(curse_25_10_21.UAHToUSD(1000));
            Console.WriteLine(curse_25_10_21.UAHToRUB(1000));
            Console.WriteLine(curse_25_10_21.UAHToEUR(1000));
            Console.WriteLine(new string('-',Console.BufferWidth));
            Console.WriteLine(curse_25_10_21.EURToUAH(1000));
            Console.WriteLine(curse_25_10_21.USDToUAH(1000));
            Console.WriteLine(curse_25_10_21.RUBToUAH(1000));
        }
    }
}
