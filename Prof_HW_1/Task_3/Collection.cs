using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Collection : ICollection
    {
        private List<Person> persons;

        public Collection()
        {
            persons = new List<Person>();
            Count = 0;
        }

        public int Count { get; private set; }
        public bool IsSynchronized { get; }
        public object SyncRoot => new object();
        public void Add(Person person) 
        {
            foreach (var item in persons)
            {
                if (person.Equals(item))
                    throw new ArgumentException($"{nameof(person)} already yet in collection");
            }

            if (person is Pensioner)
            {
                if (Count == 0 || persons.All(x => x is Pensioner))
                {
                    persons.Add(person);
                    Count++;
                }
                else
                {
                    for (int i = 0; i < Count; i++)
                    {
                        if (persons[i] is Pensioner)
                            continue;
                        else
                        {
                            persons.Insert(i, person);
                            Count++;
                            break;
                        }
                            
                    }
                }
            }
            else
            {
                persons.Add(person);
                Count++;
            }           
        }
        public void Remove()
        {
            persons.RemoveAt(0);
            Count--;
        }
        public void Remove(Person person)
        {
            for (int i = 0; i < Count; i++)
            {
                if (person.Equals(persons[i]))
                {
                    persons.Remove(persons[i]);
                    Count--;
                    return;
                }   
            }
            throw new ArgumentException($"{nameof(person)} is not contains in collection");
        }
        public int NumberInQueue(Person person) // Возвращает номер в очереди
        {
            if (persons.Contains(person))
                return persons.IndexOf(person) + 1;
            throw new ArgumentException($"{nameof(person)} Is not contains in Collection");
        }

        public void CopyTo(Array array, int index)
        {
            if (array.GetType() != typeof(Collection))
                throw new ArgumentException(nameof(array) + "is not valid type");
            if (array == null)
                throw new NullReferenceException(nameof(array) + "is null");
            if (index < 0)
                throw new ArgumentException(nameof(index) + "is less than zero");

            var temp = array as Person[];
            for (int i = index; i < Count; i++)
            {
                temp[i] = persons[i];
            }
        }
        public IEnumerator GetEnumerator()
        {
            return persons.GetEnumerator() as IEnumerator;
        }
    }
}
