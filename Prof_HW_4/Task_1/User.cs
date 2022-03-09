using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class User
    {
        public string _login;
        public string _password;
        public User(string login, string password)
        {
            _login = login;
            _password = password;
        }

        public override string ToString()
        {
            return $"Login {_login}\t\t\tPassword: {_password}";
        }
    }
}
