using System.Xml;

namespace Task_2
{
    public class Program
    {
        static void Main()
        {
            string path = @"C:\Users\admin\Desktop\ITVDN\HW_C#_Basic\Prof_HW_5\TelephoneBook.xml";

            FileStream FS = new FileStream(path, FileMode.Open);

            XmlTextReader XmlReader = new XmlTextReader(FS);

            while (XmlReader.Read())
            {
                if (XmlReader.HasAttributes)
                {
                    Console.WriteLine($"\t\t{XmlReader.GetAttribute(0)}");
                }
                Console.WriteLine($"{XmlReader.Name}" +
                    $"\t{XmlReader.Value}"); 
            }
        }
    }
}
