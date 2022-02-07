using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    static class MelodyParser
    {
        private static Note[] notes;

        public static Note[] ParseMelody(string melody)
        {
            notes = new Note[melody.Length];
            int standartDuration = 400;
            for (int i = 0; i < melody.Length; i++)
            {
                switch (melody[i])
                {
                    case '0': { notes[i] = FabricNote.FabricC(1, standartDuration); break; }
                    case '1': { notes[i] = FabricNote.FabricD(1, standartDuration); break; }
                    case '2': { notes[i] = FabricNote.FabricE(1, standartDuration); break; }
                    case '3': { notes[i] = FabricNote.FabricF(1, standartDuration); break; }
                    case '4': { notes[i] = FabricNote.FabricG(1, standartDuration); break; }
                    case '5': { notes[i] = FabricNote.FabricA(1, standartDuration); break; }
                    case '6': { notes[i] = FabricNote.FabricB(1, standartDuration); break; }
                    case '7': { notes[i] = FabricNote.FabricC(2, standartDuration); break; }
                    case '8': { notes[i] = FabricNote.FabricD(2, standartDuration); break; }
                    case '9': { notes[i] = FabricNote.FabricE(2, standartDuration); break; }
                    case ' ': { notes[i] = FabricNote.FabricPause(400); break; }
                    default: break;
                }
            }
            return notes;
        }
    }
}
