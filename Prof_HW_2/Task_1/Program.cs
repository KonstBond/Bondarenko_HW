using System;
using System.Collections;

namespace Task_1
{
    class Program
    {
        static void Main()
        {
            SortedList list = new SortedList()
            {
                {'4', 1 },
                {'f', 2 },
                {'l', 3 },
                {'!', 4 },
            };

            foreach (DictionaryEntry item in list)
            {
                Console.WriteLine($"Key: {item.Key}\t Value: {item.Value}");
            }

            SortedList list2 = new SortedList(new ComparerDescending());
            foreach (DictionaryEntry item in list)
            {
                list2.Add(item.Key, item.Value);
            }

            Console.WriteLine(new String('-',Console.BufferWidth));
            foreach (DictionaryEntry item in list2)
            {
                Console.WriteLine($"Key: {item.Key}\t Value: {item.Value}");
            }
        }

        class ComparerDescending : IComparer
        {
            CaseInsensitiveComparer comparer = new CaseInsensitiveComparer();
            public int Compare(object? x, object? y)
            {
                return comparer.Compare(y, x);
            }
        }
    }
}
