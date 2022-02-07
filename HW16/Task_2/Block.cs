using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Block
    {
        private int a, b, c, d;

        public Block(int a, int b, int c, int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        public override bool Equals(object obj)
        {  
            if (((Block)obj).GetType() == this.GetType())
            {
                Block blockObj = obj as Block;
                if (blockObj.a == this.a && blockObj.b == this.b && blockObj.c == this.c && blockObj.d == this.d)
                    return true;
                return false;
            }
            else
            {
                throw new Exception($"{obj} is not a block");
            }
        }

        public override string ToString()
        {
            return $"[{a}:{b}:{c}:{d}]";
        }
    }
}
