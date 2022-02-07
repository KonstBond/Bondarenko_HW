using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class MyDictionary<TKey, TValue>
    {
        private KeyValue<TKey,TValue>[] dictionary;
        private int count;

        public MyDictionary(int count)
        {
            dictionary = new KeyValue<TKey,TValue>[count];
            this.count = count;
        }

        public KeyValue<TKey,TValue> this[int index]
        {
            get { return dictionary[index]; }
            set { dictionary[index] = value; }
        }

        public void Append(TKey key, TValue value)
        {
            Array.Resize(ref dictionary, count + 1);
            KeyValue<TKey, TValue> nElem = new KeyValue<TKey, TValue>(key, value);
            dictionary[count] = nElem;
            count++;
        }

        public void Remove()
        {
            Array.Resize(ref dictionary, count - 1);
            count--;
        }

        public int Length { get { return count; } }

    }
}
