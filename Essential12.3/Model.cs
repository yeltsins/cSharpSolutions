using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Essential12._3
{
    class Model
    {
        public Timer timer;
        private int seconds;
        
        public int Seconds { get => seconds; }
        public Model()
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Start();
            seconds = 0;
            timer.Elapsed += (e, a) => seconds++;
        }
        public void StartTimer()
        {
            timer.Start();
        }
        public void StopTimer()
        {
            timer.Stop();
        }
        public void Clear()
        {
            timer.Stop();
            seconds = 0;
        }
    }
}
