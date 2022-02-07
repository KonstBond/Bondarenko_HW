using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    struct Train
    {
        public string destination;
        public int trainNumber;
        public DateTime departureTime;

        public static void Sort(Train[] trains)
        {
            Train temp;
            for (int i = 0; i < trains.Length; i++)
            {
                for (int j = 0; j < trains.Length-1; j++)
                {
                    if (trains[j].trainNumber > trains[j+1].trainNumber)
                    {
                        temp = trains[j];
                        trains[j] = trains[j + 1];
                        trains[j + 1] = temp;
                    }
                }
            }

            for (int i = 0; i < trains.Length; i++)
                Console.Write($"Train: {trains[i].trainNumber}, Destination: {trains[i].destination}, Depature Time: {trains[i].departureTime}\n");
        }

        public static void GetInfo(Train[] trains,int trainNumber)
        {
            for (int i = 0; i < trains.Length; i++)
            {
                if (trains[i].trainNumber == trainNumber)
                {
                    Console.Write($"Train: {trains[i].trainNumber}, Destination: {trains[i].destination}, Depature Time: {trains[i].departureTime}");
                    return;
                }
            }
            Console.Write("Cannot find this train");
        }
    }
}
