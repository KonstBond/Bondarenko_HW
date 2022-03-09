using System;

namespace Task_3
{
    public class Program
    {
        static void Main()
        {
            Person employee = new Employee("Jack");
            Person pensioner = new Pensioner("Marina");
            Person pensioner1 = new Pensioner("Vlad");
            Person pensioner3 = new Pensioner("Kostya");
            Person Student = new Student("Vova");

            Collection collection = new Collection();

            collection.Add(employee);
            collection.Add(pensioner);
            collection.Add(pensioner1);
            collection.Add(Student);
            collection.Add(pensioner3);

            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('-', Console.BufferWidth));
            foreach (Person item in collection)
            {
                Console.WriteLine(collection.NumberInQueue(item));
            }
            Console.WriteLine(new string('-', Console.BufferWidth));
            collection.Remove();
            collection.Remove(Student);
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('-', Console.BufferWidth));
            foreach (Person item in collection)
            {
                Console.WriteLine(collection.NumberInQueue(item));
            }
        }
    }
}