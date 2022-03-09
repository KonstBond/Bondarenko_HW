using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task_1
{
    public static class RegistrationUser
    {
        private static string patternLogin = @"^[a-zA-Z]+$";
        private static string patternPassword = @"\d|\w|[\\]";

        public static User Registration(string login, string password)
        {
            char[] passChars = password.ToCharArray();

            for (int i = 0; i < passChars.Length; i++)
            {
                char passCharsNew = passChars[i] switch
                {
                    '\a' => 'a',
                    '\b' => 'b',
                    '\f' => 'f',
                    '\n' => 'n',
                    '\r' => 'r',
                    '\t' => 't',
                    '\v' => 'v',
                    _ => passChars[i]
                };
                password = password.Replace(passChars[i], passCharsNew);
            }

            if (Regex.IsMatch(login,patternLogin))
            {
                Console.WriteLine("Valid login");
                if (Regex.IsMatch(password,patternPassword))
                {
                    Console.WriteLine($"User {login} has been saved\n");
                    return new User(login,password);
                }
                else
                    Console.WriteLine("Invalid password\n");   
            }
            Console.WriteLine("Invalid login\n");
            return null;
        }
       
    }
}
