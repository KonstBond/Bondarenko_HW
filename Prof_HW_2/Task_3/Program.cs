using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class Program
    {
        static void Main()
        {
            //First variant
            Dictionary<long,double> firstVariant = new Dictionary<long, double>();

            //Second variantlong
            SortedDictionary<long,double> secondVariant = new SortedDictionary<long, double>();

            //Third variant
            CompanysAccount thirdVariant = new CompanysAccount();

            thirdVariant.Add(12351236212, 150000);
            thirdVariant.Add(25582057295, 200000);
            thirdVariant.Add(82182169875, 750000);
            thirdVariant.Add(32895424786, 210000);
            thirdVariant.Add(92198201968, 422000);
            thirdVariant.Add(36974521478, 162000);
            thirdVariant.Add(60197421972, 305000);

            foreach (KeyValuePair<long, double> item in thirdVariant)
            {
                Console.WriteLine($"Account: {item.Key}\tMoney: {item.Value}");
            }
            Console.WriteLine(new string('-', Console.BufferWidth));

            thirdVariant.Remove(36974521478);
            foreach (KeyValuePair<long, double> item in thirdVariant)
            {
                Console.WriteLine($"Account: {item.Key}\tMoney: {item.Value}");
            }
            thirdVariant.ChangeMoney(92198201968, 0);
            thirdVariant.ChangeMoney(60197421972, 0);

            Console.WriteLine(new string('-', Console.BufferWidth));
            foreach (KeyValuePair<long, double> item in thirdVariant)
            {
                Console.WriteLine($"Account: {item.Key}\tMoney: {item.Value}");
            }
        }
    }
}
