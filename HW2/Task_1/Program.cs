using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Admin","Konstantin","Bondarenko",15, DateTime.Today);

            user.Show();
        }
    }
}
