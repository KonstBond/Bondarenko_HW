using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public class Program
    {
        static void Main()
        {
            OrderedDictionary ordered  = new OrderedDictionary(new Comparer());

            //Eсли добавить такой же обьект(сравнение по хешу), то произойдёт исключение
            //По дефолту сравнение и так идёт по хешам ключей

            Comparer x = new Comparer();
            Comparer y = x;

            ordered.Add(1, 5);
            ordered.Add(2, 4);
            ordered.Add(x, 3);
            ordered.Add(y, 2);
            ordered.Add(5, 1);

            foreach (DictionaryEntry item in ordered)
            {
                Console.WriteLine($"Key: {item.Key}\tValue: {item.Value}");
            }
        }
    }

    public class Comparer : IEqualityComparer
    {
        public new bool Equals(object? x, object? y)
        {
            return x != y;
        }

        public int GetHashCode(object obj)
        {
            return obj.GetHashCode();
        }
    }

}
