using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Pupil
    {
        public virtual string Study() { return "I am studying"; }
        public virtual string Read() { return "I am reading"; }
        public virtual string Write() { return "I Write"; }
        public virtual string Relax() { return "I'm resting"; }
    }
}
