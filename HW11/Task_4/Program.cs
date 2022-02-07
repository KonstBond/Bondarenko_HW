using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();

            arrayList.Add(2);
            arrayList.Add("str");
            arrayList.Add('c');

            for (int i = 0; i < arrayList.Length; i++)
            {
                Console.WriteLine(arrayList[i]);
            }
        }
    }
}
