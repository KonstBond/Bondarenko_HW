using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Task_1
{
    public class Program
    {
        static void Main()
        {
            Assembly assembly = Assembly.Load("TestLibrary");

            Reflector.GetInfo(assembly);
        }
    }
}
