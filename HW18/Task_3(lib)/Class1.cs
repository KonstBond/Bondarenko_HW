using System;

namespace Task_3_lib_
{
    public class Class1
    {
        public void SomeMethod()
        {
            Type type = typeof(Class1);

            Console.WriteLine($"Class: {type.FullName}\n" +
                $"Namespace: {type.Namespace}");
        }
    }
}
