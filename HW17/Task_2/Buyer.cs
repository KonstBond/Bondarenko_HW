using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Buyer
    {
        private Car car;
        private string name;
        private string phone;

        public Buyer(Car car, string name, string phone)
        {
            this.car = car;
            this.name = name;
            this.phone = phone;
        }

        public Car InfoCar { get { return car; } }

        public override string ToString()
        {
            return name;
        }
    }
}
