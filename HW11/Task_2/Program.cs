using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Tesla","Model S",DateTime.Parse("01/01/2021"));
            Car car2 = new Car("Dacia", "Logan", DateTime.Parse("01/01/2009"));
            Car car3 = new Car("Ford", "Probe", DateTime.Parse("01/01/1997"));

            CarCollection<Car> Park = new CarCollection<Car>(3);
            Park.AddCar(car1);
            Park.AddCar(car2);
            Park.AddCar(car3);

            for (int i = 0; i < Park.Count; i++)
            {
                Console.WriteLine(Park[i]);
            }
        }
    }
}
