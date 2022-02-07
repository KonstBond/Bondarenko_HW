using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Employee
    {
        private string fName, lName, post = "No work";
        private int exp;
        private double salary = 0, taxLevy = 0.195;

        public Employee(string firstName, string lastName)
        {
            fName = firstName;
            lName = lastName;
        }

        public string Post 
        {
            get
            {
                return post;
            }
            set
            {
                post = value;
                switch (value)
                {
                    case "Admin":
                        {
                            salary = 1300 - (1300 * taxLevy);
                            break;
                        }
                    case "Programmer":
                    case "QA":
                        {
                            salary = 1000 - (1000 * taxLevy);
                            break;
                        }
                    default:
                        {
                            post = "No work";
                            exp = 0;
                            break;
                        }
                }
            }
        }

        public int Exp 
        { 
            get
            {
                return exp;
            }
            set
            {
                if (post == "No work")
                {
                    exp = 0;
                }
                else
                {
                    exp = value;
                    switch (value)
                    {
                        case int i when i <= 5:
                            {
                                salary *= 1.3;
                                break;
                            }
                        case int i when i > 5 && i < 10:
                            {
                                salary *= 1.5;
                                break;
                            }
                        case int i when i >= 10:
                            {
                                salary *= 1.8;
                                break;
                            }
                    }
                
                }
            }
        }

        public void Show()
        {
            Console.WriteLine($"Employee: {fName} {lName}\n" +
                $"Post: {post}\n" +
                $"Experience: {exp} years\n" +
                $"Salary: {salary}\n" +
                $"Tax Levy: {taxLevy * 100}%\n");
        }
    }
}
