using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    [AccessLevel(Level.Director)]
    public class Director : User
    {
        private Director(string name, int age)
            : base(name, age)
        {

        }

        private static Director? _director;

        public static Director SetDirector(string name, int age)
        {
            if (_director is null)
                _director = new Director(name, age);
            return _director;
        }
    }
}
