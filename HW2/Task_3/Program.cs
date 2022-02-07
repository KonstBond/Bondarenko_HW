using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Konstantin","Bondarenko");
            employee1.Post = "Admin";
            employee1.Exp = 2;
            employee1.Show();

            Employee employee2 = new Employee("Oleg", "Lesovik");
            employee2.Post = "QAQ";
            employee2.Exp = 4;
            employee2.Show();
        }
    }
}
