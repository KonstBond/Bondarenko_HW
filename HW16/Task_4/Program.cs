using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan timeSpan = new MyDate(12, 7, 2020) - new MyDate(30, 5, 2014);

            Console.WriteLine(timeSpan.Days);
            Console.WriteLine(new MyDate(5,3,1999) + 345);
        }
    }
}
