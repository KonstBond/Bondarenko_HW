using System;
using System.Collections.Generic;
using System.Threading;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.ASCII;
            Console.CursorVisible = false;
            Console.SetBufferSize(200, 200);
            Console.SetWindowSize(80, 21);
            MatrixRow row;

            

            int[] arr = new int[27];
            for (int i = 0; i < 27; i++)
            {
                arr[i] = i;
            }

            for (int i = 0; ; i = new Random().Next(0, 27))
            {
                if (arr[i] >= 0)
                {
                    row = new MatrixRow(arr[i] * 3);
                    new Thread(row.Run).Start();
                    Thread.Sleep(new Random().Next(10, 800));
                    arr[i] = -1;
                }
            }
        }
    }
}

