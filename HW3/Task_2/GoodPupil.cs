using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class GoodPupil : Pupil
    {
        public override string Study()
        {
            return "I study well";
        }
        public override string Read()
        {
            return "I read a little";
        }
        public override string Write()
        {
            return "I rarely write";
        }
        public override string Relax()
        {
            return "I rest often";
        }
    }
}
