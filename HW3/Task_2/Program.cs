using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil[] pupils = new Pupil[4];

            for (int i = 0; i < pupils.Length; i++)
            {
                pupils[i] = SetPupil();
            }

            ClassRoom classRoom = new ClassRoom(pupils[0], pupils[1], pupils[2], pupils[3]);

            classRoom.AllStudy();
            Console.WriteLine(new string('-', Console.BufferWidth));
            classRoom.AllRelax();
            Console.WriteLine(new string('-', Console.BufferWidth));
            classRoom.AllWrite();
            Console.WriteLine(new string('-', Console.BufferWidth));
            classRoom.AllRead();

        }

        static Pupil SetPupil()
        {
            Random random = new Random();

            Pupil p = (random.Next(1, 5)) switch
            {
                1 => new BadPupil(),
                2 => new ExcelentPupil(),
                3 => new GoodPupil(),
                _ => new Pupil()
            };

            return p;
        }
    }
}
