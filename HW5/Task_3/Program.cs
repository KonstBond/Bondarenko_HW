using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMatrix m1 = new MyMatrix(10,10);
            m1.SetMatrix();
            m1.Show();
            Console.WriteLine("____________________");
            MyMatrix m2 = m1.ReSizeMatrix(10, 15);
            m2.Show();
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("____________________");
                m2.ShowOrderMatrix(i);
            }
        }
    }
}
