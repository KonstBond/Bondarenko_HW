using System;
using System.Collections;

namespace Task_1
{
    static class t1
    {
        static public IEnumerable<int> SqrtUnPair(this int[] arr)
        {
            if(arr == null)
                throw new ArgumentNullException(nameof(arr) + "is null");

            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 1)
                {
                    yield return arr[i] * arr[i];
                }
            }
        }
    }
}
