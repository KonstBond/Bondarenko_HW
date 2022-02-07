using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Plane : Vehicle
    {
        private int flightAltitude;
        private int qualityOfPassenger;

        public Plane(int X, int Y, int cost, int speed, DateTime dateOfRelease, int flightAltitude, int qualityOfPassenger) 
            : base(X, Y, cost, speed, dateOfRelease)
        {
            this.flightAltitude = flightAltitude;
            this.qualityOfPassenger = qualityOfPassenger;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $"flightAltitude: {flightAltitude}\n" +
                $"qualityOfPassenger: {qualityOfPassenger}";
        }
    }
}
