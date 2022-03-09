using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Task_2
{
    [Obsolete("This class is obsolote")]
    public class TestClass
    {
        [Obsolete("This method is obsolete",false, DiagnosticId = "google", UrlFormat = "https://www.google.com")]
        [Conditional("Warning")]
        public static void MethodObsoleteWarning()
        {
            Console.WriteLine("Warning");
        }

        [Obsolete("This method is obsolete", true, DiagnosticId = "google",UrlFormat = "https://www.google.com")]
        [Conditional("Error")]
        public static void MethodObsoleteError()
        {
            Console.WriteLine("Error");
        }
    }
}
