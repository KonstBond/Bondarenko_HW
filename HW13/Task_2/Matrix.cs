using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task_2
{
    class MatrixRow
    {
        private static object block = new object(); //Об синхр
        private int colunm; //Ряд
        private int length; //Длина ряда
        private int nowLength; // Длина отрисованой части

        public MatrixRow(int Pozition)
        {
            colunm = Pozition;
        }

        public void Run(object flag)
        {
            while (true)
            {
                nowLength = 0;
                length = new Random().Next(3, 9);
                for (int i = 0; i < 20; i++) //20 = высота конслоли - 1
                {
                    lock (block)
                    {
                        Console.CursorTop = 0;

                        for (int j = 0; j < i; j++)  //Отрисовка пустых символов перед рядом
                        {
                            Console.CursorLeft = colunm;
                            Console.WriteLine(" "); 
                        }

                        if (nowLength < length) //Увеличиваем отрисовануюю длину, до полной
                        {
                            nowLength++;
                        }
                        else if (nowLength == length) //Обнуляем полную длину, чтобы отрисованная не увеличивалась бесконечно
                        {
                            length = 0;
                        }

                        if (Convert.ToBoolean(flag) && i < 20 && i > nowLength + 2 && new Random().Next(0, 10) == 5) //Запуск следущего потока
                        {
                            new Thread(new MatrixRow(colunm).Run).Start(false);
                            flag = false;
                        }

                        if (19 - i < nowLength) //Если отрисованная длина дошла до конца, то уменьшаем её до 0; 19 = длина конслоли - 2, чтобы длина не была меньше 0
                        {
                            nowLength--;
                        }
                        Console.CursorTop = i - nowLength + 1; //Установка каретки на позицию отрисовки символов        

                        for (int j = 0; j < nowLength - 2; j++) //Каждый символ отрисовываем тёмным цветом
                        {
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.CursorLeft = colunm;
                            Console.WriteLine((char)new Random().Next(65, 91));
                        }
                        if (nowLength >= 2) //2 символ отрисовываем ярким цветом
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.CursorLeft = colunm;
                            Console.WriteLine((char)new Random().Next(65, 91));
                        }
                        if (nowLength >= 1) //1 символ отрисовываем белым цветом
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.CursorLeft = colunm;
                            Console.WriteLine((char)new Random().Next(65, 91));
                        }
                    }
                    Thread.Sleep(400); //"Скорость" потока
                }
            }
        }
    }
}

