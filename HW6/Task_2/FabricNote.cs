using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    static class FabricNote
    {
        public static Note FabricC(int octave, int duration)
        {
            return new Note(262 * (int)Math.Pow(2, octave-1), duration, false);
        }
        public static Note FabricD(int octave, int duration)
        {
            return new Note(294 * (int)Math.Pow(2, octave-1), duration, false);
        }
        public static Note FabricE(int octave, int duration)
        {
            return new Note(330 * (int)Math.Pow(2, octave-1), duration, false);
        }
        public static Note FabricF(int octave, int duration)
        {
            return new Note(349 * (int)Math.Pow(2, octave-1), duration, false);
        }
        public static Note FabricG(int octave, int duration)
        {
            return new Note(392 * (int)Math.Pow(2, octave-1), duration, false);
        }
        public static Note FabricA(int octave, int duration)
        {
            return new Note(440 * (int)Math.Pow(2, octave-1), duration, false);
        }
        public static Note FabricB(int octave, int duration)
        {
            return new Note(493 * (int)Math.Pow(2, octave-1), duration, false);
        }
        public static Note FabricPause(int duration)
        {
            return new Note(37, duration, true);
        }
    }
}
