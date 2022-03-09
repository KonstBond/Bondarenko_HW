using System;
using System.Collections.Generic;
using System.Reflection;

namespace Task_1
{
    public static class Reflector
    {
        public static void GetInfo(Assembly assembly)
        {
            if (assembly == null)
                throw new ArgumentNullException($"Arg: {assembly} is null");
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"ASSEMBLY \'{assembly.FullName}\' HAS BEEN LOADED");
                Console.ResetColor();
                Console.WriteLine(new String('-',100));
                GetMethods(assembly);
                GetCtors(assembly);
                GetProp(assembly);
                GetFields(assembly);
                GetEvents(assembly); 
            }
        }

        private static void GetMethods(Assembly assembly)
        {
            foreach (Type type in assembly.GetTypes())
            {
                MethodInfo[] MI = type.GetMethods(BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public);

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"{type.Name} <METHODS>");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Loop<MemberInfo>(MI);
            }
        }

        private static void GetCtors(Assembly assembly)
        {
            foreach (Type type in assembly.GetTypes())
            {
                ConstructorInfo[] MI = type.GetConstructors(BindingFlags.Public | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Instance);

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"{type.Name} <CONSTRUCTORS>");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Loop<ConstructorInfo>(MI);
            }
        }

        private static void GetProp(Assembly assembly)
        {
            foreach (Type type in assembly.GetTypes())
            {
                PropertyInfo[] MI = type.GetProperties(BindingFlags.Public | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Instance);

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"{type.Name} <PROPERTYS>");
                Console.ForegroundColor = ConsoleColor.White;
                Loop<PropertyInfo>(MI);
            }
        }

        private static void GetFields(Assembly assembly)
        {
            foreach (Type type in assembly.GetTypes())
            {
                FieldInfo[] MI = type.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Instance);

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"{type.Name} <FIELDS>");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Loop<FieldInfo>(MI);
                
            }
        }

        private static void GetEvents(Assembly assembly)
        {
            foreach (Type type in assembly.GetTypes())
            {
                EventInfo[] MI = type.GetEvents(BindingFlags.Public | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Instance);

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"{type.Name} <EVENTS>");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Loop<EventInfo>(MI);
            }
        }

        private static void Loop<T>(MemberInfo[] MI)
        {
            foreach (object field in MI)
            {
                Console.WriteLine(field);
            }
            Console.ResetColor();
            Console.WriteLine(new String('-', 100));
        }
    }
}
