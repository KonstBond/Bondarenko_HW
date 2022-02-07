using System;
using System.Threading;

namespace Task_0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MAIN THREAD: " + Thread.CurrentThread.ManagedThreadId);
            new Thread(Method).Start();

        }

        static void Method()
        {
            Thread.Sleep(500);
            Console.WriteLine("Thread:" + Thread.CurrentThread.ManagedThreadId);
            new Thread(Method).Start();
        }
    }
}
