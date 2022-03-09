using System;
using System.Reflection;

namespace Task_1
{
    public class User
    {
        protected string _name;
        protected int _age;
        protected User(string name, int age)
        {
            _name = name;
            if (age > 18 && age < 70)
            {
                _age = age;
            }
            else
                _age = 20;
        }

        public string Name { get { return _name; } }
        public int Age { get { return _age; } }
        public override string ToString()
        {
            Type type = this.GetType();
            object[] attrs = type.GetCustomAttributes(false);
            foreach (Attribute item in attrs)
            {
                if (item is AccessLevelAttribute)
                {
                    return $"Name: {_name} Age: {_age} Level: {(item as AccessLevelAttribute)!.Level}"; 
                }
            }
            return $"Name: {_name} Age:{_name}";
        }
        public static void GetAccess(User user, Level Needlevel)
        {
            Type type = user.GetType();
            object[] attrs = type.GetCustomAttributes(false);
            AccessLevelAttribute? AL = null;
            foreach (Attribute item in attrs)
                if (item is AccessLevelAttribute)
                {
                    AL = (item as AccessLevelAttribute)!;
                    break;
                }
            if ((int)AL!.Level >= (int)Needlevel)
                Console.WriteLine($"Access {Needlevel} is allowed for user {user._name}");
            else
                Console.WriteLine($"Access {Needlevel} is denied for user {user._name}");
        }
    }
}
