using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractHandler[] handlers = new AbstractHandler[3]
            { new DOCHandler("Document"), 
              new TXTHandler("Passwords"),
              new XMLHandler("XMLcomments")};

            foreach (var item in handlers)
            {
                item.Create();
                item.Open();
                item.Chenge();
                item.Save();
                Console.WriteLine(new string('-',Console.BufferWidth));
            }
        }
    }
}
