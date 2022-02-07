using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Vehicle
    {
        protected int coordX;
        protected int coordY;
        protected int cost;
        protected int speed;
        protected DateTime dateOfRelease;

        public Vehicle(int X, int Y, int cost, int speed, DateTime dateOfRelease)
        {
            coordX = X;
            coordY = Y;
            this.cost = cost;
            this.speed = speed;
            this.dateOfRelease = dateOfRelease;
        }

        public virtual string GetInfo()
        {
            return $"X: {coordX}, Y: {coordY};\n" +
                $"Cost: {cost}\n" +
                $"Speed: {speed}\n" +
                $"DateOfRelease: {dateOfRelease.Day} {dateOfRelease.Month} {dateOfRelease.Year}\n";
        }
    }
}
