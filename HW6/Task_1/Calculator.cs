using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    static class Calculator
    {
        public static int Add(int op1, int op2)
        {
            return op1 + op2;
        }

        public static int Sub(int op1, int op2)
        {
            return op1 - op2;
        }

        public static int Mul(int op1, int op2)
        {
            return op1 * op2;
        }

        public static double Div(double op1, double op2)
        {
            return op1 / op2;
        }

        public static int Mod(int op1, int op2)
        {
            return op1 % op2;
        }
    }
}
