using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class MyList<T>
    {
        private T[] arr;
        private int count;

        public MyList(int count)
        {
            this.count = count;
            arr = new T[count];
        }

        public T this[int index]
        {
            get { return arr[index]; }
            set { arr[index] = value; }
        }

        public void Append(T obj)
        {
            Array.Resize<T>(ref arr, count+1);
            arr[count] = obj;
            count++;
        }

        public void Remove()
        {
            Array.Resize<T>(ref arr, count - 1);
            count--;
        }

        public int Length { get { return count; } }
    }
}
