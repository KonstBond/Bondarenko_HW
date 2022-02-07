using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Note
    {
        public int Frequency { get; set; }
        public int Duration { get; set; }

        public Note(int frequency, int duration, bool pause)
        {
            this.Duration = duration;
            if (pause)
                this.Frequency = 37;
            else
                this.Frequency = frequency;
        }
    }
}
