using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public enum MembersOfType
    {
        Methods = 0b_0000_0001,
        Constructors = 0b_0000_0010,
        Propertys = 0b_0000_0100,
        Fields = 0b_0000_1000,
        Events = 0b_0001_0000,
        TypeAttributes = 0b_0010_0000,
        MembersAttributes = 0b_0100_0000,
    }
}
