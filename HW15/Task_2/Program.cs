using System;
using System.Collections;
using System.Linq;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker[] workers = new Worker[5];

            for (int i = 0; i < workers.Length; i++)
            {
                Console.WriteLine($"[{i+1}]");
                Console.Write("Enter Last Name: ");
                workers[i].LastName = Console.ReadLine();
                Console.Write("Enter Pozition: ");
                workers[i].Pozition = Console.ReadLine();
                try
                {
                    Console.Write("Enter Year of started: ");
                    workers[i].StartYear = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Year {workers[i].StartYear} not valid");
                    workers[i].StartYear = DateTime.Now.Year;
                }
            }

            workers = workers.OrderBy((Worker) => Worker.LastName).ToArray();
            Console.WriteLine(new string('-', Console.BufferWidth));

            Console.Write("Enter desired experience : ");
            if (int.TryParse(Console.ReadLine(),out int ans))
            {
                for (int i = 0; i < workers.Length; i++)
                {
                    if (workers[i].Exp() > ans)
                    {
                        Console.WriteLine($"Worker: {workers[i].LastName}, Pozition: {workers[i].Pozition}");
                    }
                }
            }
        }
    }
}
