using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal abstract class Person
    {
        public Person(string Name)
        {
            id = new Random().Next(0, 1000000) ^ new Random().Next(0, 1000000);
            this.Name = Name;
            
        }
        public int id { get; private set; }
        public string Name { get; set; }

        public override bool Equals(object? obj)
        {
            if (!(obj is Person))
                throw new ArgumentException($"{nameof(obj)} is not valid");

            Person temp = (Person)obj;
            return this.GetHashCode() == temp.GetHashCode();
        }

        public override string ToString()
        {
            return Name;
        }

        public override int GetHashCode()
        {
            return id;
        }
    }
}

