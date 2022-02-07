using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic a = 5;
            dynamic b = 'g';
            try
            {
                Console.WriteLine($"a + b = {Calculator.DynAdd(a,b)}\n" +
                    $"a - b = {Calculator.DynSub(a, b)}\n" +
                    $"a * b = {Calculator.DynMul(a, b)}\n" +
                    $"a / b = {Calculator.DynDiv(a, b)}\n");
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}");
            }
        }
    }
}
