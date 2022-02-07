using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("(+ - * /): ");
                if (char.TryParse(Console.ReadLine(), out char op))
                {
                    Console.Write("A: ");
                    if (int.TryParse(Console.ReadLine(), out int A))
                    {
                        Console.Write("B: ");
                        if (int.TryParse(Console.ReadLine(), out int B))
                        {
                            double rez = default;
                            try
                            {
                                rez = op switch
                                {
                                    '+' => Calculator.Add(A, B),
                                    '-' => Calculator.Sub(A, B),
                                    '*' => Calculator.Mul(A, B),
                                    '/' => Calculator.Div(A, B),
                                    _ => throw new ArithmeticException($"{op} is no operator")
                                };
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine($"Exeption: {e.Message}");
                                rez = double.NaN;
                            }
                            finally
                            {
                                Console.WriteLine($"Rezult: {rez}");
                                Console.WriteLine(new string('-', Console.BufferWidth));
                            }
                        }
                    }
                }
            }
        }
    }
}
