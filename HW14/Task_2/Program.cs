using System;
using System.Collections;
using System.Collections.Generic;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<DateTime> list = new MyList<DateTime>();

            for (int i = 0; i < 10; i++)
            {
                list.Add(Convert.ToDateTime($"{new Random().Next(1, 30)}/{new Random().Next(1, 12)}/{new Random().Next(0, 9999)}"));
            }

            foreach (var item in list)
            {
                Console.WriteLine($"Element: {item}");
            }
            Console.WriteLine("-----------------");
            list.Remove();
            foreach (var item in list)
            {
                Console.WriteLine($"Element: {item}");
            }

            IEnumerable<DateTime> dates = list as IEnumerable<DateTime>;
            
        }
    }
}
