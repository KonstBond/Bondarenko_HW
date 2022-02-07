using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Car
    {
        private Mark markCar;
        private string modelCar;
        private DateTime yearOfIssue;
        private string color;

        public Car(Mark mark, string model, DateTime yearOfIssue, string color)
        {
            this.markCar = mark;
            this.modelCar = model;
            this.yearOfIssue = yearOfIssue;
            this.color = color;
        }

        public Car InfoCar { get { return this;} }

        public override string ToString()
        {
            return $"[{color} {markCar} {modelCar} - {yearOfIssue.Year}]";
        }
    }
}
