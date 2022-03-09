using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Class_Month
    {
        public Enum_Month Month { get; }
        public int CountDay { get; }

        public Class_Month(Enum_Month month)
        {
            this.Month = month;

            switch (month) 
            {
                case Enum_Month.January:
                case Enum_Month.March:
                case Enum_Month.May:
                case Enum_Month.July:
                case Enum_Month.August:
                case Enum_Month.October:
                case Enum_Month.December:
                    CountDay = 31;
                    break;
                case Enum_Month.February:
                    CountDay = 28;
                    break;
                case Enum_Month.April:
                case Enum_Month.June:
                case Enum_Month.September:
                case Enum_Month.November:
                    CountDay = 30;
                    break;
                default:
                    throw new ArgumentOutOfRangeException("Argument is not valid");
            }

        }

        public override string ToString()
        {
            return $"NM|{(int)Month} \t M|{Month} \t CD|{CountDay}"; 
        }
    }
}
