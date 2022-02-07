using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Store s = new Store(3);

            Console.WriteLine(new string('-',Console.BufferWidth));
            s.AddProduct("TV", 17000, "Allo");
            s.AddProduct("Phone", 8000, "Allo");
            s.AddProduct("Router", 6500, "Cisco");
            s.AddProduct("Switch", 3000, "Cisco");

            Console.WriteLine(new string('-', Console.BufferWidth));
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(s[i]);
            }

            Console.WriteLine(new string('-', Console.BufferWidth));
            Console.WriteLine(s["Phone"]);
            Console.WriteLine(s["Router"]);
            Console.WriteLine(s["PC"]);
        }
    }
}
