using System;

namespace Task_1
{
    class Program
    {
        delegate string Operations(double a, double b);

        static void Main(string[] args)
        {
            Console.Write("Enter A: ");
            double a = int.Parse(Console.ReadLine());
            Console.Write("Enter B: ");
            double b = int.Parse(Console.ReadLine());
            Console.Write("Enter operation (+ - * /): ");
            string EnterOp = Console.ReadLine();

            Operations op = EnterOp switch
            {
                "+" => op = (a, b) => { return (a + b).ToString(); },
                "-" => op = (a, b) => { return (a - b).ToString(); },
                "*" => op = (a, b) => { return (a * b).ToString(); },
                "/" => op = (a, b) => { return b != 0 ? (a / b).ToString() : "Cannot div by zero"; },
                _ => throw new Exception("ERROR")
            };

            Console.WriteLine(op(a,b));
        }
    }
}
