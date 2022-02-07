using System;

namespace Task_2
{
    class Program
    {
        delegate double Element();
        delegate double Average(Element[] elements);

        static double MethodElement()
        {
            double randElem = new Random().Next(0, 10);
            Console.WriteLine($"Element: {randElem}");
            return randElem;
        }

        static void Main(string[] args)
        {
            Average average = null;

            average = delegate (Element[] elements)
            {
                double sum = 0;
                for (int i = 0; i < elements.Length; i++)
                {
                    sum += elements[i].Invoke();
                }

                return sum / elements.Length;
            };

            Element[] AllElem = new Element[]
            {
                new Element(MethodElement),
                new Element(MethodElement),
                new Element(MethodElement)
            };
        
            Console.WriteLine($"Average: " + average(AllElem));
        }
    }
}
