using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class TXTHandler : AbstractHandler
    {
        public TXTHandler(string fileName)
            : base(fileName) { }

        public override void Open()
        {
            Console.WriteLine("Open... " + file + ".txt");
        }

        public override void Create()
        {
            Console.WriteLine("Create... " + file + ".txt");
        }

        public override void Chenge()
        {
            Console.WriteLine("Change... " + file + ".txt");
        }

        public override void Save()
        {
            Console.WriteLine("Save... " + file + ".txt");
        }
    }
}
