using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Local local = new Local(new FileInfo("Product.txt"));

            var my = CultureInfo.CurrentCulture;
            var Eng = new CultureInfo("en-US");

            Console.WriteLine(local.ToString("F", my));
            Console.WriteLine(new String('-',50));
            Console.WriteLine(local.ToString("F", Eng));
        }
    }
}
