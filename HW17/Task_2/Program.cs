using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List <Car> Cars= new List<Car>();

            Cars.Add(new Car(Mark.Mitsubishi, "Outlander", new DateTime(2021, 1, 1), "Black"));
            Cars.Add(new Car(Mark.Toyota, "RAV4", new DateTime(2020, 1, 1), "White"));
            Cars.Add(new Car(Mark.Tesla, "Model S", new DateTime(2017, 1, 1), "Gray"));

            List<Buyer> buyers = new List<Buyer>();

            buyers.Add(new Buyer(Cars[new Random().Next(0, 3)], "Konstantin", "+380660009988"));
            buyers.Add(new Buyer(Cars[new Random().Next(0, 3)], "Boris", "+380660019988"));
            buyers.Add(new Buyer(Cars[new Random().Next(0, 3)], "Aleksei", "+380660029988"));
            buyers.Add(new Buyer(Cars[new Random().Next(0, 3)], "Maksim", "+380660039988"));
            buyers.Add(new Buyer(Cars[new Random().Next(0, 3)], "Bogdan", "+380660049988"));

            var Info = from b in buyers
                       join c in Cars on b.InfoCar equals c.InfoCar
                       select new
                       {
                           name = b.ToString(),
                           car = c.ToString()
                       };

            foreach (var item in Info)
            {
                Console.WriteLine($"Buyer: {item.name}\n" +
                    $"Car: {item.car}\n" +
                    $"------------------------------------------------");
            }
        }
    }
}
