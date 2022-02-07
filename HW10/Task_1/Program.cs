using System;
using System.Collections.Generic;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int f = MyClass<int>.FactoryMethod();
            List<int> a = MyClass<List<int>>.FactoryMethod();
            Console.WriteLine(f.GetType().ToString());
            Console.WriteLine(a.GetType().ToString());
        }
    }
}
