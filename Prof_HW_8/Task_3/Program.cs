using System;
using System.Xml.Serialization;
using Task_2;

namespace Task_3
{
    public class Program
    {
        public static void Main()
        {
            TestSerializationClass test2;
            XmlSerializer serializer = new XmlSerializer(typeof(TestSerializationClass));

            using (FileStream FS = new FileStream(@"C:\Users\admin\Desktop\ITVDN\HW_C#_Basic\Prof_HW_8\Task_2\bin\Debug\net6.0\test.xml", FileMode.Open, FileAccess.Read))
            {
                test2 = (serializer.Deserialize(FS) as TestSerializationClass)!;
                Console.WriteLine(test2);
            }
        }
    }
}
