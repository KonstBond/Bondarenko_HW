using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class MyDictionary<Tkey,Tvalue>: IEnumerable, IEnumerator
    {
        #region Dictionary

        private Tkey[] arrK;
        private Tvalue[] arrV;
        private int count;

        public MyDictionary()
        {
            arrK = new Tkey[0];
            arrV = new Tvalue[0];
            count = 0;
        }

        public Tvalue this[int index]
        {
            get { return arrV[index]; }
            set { arrV[index] = value; }
        }

        public Tvalue this[Tkey index]
        {
            get 
            {
                for (int i = 0; i < arrK.Length; i++)
                {
                    if (arrK[i].ToString() == index.ToString())
                    {
                        return arrV[i];
                    }
                }
                throw new Exception($"{index} has not have in dictionary");
            }

            set 
            {
                for (int i = 0; i < arrK.Length; i++)
                {
                    if (arrK[i].ToString() == index.ToString())
                    {
                        arrV[i] = value;
                        return;
                    }
                }
                throw new Exception($"{index} has not have in dictionary");
            }
        }

        public void Add(Tkey key, Tvalue value)
        {
            for (int i = 0; i < arrK.Length; i++)
            {
                if (arrK[i].ToString() == key.ToString())
                {
                    throw new Exception($"The key: {key} is already in the dictionary");
                }
            }
            Array.Resize(ref arrK, arrV.Length + 1);
            Array.Resize(ref arrV, arrV.Length + 1);
            arrK[count] = key;
            arrV[count] = value;
            count++;
        }

        public void Remove()
        {
            Array.Resize(ref arrV, arrV.Length - 1);
            Array.Resize(ref arrK, arrK.Length - 1);
            count--;
        }

        public int Count { get { return count; } }
        public int Size { get { return arrK.Length; } }

        #endregion

        #region Interfaces

        int pozition = -1;

        object IEnumerator.Current { get { return arrV[pozition]; } }

        bool IEnumerator.MoveNext()
        {
            if (pozition < arrV.Length - 1)
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

        #endregion
    }
}
