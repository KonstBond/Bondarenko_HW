using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class BadPupil : Pupil 
    {
        public override string Study()
        {
            return "I am not study";
        }
        public override string Read()
        {
            return "I do not read";
        }
        public override string Write()
        {
            return "I do not write";
        }
        public override string Relax()
        {
            return "I am always resting";
        }
    }
}
