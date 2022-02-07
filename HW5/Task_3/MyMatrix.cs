using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class MyMatrix
    {
        private int[,] Matrix;
        private int width, height;

        /// <summary>
        /// Matrix can be more then 0 and less then 10 
        /// </summary>
        /// <param name="height"></param>
        /// <param name="width"></param>
        public MyMatrix(int height, int width)
        {
            this.width = width;
            this.height = height;
            Matrix = new int[height, width];
        }

        public int this[int height, int width]
        {
            get { return Matrix[height, width]; }
            set 
            {
                if (Matrix[height, width] == 0)
                    throw new Exception("Some elements consist zero");
                Matrix[height, width] = value; 
            }
        }

        public void SetMatrix()
        {
            for (int i = 0; i < this.height; i++)
                for (int j = 0; j < this.width; j++)
                    Matrix[i, j] = new Random().Next(1,10);
        }

        public MyMatrix ReSizeMatrix(int height, int width)
        {
            int[,] newM = new int[height, width]; 
            for (int i = 0; i < height; i++)
                for (int j = 0; j < width; j++)
                {
                    if (j >= this.width || i >= this.height)
                        newM[i, j] = new Random().Next(1, 10);
                    else
                        newM[i, j] = Matrix[i, j];
                }

            return new MyMatrix(height, width) { Matrix = newM };
        }

        public void ShowOrderMatrix(int order)
        {
            if (order > height || order > width)
            {
                Console.WriteLine("Оrder cannot be larger than the size of the matrix");
                return;
            }
            for (int i = 0; i < order; i++)
            {
                for (int j = 0; j < order; j++)
                {
                    Console.Write(Matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void Show()
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(Matrix[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
