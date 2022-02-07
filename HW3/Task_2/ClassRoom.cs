using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class ClassRoom
    {
        private Pupil[] pupils = new Pupil[4];

        public ClassRoom(Pupil p1, Pupil p2) => Console.WriteLine("Class not full");

        public ClassRoom(Pupil p1, Pupil p2, Pupil p3)
            : this(p1, p2) { }

        public ClassRoom(Pupil p1, Pupil p2, Pupil p3, Pupil p4)
        {
            pupils[0] = p1;
            pupils[1] = p2;
            pupils[2] = p3;
            pupils[3] = p4;
        }

        public void AllStudy()
        {
            int indexer = 0;
            foreach (var p in pupils)
            {
                Console.WriteLine($"Student {indexer+1}: {p.Study()}");
                indexer++;
            }
        }

        public void AllWrite()
        {
            int indexer = 0;
            foreach (var p in pupils)
            {
                Console.WriteLine($"Student {indexer + 1}: {p.Write()}");
                indexer++;
            }
        }

        public void AllRead()
        {
            int indexer = 0;
            foreach (var p in pupils)
            {
                Console.WriteLine($"Student {indexer + 1}: {p.Read()}");
                indexer++;
            }
        }

        public void AllRelax()
        {
            int indexer = 0;
            foreach (var p in pupils)
            {
                Console.WriteLine($"Student {indexer + 1}: {p.Relax()}");
                indexer++;
            }
        }
    }
}
