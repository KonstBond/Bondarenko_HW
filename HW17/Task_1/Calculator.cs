using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    static class Calculator
    {
        public static dynamic DynAdd(dynamic op1, dynamic op2)
        {
            return op1 + op2;
        }

        public static dynamic DynSub(dynamic op1, dynamic op2)
        {
            return op1 - op2;
        }

        public static dynamic DynMul(dynamic op1, dynamic op2)
        {
            return op1 * op2;
        }

        public static dynamic DynDiv(dynamic op1, dynamic op2)
        {
            return op1 / op2;
        }
    }
}
