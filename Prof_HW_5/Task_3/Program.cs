using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Task_3
{
    public class Program
    {
        static void Main()
        {
            string path = @"C:\Users\admin\Desktop\ITVDN\HW_C#_Basic\Prof_HW_5\TelephoneBook.xml";

            FileStream FS = new FileStream(path, FileMode.Open);

            XmlTextReader XmlReader = new XmlTextReader(FS);

            string? atr = null;
            while (XmlReader.Read())
            {
                if (XmlReader.HasAttributes && XmlReader.NodeType == XmlNodeType.Element)
                {
                    atr = XmlReader.GetAttribute("TelephoneNumber");
                    Console.WriteLine($"ATR: <TelephoneNumber>: {atr}");
                }
            }
        }

    }
}
