using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Dictionary<TKey, TValue>
    {
        private List<TKey> keys;
        private List<TValue> values;

        public Dictionary()
        {
            keys = new List<TKey>();
            values = new List<TValue>();
            Count = 0;
        }

        public void Add(TKey key, TValue value)
        {
            keys.Add(key);
            values.Add(value);
            Count++;
        }

        public TValue this[int index]
        {
            get { return values[index]; }
        }

        public TValue this[TKey index]
        {
            get
            {
                TValue val = default;
                for (int i = 0; i < keys.Count; i++)
                {
                    if (keys[i].Equals(index))
                    {
                        val = values[i];
                        return val;
                    }
                }
                Console.Write("False key");
                return val;
            }
        }

        public int Count { get; private set; }
    }
}
