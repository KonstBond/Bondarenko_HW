using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class MyDate
    {
        private int day;
        private int month;
        private int year;
        private DateTime date;

        public MyDate(int day, int month, int year)
        {
            if (DateTime.TryParse($"{day}/{month}/{year}", out date))
            {
                this.day = day;
                this.month = month;
                this.year = year;
            }
            else
            {
                throw new Exception($"Date {date} is not valid");
            }
        }

        public int Day 
        {
            get
            {
                return day;
            }
            set
            {
                if (value < 0 || value > 31)
                    throw new Exception($"value {nameof(value)} is not valid");
                day = value;
            }
        }

        public int Month
        {
            get
            {
                return month;
            }
            set
            {
                if (value < 0 || value > 12)
                    throw new Exception($"value {nameof(value)} is not valid");
                month = value;
            }
        }

        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                if (value < 0 || value > 9999)
                    throw new Exception($"value {nameof(value)} is not valid");
                year = value;
            }
        }

        public static TimeSpan operator -(MyDate d1,MyDate d2)
        {
            return d1.date - d2.date;
        }

        public static MyDate operator +(MyDate d1, int days)
        {
            DateTime d = d1.date.AddDays(days);
            return new MyDate(d.Date.Day, d.Date.Month, d.Date.Year);
        }

        public override string ToString()
        {
            return $"{day} {month} {year}";
        }
    }
}
