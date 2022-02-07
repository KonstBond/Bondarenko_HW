using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    static class ExtentionIntArr
    {
        public static int[] ExtSort(this int[] Arr)
        {
            int temp = 0;
            for (int i = 0; i < Arr.Length; i++)
            {
                for (int j = 0; j < Arr.Length - 1; j++)
                {
                    if (Arr[j] > Arr[j+1])
                    {
                        temp = Arr[j];
                        Arr[j] = Arr[j + 1];
                        Arr[j + 1] = temp;
                    }
                }
            }
            return Arr;
        }
    }
}
