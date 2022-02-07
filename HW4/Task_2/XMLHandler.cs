using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class XMLHandler : AbstractHandler
    {
        public XMLHandler(string fileName)
            : base(fileName) { }

        public override void Open()
        {
            Console.WriteLine("Open... " + file + ".xml");
        }

        public override void Create()
        {
            Console.WriteLine("Create... " + file + ".xml");
        }

        public override void Chenge()
        {
            Console.WriteLine("Change... " + file + ".xml");
        }

        public override void Save()
        {
            Console.WriteLine("Save... " + file + ".xml");
        }
    }
}
