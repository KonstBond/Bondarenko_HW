using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Car : Vehicle
    {
        public Car(int X, int Y, int cost, int speed, DateTime dateOfRelease)
            : base(X, Y, cost, speed, dateOfRelease)
        { }

        public override string GetInfo()
        {
            return base.GetInfo();
        }
    }
}
