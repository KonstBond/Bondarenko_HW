using System;
using System.Reflection;

namespace Task_3
{
    internal class Reflector
    {
        public static void GetInfo(Assembly assembly, MembersOfType members)
        {

            if (assembly == null)
                throw new ArgumentNullException($"Arg: {assembly} is null");
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"ASSEMBLY \'{assembly.FullName}\' HAS BEEN LOADED");
                Console.ResetColor();
                Console.WriteLine(new String('-', 100));

                Action<Assembly,bool>? action = null;
                bool flag = false;

                if (members.HasFlag(MembersOfType.MembersAttributes))
                    flag = true;
                if (members.HasFlag(MembersOfType.TypeAttributes))
                    action += GetTypeAttr;
                if (members.HasFlag(MembersOfType.Propertys))
                    action += GetProp;
                if (members.HasFlag(MembersOfType.Fields))
                    action += GetFields;
                if (members.HasFlag(MembersOfType.Methods))
                    action += GetMethods;
                if (members.HasFlag(MembersOfType.Constructors))
                    action += GetCtors;
                if (members.HasFlag(MembersOfType.Events))
                    action += GetEvents;
                action!.Invoke(assembly,flag);
            }
        }

        private static void GetMethods(Assembly assembly, bool flag)
        {
            foreach (Type type in assembly.GetTypes())
            {
                MethodInfo[] MI = type.GetMethods(BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public);

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"{type.Name} <METHODS>");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Loop(MI);
                if (flag)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"{type.Name} <METHODS ATTRIBUTE>");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    GetMembAttr(type);
                }
            }
        }

        private static void GetCtors(Assembly assembly, bool flag)
        {
            foreach (Type type in assembly.GetTypes())
            {
                ConstructorInfo[] MI = type.GetConstructors(BindingFlags.Public | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Instance);

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"{type.Name} <CONSTRUCTORS>");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Loop(MI);
                if (flag)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"{type.Name} <CONSTRUCTORS ATTRIBUTE>");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    GetMembAttr(type);
                }
            }
        }

        private static void GetProp(Assembly assembly, bool flag)
        {
            foreach (Type type in assembly.GetTypes())
            {
                PropertyInfo[] MI = type.GetProperties(BindingFlags.Public | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Instance);

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"{type.Name} <PROPERTYS>");
                Console.ForegroundColor = ConsoleColor.White;
                Loop(MI);
                if (flag)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"{type.Name} <PROPERTYS ATTRIBUTE>");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    GetMembAttr(type);
                }
            }
        }

        private static void GetFields(Assembly assembly, bool flag) 
        {
            foreach (Type type in assembly.GetTypes())
            {
                FieldInfo[] MI = type.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Instance);

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"{type.Name} <FIELDS>");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Loop(MI);
                if (flag)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"{type.Name} <FIELDS ATTRIBUTE>");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    GetMembAttr(type);
                }
            }
        }

        private static void GetEvents(Assembly assembly, bool flag)
        {
            foreach (Type type in assembly.GetTypes())
            {
                EventInfo[] MI = type.GetEvents(BindingFlags.Public | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Instance);

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"{type.Name} <EVENTS>");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Loop(MI);
                if (flag)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"{type.Name} <EVENTS ATTRIBUTE>");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    GetMembAttr(type);
                }
            }
        }

        private static void Loop(MemberInfo[] MI)
        {
            foreach (object field in MI)
            {
                Console.WriteLine(field);
            }
            Console.ResetColor();
            Console.WriteLine(new String('-', 100));
        }

        //Тут flag нужен, просто для того, что бы сигнатура делегата совпдала ( костыли наше всё :) ) 
        private static void GetTypeAttr(Assembly assembly, bool flag) 
        {
            foreach (Type type in assembly.GetTypes())
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"{type.Name} <TYPE ATTRIBUTES>");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                foreach (Attribute attribute in type.GetCustomAttributes(false))
                {
                    Console.WriteLine(attribute);
                }
                Console.ResetColor();
                Console.WriteLine(new String('-', 100));
            }
        }

        private static void GetMembAttr(MemberInfo MI)
        {
            foreach (Attribute attr in MI.GetCustomAttributes(false))
            {
                Console.WriteLine(attr);
            }
            Console.ResetColor();
            Console.WriteLine(new String('-', 100));
        }
    }
}
