using System;
using System.Xml.Serialization;

namespace Task_2
{
    public class Program
    {
        public static void Main()
        {
            TestSerializationClass test = new TestSerializationClass();

            XmlSerializer serializer = new XmlSerializer(typeof(TestSerializationClass));

            using (FileStream FS = new FileStream("test.xml", FileMode.OpenOrCreate, FileAccess.Write, FileShare.Write))
            {
                serializer.Serialize(FS, test);
            }
        }
    }
}
