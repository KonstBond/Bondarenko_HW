using System;

namespace MyNameSpace
{
    class MyClass
    {
        public static void Method()
        {
            Type type = typeof(MyClass);

            Console.WriteLine($"Class: {type.FullName}\n" +
                $"Namespace: {type.Namespace}");
        }
    }
}
