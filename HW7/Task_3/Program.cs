using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass(); 
            myClass.change = "Не изменено";
            ClassTaker(myClass);
            Console.WriteLine(myClass.change); //Ссылочный тип, данные передаются по ссылке и изменяются в исходнике

            MyStruct myStruct = new MyStruct();
            myStruct.change = "Не изменено";
            StruktTaker(myStruct);
            Console.WriteLine(myStruct.change); //Структурный тип, данные копируются, но не изменяются в исходнике
        }

        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "Изменено";
        }

        static void StruktTaker(MyStruct myStruct)
        {
            myStruct.change = "Изменено";
        }
    }
}
