using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    struct Worker
    {
        int startYear;

        public string LastName { get; set; }
        public string Pozition { get; set; }
        public int StartYear {
            get { return startYear; }
            set
            {
                if (DateTime.Now.Year < startYear)
                    throw new Exception("Year is not valid");
                startYear = value;
            }
        }

        public int Exp()
        {
            return DateTime.Now.Year - this.startYear;
        }
    }
}
