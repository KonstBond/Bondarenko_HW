using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class MyClass<T> where T : new()
    {
        static public T FactoryMethod()
        {
            return new T();
        }
    }
}
