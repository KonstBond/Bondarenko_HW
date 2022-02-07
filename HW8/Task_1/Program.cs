using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your birthday: ");
            DateTime dateBirthday = DateTime.Parse(Console.ReadLine());
            DateTime today = DateTime.Now;

            int rez = today.DayOfYear > dateBirthday.DayOfYear 
                ? dateBirthday.DayOfYear - today.DayOfYear + 365
                : dateBirthday.DayOfYear - today.DayOfYear;

            Console.WriteLine($"Number of days until next birthday: {rez}");
        }
    }
}
