using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Price[] prices = new Price[2];

            for (int i = 0; i < prices.Length; i++)
            {
                Console.WriteLine($"[{i+1}]");
                Console.Write("Enter name of price: ");
                prices[i].Name = Console.ReadLine();
                Console.Write("Enter shop of price: ");
                prices[i].Shop = Console.ReadLine();
                try
                {
                    Console.Write("Enter cost of price: ");
                    prices[i].Cost = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    prices[i].Cost = -1;
                }
            }

            Console.Write(new string('-',Console.BufferWidth) +
                "\nEnter shop: ");
            string shop = Console.ReadLine();

            for (int i = 0; i < prices.Length; i++)
            {
                if (shop == prices[i].Shop)
                {
                    Console.WriteLine($"Price: {prices[i].Name}, Cost: {prices[i].Cost}");
                }
                else if (shop != prices[i].Shop && i == prices.Length - 1)
                {
                    throw new Exception("Price not found");
                }
                
            }
        }
    }
}
