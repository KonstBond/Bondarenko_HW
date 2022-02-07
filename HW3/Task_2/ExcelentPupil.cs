using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class ExcelentPupil : Pupil
    {
        public override string Study()
        {
            return "I study very well";
        }
        public override string Read()
        {
            return "I read a lot";
        }
        public override string Write()
        {
            return "I always write";
        }
        public override string Relax()
        {
            return "I rest sometimes";
        }
    }
}