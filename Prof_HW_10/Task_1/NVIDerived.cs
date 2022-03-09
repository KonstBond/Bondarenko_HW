using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class NVIDerived : NVIBase
    {
        protected override void DoWork()
        {
            base.DoWork();
            _dir.CreateSubdirectory(@"NewDir");
            Console.WriteLine("I create new directory");
        }
    }
}
