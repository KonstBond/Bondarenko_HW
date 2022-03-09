using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            User[] staff = new User[7]
            {
                new Programmer("Jack", 23),
                new Programmer("Micle", 13),
                new Manager("Bogdan", 25),
                new Programmer("Konstatin", 31),
                new Manager("Vladislav", 42),
                new Programmer("Nastya", 26),
                Director.SetDirector("Oleg",35)
            };

            foreach (User user in staff)
            {
                Console.WriteLine(user);
                User.GetAccess(user, Level.Director);
                User.GetAccess(user, Level.Manager);
                User.GetAccess(user, Level.Programmer);
                Console.WriteLine(new String('-',100));
            }

            
        }
    }
}
