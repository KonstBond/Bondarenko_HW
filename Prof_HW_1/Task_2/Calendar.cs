using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Calendar : ICollection
    {
        readonly private int[] countDays; //Массив стандартных дней в месяце
        readonly private Enum_Month[] month; // Массив стандартных месяцев 
        private List<Class_Month> arrOfMonth; //Массив с которым мы будем работать

        public Calendar()
        {
            arrOfMonth = new List<Class_Month>();
            Count = 0;
            month = new Enum_Month[12];
            countDays = new int[12];
            for (int i = 0; i < 12; i++)
            {
                month[i] = (Enum_Month)(i + 1); //Забиваем масив стандартными месяцами

                switch ((Enum_Month)(i + 1)) //Забиваем масив стандартными днями
                {
                    case Enum_Month.January:
                    case Enum_Month.March:
                    case Enum_Month.May:
                    case Enum_Month.July:
                    case Enum_Month.August:
                    case Enum_Month.October:
                    case Enum_Month.December:
                        countDays[i] = 31;
                        break;
                    case Enum_Month.February:
                        countDays[i] = 28;
                        break;
                    case Enum_Month.April:
                    case Enum_Month.June:
                    case Enum_Month.September:
                    case Enum_Month.November:
                        countDays[i] = 30;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException("Argument is not valid");
                }
            }
        }

        public void Add(Class_Month month)
        {
            arrOfMonth.Add(month);
            Count++;
        }
        public void Remove()
        {
            arrOfMonth.RemoveAt(--Count);
        }
        public IEnumerable<Enum_Month> this[int countDays]
        {
            get //Получаем перечесление всех значений по введённому количеству дней
            {
                foreach (var item in this.arrOfMonth)
                {
                    if (item.CountDay == countDays)
                    {
                        yield return item.Month;
                    }
                }
            }
        }
        public IEnumerable<Enum_Month> this[Enum_Month month]
        {
            get //Получаем перечесление всех значений по введённому Месяцу
            {
                foreach (var item in this.arrOfMonth)
                {
                    if (item.Month == month)
                    {
                        yield return item.Month;
                    }
                }
            }
        }


        public int Count { get; private set; }
        bool ICollection.IsSynchronized { get { return false; } }
        object ICollection.SyncRoot => new object();
        public void CopyTo(Array array, int index)
        {
            if (array.GetType() != typeof(Calendar))
                throw new ArgumentException(nameof(array) + "is not valid type");
            if (array == null)
                throw new NullReferenceException(nameof(array) + "is null");
            if (index < 0)
                throw new ArgumentException(nameof(index) + "is less than zero");

            var temp = array as Class_Month[];
            for (int i = index; i < Count; i++)
            {
                temp[i] = arrOfMonth[i];
            }
        }
        public IEnumerator GetEnumerator()
        {
            return arrOfMonth.GetEnumerator() as IEnumerator;
        }


    }
}
