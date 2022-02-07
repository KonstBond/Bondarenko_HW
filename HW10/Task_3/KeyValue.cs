using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class KeyValue<Tkey,Tvalue>
    {
        private Tkey key;
        private Tvalue value;

        public KeyValue(Tkey key, Tvalue value)
        {
            this.key = key;
            this.value = value;
        }

        public Tkey Key { get { return key; } set { key = value; }  }
        public Tvalue Value { get { return value; } set { this.value = value; } }
    }
}
