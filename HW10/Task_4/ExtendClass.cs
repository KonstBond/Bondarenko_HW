using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2;

namespace Task_4
{
    static class ExtendClass
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            T[] arr = new T[list.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = list[i];
            }
            return arr;
        }
    }
}
