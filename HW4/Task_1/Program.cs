using System;
using System.Text;

namespace Classes
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;

            Document document = new Document("==Document==","-------\nContent\n-------", "Head of the Council: Kirilyuk V.V.");
            document.Show();
            Console.WriteLine(new string('-',Console.BufferWidth));
            document.ReTitle("--Document--");
            document.ReBody("------------\nNice Content\n------------");
            document.ReFooter("Head of the Council: Bondarenko K.O.");
            document.Show();

            // Delay.
            Console.ReadKey();
        }
    }
}
