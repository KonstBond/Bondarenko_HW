using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Player : IPlayable, IRecodable
    {
        public void Play()
        {
            Console.WriteLine("Music play now");
        }

        public void Record()
        {
            Console.WriteLine("Sounds record now");
        }

        void IPlayable.Pause()
        {
            Console.WriteLine("Pause music");
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("Music off");
        }

        void IRecodable.Pause()
        {
            Console.WriteLine("Pause Record");
        }

        void IRecodable.Stop()
        {
            Console.WriteLine("Record off");
        }
    }
}
