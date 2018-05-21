using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            (player as IRecordable).Record();
            (player as IPlayable).Play();
            Console.ReadKey();
        }
        
        interface IPlayable
        {
            void Play();
            void Pause();
            void Stop();
        }

        interface IRecordable
        {
            void Record();
            void Pause();
            void Stop();
        }

        class Player : IRecordable, IPlayable
        {
            public void Pause()
            {
                Console.WriteLine("Paused");
            }

            public void Play()
            {
                Console.WriteLine("Playing");
            }

            public void Record()
            {
                Console.WriteLine("Recording");
            }

            public void Stop()
            {
                Console.WriteLine("Stopped");
            }
        }
    }
}
