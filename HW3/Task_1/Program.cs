using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer printerR = new PrinterRed();
            Printer printerG = new PrinterGreen();
            Printer printerB = new PrinterBlue();
            
            printerR.Print("Red");
            printerG.Print("Green");
            printerB.Print("Blue");
        }
    }
}
