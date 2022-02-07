using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class DOCHandler : AbstractHandler
    {
        public DOCHandler(string fileName)
            : base(fileName) { }

        public override void Open()
        {
            Console.WriteLine("Open... " + file + ".doc");
        }

        public override void Create()
        {
            Console.WriteLine("Create... " + file + ".doc");
        }

        public override void Chenge()
        {
            Console.WriteLine("Change... " + file + ".doc");
        }

        public override void Save()
        {
            Console.WriteLine("Save... " + file + ".doc");
        }
    }
}
