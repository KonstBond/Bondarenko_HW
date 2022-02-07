using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Train[] trains = new Train[8];

            for (int i = 0; i < trains.Length; i++)
            {
                Console.WriteLine($"Write info about train {i+1}");
                Console.Write($"Train {i+1} number: ");
                trains[i].trainNumber = int.Parse(Console.ReadLine());
                Console.Write($"Train {i+1} Destination: ");
                trains[i].destination = Console.ReadLine();
                Console.Write($"Train {i+1} Departure Time: ");
                trains[i].departureTime = DateTime.Parse(Console.ReadLine());
                Console.Clear();
            }

            Train.Sort(trains);

            Train.GetInfo(trains,45);
        }
    }
}
