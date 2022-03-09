using System;

namespace Task_2
{
    public class Program
    {
        static void Main()
        {
            Calendar calendar = new Calendar();

            calendar.Add(new Class_Month(Enum_Month.August));
            calendar.Add(new Class_Month(Enum_Month.June));
            calendar.Add(new Class_Month(Enum_Month.August));
            calendar.Add(new Class_Month(Enum_Month.December));
            calendar.Add(new Class_Month(Enum_Month.December));
            calendar.Add(new Class_Month(Enum_Month.October));
            calendar.Add(new Class_Month(Enum_Month.April));
            calendar.Add(new Class_Month(Enum_Month.January));

            foreach (var item in calendar)
            {
                Console.WriteLine(item);
            }
            calendar.Remove();
            calendar.Remove();
            Console.WriteLine(new String('-',Console.BufferWidth));
            foreach (var item in calendar)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new String('-', Console.BufferWidth));
            foreach (var item in calendar[31])
            {
                Console.WriteLine(item);
            }

            
        }
    }
}