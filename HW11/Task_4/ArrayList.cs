using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class ArrayList
    {
        object[] arr;
        private int Count { get; set; }
        private int LengthPR;
        public int Length { get; set; }

        public ArrayList()
        {
            arr = new object[100];
            LengthPR = 100;
            Count = 0;
        }

        public object this[int index]
        {
            get { return arr[index]; }
        }

        public void Add(object value)
        {
            if (Count < arr.Length)
            {
                arr[Count] = value;
                Count++;
            }
            else
            {
                Array.Resize(ref arr, ++LengthPR);
                arr[Count] = value;
                Count++;      
            }
            Length = Count;
        }

        public void Remove()
        {    
            Array.Resize(ref arr, --LengthPR);
            Count--;
            Length = Count;
        }
    }
}
