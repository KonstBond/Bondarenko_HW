using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    static class ExtToTask2
    {
        public static T[] GetArray<T>(this IEnumerable<T> list)
        {
            IEnumerator<T> temp = list.GetEnumerator();
            T[] arr = new T[list.Count()];
            for (int i = 0; temp.MoveNext() ; i++)
            {
                arr[i] = temp.Current;
            }
            return arr;
        }
    }
}
