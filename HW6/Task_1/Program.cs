using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int op1 = 4, op2 = 5;

            Console.WriteLine(Calculator.Add(op1, op2));
            Console.WriteLine(Calculator.Sub(op1, op2));
            Console.WriteLine(Calculator.Div(op1, op2));
            Console.WriteLine(Calculator.Mul(op1, op2));
            Console.WriteLine(Calculator.Mod(op1, op2));
        }
    }
}
