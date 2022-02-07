using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class ArrTasks
    {
        public static int[] UnP(int[] Arr)
        {
            return Arr.Where(x => (x % 2 != 0) && (x != 0)).ToArray();
        } 

        public static void Info(int[] arr)
        {
            Console.Write($"\nMax Value: {arr.Max()}\n" +
                              $"Min Value: {arr.Min()}\n" +
                              $"Sum of elements {arr.Sum()}\n" +
                              $"Average: {arr.Average()}\n" +
                              $"All Unpair nambers: ");
            foreach (var item in UnP(arr))
                Console.Write($"{item} ");
        } 
    }
}
