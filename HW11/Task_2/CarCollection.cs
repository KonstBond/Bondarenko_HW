using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class CarCollection<T> where T : Car
    {
        T[] cars;
        private int SizeOfPark;
        public int Count { get; private set; }

        public CarCollection(int sizeOfPark)
        {
            cars = new T[sizeOfPark];
            this.SizeOfPark = sizeOfPark;
            Count = default;
        }

        public void AddCar(T car)
        {
            if (Count < SizeOfPark)
            {
                cars[Count] = car;
                Count++;
            }
            else
            {
                Console.WriteLine("Park is full");
            }
        }

        public string this[int index]
        {
            get 
            {
                return cars[index].ToString();
            }
        }

    }
}
