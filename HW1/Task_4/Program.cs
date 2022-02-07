using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Point A = new Point(10,20, "A");
            Point B = new Point(30, 40, "B");
            Point C = new Point(50, 0, "C");
            Point D = new Point(5, 10, "D");
            Point E = new Point(15, 20, "E");

            Figure figure = new Figure(A,B,C);

            Console.WriteLine(figure.LengthSide(A, B));
            Console.WriteLine(figure.LengthSide(B, C));
            Console.WriteLine(figure.LengthSide(C, D));
            Console.WriteLine(figure.LengthSide(D, E));
            Console.WriteLine(figure.LengthSide(E, A));

            Console.WriteLine(figure.PerimeterCalculator());

        }
    }
}
