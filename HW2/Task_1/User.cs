using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class User
    {
        private string login;
        private string firstName;
        private string lastName;
        private int age;
        private readonly DateTime dateCreate;

        public User(string login, string firstName, string lastName, int age, DateTime dateCreate)
        {
            this.login = login;
            this.firstName = firstName;
            this.lastName = lastName;
            if (age > 18 && age < 100)
            {
                this.age = age;
            }
            else
            {
                this.age = 18;
            }
            this.dateCreate = dateCreate;
        }

        public string Login 
        { 
            get { return login; }
            set { login = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName 
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public int Age
        {
            get { return age; }
            set 
            {
                if (value > 18 && value < 100)
                {
                    age = value;
                }
                else
                {
                    age = -1;
                }
            }
        }

        public DateTime DateCreate
        {
            get { return dateCreate; }
        }

        public void Show()
        {
            Console.WriteLine($"\t---USER---\t\n" +
                $"Login: {login}\n" +
                $"First Name: {firstName}\n" +
                $"Last Name: {lastName}\n" +
                $"Age: {age}\n" +
                $"Date of creating form: {dateCreate.Day}.{dateCreate.Month}.{dateCreate.Year}\n");
        }
    }
}
