using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    static class ColorPrint
    {
        public static void Print(string stroka, int color)
        {
            switch (color)
            {
                case 1:
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(stroka);
                        break;
                    }
                case 2:
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(stroka);
                        break;
                    }
                case 3:
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(stroka);
                        break;
                    }
                case 4:
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(stroka);
                        break;
                    }
                case 5:
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write(stroka);
                        break;
                    }
                case 6:
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(stroka);
                        break;
                    }
                case 7:
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write(stroka);
                        break;
                    }
            }
            Console.ResetColor();
        }

        public static EnumColor ColorParser(string color)
        {
            EnumColor rez = color switch
            {
                "Red" => EnumColor.Red,
                "Blue" => EnumColor.Blue,
                "BLack" => EnumColor.Black,
                "White" => EnumColor.White,
                "Yellow" => EnumColor.Yellow,
                "Green" => EnumColor.Green,
                "Gray" => EnumColor.Gray,
                _ => EnumColor.White
            };
            return rez;
        }
    }
}
