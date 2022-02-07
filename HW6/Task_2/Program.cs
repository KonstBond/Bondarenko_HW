using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string melody = "987 876 765 654 543 432 111 8";
            Note[] notes = MelodyParser.ParseMelody(melody);
            Player.Play(notes);
        }
    }
}
