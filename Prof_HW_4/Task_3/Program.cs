using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class Program
    {
        static void Main()
        {
            string text = PreteEncryption.Encrypt(new FileInfo("Example.txt"));

            Console.WriteLine(text);
        }
    }
}
