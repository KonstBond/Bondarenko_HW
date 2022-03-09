using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Program
    {
        static void Main()
        {
            List<User> users = new List<User>();

            users.Add(RegistrationUser.Registration("Konstantin", "checkPassword%#%^"));
            users.Add(RegistrationUser.Registration("Mike12345", "ch32^$#ssword%#%^"));
            users.Add(RegistrationUser.Registration("B0gdAn", "checkPa  ssword%#%^"));
            users.Add(RegistrationUser.Registration("Razor", "che\nckP+D2ord%#%^"));
            users.Add(RegistrationUser.Registration("RMX-92", "che\nssword%#%^"));
            users.Add(RegistrationUser.Registration("LOOOL", "che235|assword%#%^"));
            Console.WriteLine(new String('-',Console.BufferWidth));

            foreach (User user in users)
            {
                if (user!=null)
                {
                    Console.WriteLine(user);
                }          
            }
        }
    }
}
