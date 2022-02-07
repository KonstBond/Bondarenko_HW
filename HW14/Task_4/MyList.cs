using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class MyList<T> : IEnumerable<T>, IEnumerator<T>
    {
        #region List

        private T[] arrElem;
        private int count;

        public MyList()
        {
            arrElem = new T[0];
            count = 0;
        }

        public void Add(T Element)
        {
            Array.Resize<T>(ref arrElem, arrElem.Length + 1);
            arrElem[count] = Element;
            count++;
        }

        public void Remove()
        {
            if (count > 0)
            {
                Array.Resize<T>(ref arrElem, arrElem.Length - 1);
                count--;
            }
            else
            {
                throw new Exception("The List contain no elements");
            }
        }

        public T this[int index]
        {
            get { return arrElem[index]; }
            set { arrElem[index] = value; }
        }

        public int Count { get { return count; } }
        public int Size { get { return arrElem.Length; } }

        #endregion

        #region Interfaces

        int pozition = -1;

        void IDisposable.Dispose() { }

        T IEnumerator<T>.Current { get { return arrElem[pozition]; } }

        object IEnumerator.Current { get { return arrElem[pozition]; } }

        bool IEnumerator.MoveNext()
        {
            if (pozition < arrElem.Length - 1)
            {
                pozition++;
                return true;
            }
            else
            {
                pozition = -1;
                return false;
            }
        }

        void IEnumerator.Reset()
        {
            pozition = -1;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this as IEnumerator;
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return this as IEnumerator<T>;
        }

        #endregion
    }
}
