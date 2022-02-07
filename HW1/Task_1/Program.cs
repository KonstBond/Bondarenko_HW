using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Try index: 12345, 01010, 65000, AB10, PL8, BA1 A4400, A1000

            Address address = new Address("65000","Starickogo","24", "10");

            Console.WriteLine($"Index: {address.Index}\n" +
                                $"Country: {address.Country}\n" +
                                $"City: {address.City}\n" +
                                $"Street: {address.Street}\n" +
                                $"House: {address.House}\n" +
                                $"Apartment: {address.Apartment}");

            Console.WriteLine(new string('-',Console.BufferWidth));
            address.GetAddress();
        }
    }
}
