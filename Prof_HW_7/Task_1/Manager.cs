using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    [AccessLevel(Level.Manager)]
    public class Manager : User 
    {
        public Manager(string name, int age)
            : base(name, age)
        {

        }
    }
}
