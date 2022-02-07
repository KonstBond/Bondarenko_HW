using System;
using System.Collections;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();

            Random rand = new Random();

            arrayList.Add(4);
            arrayList.Add("My string");
            arrayList.Add(5.4f);
            arrayList.Add(rand);

            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }
            //Ноль проблем XD (Возможно суть задания состоит в подключении к проекту System.Collections, но я не уверен)
        }
    }
}
