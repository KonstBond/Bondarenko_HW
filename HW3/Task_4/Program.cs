using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(0,0,10000,220, new DateTime(2009,9,16));
            Console.WriteLine(car.GetInfo());

            Ship ship = new Ship(100, 100, 150000, 170, new DateTime(1999, 5, 2), 40, "Port of Odessa");
            Console.WriteLine(ship.GetInfo());

            Plane plane = new Plane(100, 12300, 70000, 450, new DateTime(1980, 10, 17), 5000, 2);
            Console.WriteLine(plane.GetInfo());
        }
    }
}
