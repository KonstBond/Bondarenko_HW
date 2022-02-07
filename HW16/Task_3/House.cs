using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class House 
    {
        private int height;
        private int size;

        public int Height { get { return height; } set { height = value; } }
        public int Size { get { return size; } set { size = value; } }

        public House(int height, int size)
        {
            this.height = height;
            this.size = size;
        }

        public House Clone()
        {
            return this;
        }

        public object DeepClone()
        {
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            return $"[{height}:{size}]";
        }
    }
}
