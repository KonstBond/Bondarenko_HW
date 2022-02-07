using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Ship : Vehicle
    {
        private int qualityOfPassenger;
        private string registrationPort;

        public Ship(int X, int Y, int cost, int speed, DateTime dateOfRelease, int qualityOfPassenger, string registrationPort)
            : base(X, Y, cost, speed, dateOfRelease)
        {
            this.registrationPort = registrationPort;
            this.qualityOfPassenger = qualityOfPassenger;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $"Registration Port: {registrationPort}\n" +
                $"qualityOfPassenger: {qualityOfPassenger}\n";
        }
    }
}
