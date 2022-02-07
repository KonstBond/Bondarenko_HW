using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Car
    {
        private string mark;
        private string model;
        private DateTime releaseDate;

        public Car(string mark, string model, DateTime releaseDate)
        {
            this.mark = mark;
            this.model = model;
            this.releaseDate = releaseDate;
        }

        public override string ToString()
        {
            return $"Car: {mark} {model}, Release Date: {releaseDate.Year} ";
        }
    }
}
