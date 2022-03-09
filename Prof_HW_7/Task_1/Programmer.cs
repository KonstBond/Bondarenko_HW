using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    [AccessLevel(Level.Programmer)]
    public class Programmer : User
    {
        public Programmer(string name, int age)
            : base(name,age)
        {

        }
    }
}
