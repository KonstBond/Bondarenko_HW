using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice1 = new Invoice(123456, "Konstantin", "Xiaomi") { Article = "TV", quantity = 2 };
            invoice1.Cost(true);
        }
    }
}
