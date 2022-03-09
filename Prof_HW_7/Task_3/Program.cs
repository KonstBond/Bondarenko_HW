using System;
using System.Reflection;

namespace Task_3
{
    public class Program
    {
        static void Main()
        {
            Assembly assembly = Assembly.Load("Task_1");

            Reflector.GetInfo(assembly, MembersOfType.Propertys | MembersOfType.Methods | MembersOfType.Constructors | MembersOfType.Fields
                | MembersOfType.Events | MembersOfType.TypeAttributes | MembersOfType.MembersAttributes);
        }
    }
}
