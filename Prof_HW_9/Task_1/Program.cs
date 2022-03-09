using System;
using Task_2;

namespace Task_1
{
    public class Program
    {
        public static void Main()
        {
            //Task_2: проверка ресурсов
            StatusResources.CheckResources(20000000);

            Console.WriteLine($"Resources on started: {GC.GetTotalMemory(false)}");
            TestClass[] TSArr = new TestClass[100];
            for (int i = 0; i < TSArr.Length; i++)
            {
                using (TSArr[i] = TestClass.CreateInstance()) //Task_2: Убрать using и не вызывать работу GC, чтобы память засорялась 
                { 
                    Console.WriteLine($"Object {TSArr[i].GetHashCode()} has been instanced\n" +
                        $"Resources after instanced: {GC.GetTotalMemory(false)}");    
                }
                Thread.Sleep(100);
                Console.WriteLine(new String('-',50));
            } 
        }
    }
}

