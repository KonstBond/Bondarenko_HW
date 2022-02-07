using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            IRecodable Recorder = new Player();
            IPlayable player = new Player();

            player.Play();
            player.Stop();
            player.Pause();
            Console.WriteLine();
            Recorder.Record();
            Recorder.Stop();
            Recorder.Pause();
        }
    }
}
