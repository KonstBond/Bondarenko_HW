using System;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write a key of access: ");
            string key = Console.ReadLine();

            DocumentWorker document = key switch
            {
                "pro" => new ProDocumentWorker(),
                "exp" => new ExpertDocumentWorker(),
                _ => new DocumentWorker()
            };

            Console.WriteLine(new string('-',Console.BufferWidth));
            document.OpenDocument();
            document.EditDocument();
            document.SaveDocument();
            
        }
    }
}
